using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoreGbMSE.Migrations
{
    public partial class Srochno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Srochno",
                table: "TaskWork",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Srochno",
                table: "TaskType",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Srochno",
                table: "TaskWork");

            migrationBuilder.DropColumn(
                name: "Srochno",
                table: "TaskType");
        }
    }
}
