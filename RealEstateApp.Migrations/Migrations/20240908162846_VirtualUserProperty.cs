using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateApp.Migrations.Migrations
{
    public partial class VirtualUserProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "IsAdminApproved",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "RentLogs");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "RentLogs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PurchaseLogs");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PurchaseLogs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Pictures");

            migrationBuilder.AddColumn<int>(
                name: "ApprovalType",
                table: "Rents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "Rents",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedById",
                table: "Rents",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "RentLogs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedById",
                table: "RentLogs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "Purchases",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedById",
                table: "Purchases",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "PurchaseLogs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedById",
                table: "PurchaseLogs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "Pictures",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedById",
                table: "Pictures",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rents_CreatedById",
                table: "Rents",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_ModifiedById",
                table: "Rents",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_RentLogs_CreatedById",
                table: "RentLogs",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_RentLogs_ModifiedById",
                table: "RentLogs",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_CreatedById",
                table: "Purchases",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_ModifiedById",
                table: "Purchases",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseLogs_CreatedById",
                table: "PurchaseLogs",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseLogs_ModifiedById",
                table: "PurchaseLogs",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_CreatedById",
                table: "Pictures",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_ModifiedById",
                table: "Pictures",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Users_CreatedById",
                table: "Pictures",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Users_ModifiedById",
                table: "Pictures",
                column: "ModifiedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseLogs_Users_CreatedById",
                table: "PurchaseLogs",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseLogs_Users_ModifiedById",
                table: "PurchaseLogs",
                column: "ModifiedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Users_CreatedById",
                table: "Purchases",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Users_ModifiedById",
                table: "Purchases",
                column: "ModifiedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RentLogs_Users_CreatedById",
                table: "RentLogs",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentLogs_Users_ModifiedById",
                table: "RentLogs",
                column: "ModifiedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Users_CreatedById",
                table: "Rents",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Users_ModifiedById",
                table: "Rents",
                column: "ModifiedById",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Users_CreatedById",
                table: "Pictures");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Users_ModifiedById",
                table: "Pictures");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseLogs_Users_CreatedById",
                table: "PurchaseLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseLogs_Users_ModifiedById",
                table: "PurchaseLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Users_CreatedById",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Users_ModifiedById",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_RentLogs_Users_CreatedById",
                table: "RentLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_RentLogs_Users_ModifiedById",
                table: "RentLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Users_CreatedById",
                table: "Rents");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Users_ModifiedById",
                table: "Rents");

            migrationBuilder.DropIndex(
                name: "IX_Rents_CreatedById",
                table: "Rents");

            migrationBuilder.DropIndex(
                name: "IX_Rents_ModifiedById",
                table: "Rents");

            migrationBuilder.DropIndex(
                name: "IX_RentLogs_CreatedById",
                table: "RentLogs");

            migrationBuilder.DropIndex(
                name: "IX_RentLogs_ModifiedById",
                table: "RentLogs");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_CreatedById",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_ModifiedById",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseLogs_CreatedById",
                table: "PurchaseLogs");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseLogs_ModifiedById",
                table: "PurchaseLogs");

            migrationBuilder.DropIndex(
                name: "IX_Pictures_CreatedById",
                table: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Pictures_ModifiedById",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "ApprovalType",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "RentLogs");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "RentLogs");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "PurchaseLogs");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "PurchaseLogs");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Pictures");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Rents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdminApproved",
                table: "Rents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Rents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "RentLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "RentLogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Purchases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Purchases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PurchaseLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PurchaseLogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Pictures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Pictures",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
