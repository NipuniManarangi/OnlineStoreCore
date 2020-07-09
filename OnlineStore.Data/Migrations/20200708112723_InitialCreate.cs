using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineStore.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    Gender = table.Column<string>(type: "char(1)", nullable: false),
                    ContatctNo = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Address_Line1 = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    Address_Line2 = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
