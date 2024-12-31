using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD.NET.Migrations
{
    /// <inheritdoc />
    public partial class Users_table_Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Users",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    User_Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    User_Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    User_Role = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Users", x => x.User_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Users");
        }
    }
}
