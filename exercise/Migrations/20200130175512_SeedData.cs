using Microsoft.EntityFrameworkCore.Migrations;

namespace ex4.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Samurais",
               columns: new[] { "Id", "Name", "Age", "Killing", },
               values: new object[] { 1, "Moshe", "44", 68 });

            migrationBuilder.InsertData(
                table: "Samurais",
                columns: new[] { "Id", "Name", "Age", "Killing", },
                values: new object[] { 2, "Omer", "26", 68 });

            migrationBuilder.InsertData(
           table: "SecretIdentity",
           columns: new[] { "Id", "RealName", "SamuraiId" },
           values: new object[] { 1, "New York", 1 });

            migrationBuilder.InsertData(
                table: "SecretIdentity",
                columns: new[] { "Id", "RealName", "SamuraiId" },
                values: new object[] { 2, "New Delhi", 2 });



        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
