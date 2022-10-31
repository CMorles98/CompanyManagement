using AutoMapper;
using CompanyManagement.Domain.DTOs.Salary;
using CompanyManagement.Domain.DTOs.Salary.Request;
using CompanyManagement.Domain.DTOs.Salary.Response;
using CompanyManagement.Domain.Entities;
using CompanyManagement.Domain.Repositories;
using CompanyManagement.Domain.Shared.Validations;
using CompanyManagement.Domain.Shared.Validations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Services.Salaries
{
    public class SalaryService: ISalaryService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        private readonly ISalaryValidator _validator;

        public SalaryService(IRepositoryManager repository,
                             IMapper mapper,
                             ISalaryValidator validator)
        {
            _repository = repository;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<IEnumerable<GetRequestSalaryDTO>> GetAll(GetAllSalaryParametersDTO parameters) =>
            _mapper.Map<IEnumerable<GetRequestSalaryDTO>>(await _repository.SalaryRepository.GetAllAsync(parameters));

        public async Task<IEnumerable<GetRequestSalaryDTO>> GetAllGroupedByEmployee(GetAllSalaryParametersDTO parameters) =>
            _mapper.Map<IEnumerable<GetRequestSalaryDTO>>(await _repository.SalaryRepository.GetAllGroupedByEmployeeAsync(parameters));
        
        public async Task<GetByIdRequestSalaryDTO> GetById(int id)
        {
            var salary = _mapper.Map<GetByIdRequestSalaryDTO>(await _repository.SalaryRepository.FindSingleByCondition(o => o.Id.Equals(id),false));

            return salary;
        }

        public async Task<ValidationResultDataContext> Create(IEnumerable<SalaryForCreationDTO> dto) 
        {
            var validationResult = await _validator.ValidateOnCreate(dto);
            if (!validationResult.Success) return validationResult;

            foreach (var salary in dto)
            {
                var newId = await _repository.SalaryRepository.CreateSalary(_mapper.Map<Salary>(salary));
                validationResult.AddAffectedId(newId);
            }

            return validationResult;
        }
        public async Task<GetSalaryRecordCounterDTO> GetCountOfSalaries() 
        {
            return await _repository.SalaryRepository.GetCountOfSalaries();
        }
    }
}
