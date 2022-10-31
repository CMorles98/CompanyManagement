using CompanyManagement.Domain.Services.Positions;
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
    public class PositionController : ControllerBase
    {
        private readonly IPositionServices _services;
        public PositionController(IPositionServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Gets all positions
        /// </summary>
        /// <returns>The positions list</returns>
        // GET: api/<Position>
        [HttpGet]
        public async Task<IActionResult> Get() => 
            Ok(await _services.GetAll());
    }
}
