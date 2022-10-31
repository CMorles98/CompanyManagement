using CompanyManagement.Domain.Services.Offices;
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
    public class OfficeController : ControllerBase
    {
        private readonly IOfficeServices _services;
        public OfficeController(IOfficeServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Gets all offices
        /// </summary>
        /// <returns>The oficces list</returns>
        // GET: api/<Office>
        [HttpGet]
        public async Task<IActionResult> Get() => 
            Ok(await _services.GetAll());
    }
}
