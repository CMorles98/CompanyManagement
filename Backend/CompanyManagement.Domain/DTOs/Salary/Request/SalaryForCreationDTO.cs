using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.DTOs.Salary.Request
{
    public class SalaryForCreationDTO: BaseEntityDTO
    {
        [Required(ErrorMessage = "{0} is a required field.")]
        [Range(2000, int.MaxValue, ErrorMessage = "{0} value must be bigger than {1}")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "{0} is a required field.")]
        [Range(0, 12, ErrorMessage = "{0} value must be between 1 and 12")]
        public int? Month { get; set; }

        [Required(ErrorMessage = "{0} is a required field.")]
        [Range(1, int.MaxValue, ErrorMessage = "{0} value must be bigger than {1}")]
        public int? OfficeId { get; set; }

        [Required(ErrorMessage = "{0} is a required field.")]
        [StringLength(10, ErrorMessage = "Maximum length for the {0} is 10 characters.")]
        public string EmployeeCode { get; set; }

        [Required(ErrorMessage = "{0} is a required field.")]
        [StringLength(150, ErrorMessage = "Maximum length for the {0} is 150 characters.")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "{0} is a required field.")]
        [StringLength(150, ErrorMessage = "Maximum length for the {0} is 150 characters.")]
        public string EmployeeSurname { get; set; }

        [Required(ErrorMessage = "{0} is a required field.")]
        [Range(1, int.MaxValue, ErrorMessage = "{0} value must be bigger than {1}")]
        public int? DivisionId { get; set; }

        [Required(ErrorMessage = "{0} is a required field.")]
        [Range(1, int.MaxValue, ErrorMessage = "{0} value must be bigger than {1}")]
        public int? PositionId { get; set; }

        [Required(ErrorMessage = "{0} is a required field.")]
        [Range(1, int.MaxValue, ErrorMessage = "{0} value must be bigger than {1}")]
        public int? Grade { get; set; }

        [Required(ErrorMessage = "{0} is a required field.")]
        public DateTime? BeginDate { get; set; }

        [Required(ErrorMessage = "{0} is a required field.")]
        public DateTime? Birthday { get; set; }

        [Required(ErrorMessage = "{0} is a required field.")]
        [StringLength(10, ErrorMessage = "Maximum length for the {0} is 10 characters.")]
        public string IdentificationNumber { get; set; }

        [Required(ErrorMessage = "{0} is a required field.")]
        [Range(0, Double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public decimal? BaseSalary { get; set; }

        public decimal? ProductionBonus { get; set; }

        public decimal? CompensationBonus { get; set; }

        public decimal? Commission { get; set; }

        public decimal? Contributions { get; set; }
    }
}
