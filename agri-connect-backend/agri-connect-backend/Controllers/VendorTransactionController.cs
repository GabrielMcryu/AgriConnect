using agri_connect_backend.Dto;
using agri_connect_backend.Interfaces;
using agri_connect_backend.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace agri_connect_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorTransactionController : Controller
    {
        private readonly IVendorTransactionRepository _vendorTransactionRepository;
        private readonly IMapper _mapper;

        public VendorTransactionController(IVendorTransactionRepository vendorTransactionRepository, IMapper mapper)
        {
            _vendorTransactionRepository = vendorTransactionRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<VendorTransaction>))]
        public IActionResult GetVendorTransactions()
        {
            var vendorTransactions = _mapper.Map<List<VendorTransactionDto>>(_vendorTransactionRepository.GetVendorTransactions());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(vendorTransactions);
        }

        [HttpGet("vendorName/{vendorName}")]
        public IActionResult GetVendorTransactionsByVendorName(string vendorName)
        {
            var vendorTransactions = _vendorTransactionRepository.GetVendorTransactionsByVendorName(vendorName);
            return Ok(vendorTransactions);
        }

        [HttpGet("{vendorTransactionId}")]
        [ProducesResponseType(200, Type = typeof(VendorTransaction))]
        [ProducesResponseType(400)]
        public IActionResult GetVendorTransaction(int vendorTransactionId)
        {
            if (!_vendorTransactionRepository.VendorTransactionExists(vendorTransactionId))
                return NotFound();

            var vendorTransaction = _mapper.Map<VendorTransactionDto>(_vendorTransactionRepository.GetVendorTransaction(vendorTransactionId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(vendorTransaction);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateVendorTransaction([FromBody] VendorTransactionDto vendorTransactionCreate)
        {
            if (vendorTransactionCreate == null)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var vendorTransactionMap = _mapper.Map<VendorTransaction>(vendorTransactionCreate);

            if (!_vendorTransactionRepository.CreateVendorTransaction(vendorTransactionMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created");

        }
    }
}
