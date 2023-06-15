using agri_connect_backend.Dto;
using agri_connect_backend.Interfaces;
using agri_connect_backend.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace agri_connect_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorProductController : Controller
    {
        private readonly IVendorProductRepository _vendorProductRepository;
        private readonly IMapper _mapper;

        public VendorProductController(IVendorProductRepository vendorProductRepository, IMapper mapper)
        {
            _vendorProductRepository = vendorProductRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<VendorProduct>))]
        public IActionResult GetVendorProducts()
        {
            var vendorProducts = _mapper.Map<List<VendorProductDto>>(_vendorProductRepository.GetVendorProducts());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(vendorProducts);
        }

        [HttpGet("{vendorProductId}")]
        [ProducesResponseType(200, Type = typeof(VendorProduct))]
        [ProducesResponseType(400)]
        public IActionResult GetVendorProduct(int vendorProductId) 
        {
            if (!_vendorProductRepository.VendorProductExists(vendorProductId))
                return NotFound();

            var vendorProduct = _mapper.Map<VendorProductDto>(_vendorProductRepository.GetVendorProduct(vendorProductId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(vendorProduct);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateVendorProduct([FromBody] VendorProductDto vendorProductCreate)
        {
            if (vendorProductCreate == null)
                return BadRequest(ModelState);

            var vendorProduct = _vendorProductRepository.GetVendorProducts()
                .Where(vp => vp.Name.Trim().ToUpper() == vendorProductCreate.Name.ToUpper())
                .FirstOrDefault();

            if(vendorProduct != null)
            {
                ModelState.AddModelError("", "Product already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var vendorProductMap = _mapper.Map<VendorProduct>(vendorProductCreate);

            if(!_vendorProductRepository.CreateVendorProduct(vendorProductMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created");
        }
    }
}
