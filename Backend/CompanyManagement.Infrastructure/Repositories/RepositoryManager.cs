using CompanyManagement.Domain.Repositories;
using CompanyManagement.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Infrastructure.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        public RepositoryManager(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        private readonly ApplicationDbContext _dbContext;
        private IDivisionRepository _divisionRepository { get; set; }
        private IOfficeRepository _officeRepository { get; set; }
        private IPositionRepository _positionRepository { get; set; }
        private ISalaryRepository _salaryRepository { get; set; }

        public IDivisionRepository DivisionRepository { get => _divisionRepository == null ? new DivisionRepository(_dbContext): _divisionRepository; }
        public IOfficeRepository OfficeRepository { get => _officeRepository == null ? new OfficeRepository(_dbContext): _officeRepository; }
        public IPositionRepository PositionRepository { get => _positionRepository == null ? new PositionRepository(_dbContext): _positionRepository;}
        public ISalaryRepository SalaryRepository { get => _salaryRepository == null ? new SalaryRepository(_dbContext): _salaryRepository;}
        
        public void Save() => _dbContext.SaveChanges();
    }
}
