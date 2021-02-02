using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Migrations
{
    public partial class intialNewOrderList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Movies_MovieId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_MovieId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PublicationDate",
                table: "OrderDetial");

            migrationBuilder.DropColumn(
                name: "name",
                table: "OrderDetial");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublicationDate",
                table: "OrderDetial",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "OrderDetial",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_MovieId",
                table: "Orders",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Movies_MovieId",
                table: "Orders",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
