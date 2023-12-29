using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class organisation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ed3244c2-84ca-47d8-8358-a56756cfced7", "9f30ebb0-da81-4fbd-b183-01adf0d76538" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed3244c2-84ca-47d8-8358-a56756cfced7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f30ebb0-da81-4fbd-b183-01adf0d76538");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "82e356f7-5bf0-4a0c-a4d9-9820eefc0b5c", "82e356f7-5bf0-4a0c-a4d9-9820eefc0b5c", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c3d54f0e-3d4d-4be3-94b9-259af306a2e9", 0, "3be2aba3-7799-4322-a0d4-eafc0acfd5cc", "adam@wsei.edu.pl", true, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEA8QUDiMXGtcehordY5Z+AblZ7eY1QgJEhmSauGmcvaC7XDfZsORsy+zaj8SZOoniA==", null, false, "0b9cc803-0283-4431-9914-b69351ede3a6", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "82e356f7-5bf0-4a0c-a4d9-9820eefc0b5c", "c3d54f0e-3d4d-4be3-94b9-259af306a2e9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "82e356f7-5bf0-4a0c-a4d9-9820eefc0b5c", "c3d54f0e-3d4d-4be3-94b9-259af306a2e9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82e356f7-5bf0-4a0c-a4d9-9820eefc0b5c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d54f0e-3d4d-4be3-94b9-259af306a2e9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed3244c2-84ca-47d8-8358-a56756cfced7", "ed3244c2-84ca-47d8-8358-a56756cfced7", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9f30ebb0-da81-4fbd-b183-01adf0d76538", 0, "3162f31a-cf76-4b02-b430-f69527cd6107", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", null, "AQAAAAEAACcQAAAAEO9Py326fJzmKFTYTZeA1VVeiD9S4D5NyaToLPw4Bh2p8uOoGLvTI1QoTbn9spdB2g==", null, false, "8fa9069f-576b-4edd-ae27-1c43e0f015d8", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ed3244c2-84ca-47d8-8358-a56756cfced7", "9f30ebb0-da81-4fbd-b183-01adf0d76538" });
        }
    }
}
