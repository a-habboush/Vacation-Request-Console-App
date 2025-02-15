using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationRequestTask.Migrations
{
	/// <inheritdoc />
	public partial class migration : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<int>(
				name: "salary",
				table: "Employee",
				type: "int",
				nullable: false,
				oldClrType: typeof(decimal),
				oldType: "decimal(2,2)",
				oldPrecision: 2);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<decimal>(
				name: "salary",
				table: "Employee",
				type: "decimal(2,2)",
				precision: 2,
				nullable: false,
				oldClrType: typeof(int),
				oldType: "int");
		}
	}
}
