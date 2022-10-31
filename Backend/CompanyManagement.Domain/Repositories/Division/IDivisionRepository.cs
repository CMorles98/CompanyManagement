﻿using CompanyManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CompanyManagement.Domain.Repositories
{
    public interface IDivisionRepository
    {
        Task<IEnumerable<Division>> GetAllAsync();
    }
}
