using AutoMapper;
using CompanyManagement.Domain.DTOs.Division;
using CompanyManagement.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Services.Divisions
{
    public class DivisionServices: IDivisionServices
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public DivisionServices(
            IRepositoryManager repositoryManager,
            IMapper mapper
            )
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DivisionDTO>> GetAll() => 
            _mapper.Map<IEnumerable<DivisionDTO>> (await _repositoryManager.DivisionRepository.GetAllAsync());
    }
}
