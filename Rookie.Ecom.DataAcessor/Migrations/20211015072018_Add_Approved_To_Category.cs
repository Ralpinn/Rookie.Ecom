using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookie.Ecom.DataAcessor.Migrations
{
    public partial class Add_Approved_To_Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApprovedDate",
                table: "Category",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovedDate",
                table: "Category");
        }
    }
}
