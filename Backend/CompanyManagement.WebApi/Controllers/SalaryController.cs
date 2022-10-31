using CompanyManagement.Domain.DTOs.Salary.Request;
using CompanyManagement.Domain.Services.Salaries;
using CompanyManagement.WebApi.ActionFilters;
using Marvin.Cache.Headers;
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
    public class SalaryController : ControllerBase
    {
        private readonly ISalaryService _services;
        public SalaryController(ISalaryService services)
        {
            _services = services;
        }

        /// <summary>
        /// Gets all salaries
        /// </summary>
        /// <returns>The salaries list</returns>
        [HttpCacheValidation(MustRevalidate = true)]
        [ProducesResponseType(200)]
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllSalaryParametersDTO parameters) =>
            Ok(await _services.GetAll(parameters));

        /// <summary>
        /// Get a single salary by id
        /// </summary>
        /// <response code="404">If the return object doesn't exist in the database</response>
        /// <returns>The salary by id</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) =>
            await _services.GetById(id)
            .ContinueWith(t => t.Result != null
                ? Ok(t.Result)
                : NotFound() as IActionResult);

        /// <summary>
        /// Gets the salaries grouped by employees
        /// </summary>
        /// <returns>The salaries list</returns>
        [HttpCacheValidation(MustRevalidate = true)]
        [ProducesResponseType(200)]
        [HttpGet("GetAllGroupedByEmployee")]
        public async Task<IActionResult> GetAllGroupedByEmployee([FromQuery] GetAllSalaryParametersDTO parameters) =>
            Ok(await _services.GetAllGroupedByEmployee(parameters));


        /// <summary>
        /// Create a new salary record
        /// </summary>
        /// <returns>A newly created salary id</returns>
        /// <response code="422">If the record already exists</response>
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ProducesResponseType(200)]
        [ProducesResponseType(422)]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] IEnumerable<SalaryForCreationDTO> dto) =>
            await _services.Create(dto)
            .ContinueWith(t => t.Result.Success 
                ? Ok(t.Result.AffectedIDs) 
                : UnprocessableEntity(t.Result) as IActionResult);


        /// <summary>
        /// Gets the number of salary records in the database
        /// </summary>
        /// <returns>The number of salary records</returns>
        [ProducesResponseType(200)]
        [HttpGet("GetCountOfSalaries")]
        public async Task<IActionResult> GetCountOfSalaries() =>
            Ok(await _services.GetCountOfSalaries());
    }

}
