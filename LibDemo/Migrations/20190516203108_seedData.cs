using Microsoft.EntityFrameworkCore.Migrations;

namespace LibDemo.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.Sql("INSERT INTO Authors(FirstName, LastName) VALUES ('Mateusz', 'Zajac')");
            migrationBuilder.Sql("INSERT INTO Authors(FirstName, LastName) VALUES ('Joanna', 'Zajac')");
            migrationBuilder.Sql("INSERT INTO Authors(FirstName, LastName) VALUES ('Julka', 'Zajac')");
            migrationBuilder.Sql("INSERT INTO Authors(FirstName, LastName) VALUES ('Stefan', 'Żeromski')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Authors");
        }
    }
}
