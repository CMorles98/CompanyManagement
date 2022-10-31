using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyManagement.Infrastructure.Migrations
{
    public partial class UpdateSomeEntityConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DivisionId",
                table: "Positions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5992m, new DateTime(2020, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 136m, 784m, 1, "10005310", 6, "31151399", 4, 3, 2, 207m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5992m, new DateTime(2020, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 277m, 891m, 1, "10005310", 6, "31151399", 5, 3, 2, 526m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5992m, new DateTime(2020, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, 1965m, 1, "10005310", 6, "31151399", 6, 3, 2, 13m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5992m, new DateTime(2020, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 113m, 786m, 1, "10005310", 6, "31151399", 7, 3, 2, 730m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5992m, new DateTime(2020, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 308m, 278m, 1, "10005310", 6, "31151399", 8, 3, 2, 252m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5992m, new DateTime(2020, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 171m, 5992m, 1868m, 1, "10005310", 6, "31151399", 9, 3, 2, 869m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus" },
                values: new object[] { 4807m, new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 176m, 382m, "10007564", "13360720", 10, 6, 2m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus" },
                values: new object[] { 4807m, new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 80m, 657m, "10007564", "13360720", 11, 6, 509m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4807m, new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 403m, 195m, "10007564", "13360720", 12, 6, 98m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus" },
                values: new object[] { 4807m, new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 287m, 1220m, "10007564", "13360720", 1, 6, 421m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus" },
                values: new object[] { 4807m, new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 333m, 1750m, "10007564", "13360720", 2, 6, 539m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus" },
                values: new object[] { 4807m, new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 344m, 4807m, 38m, "10007564", "13360720", 3, 6, 807m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3480m, new DateTime(2015, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 41m, 1843m, "10007334", 12, "95334593", 4, 1, 1, 181m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3480m, new DateTime(2015, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 42m, 317m, "10007334", 12, "95334593", 5, 1, 1, 747m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3480m, new DateTime(2015, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3m, 247m, "10007334", 12, "95334593", 6, 1, 1, 924m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3480m, new DateTime(2015, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 125m, 1855m, "10007334", 12, "95334593", 7, 1, 1, 516m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3480m, new DateTime(2015, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 115m, 1613m, "10007334", 12, "95334593", 8, 1, 1, 980m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3480m, new DateTime(2015, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 178m, 3480m, 292m, "10007334", 12, "95334593", 9, 1, 1, 380m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4207m, new DateTime(2017, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 471m, 1716m, "10005456", 12, "13051150", 4, 2, 1, 785m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4207m, new DateTime(2017, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 353m, 1617m, "10005456", 12, "13051150", 5, 2, 1, 505m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4207m, new DateTime(2017, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 290m, 66m, "10005456", 12, "13051150", 6, 2, 1, 686m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4207m, new DateTime(2017, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 27m, 1608m, "10005456", 12, "13051150", 7, 2, 1, 757m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4207m, new DateTime(2017, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 38m, 898m, "10005456", 12, "13051150", 8, 2, 1, 132m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4207m, new DateTime(2017, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 111m, 4207m, 587m, "10005456", 12, "13051150", 9, 2, 1, 664m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3554m, new DateTime(2007, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 146m, 321m, 2, "10006997", "29995779", 4, 5, 4, 938m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3554m, new DateTime(2007, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 425m, 431m, 2, "10006997", "29995779", 5, 5, 4, 221m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3554m, new DateTime(2007, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 326m, 1504m, 2, "10006997", "29995779", 6, 5, 4, 118m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3554m, new DateTime(2007, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 344m, 1733m, 2, "10006997", "29995779", 7, 5, 4, 245m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3554m, new DateTime(2007, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 72m, 53m, 2, "10006997", "29995779", 8, 5, 4, 27m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3554m, new DateTime(2007, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 277m, 3554m, 791m, 2, "10006997", "29995779", 9, 5, 4, 41m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3018m, new DateTime(2019, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 41m, 120m, 4, "10008596", "66293512", 6, 5, 7, 423m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3018m, new DateTime(2019, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 384m, 65m, 4, "10008596", "66293512", 7, 5, 7, 201m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3018m, new DateTime(2019, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 419m, 232m, 4, "10008596", "66293512", 8, 5, 7, 986m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3018m, new DateTime(2019, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 146m, 277m, 4, "10008596", "66293512", 9, 5, 7, 399m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3018m, new DateTime(2019, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 95m, 912m, 4, "10008596", "66293512", 10, 5, 7, 374m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3018m, new DateTime(2019, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 182m, 3018m, 256m, 4, "10008596", "66293512", 11, 5, 7, 543m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5409m, new DateTime(2006, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 448m, 1841m, 1, "10005908", 14, "80272718", 11, 2, 3, 992m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5409m, new DateTime(2006, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 389m, 660m, 1, "10005908", 14, "80272718", 12, 2, 3, 473m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5409m, new DateTime(2006, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 468m, 92m, 1, "10005908", 14, "80272718", 1, 2, 3, 9m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5409m, new DateTime(2006, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 262m, 989m, 1, "10005908", 14, "80272718", 2, 2, 3, 880m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5409m, new DateTime(2006, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 321m, 1218m, 1, "10005908", 14, "80272718", 3, 2, 3, 881m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5409m, new DateTime(2006, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 492m, 5409m, 1153m, 1, "10005908", 14, "80272718", 4, 2, 3, 445m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3270m, new DateTime(2014, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 401m, 620m, 1, "10003829", 14, "53489970", 4, 4, 3, 665m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3270m, new DateTime(2014, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 338m, 172m, 1, "10003829", 14, "53489970", 5, 4, 3, 499m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3270m, new DateTime(2014, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 420m, 890m, 1, "10003829", 14, "53489970", 6, 4, 3, 617m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3270m, new DateTime(2014, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 467m, 1196m, 1, "10003829", 14, "53489970", 7, 4, 3, 983m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3270m, new DateTime(2014, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 119m, 1570m, 1, "10003829", 14, "53489970", 8, 4, 3, 838m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3270m, new DateTime(2014, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 58m, 3270m, 164m, 1, "10003829", 14, "53489970", 9, 4, 3, 512m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4345m, new DateTime(2011, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 29m, 708m, 1, "10002762", 14, "83923224", 4, 5, 3, 245m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4345m, new DateTime(2011, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 279m, 1473m, 1, "10002762", 14, "83923224", 5, 5, 3, 265m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4345m, new DateTime(2011, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 52m, 461m, 1, "10002762", 14, "83923224", 6, 5, 3, 950m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4345m, new DateTime(2011, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 266m, 1403m, 1, "10002762", 14, "83923224", 7, 5, 3, 556m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4345m, new DateTime(2011, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 117m, 1971m, 1, "10002762", 14, "83923224", 8, 5, 3, 746m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4345m, new DateTime(2011, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 494m, 4345m, 821m, 1, "10002762", 14, "83923224", 9, 5, 3, 686m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4416m, new DateTime(2011, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 345m, 1926m, 1, "10005997", 14, "80037027", 12, 5, 3, 517m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4416m, new DateTime(2011, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 260m, 1797m, 1, "10005997", 14, "80037027", 1, 5, 3, 223m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4416m, new DateTime(2011, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 352m, 283m, 1, "10005997", 14, "80037027", 2, 5, 3, 423m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4416m, new DateTime(2011, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 490m, 689m, 1, "10005997", 14, "80037027", 3, 5, 3, 588m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4416m, new DateTime(2011, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 39m, 17m, 1, "10005997", 14, "80037027", 4, 5, 3, 458m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4416m, new DateTime(2011, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 379m, 4416m, 1111m, 1, "10005997", 14, "80037027", 5, 5, 3, 435m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4823m, new DateTime(2011, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 429m, 1913m, 2, "10001064", 12, "19423952", 12, 5, 4, 822m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4823m, new DateTime(2011, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 319m, 978m, 2, "10001064", 12, "19423952", 1, 5, 4, 708m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4823m, new DateTime(2011, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 117m, 901m, 2, "10001064", 12, "19423952", 2, 5, 4, 739m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4823m, new DateTime(2011, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 236m, 1187m, 2, "10001064", 12, "19423952", 3, 5, 4, 608m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4823m, new DateTime(2011, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 226m, 620m, 2, "10001064", 12, "19423952", 4, 5, 4, 499m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4823m, new DateTime(2011, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 429m, 4823m, 1110m, 2, "10001064", 12, "19423952", 5, 5, 4, 58m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4913m, new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 33m, 1182m, 4, "10008073", 11, "36535294", 9, 3, 7, 128m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4913m, new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 185m, 103m, 4, "10008073", 11, "36535294", 10, 3, 7, 605m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4913m, new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 217m, 1848m, 4, "10008073", 11, "36535294", 11, 3, 7, 766m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4913m, new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 63m, 776m, 4, "10008073", 11, "36535294", 12, 3, 7, 81m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4913m, new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 221m, 1584m, 4, "10008073", 11, "36535294", 1, 3, 7, 668m, 2021 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4913m, new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 287m, 4913m, 945m, 4, "10008073", 11, "36535294", 2, 3, 7, 378m, 2021 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3098m, new DateTime(2010, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 380m, 1750m, 2, "10005610", 11, "66242356", 4, 1, 5, 971m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3098m, new DateTime(2010, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 124m, 669m, 2, "10005610", 11, "66242356", 5, 1, 5, 603m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3098m, new DateTime(2010, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 90m, 1263m, 2, "10005610", 11, "66242356", 6, 1, 5, 353m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3098m, new DateTime(2010, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 152m, 596m, 2, "10005610", 11, "66242356", 7, 1, 5, 45m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3098m, new DateTime(2010, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 430m, 1181m, 2, "10005610", 11, "66242356", 8, 1, 5, 624m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3098m, new DateTime(2010, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 284m, 3098m, 1531m, 2, "10005610", 11, "66242356", 9, 1, 5, 125m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3429m, new DateTime(2005, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 316m, 71m, 1, "10002154", "46317026", 11, 4, 1, 489m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3429m, new DateTime(2005, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 236m, 207m, 1, "10002154", "46317026", 12, 4, 1, 234m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3429m, new DateTime(2005, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 356m, 262m, 1, "10002154", "46317026", 1, 4, 1, 33m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3429m, new DateTime(2005, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 180m, 669m, 1, "10002154", "46317026", 2, 4, 1, 284m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3429m, new DateTime(2005, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 444m, 1820m, 1, "10002154", "46317026", 3, 4, 1, 902m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3429m, new DateTime(2005, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 227m, 3429m, 1342m, 1, "10002154", "46317026", 4, 4, 1, 315m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4321m, new DateTime(2018, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 110m, 1468m, 2, "10003792", 12, "54035055", 10, 2, 4, 608m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4321m, new DateTime(2018, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 235m, 487m, 2, "10003792", 12, "54035055", 11, 2, 4, 290m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4321m, new DateTime(2018, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24m, 743m, 2, "10003792", 12, "54035055", 12, 2, 4, 706m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4321m, new DateTime(2018, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 419m, 685m, 2, "10003792", 12, "54035055", 1, 2, 4, 458m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4321m, new DateTime(2018, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 422m, 869m, 2, "10003792", 12, "54035055", 2, 2, 4, 24m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4321m, new DateTime(2018, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 369m, 4321m, 636m, 2, "10003792", 12, "54035055", 3, 2, 4, 253m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4214m, new DateTime(2008, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 403m, 832m, 4, "10001524", "90523838", 8, 6, 7, 581m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4214m, new DateTime(2008, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 445m, 986m, 4, "10001524", "90523838", 9, 6, 7, 107m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4214m, new DateTime(2008, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 497m, 1757m, 4, "10001524", "90523838", 10, 6, 7, 7m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4214m, new DateTime(2008, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 176m, 1956m, 4, "10001524", "90523838", 11, 6, 7, 321m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4214m, new DateTime(2008, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 234m, 1938m, 4, "10001524", "90523838", 12, 6, 7, 95m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4214m, new DateTime(2008, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 152m, 4214m, 73m, 4, "10001524", "90523838", 1, 6, 7, 613m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4006m, new DateTime(2017, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 477m, 673m, "10002365", "72385888", 6, 2, 962m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4006m, new DateTime(2017, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 26m, 282m, "10002365", "72385888", 7, 2, 270m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4006m, new DateTime(2017, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 176m, 1998m, "10002365", "72385888", 8, 2, 940m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4006m, new DateTime(2017, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 217m, 781m, "10002365", "72385888", 9, 2, 55m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4006m, new DateTime(2017, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 162m, 1769m, "10002365", "72385888", 10, 2, 553m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4006m, new DateTime(2017, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 88m, 4006m, 1140m, "10002365", "72385888", 11, 2, 604m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5988m, new DateTime(2008, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2m, 974m, 4, "10004435", "27996363", 7, 2, 7, 75m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5988m, new DateTime(2008, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9m, 1007m, 4, "10004435", "27996363", 8, 2, 7, 916m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5988m, new DateTime(2008, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7m, 1031m, 4, "10004435", "27996363", 9, 2, 7, 355m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5988m, new DateTime(2008, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 435m, 1324m, 4, "10004435", "27996363", 10, 2, 7, 806m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5988m, new DateTime(2008, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 231m, 1338m, 4, "10004435", "27996363", 11, 2, 7, 882m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5988m, new DateTime(2008, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 53m, 5988m, 1452m, 4, "10004435", "27996363", 12, 2, 7, 463m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5118m, new DateTime(2017, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 405m, 1438m, 3, "10007128", 18, "73798541", 2, 2, 6, 878m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5118m, new DateTime(2017, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 415m, 627m, 3, "10007128", 18, "73798541", 3, 2, 6, 932m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5118m, new DateTime(2017, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 252m, 1594m, 3, "10007128", 18, "73798541", 4, 2, 6, 842m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5118m, new DateTime(2017, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 460m, 1546m, 3, "10007128", 18, "73798541", 5, 2, 6, 67m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5118m, new DateTime(2017, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 375m, 119m, 3, "10007128", 18, "73798541", 6, 2, 6, 380m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5118m, new DateTime(2017, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 213m, 5118m, 294m, 3, "10007128", 18, "73798541", 7, 2, 6, 221m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "ProductionBonus", "Year" },
                values: new object[] { 4323m, new DateTime(2007, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 226m, 95m, "10004786", "64540283", 11, 627m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "ProductionBonus", "Year" },
                values: new object[] { 4323m, new DateTime(2007, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 102m, 1689m, "10004786", "64540283", 12, 219m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "ProductionBonus", "Year" },
                values: new object[] { 4323m, new DateTime(2007, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 248m, 1892m, "10004786", "64540283", 1, 962m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "ProductionBonus", "Year" },
                values: new object[] { 4323m, new DateTime(2007, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 382m, 1868m, "10004786", "64540283", 2, 507m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "ProductionBonus", "Year" },
                values: new object[] { 4323m, new DateTime(2007, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 74m, 1820m, "10004786", "64540283", 3, 510m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "ProductionBonus", "Year" },
                values: new object[] { 4323m, new DateTime(2007, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 345m, 4323m, 184m, "10004786", "64540283", 4, 928m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3250m, new DateTime(2009, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 105m, 130m, 3, "10005335", 18, "63698172", 4, 4, 6, 392m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3250m, new DateTime(2009, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 214m, 78m, 3, "10005335", 18, "63698172", 5, 4, 6, 338m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3250m, new DateTime(2009, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 328m, 179m, 3, "10005335", 18, "63698172", 6, 4, 6, 252m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3250m, new DateTime(2009, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 15m, 208m, 3, "10005335", 18, "63698172", 7, 4, 6, 4m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3250m, new DateTime(2009, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 174m, 55m, 3, "10005335", 18, "63698172", 8, 4, 6, 992m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3250m, new DateTime(2009, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 415m, 3250m, 301m, 3, "10005335", 18, "63698172", 9, 4, 6, 678m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3012m, new DateTime(2016, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 199m, 1017m, "10005795", 12, "60293895", 5, 6, 4, 963m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3012m, new DateTime(2016, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 41m, 1264m, "10005795", 12, "60293895", 6, 6, 4, 813m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3012m, new DateTime(2016, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 365m, 738m, "10005795", 12, "60293895", 7, 6, 4, 899m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3012m, new DateTime(2016, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 276m, 1440m, "10005795", 12, "60293895", 8, 6, 4, 690m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3012m, new DateTime(2016, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 175m, 1586m, "10005795", 12, "60293895", 9, 6, 4, 505m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3012m, new DateTime(2016, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 490m, 3012m, 1668m, "10005795", 12, "60293895", 10, 6, 4, 633m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3203m, new DateTime(2018, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 319m, 875m, 2, "10002859", 11, "61849416", 7, 5, 790m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3203m, new DateTime(2018, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 397m, 1872m, 2, "10002859", 11, "61849416", 8, 5, 843m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3203m, new DateTime(2018, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 133m, 999m, 2, "10002859", 11, "61849416", 9, 5, 97m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3203m, new DateTime(2018, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 1514m, 2, "10002859", 11, "61849416", 10, 5, 787m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3203m, new DateTime(2018, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 82m, 599m, 2, "10002859", 11, "61849416", 11, 5, 256m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3203m, new DateTime(2018, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 415m, 3203m, 53m, 2, "10002859", 11, "61849416", 12, 5, 183m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3618m, new DateTime(2013, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 323m, 689m, "10001222", "52110262", 5, 1, 83m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3618m, new DateTime(2013, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3m, 1861m, "10001222", "52110262", 6, 1, 604m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3618m, new DateTime(2013, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 78m, 926m, "10001222", "52110262", 7, 1, 886m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3618m, new DateTime(2013, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 374m, 340m, "10001222", "52110262", 8, 1, 167m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3618m, new DateTime(2013, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 391m, 1324m, "10001222", "52110262", 9, 1, 920m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3618m, new DateTime(2013, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 159m, 3618m, 23m, "10001222", "52110262", 10, 1, 158m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4625m, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 56m, 255m, 1, "10004557", "95278218", 8, 5, 1, 260m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4625m, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 398m, 721m, 1, "10004557", "95278218", 9, 5, 1, 543m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4625m, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 241m, 931m, 1, "10004557", "95278218", 10, 5, 1, 271m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4625m, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 242m, 1750m, 1, "10004557", "95278218", 11, 5, 1, 957m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4625m, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 109m, 1973m, 1, "10004557", "95278218", 12, 5, 1, 317m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4625m, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 313m, 4625m, 1339m, 1, "10004557", "95278218", 1, 5, 1, 295m, 2021 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5323m, new DateTime(2007, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 14m, 868m, "10007525", "12902015", 4, 6, 90m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5323m, new DateTime(2007, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 406m, 361m, "10007525", "12902015", 5, 6, 236m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5323m, new DateTime(2007, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 23m, 538m, "10007525", "12902015", 6, 6, 956m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5323m, new DateTime(2007, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 1239m, "10007525", "12902015", 7, 6, 529m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5323m, new DateTime(2007, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 34m, 172m, "10007525", "12902015", 8, 6, 529m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5323m, new DateTime(2007, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 310m, 5323m, 1984m, "10007525", "12902015", 9, 6, 828m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5482m, new DateTime(2005, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 188m, 1088m, 2, "10006513", 12, "49369539", 5, 4, 4, 751m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5482m, new DateTime(2005, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 234m, 27m, 2, "10006513", 12, "49369539", 6, 4, 4, 32m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5482m, new DateTime(2005, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 65m, 1700m, 2, "10006513", 12, "49369539", 7, 4, 4, 125m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5482m, new DateTime(2005, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 89m, 990m, 2, "10006513", 12, "49369539", 8, 4, 4, 79m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5482m, new DateTime(2005, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 380m, 792m, 2, "10006513", 12, "49369539", 9, 4, 4, 652m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5482m, new DateTime(2005, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 363m, 5482m, 327m, 2, "10006513", 12, "49369539", 10, 4, 4, 11m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3849m, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 458m, 1840m, 2, "10005117", 12, "40618910", 12, 1, 4, 309m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3849m, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 75m, 52m, 2, "10005117", 12, "40618910", 1, 1, 4, 876m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3849m, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 151m, 374m, 2, "10005117", 12, "40618910", 2, 1, 4, 476m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3849m, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 105m, 323m, 2, "10005117", 12, "40618910", 3, 1, 4, 333m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3849m, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 325m, 610m, 2, "10005117", 12, "40618910", 4, 1, 4, 362m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3849m, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 65m, 3849m, 1330m, 2, "10005117", 12, "40618910", 5, 1, 4, 982m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4759m, new DateTime(2014, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 72m, 1376m, "10002409", "55199607", 11, 2, 322m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4759m, new DateTime(2014, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 453m, 1557m, "10002409", "55199607", 12, 2, 586m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4759m, new DateTime(2014, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 192m, 1223m, "10002409", "55199607", 1, 2, 679m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4759m, new DateTime(2014, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 224m, 554m, "10002409", "55199607", 2, 2, 987m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4759m, new DateTime(2014, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 487m, 1412m, "10002409", "55199607", 3, 2, 819m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4759m, new DateTime(2014, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 164m, 4759m, 1203m, "10002409", "55199607", 4, 2, 550m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5407m, new DateTime(2009, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 38m, 221m, 1, "10001366", 14, "14120041", 6, 3, 584m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5407m, new DateTime(2009, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 161m, 84m, 1, "10001366", 14, "14120041", 7, 3, 935m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5407m, new DateTime(2009, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 359m, 1483m, 1, "10001366", 14, "14120041", 8, 3, 392m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5407m, new DateTime(2009, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m, 1464m, 1, "10001366", 14, "14120041", 9, 3, 59m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5407m, new DateTime(2009, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 308m, 244m, 1, "10001366", 14, "14120041", 10, 3, 64m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5407m, new DateTime(2009, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 189m, 5407m, 1105m, 1, "10001366", 14, "14120041", 11, 3, 134m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5644m, new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 336m, 1147m, 4, "10001815", 11, "35646389", 11, 5, 7, 685m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5644m, new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4m, 1165m, 4, "10001815", 11, "35646389", 12, 5, 7, 741m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5644m, new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 43m, 994m, 4, "10001815", 11, "35646389", 1, 5, 7, 37m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5644m, new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 363m, 1115m, 4, "10001815", 11, "35646389", 2, 5, 7, 611m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5644m, new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 235m, 1576m, 4, "10001815", 11, "35646389", 3, 5, 7, 394m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5644m, new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 160m, 5644m, 912m, 4, "10001815", 11, "35646389", 4, 5, 7, 295m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4313m, new DateTime(2011, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 312m, 784m, 1, "10004885", 6, "34369468", 9, 2, 205m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4313m, new DateTime(2011, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 205m, 1997m, 1, "10004885", 6, "34369468", 10, 2, 449m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4313m, new DateTime(2011, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 278m, 1826m, 1, "10004885", 6, "34369468", 11, 2, 600m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4313m, new DateTime(2011, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 488m, 754m, 1, "10004885", 6, "34369468", 12, 2, 955m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4313m, new DateTime(2011, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 188m, 869m, 1, "10004885", 6, "34369468", 1, 2, 194m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4313m, new DateTime(2011, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 374m, 4313m, 1837m, 1, "10004885", 6, "34369468", 2, 2, 885m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4906m, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 353m, 1014m, 2, "10002432", 12, "96555177", 2, 4, 491m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4906m, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 109m, 258m, 2, "10002432", 12, "96555177", 2, 4, 198m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4906m, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 355m, 373m, 2, "10002432", 12, "96555177", 2, 4, 187m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4906m, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 131m, 221m, 2, "10002432", 12, "96555177", 2, 4, 862m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4906m, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 157m, 806m, 2, "10002432", 12, "96555177", 2, 4, 916m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4906m, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 368m, 4906m, 1795m, 2, "10002432", 12, "96555177", 2, 4, 224m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5009m, new DateTime(2008, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 51m, 925m, 3, "10002321", 18, "44041473", 7, 1, 6, 747m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5009m, new DateTime(2008, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 232m, 1518m, 3, "10002321", 18, "44041473", 8, 1, 6, 227m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5009m, new DateTime(2008, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 320m, 1769m, 3, "10002321", 18, "44041473", 9, 1, 6, 548m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5009m, new DateTime(2008, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 342m, 861m, 3, "10002321", 18, "44041473", 10, 1, 6, 482m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5009m, new DateTime(2008, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 63m, 126m, 3, "10002321", 18, "44041473", 11, 1, 6, 217m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5009m, new DateTime(2008, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 247m, 5009m, 1981m, 3, "10002321", 18, "44041473", 12, 1, 6, 510m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3484m, new DateTime(2018, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 231m, 334m, 2, "10001471", 11, "92605667", 6, 1, 5, 242m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3484m, new DateTime(2018, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 323m, 55m, 2, "10001471", 11, "92605667", 7, 1, 5, 444m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3484m, new DateTime(2018, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 1211m, 2, "10001471", 11, "92605667", 8, 1, 5, 141m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3484m, new DateTime(2018, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 88m, 1685m, 2, "10001471", 11, "92605667", 9, 1, 5, 563m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3484m, new DateTime(2018, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 342m, 1945m, 2, "10001471", 11, "92605667", 10, 1, 5, 392m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3484m, new DateTime(2018, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 19m, 3484m, 695m, 2, "10001471", 11, "92605667", 11, 1, 5, 153m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4008m, new DateTime(2010, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 293m, 793m, 3, "10002281", 18, "95758180", 9, 5, 6, 560m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4008m, new DateTime(2010, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 473m, 988m, 3, "10002281", 18, "95758180", 10, 5, 6, 956m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4008m, new DateTime(2010, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 211m, 268m, 3, "10002281", 18, "95758180", 11, 5, 6, 554m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4008m, new DateTime(2010, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 355m, 1457m, 3, "10002281", 18, "95758180", 12, 5, 6, 27m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4008m, new DateTime(2010, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 415m, 1440m, 3, "10002281", 18, "95758180", 1, 5, 6, 317m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4008m, new DateTime(2010, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 33m, 4008m, 660m, 3, "10002281", 18, "95758180", 2, 5, 6, 583m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4605m, new DateTime(2015, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 244m, 1490m, 3, "10004040", 18, "60089928", 10, 6, 6, 744m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4605m, new DateTime(2015, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 412m, 521m, 3, "10004040", 18, "60089928", 11, 6, 6, 220m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4605m, new DateTime(2015, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 134m, 911m, 3, "10004040", 18, "60089928", 12, 6, 6, 531m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4605m, new DateTime(2015, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 304m, 1573m, 3, "10004040", 18, "60089928", 1, 6, 6, 557m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4605m, new DateTime(2015, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 455m, 1719m, 3, "10004040", 18, "60089928", 2, 6, 6, 356m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4605m, new DateTime(2015, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 367m, 4605m, 959m, 3, "10004040", 18, "60089928", 3, 6, 6, 837m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5806m, new DateTime(2016, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 47m, 1637m, 2, "10001732", "49730223", 6, 4, 353m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5806m, new DateTime(2016, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 436m, 159m, 2, "10001732", "49730223", 6, 4, 752m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5806m, new DateTime(2016, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, 937m, 2, "10001732", "49730223", 6, 4, 385m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5806m, new DateTime(2016, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 469m, 367m, 2, "10001732", "49730223", 6, 4, 588m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "OfficeId", "PositionId", "Year" },
                values: new object[] { 5806m, new DateTime(2016, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 652m, 2, "10001732", "49730223", 6, 4, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5806m, new DateTime(2016, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 111m, 5806m, 336m, 2, "10001732", "49730223", 6, 4, 600m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5647m, new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 219m, 741m, "10004892", "99931341", 2, 4, 196m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5647m, new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 119m, 956m, "10004892", "99931341", 3, 4, 923m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5647m, new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 249m, 1306m, "10004892", "99931341", 4, 4, 561m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5647m, new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 296m, 910m, "10004892", "99931341", 5, 4, 536m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5647m, new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 252m, 244m, "10004892", "99931341", 6, 4, 168m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5647m, new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 448m, 5647m, 1990m, "10004892", "99931341", 7, 4, 102m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4203m, new DateTime(2016, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 280m, 1190m, "10004961", 12, "15003361", 3, 1, 879m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4203m, new DateTime(2016, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 348m, 1603m, "10004961", 12, "15003361", 4, 1, 257m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4203m, new DateTime(2016, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 209m, 1737m, "10004961", 12, "15003361", 5, 1, 714m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4203m, new DateTime(2016, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m, 321m, "10004961", 12, "15003361", 6, 1, 662m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4203m, new DateTime(2016, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 94m, 1655m, "10004961", 12, "15003361", 7, 1, 435m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4203m, new DateTime(2016, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 376m, 4203m, 328m, "10004961", 12, "15003361", 8, 1, 716m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4328m, new DateTime(2008, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 311m, 629m, 1, "10006323", 6, "33920736", 2, 4, 2, 772m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4328m, new DateTime(2008, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 171m, 367m, 1, "10006323", 6, "33920736", 3, 4, 2, 678m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4328m, new DateTime(2008, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 260m, 153m, 1, "10006323", 6, "33920736", 4, 4, 2, 909m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4328m, new DateTime(2008, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 384m, 808m, 1, "10006323", 6, "33920736", 5, 4, 2, 695m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4328m, new DateTime(2008, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 15m, 1057m, 1, "10006323", 6, "33920736", 6, 4, 2, 609m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4328m, new DateTime(2008, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 274m, 4328m, 1799m, 1, "10006323", 6, "33920736", 7, 4, 2, 577m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4306m, new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 26m, 937m, 1, "10002854", 14, "38926256", 3, 5, 3, 893m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4306m, new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 436m, 299m, 1, "10002854", 14, "38926256", 4, 5, 3, 261m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4306m, new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4m, 257m, 1, "10002854", 14, "38926256", 5, 5, 3, 933m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4306m, new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 105m, 1601m, 1, "10002854", 14, "38926256", 6, 5, 3, 878m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4306m, new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 381m, 1606m, 1, "10002854", 14, "38926256", 7, 5, 3, 213m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4306m, new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 239m, 4306m, 975m, 1, "10002854", 14, "38926256", 8, 5, 3, 410m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4346m, new DateTime(2007, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 202m, 1686m, 3, "10004727", 18, "83103613", 4, 1, 6, 361m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4346m, new DateTime(2007, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5m, 1305m, 3, "10004727", 18, "83103613", 5, 1, 6, 20m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4346m, new DateTime(2007, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 405m, 1912m, 3, "10004727", 18, "83103613", 6, 1, 6, 219m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4346m, new DateTime(2007, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 255m, 31m, 3, "10004727", 18, "83103613", 7, 1, 6, 605m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4346m, new DateTime(2007, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 186m, 748m, 3, "10004727", 18, "83103613", 8, 1, 6, 441m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4346m, new DateTime(2007, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 244m, 4346m, 973m, 3, "10004727", 18, "83103613", 9, 1, 6, 653m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4537m, new DateTime(2013, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 314m, 956m, 1, "10004654", 12, "11280925", 9, 3, 1, 822m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4537m, new DateTime(2013, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 302m, 1307m, 1, "10004654", 12, "11280925", 10, 3, 1, 188m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4537m, new DateTime(2013, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 234m, 1891m, 1, "10004654", 12, "11280925", 11, 3, 1, 16m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4537m, new DateTime(2013, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 312m, 386m, 1, "10004654", 12, "11280925", 12, 3, 1, 746m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4537m, new DateTime(2013, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 319m, 1449m, 1, "10004654", 12, "11280925", 1, 3, 1, 32m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4537m, new DateTime(2013, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 192m, 4537m, 253m, 1, "10004654", 12, "11280925", 2, 3, 1, 202m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5495m, new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 441m, 1408m, "10003668", 11, "61826918", 8, 4, 5, 839m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5495m, new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 437m, 206m, "10003668", 11, "61826918", 9, 4, 5, 384m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5495m, new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 316m, 82m, "10003668", 11, "61826918", 10, 4, 5, 630m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5495m, new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 461m, 216m, "10003668", 11, "61826918", 11, 4, 5, 57m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5495m, new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 378m, 1866m, "10003668", 11, "61826918", 12, 4, 5, 900m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5495m, new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 157m, 5495m, 1534m, "10003668", 11, "61826918", 1, 4, 5, 28m, 2021 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4723m, new DateTime(2012, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 263m, 1594m, 1, "10004370", 14, "81898741", 8, 3, 488m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4723m, new DateTime(2012, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 305m, 966m, 1, "10004370", 14, "81898741", 9, 3, 144m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4723m, new DateTime(2012, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 17m, 1317m, 1, "10004370", 14, "81898741", 10, 3, 261m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4723m, new DateTime(2012, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 37m, 895m, 1, "10004370", 14, "81898741", 11, 3, 372m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4723m, new DateTime(2012, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 178m, 643m, 1, "10004370", 14, "81898741", 12, 3, 675m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4723m, new DateTime(2012, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 421m, 4723m, 1436m, 1, "10004370", 14, "81898741", 1, 3, 568m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4065m, new DateTime(2012, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 133m, 1488m, 1, "10006609", 12, "89182430", 1, 3, 1, 919m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4065m, new DateTime(2012, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 221m, 1m, 1, "10006609", 12, "89182430", 2, 3, 1, 936m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4065m, new DateTime(2012, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 329m, 521m, 1, "10006609", 12, "89182430", 3, 3, 1, 83m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4065m, new DateTime(2012, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 311m, 148m, 1, "10006609", 12, "89182430", 4, 3, 1, 855m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4065m, new DateTime(2012, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 105m, 1499m, 1, "10006609", 12, "89182430", 5, 3, 1, 32m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4065m, new DateTime(2012, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 261m, 4065m, 1229m, 1, "10006609", 12, "89182430", 6, 3, 1, 284m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5052m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 477m, 610m, "10003032", 12, "26755083", 7, 2, 1, 171m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5052m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 377m, 745m, "10003032", 12, "26755083", 8, 2, 1, 482m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5052m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 435m, 449m, "10003032", 12, "26755083", 9, 2, 1, 858m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5052m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 475m, 136m, "10003032", 12, "26755083", 10, 2, 1, 168m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5052m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 635m, "10003032", 12, "26755083", 11, 2, 1, 465m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5052m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7m, 5052m, 285m, "10003032", 12, "26755083", 12, 2, 1, 384m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4070m, new DateTime(2012, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 160m, 1810m, 1, "10005368", 6, "92277467", 5, 6, 2, 694m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4070m, new DateTime(2012, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 446m, 999m, 1, "10005368", 6, "92277467", 6, 6, 2, 553m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4070m, new DateTime(2012, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 217m, 1829m, 1, "10005368", 6, "92277467", 7, 6, 2, 673m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4070m, new DateTime(2012, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 245m, 431m, 1, "10005368", 6, "92277467", 8, 6, 2, 786m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4070m, new DateTime(2012, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 163m, 1259m, 1, "10005368", 6, "92277467", 9, 6, 2, 421m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4070m, new DateTime(2012, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 361m, 4070m, 954m, 1, "10005368", 6, "92277467", 10, 6, 2, 614m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3592m, new DateTime(2020, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 259m, 1929m, 2, "10005723", 12, "62323554", 10, 3, 4, 23m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3592m, new DateTime(2020, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 12m, 519m, 2, "10005723", 12, "62323554", 11, 3, 4, 991m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3592m, new DateTime(2020, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 462m, 836m, 2, "10005723", 12, "62323554", 12, 3, 4, 949m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3592m, new DateTime(2020, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 257m, 322m, 2, "10005723", 12, "62323554", 1, 3, 4, 674m, 2021 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3592m, new DateTime(2020, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 15m, 1409m, 2, "10005723", 12, "62323554", 2, 3, 4, 193m, 2021 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3592m, new DateTime(2020, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 110m, 3592m, 484m, 2, "10005723", 12, "62323554", 3, 3, 4, 450m, 2021 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4243m, new DateTime(2009, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12m, 1098m, 2, "10004244", 11, "89336329", 5, 239m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4243m, new DateTime(2009, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 61m, 796m, 2, "10004244", 11, "89336329", 5, 709m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4243m, new DateTime(2009, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6m, 1003m, 2, "10004244", 11, "89336329", 5, 95m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4243m, new DateTime(2009, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 128m, 202m, 2, "10004244", 11, "89336329", 5, 433m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4243m, new DateTime(2009, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 204m, 272m, 2, "10004244", 11, "89336329", 5, 261m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4243m, new DateTime(2009, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 281m, 4243m, 586m, 2, "10004244", 11, "89336329", 5, 381m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4254m, new DateTime(2013, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 425m, 191m, 1, "10004790", 6, "57664459", 8, 2, 2, 498m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4254m, new DateTime(2013, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 126m, 1731m, 1, "10004790", 6, "57664459", 9, 2, 2, 471m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4254m, new DateTime(2013, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 460m, 1112m, 1, "10004790", 6, "57664459", 10, 2, 2, 637m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4254m, new DateTime(2013, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 239m, 1451m, 1, "10004790", 6, "57664459", 11, 2, 2, 276m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4254m, new DateTime(2013, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 482m, 1053m, 1, "10004790", 6, "57664459", 12, 2, 2, 436m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4254m, new DateTime(2013, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 152m, 4254m, 455m, 1, "10004790", 6, "57664459", 1, 2, 2, 746m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4617m, new DateTime(2013, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 112m, 1137m, 4, "10004890", 11, "45406513", 1, 2, 7, 832m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4617m, new DateTime(2013, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 15m, 1881m, 4, "10004890", 11, "45406513", 2, 2, 7, 718m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4617m, new DateTime(2013, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 385m, 1208m, 4, "10004890", 11, "45406513", 3, 2, 7, 601m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4617m, new DateTime(2013, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 468m, 1997m, 4, "10004890", 11, "45406513", 4, 2, 7, 857m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4617m, new DateTime(2013, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 175m, 971m, 4, "10004890", 11, "45406513", 5, 2, 7, 28m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4617m, new DateTime(2013, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 261m, 4617m, 124m, 4, "10004890", 11, "45406513", 6, 2, 7, 362m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3971m, new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 251m, 1790m, 2, "10006685", 11, "35232002", 7, 1, 5, 493m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3971m, new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 267m, 773m, 2, "10006685", 11, "35232002", 8, 1, 5, 37m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3971m, new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 447m, 1323m, 2, "10006685", 11, "35232002", 9, 1, 5, 643m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3971m, new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 182m, 1510m, 2, "10006685", 11, "35232002", 10, 1, 5, 282m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3971m, new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 322m, 1232m, 2, "10006685", 11, "35232002", 11, 1, 5, 23m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3971m, new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, 3971m, 867m, 2, "10006685", 11, "35232002", 12, 1, 5, 341m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5042m, new DateTime(2017, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 375m, 1380m, 2, "10003445", "86492631", 1, 2, 4, 468m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5042m, new DateTime(2017, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 392m, 1863m, 2, "10003445", "86492631", 2, 2, 4, 164m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5042m, new DateTime(2017, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 210m, 560m, 2, "10003445", "86492631", 3, 2, 4, 609m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5042m, new DateTime(2017, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 476m, 507m, 2, "10003445", "86492631", 4, 2, 4, 971m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5042m, new DateTime(2017, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 145m, 1924m, 2, "10003445", "86492631", 5, 2, 4, 772m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5042m, new DateTime(2017, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 470m, 5042m, 1536m, 2, "10003445", "86492631", 6, 2, 4, 943m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4808m, new DateTime(2016, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 328m, 71m, "10004775", "16727896", 5, 3, 172m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4808m, new DateTime(2016, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 7m, 182m, "10004775", "16727896", 6, 3, 948m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4808m, new DateTime(2016, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 482m, 1571m, "10004775", "16727896", 7, 3, 295m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4808m, new DateTime(2016, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 147m, 1022m, "10004775", "16727896", 8, 3, 940m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4808m, new DateTime(2016, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 102m, 1673m, "10004775", "16727896", 9, 3, 422m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4808m, new DateTime(2016, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 199m, 4808m, 1339m, "10004775", "16727896", 10, 3, 456m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5510m, new DateTime(2011, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 315m, 183m, 1, "10007228", 14, "28971923", 9, 1, 3, 197m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5510m, new DateTime(2011, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 458m, 1396m, 1, "10007228", 14, "28971923", 10, 1, 3, 712m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5510m, new DateTime(2011, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 368m, 822m, 1, "10007228", 14, "28971923", 11, 1, 3, 695m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5510m, new DateTime(2011, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 359m, 1709m, 1, "10007228", 14, "28971923", 12, 1, 3, 813m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5510m, new DateTime(2011, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 193m, 266m, 1, "10007228", 14, "28971923", 1, 1, 3, 622m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5510m, new DateTime(2011, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, 5510m, 1426m, 1, "10007228", 14, "28971923", 2, 1, 3, 915m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4385m, new DateTime(2016, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 166m, 1596m, "10005462", 6, "28379155", 7, 2, 2, 657m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4385m, new DateTime(2016, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 490m, 25m, "10005462", 6, "28379155", 8, 2, 2, 767m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4385m, new DateTime(2016, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 405m, 173m, "10005462", 6, "28379155", 9, 2, 2, 909m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4385m, new DateTime(2016, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 238m, 220m, "10005462", 6, "28379155", 10, 2, 2, 925m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4385m, new DateTime(2016, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 154m, 1547m, "10005462", 6, "28379155", 11, 2, 2, 725m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4385m, new DateTime(2016, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 485m, 4385m, 567m, "10005462", 6, "28379155", 12, 2, 2, 813m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5217m, new DateTime(2008, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5m, 206m, 2, "10003681", 12, "84547155", 5, 5, 4, 262m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5217m, new DateTime(2008, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 310m, 928m, 2, "10003681", 12, "84547155", 6, 5, 4, 432m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5217m, new DateTime(2008, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 373m, 219m, 2, "10003681", 12, "84547155", 7, 5, 4, 841m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5217m, new DateTime(2008, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 390m, 620m, 2, "10003681", 12, "84547155", 8, 5, 4, 356m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5217m, new DateTime(2008, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 327m, 964m, 2, "10003681", 12, "84547155", 9, 5, 4, 626m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5217m, new DateTime(2008, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 315m, 5217m, 1269m, 2, "10003681", 12, "84547155", 10, 5, 4, 125m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5455m, new DateTime(2015, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 53m, 626m, 4, "10004385", 11, "55059264", 3, 5, 7, 665m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5455m, new DateTime(2015, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 38m, 1276m, 4, "10004385", 11, "55059264", 4, 5, 7, 163m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5455m, new DateTime(2015, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 337m, 998m, 4, "10004385", 11, "55059264", 5, 5, 7, 975m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5455m, new DateTime(2015, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 115m, 1392m, 4, "10004385", 11, "55059264", 6, 5, 7, 785m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5455m, new DateTime(2015, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 101m, 1831m, 4, "10004385", 11, "55059264", 7, 5, 7, 635m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5455m, new DateTime(2015, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 404m, 5455m, 914m, 4, "10004385", 11, "55059264", 8, 5, 7, 348m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3129m, new DateTime(2009, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 213m, 862m, 4, "10001768", 11, "75710503", 1, 2, 7, 528m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3129m, new DateTime(2009, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 470m, 1726m, 4, "10001768", 11, "75710503", 2, 2, 7, 303m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3129m, new DateTime(2009, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 119m, 1645m, 4, "10001768", 11, "75710503", 3, 2, 7, 829m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3129m, new DateTime(2009, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 246m, 479m, 4, "10001768", 11, "75710503", 4, 2, 7, 10m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3129m, new DateTime(2009, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 202m, 790m, 4, "10001768", 11, "75710503", 5, 2, 7, 877m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3129m, new DateTime(2009, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 53m, 3129m, 1665m, 4, "10001768", 11, "75710503", 6, 2, 7, 197m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3459m, new DateTime(2007, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 435m, 679m, 1, "10005536", 6, "58890595", 5, 4, 2, 445m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3459m, new DateTime(2007, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 374m, 1091m, 1, "10005536", 6, "58890595", 6, 4, 2, 904m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3459m, new DateTime(2007, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 101m, 1840m, 1, "10005536", 6, "58890595", 7, 4, 2, 290m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3459m, new DateTime(2007, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 180m, 752m, 1, "10005536", 6, "58890595", 8, 4, 2, 996m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3459m, new DateTime(2007, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 199m, 922m, 1, "10005536", 6, "58890595", 9, 4, 2, 933m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3459m, new DateTime(2007, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 341m, 3459m, 1435m, 1, "10005536", 6, "58890595", 10, 4, 2, 361m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3393m, new DateTime(2011, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 127m, 1431m, 1, "10003806", 6, "64434203", 12, 3, 2, 788m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3393m, new DateTime(2011, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 189m, 144m, 1, "10003806", 6, "64434203", 1, 3, 2, 147m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3393m, new DateTime(2011, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 371m, 1875m, 1, "10003806", 6, "64434203", 2, 3, 2, 619m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3393m, new DateTime(2011, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 292m, 1589m, 1, "10003806", 6, "64434203", 3, 3, 2, 4m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3393m, new DateTime(2011, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 325m, 434m, 1, "10003806", 6, "64434203", 4, 3, 2, 249m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3393m, new DateTime(2011, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 223m, 3393m, 33m, 1, "10003806", 6, "64434203", 5, 3, 2, 3m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4303m, new DateTime(2017, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 450m, 1222m, 4, "10005859", "15198993", 4, 7, 97m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4303m, new DateTime(2017, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 319m, 1182m, 4, "10005859", "15198993", 5, 7, 157m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4303m, new DateTime(2017, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 384m, 801m, 4, "10005859", "15198993", 6, 7, 442m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4303m, new DateTime(2017, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 421m, 439m, 4, "10005859", "15198993", 7, 7, 935m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4303m, new DateTime(2017, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 434m, 1100m, 4, "10005859", "15198993", 8, 7, 556m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4303m, new DateTime(2017, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 51m, 4303m, 691m, 4, "10005859", "15198993", 9, 7, 573m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5272m, new DateTime(2013, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 161m, 1261m, 3, "10006241", 18, "25746228", 8, 3, 6, 226m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5272m, new DateTime(2013, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41m, 632m, 3, "10006241", 18, "25746228", 9, 3, 6, 146m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5272m, new DateTime(2013, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384m, 1980m, 3, "10006241", 18, "25746228", 10, 3, 6, 88m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5272m, new DateTime(2013, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 388m, 405m, 3, "10006241", 18, "25746228", 11, 3, 6, 7m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5272m, new DateTime(2013, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 94m, 1659m, 3, "10006241", 18, "25746228", 12, 3, 6, 187m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5272m, new DateTime(2013, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143m, 5272m, 1082m, 3, "10006241", 18, "25746228", 1, 3, 6, 72m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3909m, new DateTime(2013, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 99m, 462m, 1, "10001325", 6, "21792972", 7, 5, 2, 192m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3909m, new DateTime(2013, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 153m, 124m, 1, "10001325", 6, "21792972", 8, 5, 2, 149m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3909m, new DateTime(2013, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 215m, 1578m, 1, "10001325", 6, "21792972", 9, 5, 2, 620m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3909m, new DateTime(2013, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 328m, 83m, 1, "10001325", 6, "21792972", 10, 5, 2, 579m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3909m, new DateTime(2013, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 11m, 826m, 1, "10001325", 6, "21792972", 11, 5, 2, 686m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3909m, new DateTime(2013, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 286m, 3909m, 1599m, 1, "10001325", 6, "21792972", 12, 5, 2, 810m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4921m, new DateTime(2018, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 408m, 187m, 1, "10003202", "96075181", 2, 1, 242m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4921m, new DateTime(2018, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 499m, 1048m, 1, "10003202", "96075181", 3, 1, 725m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4921m, new DateTime(2018, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 114m, 1752m, 1, "10003202", "96075181", 4, 1, 949m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4921m, new DateTime(2018, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 339m, 1220m, 1, "10003202", "96075181", 5, 1, 53m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4921m, new DateTime(2018, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 332m, 377m, 1, "10003202", "96075181", 6, 1, 811m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4921m, new DateTime(2018, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 56m, 4921m, 143m, 1, "10003202", "96075181", 7, 1, 654m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5973m, new DateTime(2009, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 17m, 387m, 1, "10003673", 12, "23523816", 2, 4, 1, 853m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5973m, new DateTime(2009, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 246m, 1247m, 1, "10003673", 12, "23523816", 3, 4, 1, 461m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5973m, new DateTime(2009, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 422m, 1624m, 1, "10003673", 12, "23523816", 4, 4, 1, 210m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5973m, new DateTime(2009, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 316m, 430m, 1, "10003673", 12, "23523816", 5, 4, 1, 316m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5973m, new DateTime(2009, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 310m, 315m, 1, "10003673", 12, "23523816", 6, 4, 1, 694m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5973m, new DateTime(2009, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 178m, 5973m, 308m, 1, "10003673", 12, "23523816", 7, 4, 1, 991m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4902m, new DateTime(2006, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 13m, 1776m, 3, "10003876", 18, "90370299", 4, 6, 336m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4902m, new DateTime(2006, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 330m, 1008m, 3, "10003876", 18, "90370299", 4, 6, 473m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4902m, new DateTime(2006, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 226m, 863m, 3, "10003876", 18, "90370299", 4, 6, 109m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4902m, new DateTime(2006, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 298m, 1378m, 3, "10003876", 18, "90370299", 4, 6, 828m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4902m, new DateTime(2006, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 107m, 923m, 3, "10003876", 18, "90370299", 4, 6, 56m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4902m, new DateTime(2006, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 284m, 4902m, 1121m, 3, "10003876", 18, "90370299", 4, 6, 978m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3655m, new DateTime(2017, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 437m, 1407m, 2, "10002767", 11, "57698895", 2, 5, 5, 640m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3655m, new DateTime(2017, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 174m, 957m, 2, "10002767", 11, "57698895", 3, 5, 5, 829m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3655m, new DateTime(2017, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 74m, 2, "10002767", 11, "57698895", 4, 5, 5, 647m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3655m, new DateTime(2017, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 425m, 385m, 2, "10002767", 11, "57698895", 5, 5, 5, 285m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3655m, new DateTime(2017, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 231m, 1822m, 2, "10002767", 11, "57698895", 6, 5, 5, 461m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3655m, new DateTime(2017, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 466m, 3655m, 1811m, 2, "10002767", 11, "57698895", 7, 5, 5, 34m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5606m, new DateTime(2016, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 319m, 1032m, 2, "10005738", 11, "56381024", 12, 2, 5, 418m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5606m, new DateTime(2016, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 365m, 460m, 2, "10005738", 11, "56381024", 1, 2, 5, 235m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5606m, new DateTime(2016, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 181m, 135m, 2, "10005738", 11, "56381024", 2, 2, 5, 602m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5606m, new DateTime(2016, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 279m, 1024m, 2, "10005738", 11, "56381024", 3, 2, 5, 396m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5606m, new DateTime(2016, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3m, 1662m, 2, "10005738", 11, "56381024", 4, 2, 5, 526m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5606m, new DateTime(2016, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 453m, 5606m, 546m, 2, "10005738", 11, "56381024", 5, 2, 5, 679m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5498m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 108m, 27m, 1, "10004975", 6, "44749511", 6, 6, 2, 375m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5498m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 458m, 1639m, 1, "10004975", 6, "44749511", 7, 6, 2, 578m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5498m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 85m, 1878m, 1, "10004975", 6, "44749511", 8, 6, 2, 195m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5498m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 68m, 872m, 1, "10004975", 6, "44749511", 9, 6, 2, 561m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5498m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 69m, 91m, 1, "10004975", 6, "44749511", 10, 6, 2, 688m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5498m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 204m, 5498m, 427m, 1, "10004975", 6, "44749511", 11, 6, 2, 532m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4959m, new DateTime(2015, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 278m, 822m, 1, "10007334", 6, "86751833", 1, 1, 2, 800m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4959m, new DateTime(2015, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 271m, 1781m, 1, "10007334", 6, "86751833", 2, 1, 2, 202m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4959m, new DateTime(2015, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 74m, 244m, 1, "10007334", 6, "86751833", 3, 1, 2, 505m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4959m, new DateTime(2015, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 292m, 483m, 1, "10007334", 6, "86751833", 4, 1, 2, 409m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "Year" },
                values: new object[] { 4959m, new DateTime(2015, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 375m, 344m, 1, "10007334", 6, "86751833", 5, 1, 2, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4959m, new DateTime(2015, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 463m, 4959m, 228m, 1, "10007334", 6, "86751833", 6, 1, 2, 974m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4482m, new DateTime(2014, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 285m, 1627m, 3, "10006535", 18, "37714834", 7, 1, 6, 953m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4482m, new DateTime(2014, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 435m, 355m, 3, "10006535", 18, "37714834", 8, 1, 6, 602m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4482m, new DateTime(2014, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 488m, 1417m, 3, "10006535", 18, "37714834", 9, 1, 6, 929m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4482m, new DateTime(2014, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 251m, 174m, 3, "10006535", 18, "37714834", 10, 1, 6, 86m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4482m, new DateTime(2014, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 359m, 710m, 3, "10006535", 18, "37714834", 11, 1, 6, 134m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4482m, new DateTime(2014, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 391m, 4482m, 1427m, 3, "10006535", 18, "37714834", 12, 1, 6, 774m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4154m, new DateTime(2009, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 301m, 1182m, 1, "10001040", 14, "14679560", 6, 4, 3, 768m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4154m, new DateTime(2009, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 276m, 535m, 1, "10001040", 14, "14679560", 7, 4, 3, 241m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4154m, new DateTime(2009, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 202m, 1131m, 1, "10001040", 14, "14679560", 8, 4, 3, 783m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4154m, new DateTime(2009, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 487m, 1394m, 1, "10001040", 14, "14679560", 9, 4, 3, 643m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4154m, new DateTime(2009, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 314m, 10m, 1, "10001040", 14, "14679560", 10, 4, 3, 803m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4154m, new DateTime(2009, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 103m, 4154m, 670m, 1, "10001040", 14, "14679560", 11, 4, 3, 670m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5800m, new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 125m, 1271m, "10005661", 12, "34124156", 7, 5, 4, 485m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5800m, new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 403m, 875m, "10005661", 12, "34124156", 8, 5, 4, 608m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5800m, new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 74m, 1963m, "10005661", 12, "34124156", 9, 5, 4, 940m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5800m, new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 280m, 1987m, "10005661", 12, "34124156", 10, 5, 4, 155m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5800m, new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 207m, 301m, "10005661", 12, "34124156", 11, 5, 4, 312m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5800m, new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 14m, 5800m, 1647m, "10005661", 12, "34124156", 12, 5, 4, 167m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5638m, new DateTime(2012, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 47m, 1049m, 2, "10002739", "33122952", 7, 3, 5, 434m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5638m, new DateTime(2012, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 498m, 919m, 2, "10002739", "33122952", 8, 3, 5, 670m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5638m, new DateTime(2012, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 341m, 1527m, 2, "10002739", "33122952", 9, 3, 5, 137m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5638m, new DateTime(2012, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 241m, 55m, 2, "10002739", "33122952", 10, 3, 5, 383m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5638m, new DateTime(2012, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 450m, 649m, 2, "10002739", "33122952", 11, 3, 5, 358m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5638m, new DateTime(2012, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 214m, 5638m, 1101m, 2, "10002739", "33122952", 12, 3, 5, 854m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4556m, new DateTime(2017, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 408m, 559m, 1, "10003991", "50368884", 9, 5, 1, 910m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4556m, new DateTime(2017, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 144m, 148m, 1, "10003991", "50368884", 10, 5, 1, 875m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4556m, new DateTime(2017, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 413m, 558m, 1, "10003991", "50368884", 11, 5, 1, 188m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4556m, new DateTime(2017, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 450m, 875m, 1, "10003991", "50368884", 12, 5, 1, 482m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4556m, new DateTime(2017, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 498m, 1756m, 1, "10003991", "50368884", 1, 5, 1, 639m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4556m, new DateTime(2017, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 372m, 4556m, 1206m, 1, "10003991", "50368884", 2, 5, 1, 248m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5563m, new DateTime(2015, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 59m, 1029m, 2, "10006240", 12, "96132959", 7, 4, 225m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5563m, new DateTime(2015, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 334m, 100m, 2, "10006240", 12, "96132959", 8, 4, 646m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5563m, new DateTime(2015, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 211m, 1475m, 2, "10006240", 12, "96132959", 9, 4, 810m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5563m, new DateTime(2015, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 243m, 1812m, 2, "10006240", 12, "96132959", 10, 4, 731m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5563m, new DateTime(2015, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 494m, 239m, 2, "10006240", 12, "96132959", 11, 4, 906m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5563m, new DateTime(2015, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 460m, 5563m, 762m, 2, "10006240", 12, "96132959", 12, 4, 415m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3476m, new DateTime(2016, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 459m, 712m, 4, "10005812", 11, "53307952", 7, 398m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3476m, new DateTime(2016, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 253m, 310m, 4, "10005812", 11, "53307952", 7, 918m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3476m, new DateTime(2016, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 393m, 17m, 4, "10005812", 11, "53307952", 7, 587m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3476m, new DateTime(2016, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 188m, 1792m, 4, "10005812", 11, "53307952", 7, 151m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3476m, new DateTime(2016, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 133m, 1769m, 4, "10005812", 11, "53307952", 7, 285m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3476m, new DateTime(2016, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 199m, 3476m, 405m, 4, "10005812", 11, "53307952", 7, 955m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4446m, new DateTime(2008, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 133m, 919m, 1, "10006070", 12, "49032310", 10, 5, 1, 209m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4446m, new DateTime(2008, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 1320m, 1, "10006070", 12, "49032310", 11, 5, 1, 3m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4446m, new DateTime(2008, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 169m, 1810m, 1, "10006070", 12, "49032310", 12, 5, 1, 853m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4446m, new DateTime(2008, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 487m, 950m, 1, "10006070", 12, "49032310", 1, 5, 1, 82m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4446m, new DateTime(2008, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 309m, 1285m, 1, "10006070", 12, "49032310", 2, 5, 1, 420m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4446m, new DateTime(2008, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 435m, 4446m, 851m, 1, "10006070", 12, "49032310", 3, 5, 1, 308m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4140m, new DateTime(2010, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 122m, 1858m, 3, "10004849", 18, "66565420", 5, 6, 6, 222m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4140m, new DateTime(2010, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 456m, 66m, 3, "10004849", 18, "66565420", 6, 6, 6, 250m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4140m, new DateTime(2010, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 213m, 1155m, 3, "10004849", 18, "66565420", 7, 6, 6, 649m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4140m, new DateTime(2010, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 217m, 1932m, 3, "10004849", 18, "66565420", 8, 6, 6, 600m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4140m, new DateTime(2010, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 155m, 824m, 3, "10004849", 18, "66565420", 9, 6, 6, 422m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4140m, new DateTime(2010, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 11m, 4140m, 1527m, 3, "10004849", 18, "66565420", 10, 6, 6, 74m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4520m, new DateTime(2005, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 422m, 977m, 1, "10008440", 6, "74868281", 4, 1, 2, 286m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4520m, new DateTime(2005, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 400m, 626m, 1, "10008440", 6, "74868281", 5, 1, 2, 536m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4520m, new DateTime(2005, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 493m, 275m, 1, "10008440", 6, "74868281", 6, 1, 2, 870m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4520m, new DateTime(2005, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 253m, 1163m, 1, "10008440", 6, "74868281", 7, 1, 2, 805m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4520m, new DateTime(2005, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 164m, 305m, 1, "10008440", 6, "74868281", 8, 1, 2, 457m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4520m, new DateTime(2005, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 79m, 4520m, 549m, 1, "10008440", 6, "74868281", 9, 1, 2, 598m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3862m, new DateTime(2019, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 137m, 366m, 2, "10005371", 11, "66589065", 7, 3, 5, 739m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3862m, new DateTime(2019, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 479m, 1303m, 2, "10005371", 11, "66589065", 8, 3, 5, 300m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3862m, new DateTime(2019, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 406m, 1421m, 2, "10005371", 11, "66589065", 9, 3, 5, 86m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3862m, new DateTime(2019, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 345m, 1588m, 2, "10005371", 11, "66589065", 10, 3, 5, 148m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3862m, new DateTime(2019, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 419m, 702m, 2, "10005371", 11, "66589065", 11, 3, 5, 270m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3862m, new DateTime(2019, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 227m, 3862m, 349m, 2, "10005371", 11, "66589065", 12, 3, 5, 990m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4262m, new DateTime(2013, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 422m, 994m, 1, "10003742", 14, "60398525", 6, 4, 3, 337m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4262m, new DateTime(2013, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 118m, 881m, 1, "10003742", 14, "60398525", 7, 4, 3, 471m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4262m, new DateTime(2013, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 304m, 1916m, 1, "10003742", 14, "60398525", 8, 4, 3, 323m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4262m, new DateTime(2013, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 261m, 503m, 1, "10003742", 14, "60398525", 9, 4, 3, 927m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4262m, new DateTime(2013, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 148m, 1507m, 1, "10003742", 14, "60398525", 10, 4, 3, 856m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4262m, new DateTime(2013, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 222m, 4262m, 840m, 1, "10003742", 14, "60398525", 11, 4, 3, 212m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3139m, new DateTime(2010, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 179m, 1633m, "10001277", 12, "64160986", 11, 1, 1, 649m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3139m, new DateTime(2010, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 287m, 1991m, "10001277", 12, "64160986", 12, 1, 1, 461m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3139m, new DateTime(2010, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 454m, 1315m, "10001277", 12, "64160986", 1, 1, 1, 484m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3139m, new DateTime(2010, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 344m, 1679m, "10001277", 12, "64160986", 2, 1, 1, 488m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3139m, new DateTime(2010, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, 602m, "10001277", 12, "64160986", 3, 1, 1, 881m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3139m, new DateTime(2010, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 275m, 3139m, 1614m, "10001277", 12, "64160986", 4, 1, 1, 996m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5656m, new DateTime(2005, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 34m, 1248m, 4, "10001553", "61100117", 9, 5, 7, 146m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5656m, new DateTime(2005, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 343m, 70m, 4, "10001553", "61100117", 10, 5, 7, 835m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5656m, new DateTime(2005, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 489m, 1035m, 4, "10001553", "61100117", 11, 5, 7, 782m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5656m, new DateTime(2005, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 274m, 1208m, 4, "10001553", "61100117", 12, 5, 7, 176m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5656m, new DateTime(2005, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 294m, 1522m, 4, "10001553", "61100117", 1, 5, 7, 350m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5656m, new DateTime(2005, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 84m, 5656m, 679m, 4, "10001553", "61100117", 2, 5, 7, 688m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5488m, new DateTime(2010, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 163m, 418m, "10001747", "39559420", 5, 4, 845m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5488m, new DateTime(2010, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 124m, 1421m, "10001747", "39559420", 6, 4, 284m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5488m, new DateTime(2010, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 274m, 450m, "10001747", "39559420", 7, 4, 730m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5488m, new DateTime(2010, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 464m, "10001747", "39559420", 8, 4, 657m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5488m, new DateTime(2010, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 187m, 1898m, "10001747", "39559420", 9, 4, 98m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5488m, new DateTime(2010, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 216m, 5488m, 872m, "10001747", "39559420", 10, 4, 348m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus" },
                values: new object[] { 5069m, new DateTime(2013, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 1251m, 1, "10004444", 14, "15376707", 4, 3, 772m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus" },
                values: new object[] { 5069m, new DateTime(2013, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 116m, 987m, 1, "10004444", 14, "15376707", 5, 3, 429m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus" },
                values: new object[] { 5069m, new DateTime(2013, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 116m, 1475m, 1, "10004444", 14, "15376707", 6, 3, 278m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus" },
                values: new object[] { 5069m, new DateTime(2013, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 357m, 171m, 1, "10004444", 14, "15376707", 7, 3, 520m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus" },
                values: new object[] { 5069m, new DateTime(2013, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 112m, 914m, 1, "10004444", 14, "15376707", 8, 3, 552m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus" },
                values: new object[] { 5069m, new DateTime(2013, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 86m, 5069m, 1449m, 1, "10004444", 14, "15376707", 9, 3, 533m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4561m, new DateTime(2009, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 348m, 773m, "10004351", 14, "20468873", 5, 2, 3, 116m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4561m, new DateTime(2009, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 159m, 705m, "10004351", 14, "20468873", 6, 2, 3, 623m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4561m, new DateTime(2009, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 74m, 1361m, "10004351", 14, "20468873", 7, 2, 3, 35m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4561m, new DateTime(2009, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 119m, 749m, "10004351", 14, "20468873", 8, 2, 3, 245m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4561m, new DateTime(2009, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 13m, 87m, "10004351", 14, "20468873", 9, 2, 3, 811m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4561m, new DateTime(2009, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 52m, 4561m, 1068m, "10004351", 14, "20468873", 10, 2, 3, 457m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5805m, new DateTime(2011, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, 1967m, 2, "10003428", 12, "30732960", 3, 4, 4, 705m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5805m, new DateTime(2011, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 22m, 1359m, 2, "10003428", 12, "30732960", 4, 4, 4, 521m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5805m, new DateTime(2011, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 121m, 19m, 2, "10003428", 12, "30732960", 5, 4, 4, 142m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5805m, new DateTime(2011, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 19m, 522m, 2, "10003428", 12, "30732960", 6, 4, 4, 831m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5805m, new DateTime(2011, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 190m, 1279m, 2, "10003428", 12, "30732960", 7, 4, 4, 833m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5805m, new DateTime(2011, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 105m, 5805m, 587m, 2, "10003428", 12, "30732960", 8, 4, 4, 111m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5616m, new DateTime(2016, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 186m, 79m, 2, "10001261", 12, "22783018", 5, 5, 4, 407m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5616m, new DateTime(2016, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 380m, 1478m, 2, "10001261", 12, "22783018", 6, 5, 4, 465m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5616m, new DateTime(2016, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 126m, 1801m, 2, "10001261", 12, "22783018", 7, 5, 4, 860m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5616m, new DateTime(2016, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 322m, 1608m, 2, "10001261", 12, "22783018", 8, 5, 4, 177m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5616m, new DateTime(2016, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, 1660m, 2, "10001261", 12, "22783018", 9, 5, 4, 95m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5616m, new DateTime(2016, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 414m, 5616m, 1442m, 2, "10001261", 12, "22783018", 10, 5, 4, 727m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4354m, new DateTime(2016, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 417m, 1637m, "10006645", "19215739", 6, 4, 620m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4354m, new DateTime(2016, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 92m, 433m, "10006645", "19215739", 7, 4, 818m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4354m, new DateTime(2016, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 311m, 1037m, "10006645", "19215739", 8, 4, 949m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4354m, new DateTime(2016, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 419m, 793m, "10006645", "19215739", 9, 4, 837m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4354m, new DateTime(2016, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 201m, 417m, "10006645", "19215739", 10, 4, 366m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4354m, new DateTime(2016, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 348m, 4354m, 1022m, "10006645", "19215739", 11, 4, 996m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5088m, new DateTime(2012, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 65m, 1858m, 3, "10004054", 18, "18825794", 5, 4, 6, 189m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5088m, new DateTime(2012, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 222m, 937m, 3, "10004054", 18, "18825794", 6, 4, 6, 716m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5088m, new DateTime(2012, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 312m, 1498m, 3, "10004054", 18, "18825794", 7, 4, 6, 883m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5088m, new DateTime(2012, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 285m, 1302m, 3, "10004054", 18, "18825794", 8, 4, 6, 314m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5088m, new DateTime(2012, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 384m, 1590m, 3, "10004054", 18, "18825794", 9, 4, 6, 646m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5088m, new DateTime(2012, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 477m, 5088m, 1497m, 3, "10004054", 18, "18825794", 10, 4, 6, 410m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3460m, new DateTime(2007, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410m, 1469m, "10008870", 12, "12139799", 1, 1, 1, 238m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3460m, new DateTime(2007, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 74m, 1390m, "10008870", 12, "12139799", 2, 1, 1, 930m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3460m, new DateTime(2007, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 392m, 1640m, "10008870", 12, "12139799", 3, 1, 1, 715m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3460m, new DateTime(2007, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177m, 1561m, "10008870", 12, "12139799", 4, 1, 1, 848m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3460m, new DateTime(2007, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479m, 1809m, "10008870", 12, "12139799", 5, 1, 1, 13m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3460m, new DateTime(2007, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 340m, 3460m, 1882m, "10008870", 12, "12139799", 6, 1, 1, 776m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4963m, new DateTime(2013, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 201m, 307m, "10007225", 12, "44351716", 12, 2, 1, 442m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4963m, new DateTime(2013, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 138m, 968m, "10007225", 12, "44351716", 1, 2, 1, 439m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4963m, new DateTime(2013, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 378m, 1537m, "10007225", 12, "44351716", 2, 2, 1, 295m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4963m, new DateTime(2013, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 102m, 698m, "10007225", 12, "44351716", 3, 2, 1, 501m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4963m, new DateTime(2013, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 339m, 405m, "10007225", 12, "44351716", 4, 2, 1, 460m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4963m, new DateTime(2013, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 162m, 4963m, 1025m, "10007225", 12, "44351716", 5, 2, 1, 780m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5165m, new DateTime(2007, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 480m, 58m, 1, "10005196", 12, "60643393", 5, 1, 570m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5165m, new DateTime(2007, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 256m, 70m, 1, "10005196", 12, "60643393", 5, 1, 912m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5165m, new DateTime(2007, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 340m, 943m, 1, "10005196", 12, "60643393", 5, 1, 322m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5165m, new DateTime(2007, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 107m, 943m, 1, "10005196", 12, "60643393", 5, 1, 806m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5165m, new DateTime(2007, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1m, 468m, 1, "10005196", 12, "60643393", 5, 1, 267m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5165m, new DateTime(2007, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 139m, 5165m, 648m, 1, "10005196", 12, "60643393", 5, 1, 61m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5184m, new DateTime(2012, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 160m, 359m, 1, "10002902", "76713612", 9, 2, 1, 464m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5184m, new DateTime(2012, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 226m, 554m, 1, "10002902", "76713612", 10, 2, 1, 770m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5184m, new DateTime(2012, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 213m, 12m, 1, "10002902", "76713612", 11, 2, 1, 239m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5184m, new DateTime(2012, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 297m, 82m, 1, "10002902", "76713612", 12, 2, 1, 157m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5184m, new DateTime(2012, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 54m, 1941m, 1, "10002902", "76713612", 1, 2, 1, 181m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5184m, new DateTime(2012, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 452m, 5184m, 498m, 1, "10002902", "76713612", 2, 2, 1, 459m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3143m, new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 110m, 1941m, 1, "10004039", 6, "64785722", 1, 3, 2, 4m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3143m, new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 364m, 1222m, 1, "10004039", 6, "64785722", 2, 3, 2, 542m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3143m, new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7m, 1291m, 1, "10004039", 6, "64785722", 3, 3, 2, 967m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3143m, new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 86m, 1836m, 1, "10004039", 6, "64785722", 4, 3, 2, 27m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3143m, new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 138m, 1908m, 1, "10004039", 6, "64785722", 5, 3, 2, 581m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3143m, new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 146m, 3143m, 1026m, 1, "10004039", 6, "64785722", 6, 3, 2, 920m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5691m, new DateTime(2007, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2m, 116m, "10007690", "28164946", 2, 6, 79m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5691m, new DateTime(2007, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 202m, 776m, "10007690", "28164946", 3, 6, 957m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5691m, new DateTime(2007, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 366m, 1615m, "10007690", "28164946", 4, 6, 263m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5691m, new DateTime(2007, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 246m, 1915m, "10007690", "28164946", 5, 6, 858m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5691m, new DateTime(2007, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 211m, 849m, "10007690", "28164946", 6, 6, 32m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5691m, new DateTime(2007, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 458m, 5691m, 611m, "10007690", "28164946", 7, 6, 121m, 2007 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DivisionId",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5121m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 125m, 975m, 4, "10004509", 11, "88531280", 10, 2, 7, 856m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5121m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 135m, 182m, 4, "10004509", 11, "88531280", 11, 2, 7, 239m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5121m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 83m, 1892m, 4, "10004509", 11, "88531280", 12, 2, 7, 92m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5121m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 159m, 525m, 4, "10004509", 11, "88531280", 1, 2, 7, 156m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5121m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 478m, 114m, 4, "10004509", 11, "88531280", 2, 2, 7, 350m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5121m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 44m, 5121m, 719m, 4, "10004509", 11, "88531280", 3, 2, 7, 688m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus" },
                values: new object[] { 5518m, new DateTime(2017, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 293m, 1462m, "10005757", "94118897", 11, 5, 998m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus" },
                values: new object[] { 5518m, new DateTime(2017, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 112m, 1126m, "10005757", "94118897", 12, 5, 393m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5518m, new DateTime(2017, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 1908m, "10005757", "94118897", 1, 5, 724m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus" },
                values: new object[] { 5518m, new DateTime(2017, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 195m, 1813m, "10005757", "94118897", 2, 5, 447m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus" },
                values: new object[] { 5518m, new DateTime(2017, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 208m, 364m, "10005757", "94118897", 3, 5, 227m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus" },
                values: new object[] { 5518m, new DateTime(2017, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 420m, 5518m, 104m, "10005757", "94118897", 4, 5, 414m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3632m, new DateTime(2010, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 454m, 152m, "10008375", 6, "62450905", 5, 4, 2, 605m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3632m, new DateTime(2010, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 175m, "10008375", 6, "62450905", 6, 4, 2, 603m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3632m, new DateTime(2010, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 421m, 141m, "10008375", 6, "62450905", 7, 4, 2, 627m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3632m, new DateTime(2010, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 483m, 816m, "10008375", 6, "62450905", 8, 4, 2, 374m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3632m, new DateTime(2010, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 213m, 1334m, "10008375", 6, "62450905", 9, 4, 2, 86m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3632m, new DateTime(2010, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 79m, 3632m, 1888m, "10008375", 6, "62450905", 10, 4, 2, 109m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4193m, new DateTime(2009, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 122m, 958m, "10006038", 6, "14183839", 9, 6, 2, 903m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4193m, new DateTime(2009, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 444m, 1423m, "10006038", 6, "14183839", 10, 6, 2, 480m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4193m, new DateTime(2009, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 36m, 88m, "10006038", 6, "14183839", 11, 6, 2, 231m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4193m, new DateTime(2009, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 256m, 86m, "10006038", 6, "14183839", 12, 6, 2, 246m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4193m, new DateTime(2009, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 423m, 1573m, "10006038", 6, "14183839", 1, 6, 2, 213m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4193m, new DateTime(2009, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 273m, 4193m, 549m, "10006038", 6, "14183839", 2, 6, 2, 592m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3425m, new DateTime(2007, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 97m, 979m, 1, "10005636", "61105021", 10, 4, 1, 110m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3425m, new DateTime(2007, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 172m, 733m, 1, "10005636", "61105021", 11, 4, 1, 116m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3425m, new DateTime(2007, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 227m, 894m, 1, "10005636", "61105021", 12, 4, 1, 645m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3425m, new DateTime(2007, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 212m, 1043m, 1, "10005636", "61105021", 1, 4, 1, 404m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3425m, new DateTime(2007, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 436m, 1357m, 1, "10005636", "61105021", 2, 4, 1, 335m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3425m, new DateTime(2007, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 434m, 3425m, 1240m, 1, "10005636", "61105021", 3, 4, 1, 84m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3111m, new DateTime(2015, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 84m, 1620m, 2, "10005526", "19167180", 3, 3, 5, 883m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3111m, new DateTime(2015, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 667m, 2, "10005526", "19167180", 4, 3, 5, 743m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3111m, new DateTime(2015, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 64m, 1832m, 2, "10005526", "19167180", 5, 3, 5, 947m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3111m, new DateTime(2015, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 47m, 842m, 2, "10005526", "19167180", 6, 3, 5, 63m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3111m, new DateTime(2015, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 420m, 909m, 2, "10005526", "19167180", 7, 3, 5, 948m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3111m, new DateTime(2015, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 163m, 3111m, 1569m, 2, "10005526", "19167180", 8, 3, 5, 403m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4196m, new DateTime(2007, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 101m, 873m, 4, "10005277", 11, "39735895", 5, 6, 7, 322m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4196m, new DateTime(2007, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 67m, 430m, 4, "10005277", 11, "39735895", 6, 6, 7, 282m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4196m, new DateTime(2007, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 243m, 596m, 4, "10005277", 11, "39735895", 7, 6, 7, 229m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4196m, new DateTime(2007, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 479m, 1804m, 4, "10005277", 11, "39735895", 8, 6, 7, 178m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4196m, new DateTime(2007, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 313m, 281m, 4, "10005277", 11, "39735895", 9, 6, 7, 282m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4196m, new DateTime(2007, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 91m, 4196m, 44m, 4, "10005277", 11, "39735895", 10, 6, 7, 839m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5262m, new DateTime(2013, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 206m, 1928m, 4, "10008983", 11, "40592118", 1, 6, 7, 891m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5262m, new DateTime(2013, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 377m, 1628m, 4, "10008983", 11, "40592118", 2, 6, 7, 580m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5262m, new DateTime(2013, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 309m, 1821m, 4, "10008983", 11, "40592118", 3, 6, 7, 615m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5262m, new DateTime(2013, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 73m, 1125m, 4, "10008983", 11, "40592118", 4, 6, 7, 137m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5262m, new DateTime(2013, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 195m, 1440m, 4, "10008983", 11, "40592118", 5, 6, 7, 623m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5262m, new DateTime(2013, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 280m, 5262m, 669m, 4, "10008983", 11, "40592118", 6, 6, 7, 427m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4278m, new DateTime(2014, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 104m, 154m, 3, "10004967", 18, "86612674", 9, 2, 6, 370m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4278m, new DateTime(2014, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 192m, 1424m, 3, "10004967", 18, "86612674", 10, 2, 6, 852m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4278m, new DateTime(2014, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 32m, 134m, 3, "10004967", 18, "86612674", 11, 2, 6, 620m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4278m, new DateTime(2014, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 58m, 897m, 3, "10004967", 18, "86612674", 12, 2, 6, 408m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4278m, new DateTime(2014, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 187m, 917m, 3, "10004967", 18, "86612674", 1, 2, 6, 977m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4278m, new DateTime(2014, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 144m, 4278m, 132m, 3, "10004967", 18, "86612674", 2, 2, 6, 210m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4555m, new DateTime(2008, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 315m, 327m, 4, "10007971", 11, "74928094", 4, 2, 7, 28m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4555m, new DateTime(2008, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 430m, 185m, 4, "10007971", 11, "74928094", 5, 2, 7, 895m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4555m, new DateTime(2008, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 169m, 583m, 4, "10007971", 11, "74928094", 6, 2, 7, 871m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4555m, new DateTime(2008, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 468m, 544m, 4, "10007971", 11, "74928094", 7, 2, 7, 264m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4555m, new DateTime(2008, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 244m, 1918m, 4, "10007971", 11, "74928094", 8, 2, 7, 462m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4555m, new DateTime(2008, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 121m, 4555m, 1617m, 4, "10007971", 11, "74928094", 9, 2, 7, 924m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5732m, new DateTime(2005, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 182m, 1865m, 1, "10008529", 6, "30839153", 1, 6, 2, 602m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5732m, new DateTime(2005, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 143m, 1404m, 1, "10008529", 6, "30839153", 2, 6, 2, 268m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5732m, new DateTime(2005, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 396m, 1984m, 1, "10008529", 6, "30839153", 3, 6, 2, 945m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5732m, new DateTime(2005, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 275m, 962m, 1, "10008529", 6, "30839153", 4, 6, 2, 285m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5732m, new DateTime(2005, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 225m, 1861m, 1, "10008529", 6, "30839153", 5, 6, 2, 274m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5732m, new DateTime(2005, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 131m, 5732m, 1008m, 1, "10008529", 6, "30839153", 6, 6, 2, 700m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4579m, new DateTime(2007, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 259m, 709m, 2, "10004512", 12, "89619340", 8, 6, 4, 832m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4579m, new DateTime(2007, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 404m, 1455m, 2, "10004512", 12, "89619340", 9, 6, 4, 123m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4579m, new DateTime(2007, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 378m, 362m, 2, "10004512", 12, "89619340", 10, 6, 4, 244m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4579m, new DateTime(2007, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9m, 442m, 2, "10004512", 12, "89619340", 11, 6, 4, 979m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4579m, new DateTime(2007, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 164m, 1556m, 2, "10004512", 12, "89619340", 12, 6, 4, 886m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4579m, new DateTime(2007, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 22m, 4579m, 1740m, 2, "10004512", 12, "89619340", 1, 6, 4, 316m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4554m, new DateTime(2015, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 123m, 808m, 1, "10008233", 14, "11673115", 8, 2, 3, 604m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4554m, new DateTime(2015, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 420m, 926m, 1, "10008233", 14, "11673115", 9, 2, 3, 222m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4554m, new DateTime(2015, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 207m, 1235m, 1, "10008233", 14, "11673115", 10, 2, 3, 471m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4554m, new DateTime(2015, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 81m, 987m, 1, "10008233", 14, "11673115", 11, 2, 3, 132m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4554m, new DateTime(2015, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 274m, 1420m, 1, "10008233", 14, "11673115", 12, 2, 3, 73m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4554m, new DateTime(2015, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 383m, 4554m, 1039m, 1, "10008233", 14, "11673115", 1, 2, 3, 990m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4981m, new DateTime(2007, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 146m, 241m, 2, "10001171", "13440224", 7, 3, 4, 452m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4981m, new DateTime(2007, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 316m, 591m, 2, "10001171", "13440224", 8, 3, 4, 21m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4981m, new DateTime(2007, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 177m, 1738m, 2, "10001171", "13440224", 9, 3, 4, 587m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4981m, new DateTime(2007, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 122m, 574m, 2, "10001171", "13440224", 10, 3, 4, 562m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4981m, new DateTime(2007, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 374m, 1284m, 2, "10001171", "13440224", 11, 3, 4, 49m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4981m, new DateTime(2007, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 117m, 4981m, 660m, 2, "10001171", "13440224", 12, 3, 4, 444m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3667m, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 370m, 1727m, 4, "10004843", 11, "40424134", 4, 1, 7, 886m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3667m, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 452m, 162m, 4, "10004843", 11, "40424134", 5, 1, 7, 871m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3667m, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 447m, 867m, 4, "10004843", 11, "40424134", 6, 1, 7, 86m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3667m, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 247m, 546m, 4, "10004843", 11, "40424134", 7, 1, 7, 469m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3667m, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 87m, 1019m, 4, "10004843", 11, "40424134", 8, 1, 7, 68m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3667m, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 135m, 3667m, 1067m, 4, "10004843", 11, "40424134", 9, 1, 7, 48m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5231m, new DateTime(2005, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 154m, 1027m, 2, "10002897", "42291281", 6, 1, 5, 603m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5231m, new DateTime(2005, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 415m, 1571m, 2, "10002897", "42291281", 7, 1, 5, 553m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5231m, new DateTime(2005, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 84m, 102m, 2, "10002897", "42291281", 8, 1, 5, 493m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5231m, new DateTime(2005, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 430m, 1234m, 2, "10002897", "42291281", 9, 1, 5, 624m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5231m, new DateTime(2005, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 220m, 352m, 2, "10002897", "42291281", 10, 1, 5, 158m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5231m, new DateTime(2005, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 101m, 5231m, 152m, 2, "10002897", "42291281", 11, 1, 5, 514m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5353m, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3m, 1870m, "10003449", "62629028", 9, 1, 546m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5353m, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 192m, 915m, "10003449", "62629028", 10, 1, 85m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5353m, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 231m, 1600m, "10003449", "62629028", 11, 1, 919m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5353m, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 497m, 645m, "10003449", "62629028", 12, 1, 846m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5353m, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 129m, 1579m, "10003449", "62629028", 1, 1, 294m, 2021 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5353m, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 351m, 5353m, 107m, "10003449", "62629028", 2, 1, 373m, 2021 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4666m, new DateTime(2005, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 281m, 1522m, 2, "10002365", "95438503", 8, 4, 5, 83m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4666m, new DateTime(2005, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 147m, 175m, 2, "10002365", "95438503", 9, 4, 5, 679m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4666m, new DateTime(2005, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 117m, 1865m, 2, "10002365", "95438503", 10, 4, 5, 491m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4666m, new DateTime(2005, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 366m, 1100m, 2, "10002365", "95438503", 11, 4, 5, 455m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4666m, new DateTime(2005, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 67m, 1017m, 2, "10002365", "95438503", 12, 4, 5, 576m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4666m, new DateTime(2005, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 215m, 4666m, 249m, 2, "10002365", "95438503", 1, 4, 5, 319m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5008m, new DateTime(2007, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 465m, 660m, 4, "10001306", 11, "59374796", 10, 4, 7, 12m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5008m, new DateTime(2007, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 436m, 1314m, 4, "10001306", 11, "59374796", 11, 4, 7, 651m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5008m, new DateTime(2007, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 327m, 234m, 4, "10001306", 11, "59374796", 12, 4, 7, 470m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5008m, new DateTime(2007, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 363m, 1098m, 4, "10001306", 11, "59374796", 1, 4, 7, 106m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5008m, new DateTime(2007, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482m, 1786m, 4, "10001306", 11, "59374796", 2, 4, 7, 422m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5008m, new DateTime(2007, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 5008m, 971m, 4, "10001306", 11, "59374796", 3, 4, 7, 439m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "ProductionBonus", "Year" },
                values: new object[] { 3881m, new DateTime(2009, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 177m, 931m, "10005520", "21444639", 1, 271m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "ProductionBonus", "Year" },
                values: new object[] { 3881m, new DateTime(2009, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 400m, 608m, "10005520", "21444639", 2, 641m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "ProductionBonus", "Year" },
                values: new object[] { 3881m, new DateTime(2009, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 115m, 684m, "10005520", "21444639", 3, 107m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "ProductionBonus", "Year" },
                values: new object[] { 3881m, new DateTime(2009, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 196m, 180m, "10005520", "21444639", 4, 817m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "ProductionBonus", "Year" },
                values: new object[] { 3881m, new DateTime(2009, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 282m, 176m, "10005520", "21444639", 5, 483m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "ProductionBonus", "Year" },
                values: new object[] { 3881m, new DateTime(2009, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 355m, 3881m, 1609m, "10005520", "21444639", 6, 1m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3574m, new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 415m, 1366m, 2, "10002574", 11, "25266148", 2, 5, 5, 957m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3574m, new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 94m, 215m, 2, "10002574", 11, "25266148", 3, 5, 5, 414m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3574m, new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 386m, 269m, 2, "10002574", 11, "25266148", 4, 5, 5, 143m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3574m, new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 53m, 487m, 2, "10002574", 11, "25266148", 5, 5, 5, 762m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3574m, new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 277m, 1157m, 2, "10002574", 11, "25266148", 6, 5, 5, 917m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3574m, new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 362m, 3574m, 447m, 2, "10002574", 11, "25266148", 7, 5, 5, 539m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3725m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 420m, 1160m, "10003648", 11, "94066723", 10, 4, 5, 124m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3725m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 266m, 105m, "10003648", 11, "94066723", 11, 4, 5, 173m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3725m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 156m, 916m, "10003648", 11, "94066723", 12, 4, 5, 887m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3725m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 204m, 1396m, "10003648", 11, "94066723", 1, 4, 5, 0m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3725m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 210m, 1533m, "10003648", 11, "94066723", 2, 4, 5, 347m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3725m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, 3725m, 692m, "10003648", 11, "94066723", 3, 4, 5, 960m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5644m, new DateTime(2007, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 173m, 397m, 3, "10004575", 18, "71725134", 12, 6, 952m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5644m, new DateTime(2007, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 239m, 36m, 3, "10004575", 18, "71725134", 1, 6, 635m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5644m, new DateTime(2007, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 77m, 1748m, 3, "10004575", 18, "71725134", 2, 6, 618m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5644m, new DateTime(2007, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8m, 150m, 3, "10004575", 18, "71725134", 3, 6, 167m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5644m, new DateTime(2007, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 347m, 1933m, 3, "10004575", 18, "71725134", 4, 6, 253m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5644m, new DateTime(2007, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 5644m, 1040m, 3, "10004575", 18, "71725134", 5, 6, 808m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3091m, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 349m, 1313m, "10006148", "56586894", 12, 4, 183m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3091m, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 286m, 1922m, "10006148", "56586894", 1, 4, 678m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3091m, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 139m, 1513m, "10006148", "56586894", 2, 4, 782m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3091m, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 473m, 1825m, "10006148", "56586894", 3, 4, 425m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3091m, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 489m, 1120m, "10006148", "56586894", 4, 4, 580m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3091m, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 53m, 3091m, 1962m, "10006148", "56586894", 5, 4, 166m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4293m, new DateTime(2007, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 1142m, 2, "10008246", "60004413", 1, 3, 4, 105m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4293m, new DateTime(2007, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 392m, 1785m, 2, "10008246", "60004413", 2, 3, 4, 391m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4293m, new DateTime(2007, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 307m, 2, "10008246", "60004413", 3, 3, 4, 736m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4293m, new DateTime(2007, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 89m, 1012m, 2, "10008246", "60004413", 4, 3, 4, 894m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4293m, new DateTime(2007, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 333m, 614m, 2, "10008246", "60004413", 5, 3, 4, 88m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4293m, new DateTime(2007, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 55m, 4293m, 925m, 2, "10008246", "60004413", 6, 3, 4, 639m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4050m, new DateTime(2012, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 523m, "10005438", "15070606", 8, 5, 686m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4050m, new DateTime(2012, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 391m, 1477m, "10005438", "15070606", 9, 5, 616m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4050m, new DateTime(2012, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 245m, 1982m, "10005438", "15070606", 10, 5, 626m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4050m, new DateTime(2012, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 149m, 1399m, "10005438", "15070606", 11, 5, 951m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4050m, new DateTime(2012, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 58m, 441m, "10005438", "15070606", 12, 5, 116m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4050m, new DateTime(2012, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 207m, 4050m, 1205m, "10005438", "15070606", 1, 5, 590m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3503m, new DateTime(2013, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 318m, 1040m, 3, "10004298", 18, "54222766", 6, 5, 6, 400m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3503m, new DateTime(2013, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 49m, 1209m, 3, "10004298", 18, "54222766", 7, 5, 6, 393m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3503m, new DateTime(2013, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 744m, 3, "10004298", 18, "54222766", 8, 5, 6, 682m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3503m, new DateTime(2013, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 215m, 879m, 3, "10004298", 18, "54222766", 9, 5, 6, 947m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3503m, new DateTime(2013, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 422m, 28m, 3, "10004298", 18, "54222766", 10, 5, 6, 357m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3503m, new DateTime(2013, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 496m, 3503m, 825m, 3, "10004298", 18, "54222766", 11, 5, 6, 141m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5163m, new DateTime(2006, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 90m, 1731m, 1, "10007900", 6, "32529922", 6, 3, 2, 968m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5163m, new DateTime(2006, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, 535m, 1, "10007900", 6, "32529922", 7, 3, 2, 597m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5163m, new DateTime(2006, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 316m, 1986m, 1, "10007900", 6, "32529922", 8, 3, 2, 550m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5163m, new DateTime(2006, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 471m, 1744m, 1, "10007900", 6, "32529922", 9, 3, 2, 820m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5163m, new DateTime(2006, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 479m, 237m, 1, "10007900", 6, "32529922", 10, 3, 2, 944m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5163m, new DateTime(2006, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 497m, 5163m, 1947m, 1, "10007900", 6, "32529922", 11, 3, 2, 112m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3887m, new DateTime(2011, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 34m, 289m, "10008161", "15902278", 7, 4, 314m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3887m, new DateTime(2011, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 132m, 1336m, "10008161", "15902278", 8, 4, 839m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3887m, new DateTime(2011, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 396m, 228m, "10008161", "15902278", 9, 4, 801m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3887m, new DateTime(2011, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 76m, 1290m, "10008161", "15902278", 10, 4, 525m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3887m, new DateTime(2011, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 405m, 1512m, "10008161", "15902278", 11, 4, 465m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3887m, new DateTime(2011, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 61m, 3887m, 1052m, "10008161", "15902278", 12, 4, 830m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5282m, new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 427m, 1187m, 4, "10003106", 11, "26476491", 1, 7, 20m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5282m, new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2m, 160m, 4, "10003106", 11, "26476491", 2, 7, 845m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5282m, new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 93m, 1894m, 4, "10003106", 11, "26476491", 3, 7, 36m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5282m, new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4m, 1355m, 4, "10003106", 11, "26476491", 4, 7, 296m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5282m, new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 218m, 185m, 4, "10003106", 11, "26476491", 5, 7, 849m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5282m, new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 372m, 5282m, 1751m, 4, "10003106", 11, "26476491", 6, 7, 51m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5729m, new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 474m, 996m, 1, "10002165", 14, "54177187", 7, 2, 3, 943m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5729m, new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 844m, 1, "10002165", 14, "54177187", 8, 2, 3, 610m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5729m, new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 86m, 1746m, 1, "10002165", 14, "54177187", 9, 2, 3, 393m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5729m, new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 272m, 274m, 1, "10002165", 14, "54177187", 10, 2, 3, 110m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5729m, new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 341m, 1026m, 1, "10002165", 14, "54177187", 11, 2, 3, 800m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5729m, new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 107m, 5729m, 1382m, 1, "10002165", 14, "54177187", 12, 2, 3, 760m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4238m, new DateTime(2013, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 423m, 488m, 2, "10008162", 11, "48802129", 6, 5, 159m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4238m, new DateTime(2013, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 54m, 1007m, 2, "10008162", 11, "48802129", 7, 5, 479m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4238m, new DateTime(2013, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 273m, 414m, 2, "10008162", 11, "48802129", 8, 5, 953m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4238m, new DateTime(2013, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 313m, 1565m, 2, "10008162", 11, "48802129", 9, 5, 410m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4238m, new DateTime(2013, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 75m, 1705m, 2, "10008162", 11, "48802129", 10, 5, 308m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4238m, new DateTime(2013, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 314m, 4238m, 1124m, 2, "10008162", 11, "48802129", 11, 5, 251m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5368m, new DateTime(2014, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 225m, 1313m, 4, "10004725", 11, "58324334", 5, 7, 88m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5368m, new DateTime(2014, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, 409m, 4, "10004725", 11, "58324334", 5, 7, 568m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5368m, new DateTime(2014, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 432m, 1936m, 4, "10004725", 11, "58324334", 5, 7, 107m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5368m, new DateTime(2014, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 88m, 1878m, 4, "10004725", 11, "58324334", 5, 7, 811m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5368m, new DateTime(2014, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 319m, 1579m, 4, "10004725", 11, "58324334", 5, 7, 904m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5368m, new DateTime(2014, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 441m, 5368m, 1449m, 4, "10004725", 11, "58324334", 5, 7, 95m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5368m, new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 449m, 1984m, 1, "10001932", 6, "69469802", 6, 3, 2, 564m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5368m, new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 499m, 1935m, 1, "10001932", 6, "69469802", 7, 3, 2, 692m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5368m, new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 102m, 1193m, 1, "10001932", 6, "69469802", 8, 3, 2, 521m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5368m, new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 58m, 770m, 1, "10001932", 6, "69469802", 9, 3, 2, 181m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5368m, new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 55m, 1542m, 1, "10001932", 6, "69469802", 10, 3, 2, 572m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5368m, new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14m, 5368m, 976m, 1, "10001932", 6, "69469802", 11, 3, 2, 728m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5147m, new DateTime(2016, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 80m, 619m, 1, "10002782", 12, "59144808", 3, 4, 1, 498m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5147m, new DateTime(2016, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 375m, 1173m, 1, "10002782", 12, "59144808", 4, 4, 1, 618m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5147m, new DateTime(2016, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 179m, 1996m, 1, "10002782", 12, "59144808", 5, 4, 1, 735m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5147m, new DateTime(2016, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 365m, 658m, 1, "10002782", 12, "59144808", 6, 4, 1, 593m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5147m, new DateTime(2016, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 1184m, 1, "10002782", 12, "59144808", 7, 4, 1, 938m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5147m, new DateTime(2016, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8m, 5147m, 1397m, 1, "10002782", 12, "59144808", 8, 4, 1, 726m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4491m, new DateTime(2008, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 326m, 1627m, 1, "10004594", 6, "17203319", 12, 1, 2, 679m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4491m, new DateTime(2008, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 321m, 1363m, 1, "10004594", 6, "17203319", 1, 1, 2, 18m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4491m, new DateTime(2008, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 325m, 1102m, 1, "10004594", 6, "17203319", 2, 1, 2, 814m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4491m, new DateTime(2008, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 459m, 1128m, 1, "10004594", 6, "17203319", 3, 1, 2, 2m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4491m, new DateTime(2008, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 314m, 359m, 1, "10004594", 6, "17203319", 4, 1, 2, 384m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4491m, new DateTime(2008, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 86m, 4491m, 970m, 1, "10004594", 6, "17203319", 5, 1, 2, 736m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4840m, new DateTime(2006, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 269m, 1865m, 2, "10006642", 12, "21179419", 9, 2, 4, 622m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4840m, new DateTime(2006, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 148m, 701m, 2, "10006642", 12, "21179419", 10, 2, 4, 728m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4840m, new DateTime(2006, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 47m, 1277m, 2, "10006642", 12, "21179419", 11, 2, 4, 193m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4840m, new DateTime(2006, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 332m, 1646m, 2, "10006642", 12, "21179419", 12, 2, 4, 538m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4840m, new DateTime(2006, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 221m, 883m, 2, "10006642", 12, "21179419", 1, 2, 4, 499m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4840m, new DateTime(2006, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 252m, 4840m, 1610m, 2, "10006642", 12, "21179419", 2, 2, 4, 43m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3341m, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 29m, 6m, 1, "10006298", "55918778", 5, 1, 245m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3341m, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 371m, 540m, 1, "10006298", "55918778", 5, 1, 489m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3341m, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 118m, 1727m, 1, "10006298", "55918778", 5, 1, 115m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3341m, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 61m, 1658m, 1, "10006298", "55918778", 5, 1, 926m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "OfficeId", "PositionId", "Year" },
                values: new object[] { 3341m, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 406m, 158m, 1, "10006298", "55918778", 5, 1, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3341m, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 267m, 3341m, 1103m, 1, "10006298", "55918778", 5, 1, 927m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4365m, new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 398m, 1852m, "10005577", "69038969", 1, 1, 769m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4365m, new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 195m, 1160m, "10005577", "69038969", 2, 1, 28m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4365m, new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 297m, 395m, "10005577", "69038969", 3, 1, 392m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4365m, new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 104m, 1930m, "10005577", "69038969", 4, 1, 545m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4365m, new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 214m, 154m, "10005577", "69038969", 5, 1, 73m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4365m, new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 74m, 4365m, 308m, "10005577", "69038969", 6, 1, 95m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4255m, new DateTime(2005, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 151m, 1706m, "10003390", 14, "72080667", 10, 3, 452m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4255m, new DateTime(2005, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 414m, 445m, "10003390", 14, "72080667", 11, 3, 122m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4255m, new DateTime(2005, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 444m, 1642m, "10003390", 14, "72080667", 12, 3, 150m, 2005 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4255m, new DateTime(2005, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 223m, 1346m, "10003390", 14, "72080667", 1, 3, 274m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4255m, new DateTime(2005, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 406m, 1146m, "10003390", 14, "72080667", 2, 3, 69m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4255m, new DateTime(2005, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 130m, 4255m, 507m, "10003390", 14, "72080667", 3, 3, 9m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5496m, new DateTime(2010, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 141m, 298m, 2, "10006250", 11, "42924213", 4, 6, 5, 200m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5496m, new DateTime(2010, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 61m, 781m, 2, "10006250", 11, "42924213", 5, 6, 5, 262m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5496m, new DateTime(2010, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 78m, 457m, 2, "10006250", 11, "42924213", 6, 6, 5, 134m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5496m, new DateTime(2010, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 151m, 1627m, 2, "10006250", 11, "42924213", 7, 6, 5, 234m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5496m, new DateTime(2010, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 497m, 984m, 2, "10006250", 11, "42924213", 8, 6, 5, 453m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5496m, new DateTime(2010, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 60m, 5496m, 92m, 2, "10006250", 11, "42924213", 9, 6, 5, 701m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3186m, new DateTime(2016, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 201m, 1528m, 3, "10005200", 18, "88454284", 5, 1, 6, 307m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3186m, new DateTime(2016, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 353m, 728m, 3, "10005200", 18, "88454284", 6, 1, 6, 519m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3186m, new DateTime(2016, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 169m, 898m, 3, "10005200", 18, "88454284", 7, 1, 6, 814m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3186m, new DateTime(2016, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 324m, 544m, 3, "10005200", 18, "88454284", 8, 1, 6, 747m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3186m, new DateTime(2016, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 307m, 984m, 3, "10005200", 18, "88454284", 9, 1, 6, 799m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3186m, new DateTime(2016, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 433m, 3186m, 30m, 3, "10005200", 18, "88454284", 10, 1, 6, 156m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5972m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 191m, 522m, 1, "10005496", 6, "26297330", 10, 3, 2, 487m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5972m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 348m, 1562m, 1, "10005496", 6, "26297330", 11, 3, 2, 9m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5972m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 398m, 515m, 1, "10005496", 6, "26297330", 12, 3, 2, 848m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5972m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 340m, 893m, 1, "10005496", 6, "26297330", 1, 3, 2, 813m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5972m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, 353m, 1, "10005496", 6, "26297330", 2, 3, 2, 352m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5972m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 72m, 5972m, 1381m, 1, "10005496", 6, "26297330", 3, 3, 2, 590m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3700m, new DateTime(2006, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 219m, 769m, 2, "10004461", 11, "19141500", 3, 6, 5, 280m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3700m, new DateTime(2006, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 342m, 1831m, 2, "10004461", 11, "19141500", 4, 6, 5, 420m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3700m, new DateTime(2006, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 273m, 1693m, 2, "10004461", 11, "19141500", 5, 6, 5, 551m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3700m, new DateTime(2006, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 379m, 100m, 2, "10004461", 11, "19141500", 6, 6, 5, 499m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3700m, new DateTime(2006, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 265m, 735m, 2, "10004461", 11, "19141500", 7, 6, 5, 829m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3700m, new DateTime(2006, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 312m, 3700m, 1156m, 2, "10004461", 11, "19141500", 8, 6, 5, 394m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3757m, new DateTime(2015, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 153m, 284m, "10006703", 12, "76936732", 7, 5, 4, 564m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3757m, new DateTime(2015, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 60m, 1151m, "10006703", 12, "76936732", 8, 5, 4, 272m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3757m, new DateTime(2015, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 133m, 962m, "10006703", 12, "76936732", 9, 5, 4, 643m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3757m, new DateTime(2015, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 227m, 1966m, "10006703", 12, "76936732", 10, 5, 4, 753m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3757m, new DateTime(2015, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 77m, 1673m, "10006703", 12, "76936732", 11, 5, 4, 122m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3757m, new DateTime(2015, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 493m, 3757m, 1719m, "10006703", 12, "76936732", 12, 5, 4, 68m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4023m, new DateTime(2009, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 210m, 1068m, 2, "10005634", 12, "40106102", 12, 4, 49m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4023m, new DateTime(2009, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 466m, 1282m, 2, "10005634", 12, "40106102", 1, 4, 221m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4023m, new DateTime(2009, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 117m, 1270m, 2, "10005634", 12, "40106102", 2, 4, 300m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4023m, new DateTime(2009, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 291m, 211m, 2, "10005634", 12, "40106102", 3, 4, 858m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4023m, new DateTime(2009, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2m, 304m, 2, "10005634", 12, "40106102", 4, 4, 499m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4023m, new DateTime(2009, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 291m, 4023m, 433m, 2, "10005634", 12, "40106102", 5, 4, 997m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3587m, new DateTime(2017, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 199m, 902m, 4, "10007411", 11, "37357628", 10, 1, 7, 467m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3587m, new DateTime(2017, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 85m, 1354m, 4, "10007411", 11, "37357628", 11, 1, 7, 525m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3587m, new DateTime(2017, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 219m, 1089m, 4, "10007411", 11, "37357628", 12, 1, 7, 670m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3587m, new DateTime(2017, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 474m, 851m, 4, "10007411", 11, "37357628", 1, 1, 7, 527m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3587m, new DateTime(2017, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 73m, 124m, 4, "10007411", 11, "37357628", 2, 1, 7, 767m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3587m, new DateTime(2017, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 89m, 3587m, 1893m, 4, "10007411", 11, "37357628", 3, 1, 7, 566m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5126m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27m, 1445m, "10008923", 14, "17719896", 10, 3, 3, 434m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5126m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 141m, 825m, "10008923", 14, "17719896", 11, 3, 3, 818m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5126m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 332m, 300m, "10008923", 14, "17719896", 12, 3, 3, 266m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5126m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 240m, 519m, "10008923", 14, "17719896", 1, 3, 3, 64m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5126m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, 1579m, "10008923", 14, "17719896", 2, 3, 3, 915m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5126m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 457m, 5126m, 1739m, "10008923", 14, "17719896", 3, 3, 3, 684m, 2010 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3484m, new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 227m, 695m, 4, "10006585", 11, "36663754", 7, 3, 7, 880m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3484m, new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 381m, 1467m, 4, "10006585", 11, "36663754", 8, 3, 7, 581m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3484m, new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 368m, 1658m, 4, "10006585", 11, "36663754", 9, 3, 7, 623m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3484m, new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 408m, 1685m, 4, "10006585", 11, "36663754", 10, 3, 7, 469m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3484m, new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 289m, 1761m, 4, "10006585", 11, "36663754", 11, 3, 7, 680m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3484m, new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 493m, 3484m, 21m, 4, "10006585", 11, "36663754", 12, 3, 7, 858m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4214m, new DateTime(2011, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 58m, 1604m, 1, "10004430", 14, "11297408", 4, 4, 3, 882m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4214m, new DateTime(2011, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 447m, 646m, 1, "10004430", 14, "11297408", 5, 4, 3, 155m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4214m, new DateTime(2011, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 354m, 1650m, 1, "10004430", 14, "11297408", 6, 4, 3, 652m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4214m, new DateTime(2011, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 331m, 1109m, 1, "10004430", 14, "11297408", 7, 4, 3, 287m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4214m, new DateTime(2011, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 205m, 1257m, 1, "10004430", 14, "11297408", 8, 4, 3, 791m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4214m, new DateTime(2011, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 84m, 4214m, 939m, 1, "10004430", 14, "11297408", 9, 4, 3, 142m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3187m, new DateTime(2011, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 77m, 873m, 3, "10002384", 18, "25060444", 6, 715m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3187m, new DateTime(2011, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 88m, 506m, 3, "10002384", 18, "25060444", 6, 497m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3187m, new DateTime(2011, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 39m, 1608m, 3, "10002384", 18, "25060444", 6, 494m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3187m, new DateTime(2011, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 212m, 744m, 3, "10002384", 18, "25060444", 6, 669m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3187m, new DateTime(2011, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 97m, 1134m, 3, "10002384", 18, "25060444", 6, 658m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3187m, new DateTime(2011, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 271m, 3187m, 1671m, 3, "10002384", 18, "25060444", 6, 232m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3908m, new DateTime(2015, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 292m, 1974m, 3, "10001956", 18, "77197446", 4, 1, 6, 108m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3908m, new DateTime(2015, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, 1860m, 3, "10001956", 18, "77197446", 5, 1, 6, 649m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3908m, new DateTime(2015, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 467m, 226m, 3, "10001956", 18, "77197446", 6, 1, 6, 721m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3908m, new DateTime(2015, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 83m, 932m, 3, "10001956", 18, "77197446", 7, 1, 6, 465m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3908m, new DateTime(2015, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 440m, 515m, 3, "10001956", 18, "77197446", 8, 1, 6, 612m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3908m, new DateTime(2015, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 259m, 3908m, 621m, 3, "10001956", 18, "77197446", 9, 1, 6, 298m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5100m, new DateTime(2016, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 325m, 713m, 1, "10007782", 6, "53480699", 5, 6, 2, 628m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5100m, new DateTime(2016, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 328m, 671m, 1, "10007782", 6, "53480699", 6, 6, 2, 300m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5100m, new DateTime(2016, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 194m, 177m, 1, "10007782", 6, "53480699", 7, 6, 2, 147m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5100m, new DateTime(2016, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 57m, 633m, 1, "10007782", 6, "53480699", 8, 6, 2, 860m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5100m, new DateTime(2016, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 285m, 1414m, 1, "10007782", 6, "53480699", 9, 6, 2, 992m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5100m, new DateTime(2016, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 337m, 5100m, 429m, 1, "10007782", 6, "53480699", 10, 6, 2, 600m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4161m, new DateTime(2017, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 85m, 652m, 1, "10008349", 14, "98666219", 1, 5, 3, 303m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4161m, new DateTime(2017, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 150m, 1343m, 1, "10008349", 14, "98666219", 2, 5, 3, 56m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4161m, new DateTime(2017, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 426m, 203m, 1, "10008349", 14, "98666219", 3, 5, 3, 316m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4161m, new DateTime(2017, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 373m, 345m, 1, "10008349", 14, "98666219", 4, 5, 3, 13m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4161m, new DateTime(2017, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 73m, 11m, 1, "10008349", 14, "98666219", 5, 5, 3, 299m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4161m, new DateTime(2017, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 22m, 4161m, 1006m, 1, "10008349", 14, "98666219", 6, 5, 3, 503m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5025m, new DateTime(2012, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 301m, 1798m, 1, "10004830", "20368709", 11, 5, 1, 329m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5025m, new DateTime(2012, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 361m, 36m, 1, "10004830", "20368709", 12, 5, 1, 224m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5025m, new DateTime(2012, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 263m, 63m, 1, "10004830", "20368709", 1, 5, 1, 672m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5025m, new DateTime(2012, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 361m, 422m, 1, "10004830", "20368709", 2, 5, 1, 696m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5025m, new DateTime(2012, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 408m, 1627m, 1, "10004830", "20368709", 3, 5, 1, 735m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5025m, new DateTime(2012, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 135m, 5025m, 1978m, 1, "10004830", "20368709", 4, 5, 1, 143m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3762m, new DateTime(2013, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 103m, 1201m, "10006645", "94794765", 10, 2, 935m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3762m, new DateTime(2013, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 224m, 1185m, "10006645", "94794765", 11, 2, 977m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3762m, new DateTime(2013, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 181m, 1731m, "10006645", "94794765", 12, 2, 620m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3762m, new DateTime(2013, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 226m, 851m, "10006645", "94794765", 1, 2, 377m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3762m, new DateTime(2013, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 409m, 1709m, "10006645", "94794765", 2, 2, 498m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3762m, new DateTime(2013, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 33m, 3762m, 1893m, "10006645", "94794765", 3, 2, 809m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5859m, new DateTime(2007, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 343m, 1869m, 2, "10003637", 12, "88179319", 5, 4, 4, 415m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5859m, new DateTime(2007, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 226m, 105m, 2, "10003637", 12, "88179319", 6, 4, 4, 229m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5859m, new DateTime(2007, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 397m, 602m, 2, "10003637", 12, "88179319", 7, 4, 4, 852m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5859m, new DateTime(2007, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7m, 485m, 2, "10003637", 12, "88179319", 8, 4, 4, 371m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5859m, new DateTime(2007, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 210m, 1608m, 2, "10003637", 12, "88179319", 9, 4, 4, 143m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5859m, new DateTime(2007, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 400m, 5859m, 172m, 2, "10003637", 12, "88179319", 10, 4, 4, 165m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3536m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 428m, 729m, "10001675", 14, "17489497", 6, 1, 3, 860m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3536m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 60m, 847m, "10001675", 14, "17489497", 7, 1, 3, 328m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3536m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 879m, "10001675", 14, "17489497", 8, 1, 3, 830m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3536m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 144m, 976m, "10001675", 14, "17489497", 9, 1, 3, 373m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3536m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 58m, 1273m, "10001675", 14, "17489497", 10, 1, 3, 384m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3536m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 125m, 3536m, 769m, "10001675", 14, "17489497", 11, 1, 3, 539m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4115m, new DateTime(2013, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 213m, 508m, 1, "10007827", 14, "86727699", 6, 3, 3, 868m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4115m, new DateTime(2013, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 87m, 272m, 1, "10007827", 14, "86727699", 7, 3, 3, 789m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4115m, new DateTime(2013, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 13m, 85m, 1, "10007827", 14, "86727699", 8, 3, 3, 589m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4115m, new DateTime(2013, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 47m, 641m, 1, "10007827", 14, "86727699", 9, 3, 3, 482m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4115m, new DateTime(2013, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 124m, 801m, 1, "10007827", 14, "86727699", 10, 3, 3, 414m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4115m, new DateTime(2013, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 133m, 4115m, 1202m, 1, "10007827", 14, "86727699", 11, 3, 3, 603m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4233m, new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 129m, 1117m, 2, "10004969", 12, "58147972", 10, 1, 4, 175m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4233m, new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 494m, 487m, 2, "10004969", 12, "58147972", 11, 1, 4, 431m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4233m, new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 124m, 383m, 2, "10004969", 12, "58147972", 12, 1, 4, 376m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4233m, new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 93m, 837m, 2, "10004969", 12, "58147972", 1, 1, 4, 719m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4233m, new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 383m, 1381m, 2, "10004969", 12, "58147972", 2, 1, 4, 895m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4233m, new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 255m, 4233m, 1973m, 2, "10004969", 12, "58147972", 3, 1, 4, 29m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5184m, new DateTime(2016, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 486m, 624m, 3, "10006029", 18, "26373831", 12, 1, 6, 710m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5184m, new DateTime(2016, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 267m, 1245m, 3, "10006029", 18, "26373831", 1, 1, 6, 653m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5184m, new DateTime(2016, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 276m, 1293m, 3, "10006029", 18, "26373831", 2, 1, 6, 238m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5184m, new DateTime(2016, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, 1285m, 3, "10006029", 18, "26373831", 3, 1, 6, 569m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5184m, new DateTime(2016, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 442m, 1527m, 3, "10006029", 18, "26373831", 4, 1, 6, 303m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5184m, new DateTime(2016, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 416m, 5184m, 1145m, 3, "10006029", 18, "26373831", 5, 1, 6, 525m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3679m, new DateTime(2017, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 112m, 1424m, 2, "10004368", 12, "87118563", 8, 5, 4, 636m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3679m, new DateTime(2017, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 298m, 1209m, 2, "10004368", 12, "87118563", 9, 5, 4, 598m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3679m, new DateTime(2017, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 429m, 267m, 2, "10004368", 12, "87118563", 10, 5, 4, 389m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3679m, new DateTime(2017, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 223m, 1485m, 2, "10004368", 12, "87118563", 11, 5, 4, 556m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3679m, new DateTime(2017, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 224m, 879m, 2, "10004368", 12, "87118563", 12, 5, 4, 657m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3679m, new DateTime(2017, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 103m, 3679m, 721m, 2, "10004368", 12, "87118563", 1, 5, 4, 295m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4056m, new DateTime(2007, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 186m, 1045m, 2, "10001422", 12, "55365354", 6, 5, 4, 948m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4056m, new DateTime(2007, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 456m, 312m, 2, "10001422", 12, "55365354", 7, 5, 4, 901m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4056m, new DateTime(2007, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 363m, 530m, 2, "10001422", 12, "55365354", 8, 5, 4, 665m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4056m, new DateTime(2007, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 371m, 72m, 2, "10001422", 12, "55365354", 9, 5, 4, 812m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4056m, new DateTime(2007, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 183m, 1362m, 2, "10001422", 12, "55365354", 10, 5, 4, 636m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4056m, new DateTime(2007, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 453m, 4056m, 413m, 2, "10001422", 12, "55365354", 11, 5, 4, 768m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3330m, new DateTime(2007, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 142m, 1881m, 2, "10004781", "32030803", 8, 5, 859m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3330m, new DateTime(2007, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 468m, 215m, 2, "10004781", "32030803", 9, 5, 154m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3330m, new DateTime(2007, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 294m, 998m, 2, "10004781", "32030803", 10, 5, 800m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3330m, new DateTime(2007, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 188m, 1901m, 2, "10004781", "32030803", 11, 5, 86m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3330m, new DateTime(2007, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 107m, 1344m, 2, "10004781", "32030803", 12, 5, 808m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3330m, new DateTime(2007, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 308m, 3330m, 891m, 2, "10004781", "32030803", 1, 5, 703m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4700m, new DateTime(2011, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 227m, 1745m, 1, "10005573", 14, "29229951", 11, 1, 3, 405m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4700m, new DateTime(2011, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 132m, 1412m, 1, "10005573", 14, "29229951", 12, 1, 3, 672m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4700m, new DateTime(2011, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 463m, 1009m, 1, "10005573", 14, "29229951", 1, 1, 3, 914m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4700m, new DateTime(2011, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 384m, 707m, 1, "10005573", 14, "29229951", 2, 1, 3, 138m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4700m, new DateTime(2011, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 118m, 1034m, 1, "10005573", 14, "29229951", 3, 1, 3, 941m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4700m, new DateTime(2011, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 369m, 4700m, 1762m, 1, "10005573", 14, "29229951", 4, 1, 3, 883m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4254m, new DateTime(2016, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 128m, 1162m, 2, "10003213", 11, "34513671", 6, 3, 5, 260m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4254m, new DateTime(2016, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 134m, 1497m, 2, "10003213", 11, "34513671", 7, 3, 5, 443m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4254m, new DateTime(2016, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 227m, 1254m, 2, "10003213", 11, "34513671", 8, 3, 5, 405m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4254m, new DateTime(2016, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 237m, 415m, 2, "10003213", 11, "34513671", 9, 3, 5, 100m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4254m, new DateTime(2016, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 427m, 99m, 2, "10003213", 11, "34513671", 10, 3, 5, 960m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4254m, new DateTime(2016, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 448m, 4254m, 349m, 2, "10003213", 11, "34513671", 11, 3, 5, 518m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3322m, new DateTime(2007, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 23m, 1119m, 2, "10004164", "26429846", 10, 4, 654m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3322m, new DateTime(2007, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 296m, 1669m, 2, "10004164", "26429846", 11, 4, 276m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3322m, new DateTime(2007, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 337m, 990m, 2, "10004164", "26429846", 12, 4, 577m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3322m, new DateTime(2007, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 68m, 1466m, 2, "10004164", "26429846", 1, 4, 181m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3322m, new DateTime(2007, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 98m, 768m, 2, "10004164", "26429846", 2, 4, 851m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3322m, new DateTime(2007, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 229m, 3322m, 77m, 2, "10004164", "26429846", 3, 4, 482m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4830m, new DateTime(2012, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 235m, 210m, 2, "10005544", 11, "51391058", 10, 1, 5, 557m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4830m, new DateTime(2012, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5m, 34m, 2, "10005544", 11, "51391058", 11, 1, 5, 267m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4830m, new DateTime(2012, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 471m, 992m, 2, "10005544", 11, "51391058", 12, 1, 5, 972m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4830m, new DateTime(2012, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 257m, 1899m, 2, "10005544", 11, "51391058", 1, 1, 5, 199m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4830m, new DateTime(2012, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 427m, 1178m, 2, "10005544", 11, "51391058", 2, 1, 5, 915m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4830m, new DateTime(2012, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 124m, 4830m, 1053m, 2, "10005544", 11, "51391058", 3, 1, 5, 518m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4279m, new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 208m, 1323m, 1, "10005047", 14, "50083964", 1, 3, 516m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4279m, new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 158m, 1292m, 1, "10005047", 14, "50083964", 1, 3, 859m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4279m, new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 172m, 246m, 1, "10005047", 14, "50083964", 1, 3, 346m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4279m, new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 222m, 1696m, 1, "10005047", 14, "50083964", 1, 3, 675m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4279m, new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 17m, 780m, 1, "10005047", 14, "50083964", 1, 3, 455m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4279m, new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 467m, 4279m, 1842m, 1, "10005047", 14, "50083964", 1, 3, 204m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3993m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 330m, 89m, 1, "10004023", 14, "96752809", 7, 1, 3, 175m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3993m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 161m, 1739m, 1, "10004023", 14, "96752809", 8, 1, 3, 687m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3993m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, 1606m, 1, "10004023", 14, "96752809", 9, 1, 3, 893m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3993m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 238m, 641m, 1, "10004023", 14, "96752809", 10, 1, 3, 405m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3993m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 419m, 702m, 1, "10004023", 14, "96752809", 11, 1, 3, 81m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3993m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 289m, 3993m, 1793m, 1, "10004023", 14, "96752809", 12, 1, 3, 576m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5820m, new DateTime(2007, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 480m, 593m, 3, "10008725", 18, "60265035", 3, 3, 6, 862m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5820m, new DateTime(2007, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 402m, 1483m, 3, "10008725", 18, "60265035", 4, 3, 6, 247m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5820m, new DateTime(2007, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 1699m, 3, "10008725", 18, "60265035", 5, 3, 6, 744m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5820m, new DateTime(2007, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 205m, 766m, 3, "10008725", 18, "60265035", 6, 3, 6, 57m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5820m, new DateTime(2007, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 192m, 1494m, 3, "10008725", 18, "60265035", 7, 3, 6, 327m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5820m, new DateTime(2007, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 254m, 5820m, 1859m, 3, "10008725", 18, "60265035", 8, 3, 6, 979m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5469m, new DateTime(2009, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 56m, 1048m, 3, "10007212", 18, "79704219", 7, 5, 6, 296m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5469m, new DateTime(2009, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 167m, 107m, 3, "10007212", 18, "79704219", 8, 5, 6, 237m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5469m, new DateTime(2009, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 217m, 1194m, 3, "10007212", 18, "79704219", 9, 5, 6, 920m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5469m, new DateTime(2009, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 275m, 179m, 3, "10007212", 18, "79704219", 10, 5, 6, 831m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5469m, new DateTime(2009, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 185m, 324m, 3, "10007212", 18, "79704219", 11, 5, 6, 298m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5469m, new DateTime(2009, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 193m, 5469m, 243m, 3, "10007212", 18, "79704219", 12, 5, 6, 787m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5761m, new DateTime(2007, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 149m, 366m, 4, "10007004", 11, "28631384", 6, 5, 7, 875m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5761m, new DateTime(2007, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 210m, 1478m, 4, "10007004", 11, "28631384", 7, 5, 7, 932m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5761m, new DateTime(2007, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 396m, 1674m, 4, "10007004", 11, "28631384", 8, 5, 7, 381m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5761m, new DateTime(2007, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 339m, 836m, 4, "10007004", 11, "28631384", 9, 5, 7, 200m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "Year" },
                values: new object[] { 5761m, new DateTime(2007, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 116m, 948m, 4, "10007004", 11, "28631384", 10, 5, 7, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5761m, new DateTime(2007, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 431m, 5761m, 1403m, 4, "10007004", 11, "28631384", 11, 5, 7, 522m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5589m, new DateTime(2013, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 355m, 232m, 1, "10002780", 14, "56614890", 12, 3, 3, 494m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5589m, new DateTime(2013, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 162m, 1649m, 1, "10002780", 14, "56614890", 1, 3, 3, 888m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5589m, new DateTime(2013, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 164m, 1729m, 1, "10002780", 14, "56614890", 2, 3, 3, 394m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5589m, new DateTime(2013, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 43m, 1521m, 1, "10002780", 14, "56614890", 3, 3, 3, 330m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5589m, new DateTime(2013, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 357m, 1478m, 1, "10002780", 14, "56614890", 4, 3, 3, 596m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5589m, new DateTime(2013, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 87m, 5589m, 969m, 1, "10002780", 14, "56614890", 5, 3, 3, 584m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5637m, new DateTime(2011, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, 1228m, 2, "10007600", 12, "98115409", 9, 3, 4, 373m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5637m, new DateTime(2011, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 454m, 957m, 2, "10007600", 12, "98115409", 10, 3, 4, 178m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5637m, new DateTime(2011, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 109m, 1236m, 2, "10007600", 12, "98115409", 11, 3, 4, 86m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5637m, new DateTime(2011, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 82m, 874m, 2, "10007600", 12, "98115409", 12, 3, 4, 46m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5637m, new DateTime(2011, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 109m, 387m, 2, "10007600", 12, "98115409", 1, 3, 4, 349m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5637m, new DateTime(2011, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 265m, 5637m, 152m, 2, "10007600", 12, "98115409", 2, 3, 4, 738m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5624m, new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 326m, 1546m, "10003719", 11, "35983795", 12, 3, 5, 688m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5624m, new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 65m, 616m, "10003719", 11, "35983795", 1, 3, 5, 802m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5624m, new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 375m, 1734m, "10003719", 11, "35983795", 2, 3, 5, 169m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5624m, new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, 1300m, "10003719", 11, "35983795", 3, 3, 5, 963m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5624m, new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 471m, 291m, "10003719", 11, "35983795", 4, 3, 5, 936m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5624m, new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 485m, 5624m, 1191m, "10003719", 11, "35983795", 5, 3, 5, 112m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5046m, new DateTime(2009, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 483m, 39m, 4, "10003211", "88326119", 5, 1, 7, 17m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5046m, new DateTime(2009, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 458m, 1911m, 4, "10003211", "88326119", 6, 1, 7, 69m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5046m, new DateTime(2009, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 330m, 950m, 4, "10003211", "88326119", 7, 1, 7, 733m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5046m, new DateTime(2009, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 108m, 1962m, 4, "10003211", "88326119", 8, 1, 7, 465m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5046m, new DateTime(2009, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5m, 1626m, 4, "10003211", "88326119", 9, 1, 7, 431m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5046m, new DateTime(2009, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 301m, 5046m, 281m, 4, "10003211", "88326119", 10, 1, 7, 36m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3945m, new DateTime(2016, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 446m, 192m, 2, "10001900", "37455202", 4, 2, 4, 657m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3945m, new DateTime(2016, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 148m, 203m, 2, "10001900", "37455202", 5, 2, 4, 2m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3945m, new DateTime(2016, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 193m, 837m, 2, "10001900", "37455202", 6, 2, 4, 325m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3945m, new DateTime(2016, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 255m, 1782m, 2, "10001900", "37455202", 7, 2, 4, 817m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3945m, new DateTime(2016, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 412m, 1119m, 2, "10001900", "37455202", 8, 2, 4, 14m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3945m, new DateTime(2016, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 477m, 3945m, 613m, 2, "10001900", "37455202", 9, 2, 4, 637m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5058m, new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 279m, 798m, 1, "10002579", 14, "91215338", 3, 3, 509m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5058m, new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 229m, 1149m, 1, "10002579", 14, "91215338", 4, 3, 860m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5058m, new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 237m, 329m, 1, "10002579", 14, "91215338", 5, 3, 704m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5058m, new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 69m, 1497m, 1, "10002579", 14, "91215338", 6, 3, 431m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5058m, new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 228m, 179m, 1, "10002579", 14, "91215338", 7, 3, 586m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5058m, new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 433m, 5058m, 1111m, 1, "10002579", 14, "91215338", 8, 3, 100m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4510m, new DateTime(2008, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 192m, 1765m, 3, "10003725", 18, "36794161", 6, 307m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4510m, new DateTime(2008, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 47m, 113m, 3, "10003725", 18, "36794161", 6, 123m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4510m, new DateTime(2008, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 246m, 427m, 3, "10003725", 18, "36794161", 6, 588m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4510m, new DateTime(2008, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 109m, 929m, 3, "10003725", 18, "36794161", 6, 136m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4510m, new DateTime(2008, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 95m, 1309m, 3, "10003725", 18, "36794161", 6, 428m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4510m, new DateTime(2008, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 419m, 4510m, 1526m, 3, "10003725", 18, "36794161", 6, 569m, 2009 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3675m, new DateTime(2011, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 263m, 114m, 3, "10003479", 18, "51331289", 8, 4, 6, 943m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3675m, new DateTime(2011, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 163m, 1584m, 3, "10003479", 18, "51331289", 9, 4, 6, 622m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3675m, new DateTime(2011, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 293m, 1074m, 3, "10003479", 18, "51331289", 10, 4, 6, 187m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3675m, new DateTime(2011, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 139m, 1598m, 3, "10003479", 18, "51331289", 11, 4, 6, 622m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3675m, new DateTime(2011, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 153m, 211m, 3, "10003479", 18, "51331289", 12, 4, 6, 418m, 2011 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3675m, new DateTime(2011, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 284m, 3675m, 744m, 3, "10003479", 18, "51331289", 1, 4, 6, 834m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4205m, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 222m, 455m, 1, "10002409", 14, "34342488", 6, 3, 3, 627m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4205m, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 460m, 328m, 1, "10002409", 14, "34342488", 7, 3, 3, 187m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4205m, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 247m, 667m, 1, "10002409", 14, "34342488", 8, 3, 3, 816m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4205m, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 453m, 586m, 1, "10002409", 14, "34342488", 9, 3, 3, 383m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4205m, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 346m, 1782m, 1, "10002409", 14, "34342488", 10, 3, 3, 725m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4205m, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 337m, 4205m, 717m, 1, "10002409", 14, "34342488", 11, 3, 3, 147m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3778m, new DateTime(2015, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 172m, 935m, 4, "10005261", 11, "69237388", 3, 4, 7, 383m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3778m, new DateTime(2015, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1m, 655m, 4, "10005261", 11, "69237388", 4, 4, 7, 766m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3778m, new DateTime(2015, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 159m, 1711m, 4, "10005261", 11, "69237388", 5, 4, 7, 987m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3778m, new DateTime(2015, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 360m, 1217m, 4, "10005261", 11, "69237388", 6, 4, 7, 381m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3778m, new DateTime(2015, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 363m, 782m, 4, "10005261", 11, "69237388", 7, 4, 7, 290m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3778m, new DateTime(2015, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 265m, 3778m, 1020m, 4, "10005261", 11, "69237388", 8, 4, 7, 99m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4806m, new DateTime(2007, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 419m, 455m, 3, "10007085", 18, "28143537", 1, 4, 6, 207m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4806m, new DateTime(2007, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 211m, 1182m, 3, "10007085", 18, "28143537", 2, 4, 6, 330m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4806m, new DateTime(2007, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 385m, 587m, 3, "10007085", 18, "28143537", 3, 4, 6, 490m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4806m, new DateTime(2007, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 265m, 607m, 3, "10007085", 18, "28143537", 4, 4, 6, 694m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4806m, new DateTime(2007, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 388m, 439m, 3, "10007085", 18, "28143537", 5, 4, 6, 422m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4806m, new DateTime(2007, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 61m, 4806m, 628m, 3, "10007085", 18, "28143537", 6, 4, 6, 732m, 2007 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5025m, new DateTime(2016, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m, 1454m, 2, "10001562", 11, "25669301", 2, 1, 5, 693m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5025m, new DateTime(2016, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 58m, 1686m, 2, "10001562", 11, "25669301", 3, 1, 5, 853m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5025m, new DateTime(2016, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 285m, 471m, 2, "10001562", 11, "25669301", 4, 1, 5, 859m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5025m, new DateTime(2016, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 142m, 1777m, 2, "10001562", 11, "25669301", 5, 1, 5, 591m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5025m, new DateTime(2016, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 191m, 1242m, 2, "10001562", 11, "25669301", 6, 1, 5, 826m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5025m, new DateTime(2016, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 308m, 5025m, 1351m, 2, "10001562", 11, "25669301", 7, 1, 5, 990m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4444m, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 92m, 729m, "10003581", 14, "14781709", 10, 5, 3, 16m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4444m, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 981m, "10003581", 14, "14781709", 11, 5, 3, 538m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4444m, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 462m, 1965m, "10003581", 14, "14781709", 12, 5, 3, 631m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4444m, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 181m, 1737m, "10003581", 14, "14781709", 1, 5, 3, 278m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4444m, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 181m, 763m, "10003581", 14, "14781709", 2, 5, 3, 590m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4444m, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 280m, 4444m, 1370m, "10003581", 14, "14781709", 3, 5, 3, 176m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4395m, new DateTime(2008, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 449m, 358m, 2, "10005454", "81749543", 6, 1, 5, 418m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4395m, new DateTime(2008, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 346m, 1973m, 2, "10005454", "81749543", 7, 1, 5, 747m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4395m, new DateTime(2008, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 303m, 1208m, 2, "10005454", "81749543", 8, 1, 5, 479m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4395m, new DateTime(2008, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 281m, 1314m, 2, "10005454", "81749543", 9, 1, 5, 971m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4395m, new DateTime(2008, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 23m, 392m, 2, "10005454", "81749543", 10, 1, 5, 204m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4395m, new DateTime(2008, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 343m, 4395m, 173m, 2, "10005454", "81749543", 11, 1, 5, 470m, 2008 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5939m, new DateTime(2016, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 295m, 975m, "10003189", "67323539", 12, 3, 20m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5939m, new DateTime(2016, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 372m, 1144m, "10003189", "67323539", 1, 3, 962m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5939m, new DateTime(2016, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 342m, 558m, "10003189", "67323539", 2, 3, 991m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5939m, new DateTime(2016, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 422m, 1856m, "10003189", "67323539", 3, 3, 625m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5939m, new DateTime(2016, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 305m, 1915m, "10003189", "67323539", 4, 3, 37m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 5939m, new DateTime(2016, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 262m, 5939m, 966m, "10003189", "67323539", 5, 3, 722m, 2017 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus" },
                values: new object[] { 3719m, new DateTime(2013, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 1192m, 2, "10003755", 11, "99173770", 6, 5, 215m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus" },
                values: new object[] { 3719m, new DateTime(2013, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 75m, 170m, 2, "10003755", 11, "99173770", 7, 5, 856m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus" },
                values: new object[] { 3719m, new DateTime(2013, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 333m, 997m, 2, "10003755", 11, "99173770", 8, 5, 445m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus" },
                values: new object[] { 3719m, new DateTime(2013, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 226m, 1657m, 2, "10003755", 11, "99173770", 9, 5, 925m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus" },
                values: new object[] { 3719m, new DateTime(2013, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 121m, 1174m, 2, "10003755", 11, "99173770", 10, 5, 225m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "PositionId", "ProductionBonus" },
                values: new object[] { 3719m, new DateTime(2013, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 353m, 3719m, 1208m, 2, "10003755", 11, "99173770", 11, 5, 758m });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5407m, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 318m, 948m, "10003442", 6, "20382292", 11, 6, 2, 855m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5407m, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 107m, 1016m, "10003442", 6, "20382292", 12, 6, 2, 989m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5407m, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 147m, 1238m, "10003442", 6, "20382292", 1, 6, 2, 179m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5407m, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 236m, 842m, "10003442", 6, "20382292", 2, 6, 2, 974m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5407m, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 430m, 520m, "10003442", 6, "20382292", 3, 6, 2, 702m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5407m, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 453m, 5407m, 1810m, "10003442", 6, "20382292", 4, 6, 2, 920m, 2020 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3027m, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 479m, 727m, 1, "10007706", 6, "24938732", 2, 6, 2, 622m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3027m, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 36m, 237m, 1, "10007706", 6, "24938732", 3, 6, 2, 648m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3027m, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 473m, 1234m, 1, "10007706", 6, "24938732", 4, 6, 2, 37m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3027m, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 363m, 481m, 1, "10007706", 6, "24938732", 5, 6, 2, 520m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3027m, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 91m, 355m, 1, "10007706", 6, "24938732", 6, 6, 2, 337m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3027m, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 236m, 3027m, 1767m, 1, "10007706", 6, "24938732", 7, 6, 2, 716m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4717m, new DateTime(2012, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 455m, 249m, 3, "10008818", 18, "94294735", 12, 6, 6, 70m, 2012 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4717m, new DateTime(2012, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 282m, 94m, 3, "10008818", 18, "94294735", 1, 6, 6, 749m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4717m, new DateTime(2012, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 363m, 280m, 3, "10008818", 18, "94294735", 2, 6, 6, 644m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4717m, new DateTime(2012, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 46m, 1963m, 3, "10008818", 18, "94294735", 3, 6, 6, 191m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4717m, new DateTime(2012, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 128m, 1898m, 3, "10008818", 18, "94294735", 4, 6, 6, 871m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4717m, new DateTime(2012, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 331m, 4717m, 503m, 3, "10008818", 18, "94294735", 5, 6, 6, 226m, 2013 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4352m, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 82m, 184m, "10008265", "58250299", 10, 5, 453m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4352m, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 322m, 1943m, "10008265", "58250299", 11, 5, 726m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4352m, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 228m, 1805m, "10008265", "58250299", 12, 5, 240m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4352m, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 152m, 1777m, "10008265", "58250299", 1, 5, 517m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4352m, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7m, 218m, "10008265", "58250299", 2, 5, 720m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 4352m, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 4352m, 1455m, "10008265", "58250299", 3, 5, 296m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5824m, new DateTime(2018, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 217m, 80m, 2, "10007977", 11, "84625247", 1, 6, 5, 660m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5824m, new DateTime(2018, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 44m, 1200m, 2, "10007977", 11, "84625247", 2, 6, 5, 969m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5824m, new DateTime(2018, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 653m, 2, "10007977", 11, "84625247", 3, 6, 5, 439m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5824m, new DateTime(2018, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, 251m, 2, "10007977", 11, "84625247", 4, 6, 5, 400m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5824m, new DateTime(2018, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 322m, 1613m, 2, "10007977", 11, "84625247", 5, 6, 5, 681m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5824m, new DateTime(2018, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 338m, 5824m, 726m, 2, "10007977", 11, "84625247", 6, 6, 5, 894m, 2018 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4125m, new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 480m, 65m, "10001640", 6, "82687804", 11, 5, 2, 868m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4125m, new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 322m, 326m, "10001640", 6, "82687804", 12, 5, 2, 858m, 2015 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4125m, new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 128m, 639m, "10001640", 6, "82687804", 1, 5, 2, 361m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4125m, new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 395m, 1872m, "10001640", 6, "82687804", 2, 5, 2, 876m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4125m, new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 498m, 188m, "10001640", 6, "82687804", 3, 5, 2, 657m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4125m, new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 402m, 4125m, 1961m, "10001640", 6, "82687804", 4, 5, 2, 29m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5048m, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 329m, 1842m, "10001373", 14, "36723428", 7, 5, 3, 647m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5048m, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 421m, 436m, "10001373", 14, "36723428", 8, 5, 3, 178m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5048m, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 1858m, "10001373", 14, "36723428", 9, 5, 3, 989m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5048m, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 413m, 1708m, "10001373", 14, "36723428", 10, 5, 3, 391m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5048m, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 153m, 263m, "10001373", 14, "36723428", 11, 5, 3, 293m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 5048m, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 382m, 5048m, 980m, "10001373", 14, "36723428", 12, 5, 3, 889m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4221m, new DateTime(2014, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 251m, 3m, 4, "10005245", 11, "58451936", 4, 7, 995m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4221m, new DateTime(2014, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 112m, 1823m, 4, "10005245", 11, "58451936", 4, 7, 424m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4221m, new DateTime(2014, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 442m, 689m, 4, "10005245", 11, "58451936", 4, 7, 382m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4221m, new DateTime(2014, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 468m, 1424m, 4, "10005245", 11, "58451936", 4, 7, 76m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4221m, new DateTime(2014, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 454m, 281m, 4, "10005245", 11, "58451936", 4, 7, 968m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4221m, new DateTime(2014, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 306m, 4221m, 1834m, 4, "10005245", 11, "58451936", 4, 7, 827m, 2014 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3670m, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 62m, 16m, 2, "10008940", "76305810", 5, 6, 4, 575m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3670m, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 451m, 1073m, 2, "10008940", "76305810", 6, 6, 4, 954m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3670m, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 388m, 843m, 2, "10008940", "76305810", 7, 6, 4, 829m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3670m, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 454m, 134m, 2, "10008940", "76305810", 8, 6, 4, 240m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3670m, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 145m, 204m, 2, "10008940", "76305810", 9, 6, 4, 942m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 3670m, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 367m, 3670m, 1335m, 2, "10008940", "76305810", 10, 6, 4, 743m, 2019 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4746m, new DateTime(2006, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 215m, 1286m, 2, "10008545", 11, "32045879", 7, 1, 5, 75m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4746m, new DateTime(2006, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 294m, 1393m, 2, "10008545", 11, "32045879", 8, 1, 5, 388m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4746m, new DateTime(2006, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 377m, 1533m, 2, "10008545", 11, "32045879", 9, 1, 5, 237m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4746m, new DateTime(2006, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 287m, 1652m, 2, "10008545", 11, "32045879", 10, 1, 5, 504m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4746m, new DateTime(2006, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 77m, 1417m, 2, "10008545", 11, "32045879", 11, 1, 5, 630m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[] { 4746m, new DateTime(2006, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 486m, 4746m, 1773m, 2, "10008545", 11, "32045879", 12, 1, 5, 534m, 2006 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3146m, new DateTime(2016, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 358m, 1968m, "10004636", "12598583", 8, 5, 540m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3146m, new DateTime(2016, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 228m, 489m, "10004636", "12598583", 9, 5, 954m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3146m, new DateTime(2016, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 78m, 406m, "10004636", "12598583", 10, 5, 853m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3146m, new DateTime(2016, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 302m, 396m, "10004636", "12598583", 11, 5, 152m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3146m, new DateTime(2016, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 83m, 1826m, "10004636", "12598583", 12, 5, 620m, 2016 });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "IdentificationNumber", "Month", "OfficeId", "ProductionBonus", "Year" },
                values: new object[] { 3146m, new DateTime(2016, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 364m, 3146m, 1762m, "10004636", "12598583", 1, 5, 451m, 2017 });
        }
    }
}
