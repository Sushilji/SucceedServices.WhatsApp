using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SucceedServices.WhatsApp.Migrations
{
    /// <inheritdoc />
    public partial class AddWhatsAppSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WhatsAppSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumberId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessAccountId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerifyToken = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhatsAppSettings", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WhatsAppSettings");
        }
    }
}
