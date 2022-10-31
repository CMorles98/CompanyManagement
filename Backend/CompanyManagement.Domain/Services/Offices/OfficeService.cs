using AutoMapper;
using CompanyManagement.Domain.DTOs.Office;
using CompanyManagement.Domain.Entities;
using CompanyManagement.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Services.Offices
{
    public class OfficeService : IOfficeServices
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public OfficeService(
            IRepositoryManager repositoryManager,
            IMapper mapper
            )
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<IEnumerable<OfficeDTO>> GetAll() => 
            _mapper.Map<IEnumerable<OfficeDTO>>( await _repositoryManager.OfficeRepository.GetAllAsync() );

    }
}
