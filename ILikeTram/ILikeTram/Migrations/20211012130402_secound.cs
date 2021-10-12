using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ILikeTram.Migrations
{
    public partial class secound : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TramRoutes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Stare Miasto" });

            migrationBuilder.InsertData(
                table: "TramRoutes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Nowa Huta" });

            migrationBuilder.InsertData(
                table: "Trams",
                columns: new[] { "ID", "FirstRun", "Name" },
                values: new object[] { 1, new DateTime(1999, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "PartyTram" });

            migrationBuilder.InsertData(
                table: "Trams",
                columns: new[] { "ID", "FirstRun", "Name" },
                values: new object[] { 2, new DateTime(1980, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OldTram" });

            migrationBuilder.InsertData(
                table: "TramStops",
                columns: new[] { "ID", "Description", "Name", "RouteId" },
                values: new object[] { 1, "Hello, are you there?", "Plac Inwalidow", 1 });

            migrationBuilder.InsertData(
                table: "TramStops",
                columns: new[] { "ID", "Description", "Name", "RouteId" },
                values: new object[] { 2, "Hi, are you reading this?", "Meksyk", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TramStops",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TramStops",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trams",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trams",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TramRoutes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TramRoutes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
