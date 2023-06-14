using agri_connect_backend.Dto;
using agri_connect_backend.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using agri_connect_backend.Models;

namespace agri_connect_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierProductController : Controller
    {
        private readonly ISupplierProductRepository _supplierProductRepository;
        private readonly IMapper _mapper;

        public SupplierProductController(ISupplierProductRepository supplierProductRepository, IMapper mapper)
        {
            _supplierProductRepository = supplierProductRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<SupplierProduct>))]
        public IActionResult GetSupplierProducts()
        {
            var supplierProducts = _mapper.Map<List<SupplierProductDto>>(_supplierProductRepository.GetSupplierProducts());

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(supplierProducts);
        }

        [HttpGet("{supplierProductId}")]
        [ProducesResponseType(200, Type = typeof(SupplierProduct))]
        [ProducesResponseType(400)]
        public IActionResult GetSupplierProduct(int supplierProductId)
        {
            if (!_supplierProductRepository.SupplierProductExists(supplierProductId))
                return NotFound();

            var supplierProduct = _mapper.Map<SupplierProductDto>(_supplierProductRepository.GetSupplierProduct(supplierProductId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(supplierProduct);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateSupplierProduct([FromBody] SupplierProductDto supplierProductCreate)
        {
            if (supplierProductCreate == null)
                return BadRequest(ModelState);

            var supplierProduct = _supplierProductRepository.GetSupplierProducts()
                    .Where(sp => sp.Name.Trim().ToUpper() == supplierProductCreate.Name.Trim().ToUpper())
                    .FirstOrDefault();

            if(supplierProduct != null)
            {
                ModelState.AddModelError("", "Product already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var supplierProductMap = _mapper.Map<SupplierProduct>(supplierProductCreate);

            if(!_supplierProductRepository.CreateSupplierProduct(supplierProductMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created");
        }

        [HttpPut("{supplierProductId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdateSupplierProduct(int supplierProductId, [FromBody] SupplierProductDto updatedSupplierProduct)
        {
            if (updatedSupplierProduct == null)
                return BadRequest(ModelState);

            if (supplierProductId != updatedSupplierProduct.Id)
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var supplierProductMap = _mapper.Map<SupplierProduct>(updatedSupplierProduct);

            if(!_supplierProductRepository.UpdateSupplierProduct(supplierProductMap))
            {
                ModelState.AddModelError("", "Something went wrong updating category");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{supplierProductId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeleteSupplierProduct(int supplierProductId) 
        {
            if(!_supplierProductRepository.SupplierProductExists(supplierProductId))
                return NotFound();

            var supplierProductToDelete = _supplierProductRepository.GetSupplierProduct(supplierProductId);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if(!_supplierProductRepository.DeleteSupplierProduct(supplierProductToDelete))
            {
                ModelState.AddModelError("", "Something went wrong deleting product");
            }

            return NoContent();
        }

    }
}
