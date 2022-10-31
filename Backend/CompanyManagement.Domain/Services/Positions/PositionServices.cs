using AutoMapper;
using CompanyManagement.Domain.DTOs.Position;
using CompanyManagement.Domain.DTOs.Position.Response;
using CompanyManagement.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Services.Positions
{
    public class PositionServices : IPositionServices
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public PositionServices(
            IRepositoryManager repositoryManager,
            IMapper mapper
            )
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GetRequestPositionDTO>> GetAll() => 
            _mapper.Map<IEnumerable<GetRequestPositionDTO>>(await _repositoryManager.PositionRepository.GetAllAsync());
    }
}
