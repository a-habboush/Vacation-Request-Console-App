using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationRequestTask.Migrations
{
    /// <inheritdoc />
    public partial class fixedvacationrequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacationRequest_Employee_employeeNum1",
                table: "VacationRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_VacationRequest_Vacation_vacationTypeId1",
                table: "VacationRequest");

            migrationBuilder.DropIndex(
                name: "IX_VacationRequest_employeeNum1",
                table: "VacationRequest");

            migrationBuilder.DropIndex(
                name: "IX_VacationRequest_vacationTypeId1",
                table: "VacationRequest");

            migrationBuilder.DropColumn(
                name: "employeeNum1",
                table: "VacationRequest");

            migrationBuilder.DropColumn(
                name: "reqStateId",
                table: "VacationRequest");

            migrationBuilder.DropColumn(
                name: "vacationTypeId1",
                table: "VacationRequest");

            migrationBuilder.CreateIndex(
                name: "IX_VacationRequest_employeeNum",
                table: "VacationRequest",
                column: "employeeNum");

            migrationBuilder.CreateIndex(
                name: "IX_VacationRequest_vacationTypeId",
                table: "VacationRequest",
                column: "vacationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_VacationRequest_Employee_employeeNum",
                table: "VacationRequest",
                column: "employeeNum",
                principalTable: "Employee",
                principalColumn: "employeeNum",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VacationRequest_Vacation_vacationTypeId",
                table: "VacationRequest",
                column: "vacationTypeId",
                principalTable: "Vacation",
                principalColumn: "vacationTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacationRequest_Employee_employeeNum",
                table: "VacationRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_VacationRequest_Vacation_vacationTypeId",
                table: "VacationRequest");

            migrationBuilder.DropIndex(
                name: "IX_VacationRequest_employeeNum",
                table: "VacationRequest");

            migrationBuilder.DropIndex(
                name: "IX_VacationRequest_vacationTypeId",
                table: "VacationRequest");

            migrationBuilder.AddColumn<int>(
                name: "employeeNum1",
                table: "VacationRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "reqStateId",
                table: "VacationRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "vacationTypeId1",
                table: "VacationRequest",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_VacationRequest_employeeNum1",
                table: "VacationRequest",
                column: "employeeNum1");

            migrationBuilder.CreateIndex(
                name: "IX_VacationRequest_vacationTypeId1",
                table: "VacationRequest",
                column: "vacationTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_VacationRequest_Employee_employeeNum1",
                table: "VacationRequest",
                column: "employeeNum1",
                principalTable: "Employee",
                principalColumn: "employeeNum",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VacationRequest_Vacation_vacationTypeId1",
                table: "VacationRequest",
                column: "vacationTypeId1",
                principalTable: "Vacation",
                principalColumn: "vacationTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
