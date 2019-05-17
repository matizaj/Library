using Microsoft.EntityFrameworkCore.Migrations;

namespace LibDemo.Migrations
{
    public partial class seedDataToFeatureTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Features(Name) VALUES ('AudioBook')");
            migrationBuilder.Sql("INSERT INTO Features(Name) VALUES ('Tumaczenie na j. angielski')");
            migrationBuilder.Sql("INSERT INTO Features(Name) VALUES ('3 egzemplarze')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Features");
        }
    }
}
