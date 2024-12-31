using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD.NET.Migrations
{
    /// <inheritdoc />
    public partial class Customer_table_Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Customers",
                columns: table => new
                {
                    Custumer_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Custumer_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Custumer_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Custumer_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Custumer_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Customers", x => x.Custumer_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Customers");
        }
    }
}
