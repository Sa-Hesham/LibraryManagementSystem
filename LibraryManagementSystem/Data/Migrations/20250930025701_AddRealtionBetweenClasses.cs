using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRealtionBetweenClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoandId",
                table: "Fines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CatgeoryId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MemberLoans",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    LoanId = table.Column<int>(type: "int", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberLoans", x => new { x.LoanId, x.BookId, x.MemberId });
                    table.ForeignKey(
                        name: "FK_MemberLoans_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberLoans_Lonas_LoanId",
                        column: x => x.LoanId,
                        principalTable: "Lonas",
                        principalColumn: "LoanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberLoans_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fines_LoandId",
                table: "Fines",
                column: "LoandId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorId",
                table: "Book",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_CatgeoryId",
                table: "Book",
                column: "CatgeoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberLoans_BookId",
                table: "MemberLoans",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberLoans_LoanId",
                table: "MemberLoans",
                column: "LoanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MemberLoans_MemberId",
                table: "MemberLoans",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_AuthorId",
                table: "Book",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AauthorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Category_CatgeoryId",
                table: "Book",
                column: "CatgeoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fines_Lonas_LoandId",
                table: "Fines",
                column: "LoandId",
                principalTable: "Lonas",
                principalColumn: "LoanId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_AuthorId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Category_CatgeoryId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Fines_Lonas_LoandId",
                table: "Fines");

            migrationBuilder.DropTable(
                name: "MemberLoans");

            migrationBuilder.DropIndex(
                name: "IX_Fines_LoandId",
                table: "Fines");

            migrationBuilder.DropIndex(
                name: "IX_Book_AuthorId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_CatgeoryId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "LoandId",
                table: "Fines");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "CatgeoryId",
                table: "Book");
        }
    }
}
