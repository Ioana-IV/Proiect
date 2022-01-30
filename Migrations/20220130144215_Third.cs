using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ivanov_Ioana_Proiect.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
            name: "FK_Purchase_Category_CategoryID",
            table: "Purchase",
            column: "CategoryID",
            principalTable: "Category",
            principalColumn: "ID",
            onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Payee_PayeeID",
                table: "Purchase",
                column: "PayeeID",
                principalTable: "Payee",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_PaymentType_PaymentTypeID",
                table: "Purchase",
                column: "PaymentTypeID",
                principalTable: "PaymentType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Category_CategoryID",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Payee_PayeeID",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_PaymentType_PaymentTypeID",
                table: "Purchase");
        }
    }
}
