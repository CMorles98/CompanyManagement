using CompanyManagement.Domain.Services.Divisions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyManagement.WebApi.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [ApiController]
    public class DivisionController : ControllerBase
    {
        private readonly IDivisionServices _services;
        public DivisionController(IDivisionServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Gets all divisions
        /// </summary>
        /// <returns>The divisions list</returns>
        // GET: api/<Division>
        [HttpGet]
        public async Task<IActionResult> Get() => 
            Ok(await _services.GetAll());
    }
}
