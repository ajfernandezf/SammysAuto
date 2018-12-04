using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SammysAuto.Data.Migrations
{
    public partial class AddServiceTypeToDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_serviceTypes",
                table: "serviceTypes");

            migrationBuilder.RenameTable(
                name: "serviceTypes",
                newName: "ServiceTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceTypes",
                table: "ServiceTypes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceTypes",
                table: "ServiceTypes");

            migrationBuilder.RenameTable(
                name: "ServiceTypes",
                newName: "serviceTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_serviceTypes",
                table: "serviceTypes",
                column: "Id");
        }
    }
}
