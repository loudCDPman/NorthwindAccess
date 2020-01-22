using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Northwind.DataAccess;
using System;

namespace Northwind.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Customer : ControllerBase
    {
        private readonly ILogger<Customer> _logger;
        private readonly IRepository _respository;

        public Customer(ILogger<Customer> logger, IRepository repository)
        {
            _logger = logger;
            _respository = repository;
        }

        [HttpGet]
        [Route("/[action]")]
        public IActionResult GetAllCustomers()
        {
            try
            {
                return Ok(_respository.GetEmployees());
            }
            catch (Exception error)
            {
                _logger.LogError($"Error in GetAllCustomers Exception : {error}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        [Route("/[action]/{id}")]
        public IActionResult GetCustomers([FromRoute]int id)
        {
            try
            {
                return Ok(_respository.GetEmployee(id));
            }
            catch (Exception error)
            {
                _logger.LogError($"Error in GetCustomers Exception : {error}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
