using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetCore.RestAPIDemo.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "Schedule",
                nullable: false,
                defaultValue: new DateTime(2016, 12, 12, 17, 3, 15, 453, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Schedule",
                nullable: false,
                defaultValue: new DateTime(2016, 12, 12, 17, 3, 15, 446, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "Schedule",
                nullable: false,
                defaultValue: new DateTime(2016, 12, 12, 15, 41, 8, 620, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Schedule",
                nullable: false,
                defaultValue: new DateTime(2016, 12, 12, 15, 41, 8, 614, DateTimeKind.Local));
        }
    }
}
