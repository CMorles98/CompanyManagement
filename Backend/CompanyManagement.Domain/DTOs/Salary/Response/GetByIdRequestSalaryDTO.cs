﻿using CompanyManagement.Domain.DTOs.Division;
using CompanyManagement.Domain.DTOs.Office;
using CompanyManagement.Domain.DTOs.Position;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.DTOs.Salary
{
    public class GetByIdRequestSalaryDTO: BaseEntityDTO
    {
        public int Year { get; set; }

        public int Month { get; set; }

        public int OfficeId { get; set; }

        public string EmployeeCode { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeSurname { get; set; }

        public int DivisionId { get; set; }

        public int PositionId { get; set; }

        public int Grade { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime Birthday { get; set; }

        public string IdentificationNumber { get; set; }

        public decimal BaseSalary { get; set; }

        public decimal ProductionBonus { get; set; }

        public decimal CompensationBonus { get; set; }

        public decimal Commission { get; set; }

        public decimal Contributions { get; set; }
    }
}
