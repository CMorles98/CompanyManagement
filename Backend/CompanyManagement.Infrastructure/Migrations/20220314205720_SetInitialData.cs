using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyManagement.Infrastructure.Migrations
{
    public partial class SetInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DivisionId",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "DivisionName" },
                values: new object[,]
                {
                    { 1, "OPERATION" },
                    { 2, "SALES" },
                    { 3, "MARKETING" },
                    { 4, "CUSTOMER CARE" }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "OfficeName" },
                values: new object[,]
                {
                    { 1, "A" },
                    { 2, "B" },
                    { 3, "C" },
                    { 4, "D" },
                    { 5, "E" },
                    { 6, "F" },
                    { 7, "ZZ" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "DivisionId", "PositionName" },
                values: new object[,]
                {
                    { 1, 1, "CARGO MANAGER" },
                    { 2, 1, "HEAD OF CARGO" },
                    { 3, 1, "CARGO ASSISTANT" },
                    { 4, 2, "SALES MANAGER" },
                    { 5, 2, "ACCOUNT EXECUTIVE" },
                    { 6, 3, "MARKETING ASSISTANT" },
                    { 7, 4, "CUSTOMER DIRECTOR" },
                    { 8, 4, "CUSTOMER ASSISTANT" }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 25, 3425m, new DateTime(2007, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 97m, 0m, 979m, 1, "10005636", "XIMENA LUCIA", "AGREDO", 12, "61105021", 10, 4, 1, 110m, 2007 },
                    { 589, 4746m, new DateTime(2006, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 215m, 0m, 1286m, 2, "10008545", "MARISOL", "JORDAN", 11, "32045879", 7, 1, 5, 75m, 2006 },
                    { 590, 4746m, new DateTime(2006, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 294m, 0m, 1393m, 2, "10008545", "MARISOL", "JORDAN", 11, "32045879", 8, 1, 5, 388m, 2006 },
                    { 591, 4746m, new DateTime(2006, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 377m, 0m, 1533m, 2, "10008545", "MARISOL", "JORDAN", 11, "32045879", 9, 1, 5, 237m, 2006 },
                    { 592, 4746m, new DateTime(2006, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 287m, 0m, 1652m, 2, "10008545", "MARISOL", "JORDAN", 11, "32045879", 10, 1, 5, 504m, 2006 },
                    { 593, 4746m, new DateTime(2006, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 77m, 0m, 1417m, 2, "10008545", "MARISOL", "JORDAN", 11, "32045879", 11, 1, 5, 630m, 2006 },
                    { 594, 4746m, new DateTime(2006, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 486m, 4746m, 1773m, 2, "10008545", "MARISOL", "JORDAN", 11, "32045879", 12, 1, 5, 534m, 2006 },
                    { 564, 5824m, new DateTime(2018, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 338m, 5824m, 726m, 2, "10007977", "DIVER", "GOMEZ", 11, "84625247", 6, 6, 5, 894m, 2018 },
                    { 595, 3146m, new DateTime(2016, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 358m, 0m, 1968m, 2, "10004636", "EDGAR", "JURADO", 11, "12598583", 8, 5, 5, 540m, 2016 },
                    { 597, 3146m, new DateTime(2016, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 78m, 0m, 406m, 2, "10004636", "EDGAR", "JURADO", 11, "12598583", 10, 5, 5, 853m, 2016 },
                    { 598, 3146m, new DateTime(2016, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 302m, 0m, 396m, 2, "10004636", "EDGAR", "JURADO", 11, "12598583", 11, 5, 5, 152m, 2016 },
                    { 599, 3146m, new DateTime(2016, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 83m, 0m, 1826m, 2, "10004636", "EDGAR", "JURADO", 11, "12598583", 12, 5, 5, 620m, 2016 },
                    { 600, 3146m, new DateTime(2016, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 364m, 3146m, 1762m, 2, "10004636", "EDGAR", "JURADO", 11, "12598583", 1, 5, 5, 451m, 2017 },
                    { 49, 4278m, new DateTime(2014, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 104m, 0m, 154m, 3, "10004967", "HENRY", "BASTIDAS", 18, "86612674", 9, 2, 6, 370m, 2014 },
                    { 50, 4278m, new DateTime(2014, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 192m, 0m, 1424m, 3, "10004967", "HENRY", "BASTIDAS", 18, "86612674", 10, 2, 6, 852m, 2014 },
                    { 596, 3146m, new DateTime(2016, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 228m, 0m, 489m, 2, "10004636", "EDGAR", "JURADO", 11, "12598583", 9, 5, 5, 954m, 2016 },
                    { 563, 5824m, new DateTime(2018, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 322m, 0m, 1613m, 2, "10007977", "DIVER", "GOMEZ", 11, "84625247", 5, 6, 5, 681m, 2018 },
                    { 562, 5824m, new DateTime(2018, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, 0m, 251m, 2, "10007977", "DIVER", "GOMEZ", 11, "84625247", 4, 6, 5, 400m, 2018 },
                    { 561, 5824m, new DateTime(2018, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 0m, 653m, 2, "10007977", "DIVER", "GOMEZ", 11, "84625247", 3, 6, 5, 439m, 2018 },
                    { 510, 5025m, new DateTime(2016, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 308m, 5025m, 1351m, 2, "10001562", "CLAUDIA", "HOYOS", 11, "25669301", 7, 1, 5, 990m, 2016 },
                    { 517, 4395m, new DateTime(2008, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 449m, 0m, 358m, 2, "10005454", "OLGA", "HOYOS", 11, "81749543", 6, 1, 5, 418m, 2008 },
                    { 518, 4395m, new DateTime(2008, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 346m, 0m, 1973m, 2, "10005454", "OLGA", "HOYOS", 11, "81749543", 7, 1, 5, 747m, 2008 },
                    { 519, 4395m, new DateTime(2008, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 303m, 0m, 1208m, 2, "10005454", "OLGA", "HOYOS", 11, "81749543", 8, 1, 5, 479m, 2008 },
                    { 520, 4395m, new DateTime(2008, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 281m, 0m, 1314m, 2, "10005454", "OLGA", "HOYOS", 11, "81749543", 9, 1, 5, 971m, 2008 },
                    { 521, 4395m, new DateTime(2008, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 23m, 0m, 392m, 2, "10005454", "OLGA", "HOYOS", 11, "81749543", 10, 1, 5, 204m, 2008 },
                    { 522, 4395m, new DateTime(2008, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 343m, 4395m, 173m, 2, "10005454", "OLGA", "HOYOS", 11, "81749543", 11, 1, 5, 470m, 2008 },
                    { 529, 3719m, new DateTime(2013, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 0m, 1192m, 2, "10003755", "HURIEL", "HURTADO", 11, "99173770", 6, 3, 5, 215m, 2013 },
                    { 530, 3719m, new DateTime(2013, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 75m, 0m, 170m, 2, "10003755", "HURIEL", "HURTADO", 11, "99173770", 7, 3, 5, 856m, 2013 },
                    { 531, 3719m, new DateTime(2013, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 333m, 0m, 997m, 2, "10003755", "HURIEL", "HURTADO", 11, "99173770", 8, 3, 5, 445m, 2013 },
                    { 532, 3719m, new DateTime(2013, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 226m, 0m, 1657m, 2, "10003755", "HURIEL", "HURTADO", 11, "99173770", 9, 3, 5, 925m, 2013 },
                    { 533, 3719m, new DateTime(2013, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 121m, 0m, 1174m, 2, "10003755", "HURIEL", "HURTADO", 11, "99173770", 10, 3, 5, 225m, 2013 },
                    { 534, 3719m, new DateTime(2013, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 353m, 3719m, 1208m, 2, "10003755", "HURIEL", "HURTADO", 11, "99173770", 11, 3, 5, 758m, 2013 },
                    { 559, 5824m, new DateTime(2018, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 217m, 0m, 80m, 2, "10007977", "DIVER", "GOMEZ", 11, "84625247", 1, 6, 5, 660m, 2018 },
                    { 560, 5824m, new DateTime(2018, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 44m, 0m, 1200m, 2, "10007977", "DIVER", "GOMEZ", 11, "84625247", 2, 6, 5, 969m, 2018 },
                    { 51, 4278m, new DateTime(2014, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 32m, 0m, 134m, 3, "10004967", "HENRY", "BASTIDAS", 18, "86612674", 11, 2, 6, 620m, 2014 },
                    { 52, 4278m, new DateTime(2014, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 58m, 0m, 897m, 3, "10004967", "HENRY", "BASTIDAS", 18, "86612674", 12, 2, 6, 408m, 2014 },
                    { 53, 4278m, new DateTime(2014, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 187m, 0m, 917m, 3, "10004967", "HENRY", "BASTIDAS", 18, "86612674", 1, 2, 6, 977m, 2015 },
                    { 54, 4278m, new DateTime(2014, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 144m, 4278m, 132m, 3, "10004967", "HENRY", "BASTIDAS", 18, "86612674", 2, 2, 6, 210m, 2015 },
                    { 302, 3187m, new DateTime(2011, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 88m, 0m, 506m, 3, "10002384", "MILLER", "GARCIA", 18, "25060444", 8, 5, 6, 497m, 2011 },
                    { 303, 3187m, new DateTime(2011, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 39m, 0m, 1608m, 3, "10002384", "MILLER", "GARCIA", 18, "25060444", 9, 5, 6, 494m, 2011 },
                    { 304, 3187m, new DateTime(2011, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 212m, 0m, 744m, 3, "10002384", "MILLER", "GARCIA", 18, "25060444", 10, 5, 6, 669m, 2011 },
                    { 305, 3187m, new DateTime(2011, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 97m, 0m, 1134m, 3, "10002384", "MILLER", "GARCIA", 18, "25060444", 11, 5, 6, 658m, 2011 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 306, 3187m, new DateTime(2011, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 271m, 3187m, 1671m, 3, "10002384", "MILLER", "GARCIA", 18, "25060444", 12, 5, 6, 232m, 2011 },
                    { 307, 3908m, new DateTime(2015, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 292m, 0m, 1974m, 3, "10001956", "ELENA", "GARCIA", 18, "77197446", 4, 1, 6, 108m, 2015 },
                    { 308, 3908m, new DateTime(2015, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m, 0m, 1860m, 3, "10001956", "ELENA", "GARCIA", 18, "77197446", 5, 1, 6, 649m, 2015 },
                    { 309, 3908m, new DateTime(2015, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 467m, 0m, 226m, 3, "10001956", "ELENA", "GARCIA", 18, "77197446", 6, 1, 6, 721m, 2015 },
                    { 310, 3908m, new DateTime(2015, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 83m, 0m, 932m, 3, "10001956", "ELENA", "GARCIA", 18, "77197446", 7, 1, 6, 465m, 2015 },
                    { 311, 3908m, new DateTime(2015, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 440m, 0m, 515m, 3, "10001956", "ELENA", "GARCIA", 18, "77197446", 8, 1, 6, 612m, 2015 },
                    { 312, 3908m, new DateTime(2015, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 259m, 3908m, 621m, 3, "10001956", "ELENA", "GARCIA", 18, "77197446", 9, 1, 6, 298m, 2015 },
                    { 361, 5184m, new DateTime(2016, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 486m, 0m, 624m, 3, "10006029", "LUIS", "GRANADOS", 18, "26373831", 12, 1, 6, 710m, 2016 },
                    { 362, 5184m, new DateTime(2016, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 267m, 0m, 1245m, 3, "10006029", "LUIS", "GRANADOS", 18, "26373831", 1, 1, 6, 653m, 2017 },
                    { 363, 5184m, new DateTime(2016, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 276m, 0m, 1293m, 3, "10006029", "LUIS", "GRANADOS", 18, "26373831", 2, 1, 6, 238m, 2017 },
                    { 364, 5184m, new DateTime(2016, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, 0m, 1285m, 3, "10006029", "LUIS", "GRANADOS", 18, "26373831", 3, 1, 6, 569m, 2017 },
                    { 301, 3187m, new DateTime(2011, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 77m, 0m, 873m, 3, "10002384", "MILLER", "GARCIA", 18, "25060444", 7, 5, 6, 715m, 2011 },
                    { 509, 5025m, new DateTime(2016, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 191m, 0m, 1242m, 2, "10001562", "CLAUDIA", "HOYOS", 11, "25669301", 6, 1, 5, 826m, 2016 },
                    { 252, 3186m, new DateTime(2016, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 433m, 3186m, 30m, 3, "10005200", "GLADYS", "GALINDO", 18, "88454284", 10, 1, 6, 156m, 2016 },
                    { 250, 3186m, new DateTime(2016, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 324m, 0m, 544m, 3, "10005200", "GLADYS", "GALINDO", 18, "88454284", 8, 1, 6, 747m, 2016 },
                    { 133, 5644m, new DateTime(2007, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 173m, 0m, 397m, 3, "10004575", "YAZMIN", "COLLAZOS", 18, "71725134", 12, 4, 6, 952m, 2007 },
                    { 134, 5644m, new DateTime(2007, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 239m, 0m, 36m, 3, "10004575", "YAZMIN", "COLLAZOS", 18, "71725134", 1, 4, 6, 635m, 2008 },
                    { 135, 5644m, new DateTime(2007, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 77m, 0m, 1748m, 3, "10004575", "YAZMIN", "COLLAZOS", 18, "71725134", 2, 4, 6, 618m, 2008 },
                    { 136, 5644m, new DateTime(2007, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8m, 0m, 150m, 3, "10004575", "YAZMIN", "COLLAZOS", 18, "71725134", 3, 4, 6, 167m, 2008 },
                    { 137, 5644m, new DateTime(2007, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 347m, 0m, 1933m, 3, "10004575", "YAZMIN", "COLLAZOS", 18, "71725134", 4, 4, 6, 253m, 2008 },
                    { 138, 5644m, new DateTime(2007, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 5644m, 1040m, 3, "10004575", "YAZMIN", "COLLAZOS", 18, "71725134", 5, 4, 6, 808m, 2008 },
                    { 157, 3503m, new DateTime(2013, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 318m, 0m, 1040m, 3, "10004298", "MARINA", "DIAZ", 18, "54222766", 6, 5, 6, 400m, 2013 },
                    { 158, 3503m, new DateTime(2013, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 49m, 0m, 1209m, 3, "10004298", "MARINA", "DIAZ", 18, "54222766", 7, 5, 6, 393m, 2013 },
                    { 159, 3503m, new DateTime(2013, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 0m, 744m, 3, "10004298", "MARINA", "DIAZ", 18, "54222766", 8, 5, 6, 682m, 2013 },
                    { 160, 3503m, new DateTime(2013, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 215m, 0m, 879m, 3, "10004298", "MARINA", "DIAZ", 18, "54222766", 9, 5, 6, 947m, 2013 },
                    { 161, 3503m, new DateTime(2013, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 422m, 0m, 28m, 3, "10004298", "MARINA", "DIAZ", 18, "54222766", 10, 5, 6, 357m, 2013 },
                    { 162, 3503m, new DateTime(2013, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 496m, 3503m, 825m, 3, "10004298", "MARINA", "DIAZ", 18, "54222766", 11, 5, 6, 141m, 2013 },
                    { 247, 3186m, new DateTime(2016, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 201m, 0m, 1528m, 3, "10005200", "GLADYS", "GALINDO", 18, "88454284", 5, 1, 6, 307m, 2016 },
                    { 248, 3186m, new DateTime(2016, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 353m, 0m, 728m, 3, "10005200", "GLADYS", "GALINDO", 18, "88454284", 6, 1, 6, 519m, 2016 },
                    { 249, 3186m, new DateTime(2016, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 169m, 0m, 898m, 3, "10005200", "GLADYS", "GALINDO", 18, "88454284", 7, 1, 6, 814m, 2016 },
                    { 251, 3186m, new DateTime(2016, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 307m, 0m, 984m, 3, "10005200", "GLADYS", "GALINDO", 18, "88454284", 9, 1, 6, 799m, 2016 },
                    { 365, 5184m, new DateTime(2016, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 442m, 0m, 1527m, 3, "10006029", "LUIS", "GRANADOS", 18, "26373831", 4, 1, 6, 303m, 2017 },
                    { 508, 5025m, new DateTime(2016, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 142m, 0m, 1777m, 2, "10001562", "CLAUDIA", "HOYOS", 11, "25669301", 5, 1, 5, 591m, 2016 },
                    { 506, 5025m, new DateTime(2016, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 58m, 0m, 1686m, 2, "10001562", "CLAUDIA", "HOYOS", 11, "25669301", 3, 1, 5, 853m, 2016 },
                    { 124, 3574m, new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 53m, 0m, 487m, 2, "10002574", "LUCIO", "SANCHEZ", 11, "25266148", 5, 5, 5, 762m, 2007 },
                    { 125, 3574m, new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 277m, 0m, 1157m, 2, "10002574", "LUCIO", "SANCHEZ", 11, "25266148", 6, 5, 5, 917m, 2007 },
                    { 126, 3574m, new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 362m, 3574m, 447m, 2, "10002574", "LUCIO", "SANCHEZ", 11, "25266148", 7, 5, 5, 539m, 2007 },
                    { 127, 3725m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 420m, 0m, 1160m, 2, "10003648", "YANETH", "CEBALLOS", 11, "94066723", 10, 4, 5, 124m, 2009 },
                    { 128, 3725m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 266m, 0m, 105m, 2, "10003648", "YANETH", "CEBALLOS", 11, "94066723", 11, 4, 5, 173m, 2009 },
                    { 129, 3725m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 156m, 0m, 916m, 2, "10003648", "YANETH", "CEBALLOS", 11, "94066723", 12, 4, 5, 887m, 2009 },
                    { 123, 3574m, new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 386m, 0m, 269m, 2, "10002574", "LUCIO", "SANCHEZ", 11, "25266148", 4, 5, 5, 143m, 2007 },
                    { 130, 3725m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 204m, 0m, 1396m, 2, "10003648", "YANETH", "CEBALLOS", 11, "94066723", 1, 4, 5, 0m, 2010 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 132, 3725m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, 3725m, 692m, 2, "10003648", "YANETH", "CEBALLOS", 11, "94066723", 3, 4, 5, 960m, 2010 },
                    { 187, 4238m, new DateTime(2013, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 423m, 0m, 488m, 2, "10008162", "MIRTHA", "ESPINOSA", 11, "48802129", 6, 5, 5, 159m, 2013 },
                    { 188, 4238m, new DateTime(2013, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 54m, 0m, 1007m, 2, "10008162", "MIRTHA", "ESPINOSA", 11, "48802129", 7, 5, 5, 479m, 2013 },
                    { 189, 4238m, new DateTime(2013, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 273m, 0m, 414m, 2, "10008162", "MIRTHA", "ESPINOSA", 11, "48802129", 8, 5, 5, 953m, 2013 },
                    { 190, 4238m, new DateTime(2013, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 313m, 0m, 1565m, 2, "10008162", "MIRTHA", "ESPINOSA", 11, "48802129", 9, 5, 5, 410m, 2013 },
                    { 191, 4238m, new DateTime(2013, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 75m, 0m, 1705m, 2, "10008162", "MIRTHA", "ESPINOSA", 11, "48802129", 10, 5, 5, 308m, 2013 },
                    { 131, 3725m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 210m, 0m, 1533m, 2, "10003648", "YANETH", "CEBALLOS", 11, "94066723", 2, 4, 5, 347m, 2010 },
                    { 122, 3574m, new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 94m, 0m, 215m, 2, "10002574", "LUCIO", "SANCHEZ", 11, "25266148", 3, 5, 5, 414m, 2007 },
                    { 121, 3574m, new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 415m, 0m, 1366m, 2, "10002574", "LUCIO", "SANCHEZ", 11, "25266148", 2, 5, 5, 957m, 2007 },
                    { 108, 4666m, new DateTime(2005, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 215m, 4666m, 249m, 2, "10002365", "ARMANDO", "CALVACHE", 11, "95438503", 1, 4, 5, 319m, 2006 },
                    { 33, 3111m, new DateTime(2015, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 64m, 0m, 1832m, 2, "10005526", "NORA", "AGUDELO DE LOPEZ", 11, "19167180", 5, 3, 5, 947m, 2015 },
                    { 34, 3111m, new DateTime(2015, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 47m, 0m, 842m, 2, "10005526", "NORA", "AGUDELO DE LOPEZ", 11, "19167180", 6, 3, 5, 63m, 2015 },
                    { 35, 3111m, new DateTime(2015, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 420m, 0m, 909m, 2, "10005526", "NORA", "AGUDELO DE LOPEZ", 11, "19167180", 7, 3, 5, 948m, 2015 },
                    { 36, 3111m, new DateTime(2015, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 163m, 3111m, 1569m, 2, "10005526", "NORA", "AGUDELO DE LOPEZ", 11, "19167180", 8, 3, 5, 403m, 2015 },
                    { 91, 5231m, new DateTime(2005, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 154m, 0m, 1027m, 2, "10002897", "ALBERTO", "CALDAS", 11, "42291281", 6, 1, 5, 603m, 2005 },
                    { 92, 5231m, new DateTime(2005, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 415m, 0m, 1571m, 2, "10002897", "ALBERTO", "CALDAS", 11, "42291281", 7, 1, 5, 553m, 2005 },
                    { 93, 5231m, new DateTime(2005, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 84m, 0m, 102m, 2, "10002897", "ALBERTO", "CALDAS", 11, "42291281", 8, 1, 5, 493m, 2005 },
                    { 94, 5231m, new DateTime(2005, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 430m, 0m, 1234m, 2, "10002897", "ALBERTO", "CALDAS", 11, "42291281", 9, 1, 5, 624m, 2005 },
                    { 95, 5231m, new DateTime(2005, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 220m, 0m, 352m, 2, "10002897", "ALBERTO", "CALDAS", 11, "42291281", 10, 1, 5, 158m, 2005 },
                    { 96, 5231m, new DateTime(2005, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 101m, 5231m, 152m, 2, "10002897", "ALBERTO", "CALDAS", 11, "42291281", 11, 1, 5, 514m, 2005 },
                    { 103, 4666m, new DateTime(2005, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 281m, 0m, 1522m, 2, "10002365", "ARMANDO", "CALVACHE", 11, "95438503", 8, 4, 5, 83m, 2005 },
                    { 104, 4666m, new DateTime(2005, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 147m, 0m, 175m, 2, "10002365", "ARMANDO", "CALVACHE", 11, "95438503", 9, 4, 5, 679m, 2005 },
                    { 105, 4666m, new DateTime(2005, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 117m, 0m, 1865m, 2, "10002365", "ARMANDO", "CALVACHE", 11, "95438503", 10, 4, 5, 491m, 2005 },
                    { 106, 4666m, new DateTime(2005, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 366m, 0m, 1100m, 2, "10002365", "ARMANDO", "CALVACHE", 11, "95438503", 11, 4, 5, 455m, 2005 },
                    { 107, 4666m, new DateTime(2005, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 67m, 0m, 1017m, 2, "10002365", "ARMANDO", "CALVACHE", 11, "95438503", 12, 4, 5, 576m, 2005 },
                    { 192, 4238m, new DateTime(2013, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 314m, 4238m, 1124m, 2, "10008162", "MIRTHA", "ESPINOSA", 11, "48802129", 11, 5, 5, 251m, 2013 },
                    { 241, 5496m, new DateTime(2010, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 141m, 0m, 298m, 2, "10006250", "MARY", "LASSO", 11, "42924213", 4, 6, 5, 200m, 2010 },
                    { 242, 5496m, new DateTime(2010, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 61m, 0m, 781m, 2, "10006250", "MARY", "LASSO", 11, "42924213", 5, 6, 5, 262m, 2010 },
                    { 243, 5496m, new DateTime(2010, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 78m, 0m, 457m, 2, "10006250", "MARY", "LASSO", 11, "42924213", 6, 6, 5, 134m, 2010 },
                    { 395, 4254m, new DateTime(2016, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 427m, 0m, 99m, 2, "10003213", "MARIA", "GUERRERO", 11, "34513671", 10, 3, 5, 960m, 2016 },
                    { 396, 4254m, new DateTime(2016, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 448m, 4254m, 349m, 2, "10003213", "MARIA", "GUERRERO", 11, "34513671", 11, 3, 5, 518m, 2016 },
                    { 403, 4830m, new DateTime(2012, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 235m, 0m, 210m, 2, "10005544", "SANDRA", "GUEVARA", 11, "51391058", 10, 1, 5, 557m, 2012 },
                    { 404, 4830m, new DateTime(2012, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5m, 0m, 34m, 2, "10005544", "SANDRA", "GUEVARA", 11, "51391058", 11, 1, 5, 267m, 2012 },
                    { 405, 4830m, new DateTime(2012, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 471m, 0m, 992m, 2, "10005544", "SANDRA", "GUEVARA", 11, "51391058", 12, 1, 5, 972m, 2012 },
                    { 406, 4830m, new DateTime(2012, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 257m, 0m, 1899m, 2, "10005544", "SANDRA", "GUEVARA", 11, "51391058", 1, 1, 5, 199m, 2013 },
                    { 407, 4830m, new DateTime(2012, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 427m, 0m, 1178m, 2, "10005544", "SANDRA", "GUEVARA", 11, "51391058", 2, 1, 5, 915m, 2013 },
                    { 408, 4830m, new DateTime(2012, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 124m, 4830m, 1053m, 2, "10005544", "SANDRA", "GUEVARA", 11, "51391058", 3, 1, 5, 518m, 2013 },
                    { 451, 5624m, new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 326m, 0m, 1546m, 2, "10003719", "IVAN", "HERNADEZ", 11, "35983795", 12, 3, 5, 688m, 2018 },
                    { 452, 5624m, new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 65m, 0m, 616m, 2, "10003719", "IVAN", "HERNADEZ", 11, "35983795", 1, 3, 5, 802m, 2019 },
                    { 453, 5624m, new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 375m, 0m, 1734m, 2, "10003719", "IVAN", "HERNADEZ", 11, "35983795", 2, 3, 5, 169m, 2019 },
                    { 454, 5624m, new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, 0m, 1300m, 2, "10003719", "IVAN", "HERNADEZ", 11, "35983795", 3, 3, 5, 963m, 2019 },
                    { 455, 5624m, new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 471m, 0m, 291m, 2, "10003719", "IVAN", "HERNADEZ", 11, "35983795", 4, 3, 5, 936m, 2019 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 456, 5624m, new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 485m, 5624m, 1191m, 2, "10003719", "IVAN", "HERNADEZ", 11, "35983795", 5, 3, 5, 112m, 2019 },
                    { 505, 5025m, new DateTime(2016, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m, 0m, 1454m, 2, "10001562", "CLAUDIA", "HOYOS", 11, "25669301", 2, 1, 5, 693m, 2016 },
                    { 394, 4254m, new DateTime(2016, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 237m, 0m, 415m, 2, "10003213", "MARIA", "GUERRERO", 11, "34513671", 9, 3, 5, 100m, 2016 },
                    { 507, 5025m, new DateTime(2016, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 285m, 0m, 471m, 2, "10001562", "CLAUDIA", "HOYOS", 11, "25669301", 4, 1, 5, 859m, 2016 },
                    { 393, 4254m, new DateTime(2016, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 227m, 0m, 1254m, 2, "10003213", "MARIA", "GUERRERO", 11, "34513671", 8, 3, 5, 405m, 2016 },
                    { 391, 4254m, new DateTime(2016, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 128m, 0m, 1162m, 2, "10003213", "MARIA", "GUERRERO", 11, "34513671", 6, 3, 5, 260m, 2016 },
                    { 244, 5496m, new DateTime(2010, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 151m, 0m, 1627m, 2, "10006250", "MARY", "LASSO", 11, "42924213", 7, 6, 5, 234m, 2010 },
                    { 245, 5496m, new DateTime(2010, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 497m, 0m, 984m, 2, "10006250", "MARY", "LASSO", 11, "42924213", 8, 6, 5, 453m, 2010 },
                    { 246, 5496m, new DateTime(2010, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 60m, 5496m, 92m, 2, "10006250", "MARY", "LASSO", 11, "42924213", 9, 6, 5, 701m, 2010 },
                    { 259, 3700m, new DateTime(2006, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 219m, 0m, 769m, 2, "10004461", "JOSE", "GALLO", 11, "19141500", 3, 6, 5, 280m, 2006 },
                    { 260, 3700m, new DateTime(2006, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 342m, 0m, 1831m, 2, "10004461", "JOSE", "GALLO", 11, "19141500", 4, 6, 5, 420m, 2006 },
                    { 261, 3700m, new DateTime(2006, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 273m, 0m, 1693m, 2, "10004461", "JOSE", "GALLO", 11, "19141500", 5, 6, 5, 551m, 2006 },
                    { 262, 3700m, new DateTime(2006, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 379m, 0m, 100m, 2, "10004461", "JOSE", "GALLO", 11, "19141500", 6, 6, 5, 499m, 2006 },
                    { 263, 3700m, new DateTime(2006, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 265m, 0m, 735m, 2, "10004461", "JOSE", "GALLO", 11, "19141500", 7, 6, 5, 829m, 2006 },
                    { 264, 3700m, new DateTime(2006, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 312m, 3700m, 1156m, 2, "10004461", "JOSE", "GALLO", 11, "19141500", 8, 6, 5, 394m, 2006 },
                    { 379, 3330m, new DateTime(2007, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 142m, 0m, 1881m, 2, "10004781", "LESLIE", "GUEVARA", 11, "32030803", 8, 5, 5, 859m, 2007 },
                    { 380, 3330m, new DateTime(2007, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 468m, 0m, 215m, 2, "10004781", "LESLIE", "GUEVARA", 11, "32030803", 9, 5, 5, 154m, 2007 },
                    { 381, 3330m, new DateTime(2007, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 294m, 0m, 998m, 2, "10004781", "LESLIE", "GUEVARA", 11, "32030803", 10, 5, 5, 800m, 2007 },
                    { 382, 3330m, new DateTime(2007, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 188m, 0m, 1901m, 2, "10004781", "LESLIE", "GUEVARA", 11, "32030803", 11, 5, 5, 86m, 2007 },
                    { 383, 3330m, new DateTime(2007, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 107m, 0m, 1344m, 2, "10004781", "LESLIE", "GUEVARA", 11, "32030803", 12, 5, 5, 808m, 2007 },
                    { 384, 3330m, new DateTime(2007, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 308m, 3330m, 891m, 2, "10004781", "LESLIE", "GUEVARA", 11, "32030803", 1, 5, 5, 703m, 2008 },
                    { 392, 4254m, new DateTime(2016, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 134m, 0m, 1497m, 2, "10003213", "MARIA", "GUERRERO", 11, "34513671", 7, 3, 5, 443m, 2016 },
                    { 32, 3111m, new DateTime(2015, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 0m, 667m, 2, "10005526", "NORA", "AGUDELO DE LOPEZ", 11, "19167180", 4, 3, 5, 743m, 2015 },
                    { 366, 5184m, new DateTime(2016, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 416m, 5184m, 1145m, 3, "10006029", "LUIS", "GRANADOS", 18, "26373831", 5, 1, 6, 525m, 2017 },
                    { 422, 5820m, new DateTime(2007, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 402m, 0m, 1483m, 3, "10008725", "ORLANDO", "GUTIERREZ", 18, "60265035", 4, 3, 6, 247m, 2007 },
                    { 175, 5282m, new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 427m, 0m, 1187m, 4, "10003106", "JAIME", "ESCOBAR", 11, "26476491", 1, 6, 7, 20m, 2015 },
                    { 176, 5282m, new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2m, 0m, 160m, 4, "10003106", "JAIME", "ESCOBAR", 11, "26476491", 2, 6, 7, 845m, 2015 },
                    { 177, 5282m, new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 93m, 0m, 1894m, 4, "10003106", "JAIME", "ESCOBAR", 11, "26476491", 3, 6, 7, 36m, 2015 },
                    { 178, 5282m, new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4m, 0m, 1355m, 4, "10003106", "JAIME", "ESCOBAR", 11, "26476491", 4, 6, 7, 296m, 2015 },
                    { 179, 5282m, new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 218m, 0m, 185m, 4, "10003106", "JAIME", "ESCOBAR", 11, "26476491", 5, 6, 7, 849m, 2015 },
                    { 180, 5282m, new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 372m, 5282m, 1751m, 4, "10003106", "JAIME", "ESCOBAR", 11, "26476491", 6, 6, 7, 51m, 2015 },
                    { 174, 3887m, new DateTime(2011, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 61m, 3887m, 1052m, 4, "10008161", "MAURO", "EGAS", 11, "15902278", 12, 4, 7, 830m, 2011 },
                    { 193, 5368m, new DateTime(2014, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 225m, 0m, 1313m, 4, "10004725", "ROBERTH", "EUSCATEGUI", 11, "58324334", 11, 5, 7, 88m, 2014 },
                    { 195, 5368m, new DateTime(2014, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 432m, 0m, 1936m, 4, "10004725", "ROBERTH", "EUSCATEGUI", 11, "58324334", 1, 5, 7, 107m, 2015 },
                    { 196, 5368m, new DateTime(2014, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 88m, 0m, 1878m, 4, "10004725", "ROBERTH", "EUSCATEGUI", 11, "58324334", 2, 5, 7, 811m, 2015 },
                    { 197, 5368m, new DateTime(2014, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 319m, 0m, 1579m, 4, "10004725", "ROBERTH", "EUSCATEGUI", 11, "58324334", 3, 5, 7, 904m, 2015 },
                    { 198, 5368m, new DateTime(2014, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 441m, 5368m, 1449m, 4, "10004725", "ROBERTH", "EUSCATEGUI", 11, "58324334", 4, 5, 7, 95m, 2015 },
                    { 229, 4365m, new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 398m, 0m, 1852m, 4, "10005577", "LIZARDO", "FERNANDEZ", 11, "69038969", 1, 1, 7, 769m, 2016 },
                    { 230, 4365m, new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 195m, 0m, 1160m, 4, "10005577", "LIZARDO", "FERNANDEZ", 11, "69038969", 2, 1, 7, 28m, 2016 },
                    { 194, 5368m, new DateTime(2014, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, 0m, 409m, 4, "10004725", "ROBERTH", "EUSCATEGUI", 11, "58324334", 12, 5, 7, 568m, 2014 },
                    { 173, 3887m, new DateTime(2011, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 405m, 0m, 1512m, 4, "10008161", "MAURO", "EGAS", 11, "15902278", 11, 4, 7, 465m, 2011 },
                    { 172, 3887m, new DateTime(2011, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 76m, 0m, 1290m, 4, "10008161", "MAURO", "EGAS", 11, "15902278", 10, 4, 7, 525m, 2011 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 171, 3887m, new DateTime(2011, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 396m, 0m, 228m, 4, "10008161", "MAURO", "EGAS", 11, "15902278", 9, 4, 7, 801m, 2011 },
                    { 114, 5008m, new DateTime(2007, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 5008m, 971m, 4, "10001306", "GUILLERMO", "CASTRO", 11, "59374796", 3, 4, 7, 439m, 2008 },
                    { 139, 3091m, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 349m, 0m, 1313m, 4, "10006148", "FERNANDO", "DELGADO", 11, "56586894", 12, 4, 7, 183m, 2018 },
                    { 140, 3091m, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 286m, 0m, 1922m, 4, "10006148", "FERNANDO", "DELGADO", 11, "56586894", 1, 4, 7, 678m, 2019 },
                    { 141, 3091m, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 139m, 0m, 1513m, 4, "10006148", "FERNANDO", "DELGADO", 11, "56586894", 2, 4, 7, 782m, 2019 },
                    { 142, 3091m, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 473m, 0m, 1825m, 4, "10006148", "FERNANDO", "DELGADO", 11, "56586894", 3, 4, 7, 425m, 2019 },
                    { 143, 3091m, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 489m, 0m, 1120m, 4, "10006148", "FERNANDO", "DELGADO", 11, "56586894", 4, 4, 7, 580m, 2019 },
                    { 144, 3091m, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 53m, 3091m, 1962m, 4, "10006148", "FERNANDO", "DELGADO", 11, "56586894", 5, 4, 7, 166m, 2019 },
                    { 151, 4050m, new DateTime(2012, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 0m, 523m, 4, "10005438", "MARINA", "DIAGO", 11, "15070606", 8, 5, 7, 686m, 2012 },
                    { 152, 4050m, new DateTime(2012, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 391m, 0m, 1477m, 4, "10005438", "MARINA", "DIAGO", 11, "15070606", 9, 5, 7, 616m, 2012 },
                    { 153, 4050m, new DateTime(2012, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 245m, 0m, 1982m, 4, "10005438", "MARINA", "DIAGO", 11, "15070606", 10, 5, 7, 626m, 2012 },
                    { 154, 4050m, new DateTime(2012, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 149m, 0m, 1399m, 4, "10005438", "MARINA", "DIAGO", 11, "15070606", 11, 5, 7, 951m, 2012 },
                    { 155, 4050m, new DateTime(2012, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 58m, 0m, 441m, 4, "10005438", "MARINA", "DIAGO", 11, "15070606", 12, 5, 7, 116m, 2012 },
                    { 156, 4050m, new DateTime(2012, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 207m, 4050m, 1205m, 4, "10005438", "MARINA", "DIAGO", 11, "15070606", 1, 5, 7, 590m, 2013 },
                    { 169, 3887m, new DateTime(2011, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 34m, 0m, 289m, 4, "10008161", "MAURO", "EGAS", 11, "15902278", 7, 4, 7, 314m, 2011 },
                    { 170, 3887m, new DateTime(2011, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 132m, 0m, 1336m, 4, "10008161", "MAURO", "EGAS", 11, "15902278", 8, 4, 7, 839m, 2011 },
                    { 231, 4365m, new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 297m, 0m, 395m, 4, "10005577", "LIZARDO", "FERNANDEZ", 11, "69038969", 3, 1, 7, 392m, 2016 },
                    { 232, 4365m, new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 104m, 0m, 1930m, 4, "10005577", "LIZARDO", "FERNANDEZ", 11, "69038969", 4, 1, 7, 545m, 2016 },
                    { 233, 4365m, new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 214m, 0m, 154m, 4, "10005577", "LIZARDO", "FERNANDEZ", 11, "69038969", 5, 1, 7, 73m, 2016 },
                    { 234, 4365m, new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 74m, 4365m, 308m, 4, "10005577", "LIZARDO", "FERNANDEZ", 11, "69038969", 6, 1, 7, 95m, 2016 },
                    { 458, 5046m, new DateTime(2009, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 458m, 0m, 1911m, 4, "10003211", "MYRIAM", "HERNANDEZ", 11, "88326119", 6, 1, 7, 69m, 2009 },
                    { 459, 5046m, new DateTime(2009, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 330m, 0m, 950m, 4, "10003211", "MYRIAM", "HERNANDEZ", 11, "88326119", 7, 1, 7, 733m, 2009 },
                    { 460, 5046m, new DateTime(2009, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 108m, 0m, 1962m, 4, "10003211", "MYRIAM", "HERNANDEZ", 11, "88326119", 8, 1, 7, 465m, 2009 },
                    { 461, 5046m, new DateTime(2009, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5m, 0m, 1626m, 4, "10003211", "MYRIAM", "HERNANDEZ", 11, "88326119", 9, 1, 7, 431m, 2009 },
                    { 462, 5046m, new DateTime(2009, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 301m, 5046m, 281m, 4, "10003211", "MYRIAM", "HERNANDEZ", 11, "88326119", 10, 1, 7, 36m, 2009 },
                    { 493, 3778m, new DateTime(2015, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 172m, 0m, 935m, 4, "10005261", "GEOVANNY", "HINCAPIE", 11, "69237388", 3, 4, 7, 383m, 2015 },
                    { 494, 3778m, new DateTime(2015, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1m, 0m, 655m, 4, "10005261", "GEOVANNY", "HINCAPIE", 11, "69237388", 4, 4, 7, 766m, 2015 },
                    { 495, 3778m, new DateTime(2015, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 159m, 0m, 1711m, 4, "10005261", "GEOVANNY", "HINCAPIE", 11, "69237388", 5, 4, 7, 987m, 2015 },
                    { 496, 3778m, new DateTime(2015, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 360m, 0m, 1217m, 4, "10005261", "GEOVANNY", "HINCAPIE", 11, "69237388", 6, 4, 7, 381m, 2015 },
                    { 497, 3778m, new DateTime(2015, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 363m, 0m, 782m, 4, "10005261", "GEOVANNY", "HINCAPIE", 11, "69237388", 7, 4, 7, 290m, 2015 },
                    { 498, 3778m, new DateTime(2015, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 265m, 3778m, 1020m, 4, "10005261", "GEOVANNY", "HINCAPIE", 11, "69237388", 8, 4, 7, 99m, 2015 },
                    { 577, 4221m, new DateTime(2014, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 251m, 0m, 3m, 4, "10005245", "TOMAS", "JARAMILLO", 11, "58451936", 4, 4, 7, 995m, 2014 },
                    { 578, 4221m, new DateTime(2014, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 112m, 0m, 1823m, 4, "10005245", "TOMAS", "JARAMILLO", 11, "58451936", 5, 4, 7, 424m, 2014 },
                    { 579, 4221m, new DateTime(2014, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 442m, 0m, 689m, 4, "10005245", "TOMAS", "JARAMILLO", 11, "58451936", 6, 4, 7, 382m, 2014 },
                    { 580, 4221m, new DateTime(2014, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 468m, 0m, 1424m, 4, "10005245", "TOMAS", "JARAMILLO", 11, "58451936", 7, 4, 7, 76m, 2014 },
                    { 457, 5046m, new DateTime(2009, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 483m, 0m, 39m, 4, "10003211", "MYRIAM", "HERNANDEZ", 11, "88326119", 5, 1, 7, 17m, 2009 },
                    { 113, 5008m, new DateTime(2007, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482m, 0m, 1786m, 4, "10001306", "GUILLERMO", "CASTRO", 11, "59374796", 2, 4, 7, 422m, 2008 },
                    { 438, 5761m, new DateTime(2007, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 431m, 5761m, 1403m, 4, "10007004", "SONIA", "GUZMAN", 11, "28631384", 11, 5, 7, 522m, 2007 },
                    { 436, 5761m, new DateTime(2007, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 339m, 0m, 836m, 4, "10007004", "SONIA", "GUZMAN", 11, "28631384", 9, 5, 7, 200m, 2007 },
                    { 277, 3587m, new DateTime(2017, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 199m, 0m, 902m, 4, "10007411", "ENRIQUE", "GARCES", 11, "37357628", 10, 1, 7, 467m, 2017 },
                    { 278, 3587m, new DateTime(2017, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 85m, 0m, 1354m, 4, "10007411", "ENRIQUE", "GARCES", 11, "37357628", 11, 1, 7, 525m, 2017 },
                    { 279, 3587m, new DateTime(2017, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 219m, 0m, 1089m, 4, "10007411", "ENRIQUE", "GARCES", 11, "37357628", 12, 1, 7, 670m, 2017 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 280, 3587m, new DateTime(2017, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 474m, 0m, 851m, 4, "10007411", "ENRIQUE", "GARCES", 11, "37357628", 1, 1, 7, 527m, 2018 },
                    { 281, 3587m, new DateTime(2017, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 73m, 0m, 124m, 4, "10007411", "ENRIQUE", "GARCES", 11, "37357628", 2, 1, 7, 767m, 2018 },
                    { 282, 3587m, new DateTime(2017, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 89m, 3587m, 1893m, 4, "10007411", "ENRIQUE", "GARCES", 11, "37357628", 3, 1, 7, 566m, 2018 },
                    { 289, 3484m, new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 227m, 0m, 695m, 4, "10006585", "DE SANCHEZ YOLANDA", "GARCIA", 11, "36663754", 7, 3, 7, 880m, 2017 },
                    { 290, 3484m, new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 381m, 0m, 1467m, 4, "10006585", "DE SANCHEZ YOLANDA", "GARCIA", 11, "36663754", 8, 3, 7, 581m, 2017 },
                    { 291, 3484m, new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 368m, 0m, 1658m, 4, "10006585", "DE SANCHEZ YOLANDA", "GARCIA", 11, "36663754", 9, 3, 7, 623m, 2017 },
                    { 292, 3484m, new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 408m, 0m, 1685m, 4, "10006585", "DE SANCHEZ YOLANDA", "GARCIA", 11, "36663754", 10, 3, 7, 469m, 2017 },
                    { 293, 3484m, new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 289m, 0m, 1761m, 4, "10006585", "DE SANCHEZ YOLANDA", "GARCIA", 11, "36663754", 11, 3, 7, 680m, 2017 },
                    { 294, 3484m, new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 493m, 3484m, 21m, 4, "10006585", "DE SANCHEZ YOLANDA", "GARCIA", 11, "36663754", 12, 3, 7, 858m, 2017 },
                    { 433, 5761m, new DateTime(2007, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 149m, 0m, 366m, 4, "10007004", "SONIA", "GUZMAN", 11, "28631384", 6, 5, 7, 875m, 2007 },
                    { 434, 5761m, new DateTime(2007, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 210m, 0m, 1478m, 4, "10007004", "SONIA", "GUZMAN", 11, "28631384", 7, 5, 7, 932m, 2007 },
                    { 435, 5761m, new DateTime(2007, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 396m, 0m, 1674m, 4, "10007004", "SONIA", "GUZMAN", 11, "28631384", 8, 5, 7, 381m, 2007 },
                    { 437, 5761m, new DateTime(2007, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 116m, 0m, 948m, 4, "10007004", "SONIA", "GUZMAN", 11, "28631384", 10, 5, 7, 943m, 2007 },
                    { 421, 5820m, new DateTime(2007, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 480m, 0m, 593m, 3, "10008725", "ORLANDO", "GUTIERREZ", 18, "60265035", 3, 3, 6, 862m, 2007 },
                    { 112, 5008m, new DateTime(2007, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 363m, 0m, 1098m, 4, "10001306", "GUILLERMO", "CASTRO", 11, "59374796", 1, 4, 7, 106m, 2008 },
                    { 110, 5008m, new DateTime(2007, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 436m, 0m, 1314m, 4, "10001306", "GUILLERMO", "CASTRO", 11, "59374796", 11, 4, 7, 651m, 2007 },
                    { 484, 3675m, new DateTime(2011, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 139m, 0m, 1598m, 3, "10003479", "LUZ", "HERRERA", 18, "51331289", 11, 4, 6, 622m, 2011 },
                    { 485, 3675m, new DateTime(2011, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 153m, 0m, 211m, 3, "10003479", "LUZ", "HERRERA", 18, "51331289", 12, 4, 6, 418m, 2011 },
                    { 486, 3675m, new DateTime(2011, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 284m, 3675m, 744m, 3, "10003479", "LUZ", "HERRERA", 18, "51331289", 1, 4, 6, 834m, 2012 },
                    { 499, 4806m, new DateTime(2007, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 419m, 0m, 455m, 3, "10007085", "LUIS", "HOYOS", 18, "28143537", 1, 4, 6, 207m, 2007 },
                    { 500, 4806m, new DateTime(2007, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 211m, 0m, 1182m, 3, "10007085", "LUIS", "HOYOS", 18, "28143537", 2, 4, 6, 330m, 2007 },
                    { 501, 4806m, new DateTime(2007, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 385m, 0m, 587m, 3, "10007085", "LUIS", "HOYOS", 18, "28143537", 3, 4, 6, 490m, 2007 },
                    { 483, 3675m, new DateTime(2011, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 293m, 0m, 1074m, 3, "10003479", "LUZ", "HERRERA", 18, "51331289", 10, 4, 6, 187m, 2011 },
                    { 502, 4806m, new DateTime(2007, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 265m, 0m, 607m, 3, "10007085", "LUIS", "HOYOS", 18, "28143537", 4, 4, 6, 694m, 2007 },
                    { 504, 4806m, new DateTime(2007, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 61m, 4806m, 628m, 3, "10007085", "LUIS", "HOYOS", 18, "28143537", 6, 4, 6, 732m, 2007 },
                    { 547, 4717m, new DateTime(2012, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 455m, 0m, 249m, 3, "10008818", "MARY", "IDROBO", 18, "94294735", 12, 6, 6, 70m, 2012 },
                    { 548, 4717m, new DateTime(2012, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 282m, 0m, 94m, 3, "10008818", "MARY", "IDROBO", 18, "94294735", 1, 6, 6, 749m, 2013 },
                    { 549, 4717m, new DateTime(2012, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 363m, 0m, 280m, 3, "10008818", "MARY", "IDROBO", 18, "94294735", 2, 6, 6, 644m, 2013 },
                    { 550, 4717m, new DateTime(2012, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 46m, 0m, 1963m, 3, "10008818", "MARY", "IDROBO", 18, "94294735", 3, 6, 6, 191m, 2013 },
                    { 551, 4717m, new DateTime(2012, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 128m, 0m, 1898m, 3, "10008818", "MARY", "IDROBO", 18, "94294735", 4, 6, 6, 871m, 2013 },
                    { 503, 4806m, new DateTime(2007, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 388m, 0m, 439m, 3, "10007085", "LUIS", "HOYOS", 18, "28143537", 5, 4, 6, 422m, 2007 },
                    { 482, 3675m, new DateTime(2011, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 163m, 0m, 1584m, 3, "10003479", "LUZ", "HERRERA", 18, "51331289", 9, 4, 6, 622m, 2011 },
                    { 481, 3675m, new DateTime(2011, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 263m, 0m, 114m, 3, "10003479", "LUZ", "HERRERA", 18, "51331289", 8, 4, 6, 943m, 2011 },
                    { 480, 4510m, new DateTime(2008, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 419m, 4510m, 1526m, 3, "10003725", "MANUEL", "HERRERA", 18, "36794161", 1, 4, 6, 569m, 2009 },
                    { 423, 5820m, new DateTime(2007, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 0m, 1699m, 3, "10008725", "ORLANDO", "GUTIERREZ", 18, "60265035", 5, 3, 6, 744m, 2007 },
                    { 424, 5820m, new DateTime(2007, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 205m, 0m, 766m, 3, "10008725", "ORLANDO", "GUTIERREZ", 18, "60265035", 6, 3, 6, 57m, 2007 },
                    { 425, 5820m, new DateTime(2007, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 192m, 0m, 1494m, 3, "10008725", "ORLANDO", "GUTIERREZ", 18, "60265035", 7, 3, 6, 327m, 2007 },
                    { 426, 5820m, new DateTime(2007, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 254m, 5820m, 1859m, 3, "10008725", "ORLANDO", "GUTIERREZ", 18, "60265035", 8, 3, 6, 979m, 2007 },
                    { 427, 5469m, new DateTime(2009, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 56m, 0m, 1048m, 3, "10007212", "TERESA", "GUZMAN", 18, "79704219", 7, 5, 6, 296m, 2009 },
                    { 428, 5469m, new DateTime(2009, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 167m, 0m, 107m, 3, "10007212", "TERESA", "GUZMAN", 18, "79704219", 8, 5, 6, 237m, 2009 },
                    { 429, 5469m, new DateTime(2009, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 217m, 0m, 1194m, 3, "10007212", "TERESA", "GUZMAN", 18, "79704219", 9, 5, 6, 920m, 2009 },
                    { 430, 5469m, new DateTime(2009, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 275m, 0m, 179m, 3, "10007212", "TERESA", "GUZMAN", 18, "79704219", 10, 5, 6, 831m, 2009 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 431, 5469m, new DateTime(2009, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 185m, 0m, 324m, 3, "10007212", "TERESA", "GUZMAN", 18, "79704219", 11, 5, 6, 298m, 2009 },
                    { 432, 5469m, new DateTime(2009, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 193m, 5469m, 243m, 3, "10007212", "TERESA", "GUZMAN", 18, "79704219", 12, 5, 6, 787m, 2009 },
                    { 475, 4510m, new DateTime(2008, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 192m, 0m, 1765m, 3, "10003725", "MANUEL", "HERRERA", 18, "36794161", 8, 4, 6, 307m, 2008 },
                    { 476, 4510m, new DateTime(2008, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 47m, 0m, 113m, 3, "10003725", "MANUEL", "HERRERA", 18, "36794161", 9, 4, 6, 123m, 2008 },
                    { 477, 4510m, new DateTime(2008, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 246m, 0m, 427m, 3, "10003725", "MANUEL", "HERRERA", 18, "36794161", 10, 4, 6, 588m, 2008 },
                    { 478, 4510m, new DateTime(2008, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 109m, 0m, 929m, 3, "10003725", "MANUEL", "HERRERA", 18, "36794161", 11, 4, 6, 136m, 2008 },
                    { 479, 4510m, new DateTime(2008, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 95m, 0m, 1309m, 3, "10003725", "MANUEL", "HERRERA", 18, "36794161", 12, 4, 6, 428m, 2008 },
                    { 552, 4717m, new DateTime(2012, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 331m, 4717m, 503m, 3, "10008818", "MARY", "IDROBO", 18, "94294735", 5, 6, 6, 226m, 2013 },
                    { 1, 5121m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 125m, 0m, 975m, 4, "10004509", "WILLIAM", "ABELLA", 11, "88531280", 10, 2, 7, 856m, 2008 },
                    { 2, 5121m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 135m, 0m, 182m, 4, "10004509", "WILLIAM", "ABELLA", 11, "88531280", 11, 2, 7, 239m, 2008 },
                    { 3, 5121m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 83m, 0m, 1892m, 4, "10004509", "WILLIAM", "ABELLA", 11, "88531280", 12, 2, 7, 92m, 2008 },
                    { 47, 5262m, new DateTime(2013, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 195m, 0m, 1440m, 4, "10008983", "LUIS", "BARRETO", 11, "40592118", 5, 6, 7, 623m, 2013 },
                    { 48, 5262m, new DateTime(2013, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 280m, 5262m, 669m, 4, "10008983", "LUIS", "BARRETO", 11, "40592118", 6, 6, 7, 427m, 2013 },
                    { 55, 4555m, new DateTime(2008, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 315m, 0m, 327m, 4, "10007971", "CLARA", "BECERRA", 11, "74928094", 4, 2, 7, 28m, 2008 },
                    { 56, 4555m, new DateTime(2008, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 430m, 0m, 185m, 4, "10007971", "CLARA", "BECERRA", 11, "74928094", 5, 2, 7, 895m, 2008 },
                    { 57, 4555m, new DateTime(2008, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 169m, 0m, 583m, 4, "10007971", "CLARA", "BECERRA", 11, "74928094", 6, 2, 7, 871m, 2008 },
                    { 58, 4555m, new DateTime(2008, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 468m, 0m, 544m, 4, "10007971", "CLARA", "BECERRA", 11, "74928094", 7, 2, 7, 264m, 2008 },
                    { 59, 4555m, new DateTime(2008, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 244m, 0m, 1918m, 4, "10007971", "CLARA", "BECERRA", 11, "74928094", 8, 2, 7, 462m, 2008 },
                    { 60, 4555m, new DateTime(2008, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 121m, 4555m, 1617m, 4, "10007971", "CLARA", "BECERRA", 11, "74928094", 9, 2, 7, 924m, 2008 },
                    { 85, 3667m, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 370m, 0m, 1727m, 4, "10004843", "JESUS", "CALAMBAS", 11, "40424134", 4, 1, 7, 886m, 2019 },
                    { 86, 3667m, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 452m, 0m, 162m, 4, "10004843", "JESUS", "CALAMBAS", 11, "40424134", 5, 1, 7, 871m, 2019 },
                    { 87, 3667m, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 447m, 0m, 867m, 4, "10004843", "JESUS", "CALAMBAS", 11, "40424134", 6, 1, 7, 86m, 2019 },
                    { 88, 3667m, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 247m, 0m, 546m, 4, "10004843", "JESUS", "CALAMBAS", 11, "40424134", 7, 1, 7, 469m, 2019 },
                    { 89, 3667m, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 87m, 0m, 1019m, 4, "10004843", "JESUS", "CALAMBAS", 11, "40424134", 8, 1, 7, 68m, 2019 },
                    { 90, 3667m, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 135m, 3667m, 1067m, 4, "10004843", "JESUS", "CALAMBAS", 11, "40424134", 9, 1, 7, 48m, 2019 },
                    { 109, 5008m, new DateTime(2007, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 465m, 0m, 660m, 4, "10001306", "GUILLERMO", "CASTRO", 11, "59374796", 10, 4, 7, 12m, 2007 },
                    { 46, 5262m, new DateTime(2013, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 73m, 0m, 1125m, 4, "10008983", "LUIS", "BARRETO", 11, "40592118", 4, 6, 7, 137m, 2013 },
                    { 111, 5008m, new DateTime(2007, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 327m, 0m, 234m, 4, "10001306", "GUILLERMO", "CASTRO", 11, "59374796", 12, 4, 7, 470m, 2007 },
                    { 45, 5262m, new DateTime(2013, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 309m, 0m, 1821m, 4, "10008983", "LUIS", "BARRETO", 11, "40592118", 3, 6, 7, 615m, 2013 },
                    { 43, 5262m, new DateTime(2013, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 206m, 0m, 1928m, 4, "10008983", "LUIS", "BARRETO", 11, "40592118", 1, 6, 7, 891m, 2013 },
                    { 4, 5121m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 159m, 0m, 525m, 4, "10004509", "WILLIAM", "ABELLA", 11, "88531280", 1, 2, 7, 156m, 2009 },
                    { 5, 5121m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 478m, 0m, 114m, 4, "10004509", "WILLIAM", "ABELLA", 11, "88531280", 2, 2, 7, 350m, 2009 },
                    { 6, 5121m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 44m, 5121m, 719m, 4, "10004509", "WILLIAM", "ABELLA", 11, "88531280", 3, 2, 7, 688m, 2009 },
                    { 7, 5518m, new DateTime(2017, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 293m, 0m, 1462m, 4, "10005757", "JOSE", "ACOSTA", 11, "94118897", 11, 5, 7, 998m, 2017 },
                    { 8, 5518m, new DateTime(2017, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 112m, 0m, 1126m, 4, "10005757", "JOSE", "ACOSTA", 11, "94118897", 12, 5, 7, 393m, 2017 },
                    { 9, 5518m, new DateTime(2017, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 0m, 1908m, 4, "10005757", "JOSE", "ACOSTA", 11, "94118897", 1, 5, 7, 724m, 2018 },
                    { 10, 5518m, new DateTime(2017, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 195m, 0m, 1813m, 4, "10005757", "JOSE", "ACOSTA", 11, "94118897", 2, 5, 7, 447m, 2018 },
                    { 11, 5518m, new DateTime(2017, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 208m, 0m, 364m, 4, "10005757", "JOSE", "ACOSTA", 11, "94118897", 3, 5, 7, 227m, 2018 },
                    { 12, 5518m, new DateTime(2017, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 420m, 5518m, 104m, 4, "10005757", "JOSE", "ACOSTA", 11, "94118897", 4, 5, 7, 414m, 2018 },
                    { 37, 4196m, new DateTime(2007, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 101m, 0m, 873m, 4, "10005277", "JESUS", "BARRAGAN", 11, "39735895", 5, 6, 7, 322m, 2007 },
                    { 38, 4196m, new DateTime(2007, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 67m, 0m, 430m, 4, "10005277", "JESUS", "BARRAGAN", 11, "39735895", 6, 6, 7, 282m, 2007 },
                    { 39, 4196m, new DateTime(2007, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 243m, 0m, 596m, 4, "10005277", "JESUS", "BARRAGAN", 11, "39735895", 7, 6, 7, 229m, 2007 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 40, 4196m, new DateTime(2007, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 479m, 0m, 1804m, 4, "10005277", "JESUS", "BARRAGAN", 11, "39735895", 8, 6, 7, 178m, 2007 },
                    { 41, 4196m, new DateTime(2007, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 313m, 0m, 281m, 4, "10005277", "JESUS", "BARRAGAN", 11, "39735895", 9, 6, 7, 282m, 2007 },
                    { 42, 4196m, new DateTime(2007, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 91m, 4196m, 44m, 4, "10005277", "JESUS", "BARRAGAN", 11, "39735895", 10, 6, 7, 839m, 2007 },
                    { 44, 5262m, new DateTime(2013, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 377m, 0m, 1628m, 4, "10008983", "LUIS", "BARRETO", 11, "40592118", 2, 6, 7, 580m, 2013 },
                    { 31, 3111m, new DateTime(2015, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 84m, 0m, 1620m, 2, "10005526", "NORA", "AGUDELO DE LOPEZ", 11, "19167180", 3, 3, 5, 883m, 2015 },
                    { 588, 3670m, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 367m, 3670m, 1335m, 2, "10008940", "MARIA", "JOAQUI", 12, "76305810", 10, 6, 4, 743m, 2019 },
                    { 587, 3670m, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 145m, 0m, 204m, 2, "10008940", "MARIA", "JOAQUI", 12, "76305810", 9, 6, 4, 942m, 2019 },
                    { 540, 5407m, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 453m, 5407m, 1810m, 1, "10003442", "DORIS", "HURTADO", 6, "20382292", 4, 6, 2, 920m, 2020 },
                    { 541, 3027m, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 479m, 0m, 727m, 1, "10007706", "CARMEN", "IBARRA", 6, "24938732", 2, 6, 2, 622m, 2019 },
                    { 542, 3027m, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 36m, 0m, 237m, 1, "10007706", "CARMEN", "IBARRA", 6, "24938732", 3, 6, 2, 648m, 2019 },
                    { 543, 3027m, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 473m, 0m, 1234m, 1, "10007706", "CARMEN", "IBARRA", 6, "24938732", 4, 6, 2, 37m, 2019 },
                    { 544, 3027m, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 363m, 0m, 481m, 1, "10007706", "CARMEN", "IBARRA", 6, "24938732", 5, 6, 2, 520m, 2019 },
                    { 545, 3027m, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 91m, 0m, 355m, 1, "10007706", "CARMEN", "IBARRA", 6, "24938732", 6, 6, 2, 337m, 2019 },
                    { 539, 5407m, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 430m, 0m, 520m, 1, "10003442", "DORIS", "HURTADO", 6, "20382292", 3, 6, 2, 702m, 2020 },
                    { 546, 3027m, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 236m, 3027m, 1767m, 1, "10007706", "CARMEN", "IBARRA", 6, "24938732", 7, 6, 2, 716m, 2019 },
                    { 566, 4125m, new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 322m, 0m, 326m, 1, "10001640", "EUGENIA", "CLARA", 6, "82687804", 12, 5, 2, 858m, 2015 },
                    { 567, 4125m, new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 128m, 0m, 639m, 1, "10001640", "EUGENIA", "CLARA", 6, "82687804", 1, 5, 2, 361m, 2016 },
                    { 568, 4125m, new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 395m, 0m, 1872m, 1, "10001640", "EUGENIA", "CLARA", 6, "82687804", 2, 5, 2, 876m, 2016 },
                    { 569, 4125m, new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 498m, 0m, 188m, 1, "10001640", "EUGENIA", "CLARA", 6, "82687804", 3, 5, 2, 657m, 2016 },
                    { 570, 4125m, new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 402m, 4125m, 1961m, 1, "10001640", "EUGENIA", "CLARA", 6, "82687804", 4, 5, 2, 29m, 2016 },
                    { 73, 4554m, new DateTime(2015, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 123m, 0m, 808m, 1, "10008233", "LUCIA", "CADENA", 14, "11673115", 8, 2, 3, 604m, 2015 },
                    { 565, 4125m, new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 480m, 0m, 65m, 1, "10001640", "EUGENIA", "CLARA", 6, "82687804", 11, 5, 2, 868m, 2015 },
                    { 538, 5407m, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 236m, 0m, 842m, 1, "10003442", "DORIS", "HURTADO", 6, "20382292", 2, 6, 2, 974m, 2020 },
                    { 537, 5407m, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 147m, 0m, 1238m, 1, "10003442", "DORIS", "HURTADO", 6, "20382292", 1, 6, 2, 179m, 2020 },
                    { 536, 5407m, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 107m, 0m, 1016m, 1, "10003442", "DORIS", "HURTADO", 6, "20382292", 12, 6, 2, 989m, 2019 },
                    { 215, 4491m, new DateTime(2008, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 314m, 0m, 359m, 1, "10004594", "ALFONSO", "FALLA", 6, "17203319", 4, 1, 2, 384m, 2009 },
                    { 216, 4491m, new DateTime(2008, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 86m, 4491m, 970m, 1, "10004594", "ALFONSO", "FALLA", 6, "17203319", 5, 1, 2, 736m, 2009 },
                    { 253, 5972m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 191m, 0m, 522m, 1, "10005496", "CARLOS", "GALLARDO", 6, "26297330", 10, 3, 2, 487m, 2008 },
                    { 254, 5972m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 348m, 0m, 1562m, 1, "10005496", "CARLOS", "GALLARDO", 6, "26297330", 11, 3, 2, 9m, 2008 },
                    { 255, 5972m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 398m, 0m, 515m, 1, "10005496", "CARLOS", "GALLARDO", 6, "26297330", 12, 3, 2, 848m, 2008 },
                    { 256, 5972m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 340m, 0m, 893m, 1, "10005496", "CARLOS", "GALLARDO", 6, "26297330", 1, 3, 2, 813m, 2009 },
                    { 257, 5972m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, 0m, 353m, 1, "10005496", "CARLOS", "GALLARDO", 6, "26297330", 2, 3, 2, 352m, 2009 },
                    { 258, 5972m, new DateTime(2008, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 72m, 5972m, 1381m, 1, "10005496", "CARLOS", "GALLARDO", 6, "26297330", 3, 3, 2, 590m, 2009 },
                    { 313, 5100m, new DateTime(2016, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 325m, 0m, 713m, 1, "10007782", "CARLOS", "GAVIRIA", 6, "53480699", 5, 6, 2, 628m, 2016 },
                    { 314, 5100m, new DateTime(2016, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 328m, 0m, 671m, 1, "10007782", "CARLOS", "GAVIRIA", 6, "53480699", 6, 6, 2, 300m, 2016 },
                    { 315, 5100m, new DateTime(2016, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 194m, 0m, 177m, 1, "10007782", "CARLOS", "GAVIRIA", 6, "53480699", 7, 6, 2, 147m, 2016 },
                    { 316, 5100m, new DateTime(2016, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 57m, 0m, 633m, 1, "10007782", "CARLOS", "GAVIRIA", 6, "53480699", 8, 6, 2, 860m, 2016 },
                    { 317, 5100m, new DateTime(2016, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 285m, 0m, 1414m, 1, "10007782", "CARLOS", "GAVIRIA", 6, "53480699", 9, 6, 2, 992m, 2016 },
                    { 318, 5100m, new DateTime(2016, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 337m, 5100m, 429m, 1, "10007782", "CARLOS", "GAVIRIA", 6, "53480699", 10, 6, 2, 600m, 2016 },
                    { 535, 5407m, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 318m, 0m, 948m, 1, "10003442", "DORIS", "HURTADO", 6, "20382292", 11, 6, 2, 855m, 2019 },
                    { 74, 4554m, new DateTime(2015, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 420m, 0m, 926m, 1, "10008233", "LUCIA", "CADENA", 14, "11673115", 9, 2, 3, 222m, 2015 },
                    { 75, 4554m, new DateTime(2015, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 207m, 0m, 1235m, 1, "10008233", "LUCIA", "CADENA", 14, "11673115", 10, 2, 3, 471m, 2015 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 76, 4554m, new DateTime(2015, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 81m, 0m, 987m, 1, "10008233", "LUCIA", "CADENA", 14, "11673115", 11, 2, 3, 132m, 2015 },
                    { 77, 4554m, new DateTime(2015, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 274m, 0m, 1420m, 1, "10008233", "LUCIA", "CADENA", 14, "11673115", 12, 2, 3, 73m, 2015 },
                    { 295, 4214m, new DateTime(2011, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 58m, 0m, 1604m, 1, "10004430", "GLORIA", "GARCIA", 14, "11297408", 4, 4, 3, 882m, 2011 },
                    { 296, 4214m, new DateTime(2011, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 447m, 0m, 646m, 1, "10004430", "GLORIA", "GARCIA", 14, "11297408", 5, 4, 3, 155m, 2011 },
                    { 297, 4214m, new DateTime(2011, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 354m, 0m, 1650m, 1, "10004430", "GLORIA", "GARCIA", 14, "11297408", 6, 4, 3, 652m, 2011 },
                    { 298, 4214m, new DateTime(2011, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 331m, 0m, 1109m, 1, "10004430", "GLORIA", "GARCIA", 14, "11297408", 7, 4, 3, 287m, 2011 },
                    { 299, 4214m, new DateTime(2011, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 205m, 0m, 1257m, 1, "10004430", "GLORIA", "GARCIA", 14, "11297408", 8, 4, 3, 791m, 2011 },
                    { 300, 4214m, new DateTime(2011, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 84m, 4214m, 939m, 1, "10004430", "GLORIA", "GARCIA", 14, "11297408", 9, 4, 3, 142m, 2011 },
                    { 319, 4161m, new DateTime(2017, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 85m, 0m, 652m, 1, "10008349", "JHON", "GIRALDO", 14, "98666219", 1, 5, 3, 303m, 2017 },
                    { 320, 4161m, new DateTime(2017, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 150m, 0m, 1343m, 1, "10008349", "JHON", "GIRALDO", 14, "98666219", 2, 5, 3, 56m, 2017 },
                    { 321, 4161m, new DateTime(2017, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 426m, 0m, 203m, 1, "10008349", "JHON", "GIRALDO", 14, "98666219", 3, 5, 3, 316m, 2017 },
                    { 322, 4161m, new DateTime(2017, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 373m, 0m, 345m, 1, "10008349", "JHON", "GIRALDO", 14, "98666219", 4, 5, 3, 13m, 2017 },
                    { 323, 4161m, new DateTime(2017, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 73m, 0m, 11m, 1, "10008349", "JHON", "GIRALDO", 14, "98666219", 5, 5, 3, 299m, 2017 },
                    { 324, 4161m, new DateTime(2017, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 22m, 4161m, 1006m, 1, "10008349", "JHON", "GIRALDO", 14, "98666219", 6, 5, 3, 503m, 2017 },
                    { 343, 3536m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 428m, 0m, 729m, 1, "10001675", "RIGOBERTO", "GOMEZ", 14, "17489497", 6, 1, 3, 860m, 2006 },
                    { 344, 3536m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 60m, 0m, 847m, 1, "10001675", "RIGOBERTO", "GOMEZ", 14, "17489497", 7, 1, 3, 328m, 2006 },
                    { 345, 3536m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 0m, 879m, 1, "10001675", "RIGOBERTO", "GOMEZ", 14, "17489497", 8, 1, 3, 830m, 2006 },
                    { 288, 5126m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 457m, 5126m, 1739m, 1, "10008923", "WILLIAM", "GARCIA", 14, "17719896", 3, 3, 3, 684m, 2010 },
                    { 214, 4491m, new DateTime(2008, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 459m, 0m, 1128m, 1, "10004594", "ALFONSO", "FALLA", 6, "17203319", 3, 1, 2, 2m, 2009 },
                    { 287, 5126m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, 0m, 1579m, 1, "10008923", "WILLIAM", "GARCIA", 14, "17719896", 2, 3, 3, 915m, 2010 },
                    { 285, 5126m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 332m, 0m, 300m, 1, "10008923", "WILLIAM", "GARCIA", 14, "17719896", 12, 3, 3, 266m, 2009 },
                    { 78, 4554m, new DateTime(2015, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 383m, 4554m, 1039m, 1, "10008233", "LUCIA", "CADENA", 14, "11673115", 1, 2, 3, 990m, 2016 },
                    { 181, 5729m, new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 474m, 0m, 996m, 1, "10002165", "PAULO", "ESPINOSA", 14, "54177187", 7, 2, 3, 943m, 2013 },
                    { 182, 5729m, new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 0m, 844m, 1, "10002165", "PAULO", "ESPINOSA", 14, "54177187", 8, 2, 3, 610m, 2013 },
                    { 183, 5729m, new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 86m, 0m, 1746m, 1, "10002165", "PAULO", "ESPINOSA", 14, "54177187", 9, 2, 3, 393m, 2013 },
                    { 184, 5729m, new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 272m, 0m, 274m, 1, "10002165", "PAULO", "ESPINOSA", 14, "54177187", 10, 2, 3, 110m, 2013 },
                    { 185, 5729m, new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 341m, 0m, 1026m, 1, "10002165", "PAULO", "ESPINOSA", 14, "54177187", 11, 2, 3, 800m, 2013 },
                    { 186, 5729m, new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 107m, 5729m, 1382m, 1, "10002165", "PAULO", "ESPINOSA", 14, "54177187", 12, 2, 3, 760m, 2013 },
                    { 235, 4255m, new DateTime(2005, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 151m, 0m, 1706m, 1, "10003390", "JULIAN", "FERNANDEZ", 14, "72080667", 10, 3, 3, 452m, 2005 },
                    { 236, 4255m, new DateTime(2005, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 414m, 0m, 445m, 1, "10003390", "JULIAN", "FERNANDEZ", 14, "72080667", 11, 3, 3, 122m, 2005 },
                    { 237, 4255m, new DateTime(2005, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 444m, 0m, 1642m, 1, "10003390", "JULIAN", "FERNANDEZ", 14, "72080667", 12, 3, 3, 150m, 2005 },
                    { 238, 4255m, new DateTime(2005, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 223m, 0m, 1346m, 1, "10003390", "JULIAN", "FERNANDEZ", 14, "72080667", 1, 3, 3, 274m, 2006 },
                    { 239, 4255m, new DateTime(2005, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 406m, 0m, 1146m, 1, "10003390", "JULIAN", "FERNANDEZ", 14, "72080667", 2, 3, 3, 69m, 2006 },
                    { 240, 4255m, new DateTime(2005, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 130m, 4255m, 507m, 1, "10003390", "JULIAN", "FERNANDEZ", 14, "72080667", 3, 3, 3, 9m, 2006 },
                    { 283, 5126m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27m, 0m, 1445m, 1, "10008923", "WILLIAM", "GARCIA", 14, "17719896", 10, 3, 3, 434m, 2009 },
                    { 284, 5126m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 141m, 0m, 825m, 1, "10008923", "WILLIAM", "GARCIA", 14, "17719896", 11, 3, 3, 818m, 2009 },
                    { 286, 5126m, new DateTime(2009, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 240m, 0m, 519m, 1, "10008923", "WILLIAM", "GARCIA", 14, "17719896", 1, 3, 3, 64m, 2010 },
                    { 346, 3536m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 144m, 0m, 976m, 1, "10001675", "RIGOBERTO", "GOMEZ", 14, "17489497", 9, 1, 3, 373m, 2006 },
                    { 213, 4491m, new DateTime(2008, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 325m, 0m, 1102m, 1, "10004594", "ALFONSO", "FALLA", 6, "17203319", 2, 1, 2, 814m, 2009 },
                    { 211, 4491m, new DateTime(2008, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 326m, 0m, 1627m, 1, "10004594", "ALFONSO", "FALLA", 6, "17203319", 12, 1, 2, 679m, 2008 },
                    { 225, 3341m, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 118m, 0m, 1727m, 1, "10006298", "NANCY", "FERNANDEZ", 12, "55918778", 5, 5, 1, 115m, 2020 },
                    { 226, 3341m, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 61m, 0m, 1658m, 1, "10006298", "NANCY", "FERNANDEZ", 12, "55918778", 6, 5, 1, 926m, 2020 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 227, 3341m, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 406m, 0m, 158m, 1, "10006298", "NANCY", "FERNANDEZ", 12, "55918778", 7, 5, 1, 475m, 2020 },
                    { 228, 3341m, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 267m, 3341m, 1103m, 1, "10006298", "NANCY", "FERNANDEZ", 12, "55918778", 8, 5, 1, 927m, 2020 },
                    { 325, 5025m, new DateTime(2012, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 301m, 0m, 1798m, 1, "10004830", "SAUL", "GOMEZ", 12, "20368709", 11, 5, 1, 329m, 2012 },
                    { 326, 5025m, new DateTime(2012, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 361m, 0m, 36m, 1, "10004830", "SAUL", "GOMEZ", 12, "20368709", 12, 5, 1, 224m, 2012 },
                    { 224, 3341m, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 371m, 0m, 540m, 1, "10006298", "NANCY", "FERNANDEZ", 12, "55918778", 4, 5, 1, 489m, 2020 },
                    { 327, 5025m, new DateTime(2012, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 263m, 0m, 63m, 1, "10004830", "SAUL", "GOMEZ", 12, "20368709", 1, 5, 1, 672m, 2013 },
                    { 329, 5025m, new DateTime(2012, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 408m, 0m, 1627m, 1, "10004830", "SAUL", "GOMEZ", 12, "20368709", 3, 5, 1, 735m, 2013 },
                    { 330, 5025m, new DateTime(2012, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 135m, 5025m, 1978m, 1, "10004830", "SAUL", "GOMEZ", 12, "20368709", 4, 5, 1, 143m, 2013 },
                    { 331, 3762m, new DateTime(2013, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 103m, 0m, 1201m, 1, "10006645", "LINO", "GOMEZ", 12, "94794765", 10, 2, 1, 935m, 2013 },
                    { 332, 3762m, new DateTime(2013, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 224m, 0m, 1185m, 1, "10006645", "LINO", "GOMEZ", 12, "94794765", 11, 2, 1, 977m, 2013 },
                    { 333, 3762m, new DateTime(2013, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 181m, 0m, 1731m, 1, "10006645", "LINO", "GOMEZ", 12, "94794765", 12, 2, 1, 620m, 2013 },
                    { 334, 3762m, new DateTime(2013, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 226m, 0m, 851m, 1, "10006645", "LINO", "GOMEZ", 12, "94794765", 1, 2, 1, 377m, 2014 },
                    { 328, 5025m, new DateTime(2012, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 361m, 0m, 422m, 1, "10004830", "SAUL", "GOMEZ", 12, "20368709", 2, 5, 1, 696m, 2013 },
                    { 223, 3341m, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 29m, 0m, 6m, 1, "10006298", "NANCY", "FERNANDEZ", 12, "55918778", 3, 5, 1, 245m, 2020 },
                    { 210, 5147m, new DateTime(2016, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8m, 5147m, 1397m, 1, "10002782", "ALEXANDER", "SARRIA", 12, "59144808", 8, 4, 1, 726m, 2016 },
                    { 209, 5147m, new DateTime(2016, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 0m, 1184m, 1, "10002782", "ALEXANDER", "SARRIA", 12, "59144808", 7, 4, 1, 938m, 2016 },
                    { 26, 3425m, new DateTime(2007, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 172m, 0m, 733m, 1, "10005636", "XIMENA LUCIA", "AGREDO", 12, "61105021", 11, 4, 1, 116m, 2007 },
                    { 27, 3425m, new DateTime(2007, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 227m, 0m, 894m, 1, "10005636", "XIMENA LUCIA", "AGREDO", 12, "61105021", 12, 4, 1, 645m, 2007 },
                    { 28, 3425m, new DateTime(2007, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 212m, 0m, 1043m, 1, "10005636", "XIMENA LUCIA", "AGREDO", 12, "61105021", 1, 4, 1, 404m, 2008 },
                    { 29, 3425m, new DateTime(2007, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 436m, 0m, 1357m, 1, "10005636", "XIMENA LUCIA", "AGREDO", 12, "61105021", 2, 4, 1, 335m, 2008 },
                    { 30, 3425m, new DateTime(2007, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 434m, 3425m, 1240m, 1, "10005636", "XIMENA LUCIA", "AGREDO", 12, "61105021", 3, 4, 1, 84m, 2008 },
                    { 97, 5353m, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3m, 0m, 1870m, 1, "10003449", "HEIMER", "CALERO", 12, "62629028", 9, 1, 1, 546m, 2020 },
                    { 98, 5353m, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 192m, 0m, 915m, 1, "10003449", "HEIMER", "CALERO", 12, "62629028", 10, 1, 1, 85m, 2020 },
                    { 99, 5353m, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 231m, 0m, 1600m, 1, "10003449", "HEIMER", "CALERO", 12, "62629028", 11, 1, 1, 919m, 2020 },
                    { 100, 5353m, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 497m, 0m, 645m, 1, "10003449", "HEIMER", "CALERO", 12, "62629028", 12, 1, 1, 846m, 2020 },
                    { 101, 5353m, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 129m, 0m, 1579m, 1, "10003449", "HEIMER", "CALERO", 12, "62629028", 1, 1, 1, 294m, 2021 },
                    { 102, 5353m, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 351m, 5353m, 107m, 1, "10003449", "HEIMER", "CALERO", 12, "62629028", 2, 1, 1, 373m, 2021 },
                    { 205, 5147m, new DateTime(2016, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 80m, 0m, 619m, 1, "10002782", "ALEXANDER", "SARRIA", 12, "59144808", 3, 4, 1, 498m, 2016 },
                    { 206, 5147m, new DateTime(2016, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 375m, 0m, 1173m, 1, "10002782", "ALEXANDER", "SARRIA", 12, "59144808", 4, 4, 1, 618m, 2016 },
                    { 207, 5147m, new DateTime(2016, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 179m, 0m, 1996m, 1, "10002782", "ALEXANDER", "SARRIA", 12, "59144808", 5, 4, 1, 735m, 2016 },
                    { 208, 5147m, new DateTime(2016, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 365m, 0m, 658m, 1, "10002782", "ALEXANDER", "SARRIA", 12, "59144808", 6, 4, 1, 593m, 2016 },
                    { 335, 3762m, new DateTime(2013, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 409m, 0m, 1709m, 1, "10006645", "LINO", "GOMEZ", 12, "94794765", 2, 2, 1, 498m, 2014 },
                    { 336, 3762m, new DateTime(2013, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 33m, 3762m, 1893m, 1, "10006645", "LINO", "GOMEZ", 12, "94794765", 3, 2, 1, 809m, 2014 },
                    { 523, 5939m, new DateTime(2016, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 295m, 0m, 975m, 1, "10003189", "DAVID", "HURTADO", 12, "67323539", 12, 3, 1, 20m, 2016 },
                    { 524, 5939m, new DateTime(2016, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 372m, 0m, 1144m, 1, "10003189", "DAVID", "HURTADO", 12, "67323539", 1, 3, 1, 962m, 2017 },
                    { 64, 5732m, new DateTime(2005, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 275m, 0m, 962m, 1, "10008529", "HERNANDO", "CABRERA", 6, "30839153", 4, 6, 2, 285m, 2005 },
                    { 65, 5732m, new DateTime(2005, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 225m, 0m, 1861m, 1, "10008529", "HERNANDO", "CABRERA", 6, "30839153", 5, 6, 2, 274m, 2005 },
                    { 66, 5732m, new DateTime(2005, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 131m, 5732m, 1008m, 1, "10008529", "HERNANDO", "CABRERA", 6, "30839153", 6, 6, 2, 700m, 2005 },
                    { 163, 5163m, new DateTime(2006, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 90m, 0m, 1731m, 1, "10007900", "ROSALBA", "DIAZ", 6, "32529922", 6, 3, 2, 968m, 2006 },
                    { 164, 5163m, new DateTime(2006, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, 0m, 535m, 1, "10007900", "ROSALBA", "DIAZ", 6, "32529922", 7, 3, 2, 597m, 2006 },
                    { 165, 5163m, new DateTime(2006, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 316m, 0m, 1986m, 1, "10007900", "ROSALBA", "DIAZ", 6, "32529922", 8, 3, 2, 550m, 2006 },
                    { 166, 5163m, new DateTime(2006, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 471m, 0m, 1744m, 1, "10007900", "ROSALBA", "DIAZ", 6, "32529922", 9, 3, 2, 820m, 2006 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 167, 5163m, new DateTime(2006, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 479m, 0m, 237m, 1, "10007900", "ROSALBA", "DIAZ", 6, "32529922", 10, 3, 2, 944m, 2006 },
                    { 168, 5163m, new DateTime(2006, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 497m, 5163m, 1947m, 1, "10007900", "ROSALBA", "DIAZ", 6, "32529922", 11, 3, 2, 112m, 2006 },
                    { 199, 5368m, new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 449m, 0m, 1984m, 1, "10001932", "JAIME", "OLIVEROS", 6, "69469802", 6, 3, 2, 564m, 2017 },
                    { 200, 5368m, new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 499m, 0m, 1935m, 1, "10001932", "JAIME", "OLIVEROS", 6, "69469802", 7, 3, 2, 692m, 2017 },
                    { 201, 5368m, new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 102m, 0m, 1193m, 1, "10001932", "JAIME", "OLIVEROS", 6, "69469802", 8, 3, 2, 521m, 2017 },
                    { 202, 5368m, new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 58m, 0m, 770m, 1, "10001932", "JAIME", "OLIVEROS", 6, "69469802", 9, 3, 2, 181m, 2017 },
                    { 203, 5368m, new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 55m, 0m, 1542m, 1, "10001932", "JAIME", "OLIVEROS", 6, "69469802", 10, 3, 2, 572m, 2017 },
                    { 204, 5368m, new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14m, 5368m, 976m, 1, "10001932", "JAIME", "OLIVEROS", 6, "69469802", 11, 3, 2, 728m, 2017 },
                    { 63, 5732m, new DateTime(2005, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 396m, 0m, 1984m, 1, "10008529", "HERNANDO", "CABRERA", 6, "30839153", 3, 6, 2, 945m, 2005 },
                    { 212, 4491m, new DateTime(2008, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 321m, 0m, 1363m, 1, "10004594", "ALFONSO", "FALLA", 6, "17203319", 1, 1, 2, 18m, 2009 },
                    { 62, 5732m, new DateTime(2005, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 143m, 0m, 1404m, 1, "10008529", "HERNANDO", "CABRERA", 6, "30839153", 2, 6, 2, 268m, 2005 },
                    { 24, 4193m, new DateTime(2009, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 273m, 4193m, 549m, 1, "10006038", "GUEFRY", "AGREDO", 6, "14183839", 2, 6, 2, 592m, 2010 },
                    { 525, 5939m, new DateTime(2016, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 342m, 0m, 558m, 1, "10003189", "DAVID", "HURTADO", 12, "67323539", 2, 3, 1, 991m, 2017 },
                    { 526, 5939m, new DateTime(2016, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 422m, 0m, 1856m, 1, "10003189", "DAVID", "HURTADO", 12, "67323539", 3, 3, 1, 625m, 2017 },
                    { 527, 5939m, new DateTime(2016, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 305m, 0m, 1915m, 1, "10003189", "DAVID", "HURTADO", 12, "67323539", 4, 3, 1, 37m, 2017 },
                    { 528, 5939m, new DateTime(2016, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 262m, 5939m, 966m, 1, "10003189", "DAVID", "HURTADO", 12, "67323539", 5, 3, 1, 722m, 2017 },
                    { 13, 3632m, new DateTime(2010, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 454m, 0m, 152m, 1, "10008375", "PEREGRINO", "ACOSTA", 6, "62450905", 5, 4, 2, 605m, 2010 },
                    { 14, 3632m, new DateTime(2010, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 0m, 175m, 1, "10008375", "PEREGRINO", "ACOSTA", 6, "62450905", 6, 4, 2, 603m, 2010 },
                    { 15, 3632m, new DateTime(2010, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 421m, 0m, 141m, 1, "10008375", "PEREGRINO", "ACOSTA", 6, "62450905", 7, 4, 2, 627m, 2010 },
                    { 16, 3632m, new DateTime(2010, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 483m, 0m, 816m, 1, "10008375", "PEREGRINO", "ACOSTA", 6, "62450905", 8, 4, 2, 374m, 2010 },
                    { 17, 3632m, new DateTime(2010, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 213m, 0m, 1334m, 1, "10008375", "PEREGRINO", "ACOSTA", 6, "62450905", 9, 4, 2, 86m, 2010 },
                    { 18, 3632m, new DateTime(2010, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 79m, 3632m, 1888m, 1, "10008375", "PEREGRINO", "ACOSTA", 6, "62450905", 10, 4, 2, 109m, 2010 },
                    { 19, 4193m, new DateTime(2009, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 122m, 0m, 958m, 1, "10006038", "GUEFRY", "AGREDO", 6, "14183839", 9, 6, 2, 903m, 2009 },
                    { 20, 4193m, new DateTime(2009, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 444m, 0m, 1423m, 1, "10006038", "GUEFRY", "AGREDO", 6, "14183839", 10, 6, 2, 480m, 2009 },
                    { 21, 4193m, new DateTime(2009, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 36m, 0m, 88m, 1, "10006038", "GUEFRY", "AGREDO", 6, "14183839", 11, 6, 2, 231m, 2009 },
                    { 22, 4193m, new DateTime(2009, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 256m, 0m, 86m, 1, "10006038", "GUEFRY", "AGREDO", 6, "14183839", 12, 6, 2, 246m, 2009 },
                    { 23, 4193m, new DateTime(2009, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 423m, 0m, 1573m, 1, "10006038", "GUEFRY", "AGREDO", 6, "14183839", 1, 6, 2, 213m, 2010 },
                    { 61, 5732m, new DateTime(2005, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 182m, 0m, 1865m, 1, "10008529", "HERNANDO", "CABRERA", 6, "30839153", 1, 6, 2, 602m, 2005 },
                    { 347, 3536m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 58m, 0m, 1273m, 1, "10001675", "RIGOBERTO", "GOMEZ", 14, "17489497", 10, 1, 3, 384m, 2006 },
                    { 348, 3536m, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 125m, 3536m, 769m, 1, "10001675", "RIGOBERTO", "GOMEZ", 14, "17489497", 11, 1, 3, 539m, 2006 },
                    { 349, 4115m, new DateTime(2013, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 213m, 0m, 508m, 1, "10007827", "ELIZABETH", "GONZALEZ", 14, "86727699", 6, 3, 3, 868m, 2013 },
                    { 271, 4023m, new DateTime(2009, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 210m, 0m, 1068m, 2, "10005634", "RUTH", "GAMEZ", 12, "40106102", 12, 6, 4, 49m, 2009 },
                    { 272, 4023m, new DateTime(2009, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 466m, 0m, 1282m, 2, "10005634", "RUTH", "GAMEZ", 12, "40106102", 1, 6, 4, 221m, 2010 },
                    { 273, 4023m, new DateTime(2009, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 117m, 0m, 1270m, 2, "10005634", "RUTH", "GAMEZ", 12, "40106102", 2, 6, 4, 300m, 2010 },
                    { 274, 4023m, new DateTime(2009, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 291m, 0m, 211m, 2, "10005634", "RUTH", "GAMEZ", 12, "40106102", 3, 6, 4, 858m, 2010 },
                    { 275, 4023m, new DateTime(2009, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2m, 0m, 304m, 2, "10005634", "RUTH", "GAMEZ", 12, "40106102", 4, 6, 4, 499m, 2010 },
                    { 276, 4023m, new DateTime(2009, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 291m, 4023m, 433m, 2, "10005634", "RUTH", "GAMEZ", 12, "40106102", 5, 6, 4, 997m, 2010 },
                    { 270, 3757m, new DateTime(2015, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 493m, 3757m, 1719m, 2, "10006703", "ALBERT", "GALVIS", 12, "76936732", 12, 5, 4, 68m, 2015 },
                    { 337, 5859m, new DateTime(2007, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 343m, 0m, 1869m, 2, "10003637", "ELISA", "GOMEZ", 12, "88179319", 5, 4, 4, 415m, 2007 },
                    { 339, 5859m, new DateTime(2007, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 397m, 0m, 602m, 2, "10003637", "ELISA", "GOMEZ", 12, "88179319", 7, 4, 4, 852m, 2007 },
                    { 340, 5859m, new DateTime(2007, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7m, 0m, 485m, 2, "10003637", "ELISA", "GOMEZ", 12, "88179319", 8, 4, 4, 371m, 2007 },
                    { 341, 5859m, new DateTime(2007, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 210m, 0m, 1608m, 2, "10003637", "ELISA", "GOMEZ", 12, "88179319", 9, 4, 4, 143m, 2007 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 342, 5859m, new DateTime(2007, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 400m, 5859m, 172m, 2, "10003637", "ELISA", "GOMEZ", 12, "88179319", 10, 4, 4, 165m, 2007 },
                    { 355, 4233m, new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 129m, 0m, 1117m, 2, "10004969", "ANDRES", "GONZALEZ", 12, "58147972", 10, 1, 4, 175m, 2018 },
                    { 356, 4233m, new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 494m, 0m, 487m, 2, "10004969", "ANDRES", "GONZALEZ", 12, "58147972", 11, 1, 4, 431m, 2018 },
                    { 338, 5859m, new DateTime(2007, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 226m, 0m, 105m, 2, "10003637", "ELISA", "GOMEZ", 12, "88179319", 6, 4, 4, 229m, 2007 },
                    { 269, 3757m, new DateTime(2015, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 77m, 0m, 1673m, 2, "10006703", "ALBERT", "GALVIS", 12, "76936732", 11, 5, 4, 122m, 2015 },
                    { 268, 3757m, new DateTime(2015, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 227m, 0m, 1966m, 2, "10006703", "ALBERT", "GALVIS", 12, "76936732", 10, 5, 4, 753m, 2015 },
                    { 267, 3757m, new DateTime(2015, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 133m, 0m, 962m, 2, "10006703", "ALBERT", "GALVIS", 12, "76936732", 9, 5, 4, 643m, 2015 },
                    { 120, 3881m, new DateTime(2009, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 355m, 3881m, 1609m, 2, "10005520", "SANTIAGO", "CASTRO", 12, "21444639", 6, 6, 4, 1m, 2009 },
                    { 145, 4293m, new DateTime(2007, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 0m, 1142m, 2, "10008246", "JULIO", "DIAGO", 12, "60004413", 1, 3, 4, 105m, 2007 },
                    { 146, 4293m, new DateTime(2007, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 392m, 0m, 1785m, 2, "10008246", "JULIO", "DIAGO", 12, "60004413", 2, 3, 4, 391m, 2007 },
                    { 147, 4293m, new DateTime(2007, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 0m, 307m, 2, "10008246", "JULIO", "DIAGO", 12, "60004413", 3, 3, 4, 736m, 2007 },
                    { 148, 4293m, new DateTime(2007, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 89m, 0m, 1012m, 2, "10008246", "JULIO", "DIAGO", 12, "60004413", 4, 3, 4, 894m, 2007 },
                    { 149, 4293m, new DateTime(2007, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 333m, 0m, 614m, 2, "10008246", "JULIO", "DIAGO", 12, "60004413", 5, 3, 4, 88m, 2007 },
                    { 150, 4293m, new DateTime(2007, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 55m, 4293m, 925m, 2, "10008246", "JULIO", "DIAGO", 12, "60004413", 6, 3, 4, 639m, 2007 },
                    { 217, 4840m, new DateTime(2006, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 269m, 0m, 1865m, 2, "10006642", "MABEL", "FARFAN", 12, "21179419", 9, 2, 4, 622m, 2006 },
                    { 218, 4840m, new DateTime(2006, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 148m, 0m, 701m, 2, "10006642", "MABEL", "FARFAN", 12, "21179419", 10, 2, 4, 728m, 2006 },
                    { 219, 4840m, new DateTime(2006, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 47m, 0m, 1277m, 2, "10006642", "MABEL", "FARFAN", 12, "21179419", 11, 2, 4, 193m, 2006 },
                    { 220, 4840m, new DateTime(2006, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 332m, 0m, 1646m, 2, "10006642", "MABEL", "FARFAN", 12, "21179419", 12, 2, 4, 538m, 2006 },
                    { 221, 4840m, new DateTime(2006, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 221m, 0m, 883m, 2, "10006642", "MABEL", "FARFAN", 12, "21179419", 1, 2, 4, 499m, 2007 },
                    { 222, 4840m, new DateTime(2006, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 252m, 4840m, 1610m, 2, "10006642", "MABEL", "FARFAN", 12, "21179419", 2, 2, 4, 43m, 2007 },
                    { 265, 3757m, new DateTime(2015, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 153m, 0m, 284m, 2, "10006703", "ALBERT", "GALVIS", 12, "76936732", 7, 5, 4, 564m, 2015 },
                    { 266, 3757m, new DateTime(2015, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 60m, 0m, 1151m, 2, "10006703", "ALBERT", "GALVIS", 12, "76936732", 8, 5, 4, 272m, 2015 },
                    { 357, 4233m, new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 124m, 0m, 383m, 2, "10004969", "ANDRES", "GONZALEZ", 12, "58147972", 12, 1, 4, 376m, 2018 },
                    { 358, 4233m, new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 93m, 0m, 837m, 2, "10004969", "ANDRES", "GONZALEZ", 12, "58147972", 1, 1, 4, 719m, 2019 },
                    { 359, 4233m, new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 383m, 0m, 1381m, 2, "10004969", "ANDRES", "GONZALEZ", 12, "58147972", 2, 1, 4, 895m, 2019 },
                    { 360, 4233m, new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 255m, 4233m, 1973m, 2, "10004969", "ANDRES", "GONZALEZ", 12, "58147972", 3, 1, 4, 29m, 2019 },
                    { 446, 5637m, new DateTime(2011, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 454m, 0m, 957m, 2, "10007600", "GARCES", "HARTMANN", 12, "98115409", 10, 3, 4, 178m, 2011 },
                    { 447, 5637m, new DateTime(2011, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 109m, 0m, 1236m, 2, "10007600", "GARCES", "HARTMANN", 12, "98115409", 11, 3, 4, 86m, 2011 },
                    { 448, 5637m, new DateTime(2011, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 82m, 0m, 874m, 2, "10007600", "GARCES", "HARTMANN", 12, "98115409", 12, 3, 4, 46m, 2011 },
                    { 449, 5637m, new DateTime(2011, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 109m, 0m, 387m, 2, "10007600", "GARCES", "HARTMANN", 12, "98115409", 1, 3, 4, 349m, 2012 },
                    { 450, 5637m, new DateTime(2011, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 265m, 5637m, 152m, 2, "10007600", "GARCES", "HARTMANN", 12, "98115409", 2, 3, 4, 738m, 2012 },
                    { 463, 3945m, new DateTime(2016, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 446m, 0m, 192m, 2, "10001900", "MARTHA", "HERRERA", 12, "37455202", 4, 2, 4, 657m, 2016 },
                    { 464, 3945m, new DateTime(2016, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 148m, 0m, 203m, 2, "10001900", "MARTHA", "HERRERA", 12, "37455202", 5, 2, 4, 2m, 2016 },
                    { 465, 3945m, new DateTime(2016, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 193m, 0m, 837m, 2, "10001900", "MARTHA", "HERRERA", 12, "37455202", 6, 2, 4, 325m, 2016 },
                    { 466, 3945m, new DateTime(2016, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 255m, 0m, 1782m, 2, "10001900", "MARTHA", "HERRERA", 12, "37455202", 7, 2, 4, 817m, 2016 },
                    { 467, 3945m, new DateTime(2016, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 412m, 0m, 1119m, 2, "10001900", "MARTHA", "HERRERA", 12, "37455202", 8, 2, 4, 14m, 2016 },
                    { 468, 3945m, new DateTime(2016, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 477m, 3945m, 613m, 2, "10001900", "MARTHA", "HERRERA", 12, "37455202", 9, 2, 4, 637m, 2016 },
                    { 583, 3670m, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 62m, 0m, 16m, 2, "10008940", "MARIA", "JOAQUI", 12, "76305810", 5, 6, 4, 575m, 2019 },
                    { 584, 3670m, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 451m, 0m, 1073m, 2, "10008940", "MARIA", "JOAQUI", 12, "76305810", 6, 6, 4, 954m, 2019 },
                    { 585, 3670m, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 388m, 0m, 843m, 2, "10008940", "MARIA", "JOAQUI", 12, "76305810", 7, 6, 4, 829m, 2019 },
                    { 586, 3670m, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 454m, 0m, 134m, 2, "10008940", "MARIA", "JOAQUI", 12, "76305810", 8, 6, 4, 240m, 2019 },
                    { 445, 5637m, new DateTime(2011, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, 0m, 1228m, 2, "10007600", "GARCES", "HARTMANN", 12, "98115409", 9, 3, 4, 373m, 2011 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 119, 3881m, new DateTime(2009, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 282m, 0m, 176m, 2, "10005520", "SANTIAGO", "CASTRO", 12, "21444639", 5, 6, 4, 483m, 2009 },
                    { 402, 3322m, new DateTime(2007, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 229m, 3322m, 77m, 2, "10004164", "JERONIMO", "GUERRERO", 12, "26429846", 3, 1, 4, 482m, 2008 },
                    { 400, 3322m, new DateTime(2007, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 68m, 0m, 1466m, 2, "10004164", "JERONIMO", "GUERRERO", 12, "26429846", 1, 1, 4, 181m, 2008 },
                    { 367, 3679m, new DateTime(2017, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 112m, 0m, 1424m, 2, "10004368", "PEDRO", "GRIJALBA", 12, "87118563", 8, 5, 4, 636m, 2017 },
                    { 368, 3679m, new DateTime(2017, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 298m, 0m, 1209m, 2, "10004368", "PEDRO", "GRIJALBA", 12, "87118563", 9, 5, 4, 598m, 2017 },
                    { 369, 3679m, new DateTime(2017, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 429m, 0m, 267m, 2, "10004368", "PEDRO", "GRIJALBA", 12, "87118563", 10, 5, 4, 389m, 2017 },
                    { 370, 3679m, new DateTime(2017, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 223m, 0m, 1485m, 2, "10004368", "PEDRO", "GRIJALBA", 12, "87118563", 11, 5, 4, 556m, 2017 },
                    { 371, 3679m, new DateTime(2017, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 224m, 0m, 879m, 2, "10004368", "PEDRO", "GRIJALBA", 12, "87118563", 12, 5, 4, 657m, 2017 },
                    { 372, 3679m, new DateTime(2017, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 103m, 3679m, 721m, 2, "10004368", "PEDRO", "GRIJALBA", 12, "87118563", 1, 5, 4, 295m, 2018 },
                    { 373, 4056m, new DateTime(2007, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 186m, 0m, 1045m, 2, "10001422", "CLAUDIA", "GRUESO", 12, "55365354", 6, 5, 4, 948m, 2007 },
                    { 374, 4056m, new DateTime(2007, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 456m, 0m, 312m, 2, "10001422", "CLAUDIA", "GRUESO", 12, "55365354", 7, 5, 4, 901m, 2007 },
                    { 375, 4056m, new DateTime(2007, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 363m, 0m, 530m, 2, "10001422", "CLAUDIA", "GRUESO", 12, "55365354", 8, 5, 4, 665m, 2007 },
                    { 376, 4056m, new DateTime(2007, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 371m, 0m, 72m, 2, "10001422", "CLAUDIA", "GRUESO", 12, "55365354", 9, 5, 4, 812m, 2007 },
                    { 377, 4056m, new DateTime(2007, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 183m, 0m, 1362m, 2, "10001422", "CLAUDIA", "GRUESO", 12, "55365354", 10, 5, 4, 636m, 2007 },
                    { 378, 4056m, new DateTime(2007, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 453m, 4056m, 413m, 2, "10001422", "CLAUDIA", "GRUESO", 12, "55365354", 11, 5, 4, 768m, 2007 },
                    { 397, 3322m, new DateTime(2007, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 23m, 0m, 1119m, 2, "10004164", "JERONIMO", "GUERRERO", 12, "26429846", 10, 1, 4, 654m, 2007 },
                    { 398, 3322m, new DateTime(2007, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 296m, 0m, 1669m, 2, "10004164", "JERONIMO", "GUERRERO", 12, "26429846", 11, 1, 4, 276m, 2007 },
                    { 399, 3322m, new DateTime(2007, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 337m, 0m, 990m, 2, "10004164", "JERONIMO", "GUERRERO", 12, "26429846", 12, 1, 4, 577m, 2007 },
                    { 401, 3322m, new DateTime(2007, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 98m, 0m, 768m, 2, "10004164", "JERONIMO", "GUERRERO", 12, "26429846", 2, 1, 4, 851m, 2008 },
                    { 118, 3881m, new DateTime(2009, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 196m, 0m, 180m, 2, "10005520", "SANTIAGO", "CASTRO", 12, "21444639", 4, 6, 4, 817m, 2009 },
                    { 117, 3881m, new DateTime(2009, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 115m, 0m, 684m, 2, "10005520", "SANTIAGO", "CASTRO", 12, "21444639", 3, 6, 4, 107m, 2009 },
                    { 116, 3881m, new DateTime(2009, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 400m, 0m, 608m, 2, "10005520", "SANTIAGO", "CASTRO", 12, "21444639", 2, 6, 4, 641m, 2009 },
                    { 417, 3993m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, 0m, 1606m, 1, "10004023", "CARMEN", "GUTIERREZ", 14, "96752809", 9, 1, 3, 893m, 2011 },
                    { 418, 3993m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 238m, 0m, 641m, 1, "10004023", "CARMEN", "GUTIERREZ", 14, "96752809", 10, 1, 3, 405m, 2011 },
                    { 419, 3993m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 419m, 0m, 702m, 1, "10004023", "CARMEN", "GUTIERREZ", 14, "96752809", 11, 1, 3, 81m, 2011 },
                    { 420, 3993m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 289m, 3993m, 1793m, 1, "10004023", "CARMEN", "GUTIERREZ", 14, "96752809", 12, 1, 3, 576m, 2011 },
                    { 439, 5589m, new DateTime(2013, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 355m, 0m, 232m, 1, "10002780", "LUCIA", "GUZMAN", 14, "56614890", 12, 3, 3, 494m, 2013 },
                    { 440, 5589m, new DateTime(2013, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 162m, 0m, 1649m, 1, "10002780", "LUCIA", "GUZMAN", 14, "56614890", 1, 3, 3, 888m, 2014 },
                    { 441, 5589m, new DateTime(2013, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 164m, 0m, 1729m, 1, "10002780", "LUCIA", "GUZMAN", 14, "56614890", 2, 3, 3, 394m, 2014 },
                    { 442, 5589m, new DateTime(2013, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 43m, 0m, 1521m, 1, "10002780", "LUCIA", "GUZMAN", 14, "56614890", 3, 3, 3, 330m, 2014 },
                    { 443, 5589m, new DateTime(2013, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 357m, 0m, 1478m, 1, "10002780", "LUCIA", "GUZMAN", 14, "56614890", 4, 3, 3, 596m, 2014 },
                    { 444, 5589m, new DateTime(2013, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 87m, 5589m, 969m, 1, "10002780", "LUCIA", "GUZMAN", 14, "56614890", 5, 3, 3, 584m, 2014 },
                    { 469, 5058m, new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 279m, 0m, 798m, 1, "10002579", "NHORA", "HERRERA", 14, "91215338", 3, 6, 3, 509m, 2012 },
                    { 470, 5058m, new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 229m, 0m, 1149m, 1, "10002579", "NHORA", "HERRERA", 14, "91215338", 4, 6, 3, 860m, 2012 },
                    { 471, 5058m, new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 237m, 0m, 329m, 1, "10002579", "NHORA", "HERRERA", 14, "91215338", 5, 6, 3, 704m, 2012 },
                    { 472, 5058m, new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 69m, 0m, 1497m, 1, "10002579", "NHORA", "HERRERA", 14, "91215338", 6, 6, 3, 431m, 2012 },
                    { 473, 5058m, new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 228m, 0m, 179m, 1, "10002579", "NHORA", "HERRERA", 14, "91215338", 7, 6, 3, 586m, 2012 },
                    { 416, 3993m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 161m, 0m, 1739m, 1, "10004023", "CARMEN", "GUTIERREZ", 14, "96752809", 8, 1, 3, 687m, 2011 },
                    { 474, 5058m, new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 433m, 5058m, 1111m, 1, "10002579", "NHORA", "HERRERA", 14, "91215338", 8, 6, 3, 100m, 2012 },
                    { 415, 3993m, new DateTime(2011, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 330m, 0m, 89m, 1, "10004023", "CARMEN", "GUTIERREZ", 14, "96752809", 7, 1, 3, 175m, 2011 },
                    { 413, 4279m, new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 17m, 0m, 780m, 1, "10005047", "OSCAR", "GUTIERREZ", 14, "50083964", 6, 1, 3, 455m, 2012 },
                    { 350, 4115m, new DateTime(2013, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 87m, 0m, 272m, 1, "10007827", "ELIZABETH", "GONZALEZ", 14, "86727699", 7, 3, 3, 789m, 2013 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 351, 4115m, new DateTime(2013, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 13m, 0m, 85m, 1, "10007827", "ELIZABETH", "GONZALEZ", 14, "86727699", 8, 3, 3, 589m, 2013 },
                    { 352, 4115m, new DateTime(2013, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 47m, 0m, 641m, 1, "10007827", "ELIZABETH", "GONZALEZ", 14, "86727699", 9, 3, 3, 482m, 2013 },
                    { 353, 4115m, new DateTime(2013, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 124m, 0m, 801m, 1, "10007827", "ELIZABETH", "GONZALEZ", 14, "86727699", 10, 3, 3, 414m, 2013 },
                    { 354, 4115m, new DateTime(2013, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 133m, 4115m, 1202m, 1, "10007827", "ELIZABETH", "GONZALEZ", 14, "86727699", 11, 3, 3, 603m, 2013 },
                    { 385, 4700m, new DateTime(2011, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 227m, 0m, 1745m, 1, "10005573", "ADOLFO", "BURBANO", 14, "29229951", 11, 1, 3, 405m, 2011 },
                    { 386, 4700m, new DateTime(2011, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 132m, 0m, 1412m, 1, "10005573", "ADOLFO", "BURBANO", 14, "29229951", 12, 1, 3, 672m, 2011 },
                    { 387, 4700m, new DateTime(2011, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 463m, 0m, 1009m, 1, "10005573", "ADOLFO", "BURBANO", 14, "29229951", 1, 1, 3, 914m, 2012 },
                    { 388, 4700m, new DateTime(2011, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 384m, 0m, 707m, 1, "10005573", "ADOLFO", "BURBANO", 14, "29229951", 2, 1, 3, 138m, 2012 },
                    { 389, 4700m, new DateTime(2011, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 118m, 0m, 1034m, 1, "10005573", "ADOLFO", "BURBANO", 14, "29229951", 3, 1, 3, 941m, 2012 },
                    { 390, 4700m, new DateTime(2011, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 369m, 4700m, 1762m, 1, "10005573", "ADOLFO", "BURBANO", 14, "29229951", 4, 1, 3, 883m, 2012 },
                    { 409, 4279m, new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 208m, 0m, 1323m, 1, "10005047", "OSCAR", "GUTIERREZ", 14, "50083964", 2, 1, 3, 516m, 2012 },
                    { 410, 4279m, new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 158m, 0m, 1292m, 1, "10005047", "OSCAR", "GUTIERREZ", 14, "50083964", 3, 1, 3, 859m, 2012 },
                    { 411, 4279m, new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 172m, 0m, 246m, 1, "10005047", "OSCAR", "GUTIERREZ", 14, "50083964", 4, 1, 3, 346m, 2012 },
                    { 412, 4279m, new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 222m, 0m, 1696m, 1, "10005047", "OSCAR", "GUTIERREZ", 14, "50083964", 5, 1, 3, 675m, 2012 },
                    { 414, 4279m, new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 467m, 4279m, 1842m, 1, "10005047", "OSCAR", "GUTIERREZ", 14, "50083964", 7, 1, 3, 204m, 2012 },
                    { 581, 4221m, new DateTime(2014, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 454m, 0m, 281m, 4, "10005245", "TOMAS", "JARAMILLO", 11, "58451936", 8, 4, 7, 968m, 2014 },
                    { 487, 4205m, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 222m, 0m, 455m, 1, "10002409", "ANA", "HIDALGO", 14, "34342488", 6, 3, 3, 627m, 2020 },
                    { 489, 4205m, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 247m, 0m, 667m, 1, "10002409", "ANA", "HIDALGO", 14, "34342488", 8, 3, 3, 816m, 2020 },
                    { 575, 5048m, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 153m, 0m, 263m, 1, "10001373", "TULIO", "IMBACHI", 14, "36723428", 11, 5, 3, 293m, 2016 },
                    { 576, 5048m, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 382m, 5048m, 980m, 1, "10001373", "TULIO", "IMBACHI", 14, "36723428", 12, 5, 3, 889m, 2016 },
                    { 67, 4579m, new DateTime(2007, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 259m, 0m, 709m, 2, "10004512", "DIEGO", "CACERES", 12, "89619340", 8, 6, 4, 832m, 2007 },
                    { 68, 4579m, new DateTime(2007, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 404m, 0m, 1455m, 2, "10004512", "DIEGO", "CACERES", 12, "89619340", 9, 6, 4, 123m, 2007 },
                    { 69, 4579m, new DateTime(2007, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 378m, 0m, 362m, 2, "10004512", "DIEGO", "CACERES", 12, "89619340", 10, 6, 4, 244m, 2007 },
                    { 70, 4579m, new DateTime(2007, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9m, 0m, 442m, 2, "10004512", "DIEGO", "CACERES", 12, "89619340", 11, 6, 4, 979m, 2007 },
                    { 71, 4579m, new DateTime(2007, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 164m, 0m, 1556m, 2, "10004512", "DIEGO", "CACERES", 12, "89619340", 12, 6, 4, 886m, 2007 },
                    { 72, 4579m, new DateTime(2007, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 22m, 4579m, 1740m, 2, "10004512", "DIEGO", "CACERES", 12, "89619340", 1, 6, 4, 316m, 2008 },
                    { 79, 4981m, new DateTime(2007, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 146m, 0m, 241m, 2, "10001171", "EMILIO", "CAICEDO", 12, "13440224", 7, 3, 4, 452m, 2007 },
                    { 80, 4981m, new DateTime(2007, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 316m, 0m, 591m, 2, "10001171", "EMILIO", "CAICEDO", 12, "13440224", 8, 3, 4, 21m, 2007 },
                    { 81, 4981m, new DateTime(2007, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 177m, 0m, 1738m, 2, "10001171", "EMILIO", "CAICEDO", 12, "13440224", 9, 3, 4, 587m, 2007 },
                    { 82, 4981m, new DateTime(2007, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 122m, 0m, 574m, 2, "10001171", "EMILIO", "CAICEDO", 12, "13440224", 10, 3, 4, 562m, 2007 },
                    { 83, 4981m, new DateTime(2007, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 374m, 0m, 1284m, 2, "10001171", "EMILIO", "CAICEDO", 12, "13440224", 11, 3, 4, 49m, 2007 },
                    { 84, 4981m, new DateTime(2007, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 117m, 4981m, 660m, 2, "10001171", "EMILIO", "CAICEDO", 12, "13440224", 12, 3, 4, 444m, 2007 },
                    { 115, 3881m, new DateTime(2009, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 177m, 0m, 931m, 2, "10005520", "SANTIAGO", "CASTRO", 12, "21444639", 1, 6, 4, 271m, 2009 },
                    { 574, 5048m, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 413m, 0m, 1708m, 1, "10001373", "TULIO", "IMBACHI", 14, "36723428", 10, 5, 3, 391m, 2016 },
                    { 488, 4205m, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 460m, 0m, 328m, 1, "10002409", "ANA", "HIDALGO", 14, "34342488", 7, 3, 3, 187m, 2020 },
                    { 573, 5048m, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 0m, 1858m, 1, "10001373", "TULIO", "IMBACHI", 14, "36723428", 9, 5, 3, 989m, 2016 },
                    { 571, 5048m, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 329m, 0m, 1842m, 1, "10001373", "TULIO", "IMBACHI", 14, "36723428", 7, 5, 3, 647m, 2016 },
                    { 490, 4205m, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 453m, 0m, 586m, 1, "10002409", "ANA", "HIDALGO", 14, "34342488", 9, 3, 3, 383m, 2020 },
                    { 491, 4205m, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 346m, 0m, 1782m, 1, "10002409", "ANA", "HIDALGO", 14, "34342488", 10, 3, 3, 725m, 2020 },
                    { 492, 4205m, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 337m, 4205m, 717m, 1, "10002409", "ANA", "HIDALGO", 14, "34342488", 11, 3, 3, 147m, 2020 },
                    { 511, 4444m, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 92m, 0m, 729m, 1, "10003581", "LAURENCIO", "HOYOS", 14, "14781709", 10, 5, 3, 16m, 2019 },
                    { 512, 4444m, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 0m, 981m, 1, "10003581", "LAURENCIO", "HOYOS", 14, "14781709", 11, 5, 3, 538m, 2019 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 513, 4444m, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 462m, 0m, 1965m, 1, "10003581", "LAURENCIO", "HOYOS", 14, "14781709", 12, 5, 3, 631m, 2019 },
                    { 514, 4444m, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 181m, 0m, 1737m, 1, "10003581", "LAURENCIO", "HOYOS", 14, "14781709", 1, 5, 3, 278m, 2020 },
                    { 515, 4444m, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 181m, 0m, 763m, 1, "10003581", "LAURENCIO", "HOYOS", 14, "14781709", 2, 5, 3, 590m, 2020 },
                    { 516, 4444m, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 280m, 4444m, 1370m, 1, "10003581", "LAURENCIO", "HOYOS", 14, "14781709", 3, 5, 3, 176m, 2020 },
                    { 553, 4352m, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 82m, 0m, 184m, 1, "10008265", "SIMON", "IDROBO", 14, "58250299", 10, 5, 3, 453m, 2018 },
                    { 554, 4352m, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 322m, 0m, 1943m, 1, "10008265", "SIMON", "IDROBO", 14, "58250299", 11, 5, 3, 726m, 2018 },
                    { 555, 4352m, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 228m, 0m, 1805m, 1, "10008265", "SIMON", "IDROBO", 14, "58250299", 12, 5, 3, 240m, 2018 },
                    { 556, 4352m, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 152m, 0m, 1777m, 1, "10008265", "SIMON", "IDROBO", 14, "58250299", 1, 5, 3, 517m, 2019 },
                    { 557, 4352m, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7m, 0m, 218m, 1, "10008265", "SIMON", "IDROBO", 14, "58250299", 2, 5, 3, 720m, 2019 },
                    { 558, 4352m, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 4352m, 1455m, 1, "10008265", "SIMON", "IDROBO", 14, "58250299", 3, 5, 3, 296m, 2019 },
                    { 572, 5048m, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 421m, 0m, 436m, 1, "10001373", "TULIO", "IMBACHI", 14, "36723428", 8, 5, 3, 178m, 2016 },
                    { 582, 4221m, new DateTime(2014, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 306m, 4221m, 1834m, 4, "10005245", "TOMAS", "JARAMILLO", 11, "58451936", 9, 4, 7, 827m, 2014 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Positions_DivisionId",
                table: "Positions",
                column: "DivisionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Divisions_DivisionId",
                table: "Positions",
                column: "DivisionId",
                principalTable: "Divisions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Divisions_DivisionId",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Positions_DivisionId",
                table: "Positions");

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "DivisionId",
                table: "Positions");
        }
    }
}
