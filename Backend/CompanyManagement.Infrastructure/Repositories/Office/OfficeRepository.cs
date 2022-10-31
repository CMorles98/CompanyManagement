using CompanyManagement.Domain.Entities;
using CompanyManagement.Domain.Repositories;
using CompanyManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Infrastructure.Repositories
{
    public class OfficeRepository : BaseRepository<Office>, IOfficeRepository
    {
        public OfficeRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Office>> GetAllAsync() => await FindAll(false).ToListAsync();
    }
}