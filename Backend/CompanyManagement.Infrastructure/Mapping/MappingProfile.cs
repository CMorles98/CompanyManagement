using AutoMapper;
using CompanyManagement.Infrastructure.Utils;
using CompanyManagement.Domain.DTOs.Division;
using CompanyManagement.Domain.DTOs.Office;
using CompanyManagement.Domain.DTOs.Position;
using CompanyManagement.Domain.DTOs.Salary;
using CompanyManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyManagement.Domain.DTOs.Salary.Response;
using CompanyManagement.Domain.DTOs.Salary.Request;
using CompanyManagement.Domain.DTOs.Position.Response;

namespace CompanyManagement.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Divisions

            CreateMap<Division, DivisionDTO>()
                .ForMember(dto => dto.Positions, options => options.MapFrom(d => d.Positions))
                .ReverseMap();

            #endregion

            #region Offices

            CreateMap<Office, OfficeDTO>().ReverseMap();

            #endregion

            #region Positions

            CreateMap<Position, PositionDTO>();

            CreateMap<Position, GetRequestPositionDTO>();

            #endregion

            #region Salaries

            CreateMap<Salary, SalaryDTO>().ReverseMap();

            CreateMap<Salary, GetRequestSalaryDTO>()
                .ForMember(dto => dto.EmployeeDivision, options => options.MapFrom(e => e.Division.DivisionName))
                .ForMember(dto => dto.EmployeePosition, options => options.MapFrom(e => e.Position.PositionName))
                .ForMember(dto => dto.EmployeeFullName, options => options.MapFrom(e => $"{e.EmployeeName} {e.EmployeeSurname}"))
                .ForMember(dto => dto.TotalSalary, options => options.MapFrom(e => MappingUtils.GetTotalSalary(e.BaseSalary, e.Commission, e.ProductionBonus, e.CompensationBonus, e.Contributions)));

            CreateMap<Salary, GetByIdRequestSalaryDTO>();

            CreateMap<Salary, SalaryForCreationDTO>().ReverseMap();

            #endregion

        }
    }
}
