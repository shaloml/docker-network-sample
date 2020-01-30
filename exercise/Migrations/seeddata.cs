using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SecretIdentity",
                columns: new[] { "Id", "RealName" },
                values: new object[] { 1, "New York"});

            migrationBuilder.InsertData(
                table: "SecretIdentity",
                columns: new[] { "Id", "RealName" },
                values: new object[] { 2, "New Delhi" });


            migrationBuilder.InsertData(
                table: "Samurai",
                columns: new[] { "Id", "Name", "SamuraiId", "Age", "Killing", },
                values: new object[] { 1, "Moshe", 1, "44", 68 });

            migrationBuilder.InsertData(
                table: "Samurai",
                columns: new[] { "Id", "Name", "SamuraiId", "Age", "Killing", },
                values: new object[] { 2, "Omer", 2, "26",  68 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
 
        }
    }
}