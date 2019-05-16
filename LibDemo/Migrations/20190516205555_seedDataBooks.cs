using Microsoft.EntityFrameworkCore.Migrations;

namespace LibDemo.Migrations
{
    public partial class seedDataBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Books (Title, AuthorId) VALUES ('Make3-ModelC', (SELECT ID FROM Authors WHERE FirstName = 'Julka'))");

            migrationBuilder.Sql("INSERT INTO Books (Title, AuthorId) VALUES ('Ngrx', (SELECT ID FROM Authors WHERE FirstName = 'Mateusz'))");
            migrationBuilder.Sql("INSERT INTO Books (Title, AuthorId) VALUES ('Angular 7', (SELECT ID FROM Authors WHERE FirstName = 'Mateusz'))");
            migrationBuilder.Sql("INSERT INTO Books (Title, AuthorId) VALUES ('C#', (SELECT ID FROM Authors WHERE FirstName = 'Mateusz'))");
            migrationBuilder.Sql("INSERT INTO Books (Title, AuthorId) VALUES ('HTML', (SELECT ID FROM Authors WHERE FirstName = 'Mateusz'))");
            migrationBuilder.Sql("INSERT INTO Books (Title, AuthorId) VALUES ('JavaScript', (SELECT ID FROM Authors WHERE FirstName = 'Mateusz'))");
            migrationBuilder.Sql("INSERT INTO Books (Title, AuthorId) VALUES ('PhP', (SELECT ID FROM Authors WHERE FirstName = 'Mateusz'))");
            migrationBuilder.Sql("INSERT INTO Books (Title, AuthorId) VALUES ('CSS', (SELECT ID FROM Authors WHERE FirstName = 'Mateusz'))");
            migrationBuilder.Sql("INSERT INTO Books (Title, AuthorId) VALUES ('ASP.Net Core', (SELECT ID FROM Authors WHERE FirstName = 'Mateusz'))");

            migrationBuilder.Sql("INSERT INTO Books (Title, AuthorId) VALUES ('Maja i Gucio', (SELECT ID FROM Authors WHERE FirstName = 'Julka'))");
            migrationBuilder.Sql("INSERT INTO Books (Title, AuthorId) VALUES ('Matematyka', (SELECT ID FROM Authors WHERE FirstName = 'Julka'))");
            migrationBuilder.Sql("INSERT INTO Books (Title, AuthorId) VALUES ('Czytanka', (SELECT ID FROM Authors WHERE FirstName = 'Julka'))");
            migrationBuilder.Sql("INSERT INTO Books (Title, AuthorId) VALUES ('Pisanki', (SELECT ID FROM Authors WHERE FirstName = 'Julka'))");

            migrationBuilder.Sql("INSERT INTO Books (Title, AuthorId) VALUES ('Exel', (SELECT ID FROM Authors WHERE FirstName = 'Joanna'))");
            migrationBuilder.Sql("INSERT INTO Books (Title, AuthorId) VALUES ('Ekonomia', (SELECT ID FROM Authors WHERE FirstName = 'Joanna'))");
            migrationBuilder.Sql("INSERT INTO Books (Title, AuthorId) VALUES ('Zarządzanie', (SELECT ID FROM Authors WHERE FirstName = 'Joanna'))");
            migrationBuilder.Sql("INSERT INTO Books (Title, AuthorId) VALUES ('CIMA', (SELECT ID FROM Authors WHERE FirstName = 'Joanna'))");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Books");
        }
    }
}
