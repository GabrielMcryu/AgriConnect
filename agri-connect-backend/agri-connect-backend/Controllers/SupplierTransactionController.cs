using agri_connect_backend.Dto;
using agri_connect_backend.Interfaces;
using agri_connect_backend.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace agri_connect_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierTransactionController : Controller
    {
        private readonly ISupplierTransactionRepository _supplierTransactionRepository;
        private readonly IMapper _mapper;

        public SupplierTransactionController(ISupplierTransactionRepository supplierTransactionRepository, IMapper mapper)
        {
            _supplierTransactionRepository = supplierTransactionRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<SupplierTransaction>))]
        public IActionResult GetSupplierTransactions()
        {
            var supplierTransactions = _mapper.Map<List<SupplierTransactionDto>>(_supplierTransactionRepository.GetSupplierTransactions());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(supplierTransactions);
        }

        [HttpGet("supplierName/{supplierName}")]
        public IActionResult GetSupplierTransactionsBySupplierName(string supplierName)
        {
            var supplierTransactions = _supplierTransactionRepository.GetSupplierTransactionsBySupplierName(supplierName);
            return Ok(supplierTransactions);
        }

        [HttpGet("{supplierTransactionId}")]
        [ProducesResponseType(200, Type = typeof(SupplierTransaction))]
        [ProducesResponseType(400)]
        public IActionResult GetSupplierTransaction(int supplierTransactionId)
        {
            if (!_supplierTransactionRepository.SupplierTransactionExists(supplierTransactionId))
                return NotFound();

            var supplierTransaction = _mapper.Map<SupplierTransactionDto>(_supplierTransactionRepository.GetSupplierTransaction(supplierTransactionId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(supplierTransaction);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateSupplierTransaction([FromBody] SupplierTransactionDto supplierTransactionCreate)
        {
            if (supplierTransactionCreate == null)
                return BadRequest(ModelState);

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var supplierTransactionMap = _mapper.Map<SupplierTransaction>(supplierTransactionCreate);

            if(!_supplierTransactionRepository.CreateSupplierTransaction(supplierTransactionMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created");
        }
    }
}
