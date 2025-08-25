using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistence.Migrations
{
    public partial class RenamePriceToModel_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Cars",
                type: "nvarchar(100)",
                nullable: true);

            
            migrationBuilder.Sql(@"
                UPDATE C
                SET C.[Model] = CAST(C.[Price] AS nvarchar(100))
                FROM [dbo].[Cars] AS C
            ");

            
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Cars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Cars",
                type: "decimal(18,2)",
                nullable: true);

            
            migrationBuilder.Sql(@"
                UPDATE C
                SET C.[Price] = TRY_CAST(C.[Model] AS decimal(18,2))
                FROM [dbo].[Cars] AS C
            ");

            
            migrationBuilder.DropColumn(
                name: "Model",
                table: "Cars");
        }
    }
}
