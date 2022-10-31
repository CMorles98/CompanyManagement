using CompanyManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Infrastructure.Utils
{
    public static class DbUtils
    {
        public static IEnumerable<Office> GetOffices() =>
            new List<Office>() {
                   new Office() { Id = 1, OfficeName = "A" },
                   new Office() { Id = 2, OfficeName = "B" },
                   new Office() { Id = 3, OfficeName = "C" },
                   new Office() { Id = 4, OfficeName = "D" },
                   new Office() { Id = 5, OfficeName = "E" },
                   new Office() { Id = 6, OfficeName = "F" },
                   new Office() { Id = 7, OfficeName = "ZZ" }
            };

        public static IEnumerable<Division> GetDivisions() =>
             new List<Division>() {
                   new Division() { Id = 1, DivisionName = "OPERATION" },
                   new Division() { Id = 2, DivisionName = "SALES" },
                   new Division() { Id = 3, DivisionName = "MARKETING" },
                   new Division() { Id = 4, DivisionName = "CUSTOMER CARE" }
            };

        public static IEnumerable<Position> GetPositions() =>
            new List<Position>() {
                   new Position() { Id = 1, PositionName = "CARGO MANAGER",       DivisionId = 1 },
                   new Position() { Id = 2, PositionName = "HEAD OF CARGO",       DivisionId = 1 },
                   new Position() { Id = 3, PositionName = "CARGO ASSISTANT",     DivisionId = 1 },
                   new Position() { Id = 4, PositionName = "SALES MANAGER",       DivisionId = 2 },
                   new Position() { Id = 5, PositionName = "ACCOUNT EXECUTIVE",   DivisionId = 2 },
                   new Position() { Id = 6, PositionName = "MARKETING ASSISTANT", DivisionId = 3 },
                   new Position() { Id = 7, PositionName = "CUSTOMER DIRECTOR",   DivisionId = 4 },
                   new Position() { Id = 8, PositionName = "CUSTOMER ASSISTANT",  DivisionId = 4 }
            };

        public static IEnumerable<Salary> GetSalaries()
        {
            int[] grades = { 18, 12, 6, 14, 12, 11, 18, 11 };

            var usedCodes = new List<string>();
            var usedIdNumbers = new List<string>();
            var salaries = new List<Salary>();

            var mockEmployees = GetMockEmployees();
            var positions = GetPositions();

            int index = 1;

            foreach (var employee in mockEmployees)
            {
                //Create 6 records for each employee

                var identificationNumber = GetRandomIdentificationNumber(usedIdNumbers);
                var employeeCode = GetEmployeeCode(usedCodes);
                var beginDate = GetRandomDateBetweenLimits(2005, 2021).Date;
                var officeId = new Random().Next(1, 7);
                var positionId = new Random().Next(1, 8);

                var position = positions.FirstOrDefault(p => p.Id.Equals(positionId));
                var grade = grades[position.Id];

                int year  = beginDate.Year;
                int month = beginDate.Month;

                decimal baseSalary = new Random().Next(3000, 6000);

                for (int i = 1; i < 7; i++)
                {
                    salaries.Add(
                        new Salary()
                        {
                            Id = index++,
                            Year = year,
                            Month = month,
                            OfficeId = officeId,
                            EmployeeCode = employeeCode,
                            EmployeeName = employee.EmployeeName.Trim(),
                            EmployeeSurname = employee.EmployeeSurname.Trim(),
                            DivisionId = (int)position.DivisionId,
                            PositionId = position.Id,
                            Grade = grade,
                            BeginDate = beginDate.Date,
                            Birthday = employee.Birthday.Date,
                            IdentificationNumber = identificationNumber,
                            BaseSalary = baseSalary,
                            ProductionBonus = new Random().Next(0, 1000),
                            CompensationBonus = i.Equals(6) ? baseSalary : 0,
                            Commission = new Random().Next(0, 500),
                            Contributions = new Random().Next(0, 2000)
                        });
                    month++;
                    if (month.Equals(13)) 
                    {
                        month = 1;
                        year += 1;
                    }
                }
            }

            return salaries;
        }

        private class MockEmployees
        {
            public string EmployeeName { get; set; }
            public string EmployeeSurname { get; set; }
            public DateTime Birthday { get; set; }
            public MockEmployees(string surName,
                                 string name)
            {
                EmployeeName = name;
                EmployeeSurname = surName;
                Birthday = GetRandomDateBetweenLimits(1980, 2000);
            }
        }

        private static DateTime GetRandomDateBetweenLimits(int beginYear, int endYear)
        {
            DateTime start = new DateTime(beginYear, 1, 1);
            DateTime end = new DateTime(endYear, 1, 1);
            Random gen = new Random();
            var range = (end - start).Days;

            return start.AddDays(gen.Next(range)).AddHours(0).AddMinutes(0).AddSeconds(0);
        }

        private static string GetRandomIdentificationNumber(IEnumerable<string> usedIdNumbers)
        {
            var newIdNumber = ((long)Math.Round(new Random().NextDouble() * (99999999 - 11111111 - 1)) + 11111111).ToString();

            if (usedIdNumbers.Any(e => e.Equals(newIdNumber)))
            {
                while (usedIdNumbers.Any(e => e.Equals(newIdNumber)))
                {
                    newIdNumber = ((long)Math.Round(new Random().NextDouble() * (99999999 - 11111111 - 1)) + 11111111).ToString();
                    continue;
                }

            }
            return newIdNumber;
        }

        private static IEnumerable<MockEmployees> GetMockEmployees() =>
            new List<MockEmployees>() {
            new MockEmployees("ABELLA              ","WILLIAM               "),
            new MockEmployees("ACOSTA              ", "JOSE                 "),
            new MockEmployees("ACOSTA              ", "PEREGRINO            "),
            new MockEmployees("AGREDO              ", "GUEFRY               "),
            new MockEmployees("AGREDO              ", "XIMENA LUCIA         "),
            new MockEmployees("AGUDELO DE LOPEZ    ", "NORA                 "),
            new MockEmployees("BARRAGAN            ", "JESUS                "),
            new MockEmployees("BARRETO             ", "LUIS                 "),
            new MockEmployees("BASTIDAS            ", "HENRY                "),
            new MockEmployees("BECERRA             ", "CLARA                "),
            new MockEmployees("CABRERA             ", "HERNANDO             "),
            new MockEmployees("CACERES             ", "DIEGO                "),
            new MockEmployees("CADENA              ", "LUCIA                "),
            new MockEmployees("CAICEDO             ", "EMILIO               "),
            new MockEmployees("CALAMBAS            ", "JESUS                "),
            new MockEmployees("CALDAS              ", "ALBERTO              "),
            new MockEmployees("CALERO              ", "HEIMER               "),
            new MockEmployees("CALVACHE            ", "ARMANDO              "),
            new MockEmployees("CASTRO              ", "GUILLERMO            "),
            new MockEmployees("CASTRO              ", "SANTIAGO             "),
            new MockEmployees("SANCHEZ             ", "LUCIO                "),
            new MockEmployees("CEBALLOS            ", "YANETH               "),
            new MockEmployees("COLLAZOS            ", "YAZMIN               "),
            new MockEmployees("DELGADO             ", "FERNANDO             "),
            new MockEmployees("DIAGO               ", "JULIO                "),
            new MockEmployees("DIAGO               ", "MARINA               "),
            new MockEmployees("DIAZ                ", "MARINA               "),
            new MockEmployees("DIAZ                ", "ROSALBA              "),
            new MockEmployees("EGAS                ", "MAURO                "),
            new MockEmployees("ESCOBAR             ", "JAIME                "),
            new MockEmployees("ESPINOSA            ", "PAULO                "),
            new MockEmployees("ESPINOSA            ", "MIRTHA               "),
            new MockEmployees("EUSCATEGUI          ", "ROBERTH              "),
            new MockEmployees("OLIVEROS            ", "JAIME                "),
            new MockEmployees("SARRIA              ", "ALEXANDER            "),
            new MockEmployees("FALLA               ", "ALFONSO              "),
            new MockEmployees("FARFAN              ", "MABEL                "),
            new MockEmployees("FERNANDEZ           ", "NANCY                "),
            new MockEmployees("FERNANDEZ           ", "LIZARDO              "),
            new MockEmployees("FERNANDEZ           ", "JULIAN               "),
            new MockEmployees("LASSO               ", "MARY                 "),
            new MockEmployees("GALINDO             ", "GLADYS               "),
            new MockEmployees("GALLARDO            ", "CARLOS               "),
            new MockEmployees("GALLO               ", "JOSE                 "),
            new MockEmployees("GALVIS              ", "ALBERT               "),
            new MockEmployees("GAMEZ               ", "RUTH                 "),
            new MockEmployees("GARCES              ", "ENRIQUE              "),
            new MockEmployees("GARCIA              ", "WILLIAM              "),
            new MockEmployees("GARCIA              ", "DE SANCHEZ YOLANDA   "),
            new MockEmployees("GARCIA              ", "GLORIA               "),
            new MockEmployees("GARCIA              ", "MILLER               "),
            new MockEmployees("GARCIA              ", "ELENA                "),
            new MockEmployees("GAVIRIA             ", "CARLOS               "),
            new MockEmployees("GIRALDO             ", "JHON                 "),
            new MockEmployees("GOMEZ               ", "SAUL                 "),
            new MockEmployees("GOMEZ               ", "LINO                 "),
            new MockEmployees("GOMEZ               ", "ELISA                "),
            new MockEmployees("GOMEZ               ", "RIGOBERTO            "),
            new MockEmployees("GONZALEZ            ", "ELIZABETH            "),
            new MockEmployees("GONZALEZ            ", "ANDRES               "),
            new MockEmployees("GRANADOS            ", "LUIS                 "),
            new MockEmployees("GRIJALBA            ", "PEDRO                "),
            new MockEmployees("GRUESO              ", "CLAUDIA              "),
            new MockEmployees("GUEVARA             ", "LESLIE               "),
            new MockEmployees("BURBANO             ", "ADOLFO               "),
            new MockEmployees("GUERRERO            ", "MARIA                "),
            new MockEmployees("GUERRERO            ", "JERONIMO             "),
            new MockEmployees("GUEVARA             ", "SANDRA               "),
            new MockEmployees("GUTIERREZ           ", "OSCAR                "),
            new MockEmployees("GUTIERREZ           ", "CARMEN               "),
            new MockEmployees("GUTIERREZ           ", "ORLANDO              "),
            new MockEmployees("GUZMAN              ", "TERESA               "),
            new MockEmployees("GUZMAN              ", "SONIA                "),
            new MockEmployees("GUZMAN              ", "LUCIA                "),
            new MockEmployees("HARTMANN            ", "GARCES               "),
            new MockEmployees("HERNADEZ            ", "IVAN                 "),
            new MockEmployees("HERNANDEZ           ", "MYRIAM               "),
            new MockEmployees("HERRERA             ", "MARTHA               "),
            new MockEmployees("HERRERA             ", "NHORA                "),
            new MockEmployees("HERRERA             ", "MANUEL               "),
            new MockEmployees("HERRERA             ", "LUZ                  "),
            new MockEmployees("HIDALGO             ", "ANA                  "),
            new MockEmployees("HINCAPIE            ", "GEOVANNY             "),
            new MockEmployees("HOYOS               ", "LUIS                 "),
            new MockEmployees("HOYOS               ", "CLAUDIA              "),
            new MockEmployees("HOYOS               ", "LAURENCIO            "),
            new MockEmployees("HOYOS               ", "OLGA                 "),
            new MockEmployees("HURTADO             ", "DAVID                "),
            new MockEmployees("HURTADO             ", "HURIEL               "),
            new MockEmployees("HURTADO             ", "DORIS                "),
            new MockEmployees("IBARRA              ", "CARMEN               "),
            new MockEmployees("IDROBO              ", "MARY                 "),
            new MockEmployees("IDROBO              ", "SIMON                "),
            new MockEmployees("GOMEZ               ", "DIVER                "),
            new MockEmployees("CLARA               ", "EUGENIA              "),
            new MockEmployees("IMBACHI             ", "TULIO                "),
            new MockEmployees("JARAMILLO           ", "TOMAS                "),
            new MockEmployees("JOAQUI              ", "MARIA                "),
            new MockEmployees("JORDAN              ", "MARISOL              "),
            new MockEmployees("JURADO              ", "EDGAR                ")
            };

        private static string GetEmployeeCode(List<string> usedCodes)
        {
            var newCode = $"1000{ new Random().Next(1000, 9000) }";

            if (usedCodes.Any(e => e.Equals(newCode)))
            {
                while (usedCodes.Any(e => e.Equals(newCode)))
                {
                    newCode = $"1000{ new Random().Next(1000, 9000) }";
                    continue;
                }

            }
            return newCode;
        }
    }
}
