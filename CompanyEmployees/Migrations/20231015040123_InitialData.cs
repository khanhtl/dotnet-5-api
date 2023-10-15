using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyEmployees.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[] { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "N03 T1, Ngoai Giao Doan", "VN", "MISA JSC" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[] { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Tran Huu Duc", "VN", "Viettel solution" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), 23, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Ta Long Khanh", "Software developer" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), 28, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Hoang Trung Kien", "Software developer" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), 25, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Phung Dinh Xuan", "Administrator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));
        }
    }
}
