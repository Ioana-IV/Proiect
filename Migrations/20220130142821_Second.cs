using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ivanov_Ioana_Proiect.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Category_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Payee",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayeeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Payee_Payee_PayeeID",
                        column: x => x.PayeeID,
                        principalTable: "Payee",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PaymentType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvailableAmmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentTypeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentType", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PaymentType_PaymentType_PaymentTypeID",
                        column: x => x.PaymentTypeID,
                        principalTable: "PaymentType",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_CategoryID",
                table: "Purchase",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_PayeeID",
                table: "Purchase",
                column: "PayeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_PaymentTypeID",
                table: "Purchase",
                column: "PaymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryID",
                table: "Category",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Payee_PayeeID",
                table: "Payee",
                column: "PayeeID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentType_PaymentTypeID",
                table: "PaymentType",
                column: "PaymentTypeID");
/**

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
**/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

/**
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Category_CategoryID",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Payee_PayeeID",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_PaymentType_PaymentTypeID",
                table: "Purchase");
**/
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Payee");

            migrationBuilder.DropTable(
                name: "PaymentType");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_CategoryID",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_PayeeID",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_PaymentTypeID",
                table: "Purchase");
        }
    }
}
