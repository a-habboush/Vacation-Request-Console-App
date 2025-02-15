using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationRequestTask.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    departmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departmentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.departmentId);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    positionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    positionName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.positionId);
                });

            migrationBuilder.CreateTable(
                name: "RequestState",
                columns: table => new
                {
                    reqStateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reqStateName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestState", x => x.reqStateId);
                });

            migrationBuilder.CreateTable(
                name: "Vacation",
                columns: table => new
                {
                    vacationTypeId = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    vacationTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacation", x => x.vacationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    employeeNum = table.Column<int>(type: "int", maxLength: 6, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employeeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    departmentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    positionName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    genderCode = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    reportedToId = table.Column<int>(type: "int", maxLength: 6, nullable: true),
                    remainingVacationDays = table.Column<int>(type: "int", nullable: false),
                    salary = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    departmentId = table.Column<int>(type: "int", nullable: false),
                    positionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.employeeNum);
                    table.CheckConstraint("check_vacationdays_limit", "remainingVacationDays <= 24");
                    table.ForeignKey(
                        name: "FK_Employee_Departments_departmentId",
                        column: x => x.departmentId,
                        principalTable: "Departments",
                        principalColumn: "departmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Position_positionId",
                        column: x => x.positionId,
                        principalTable: "Position",
                        principalColumn: "positionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacationRequest",
                columns: table => new
                {
                    reqId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reqSubmitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    reqDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    employeeNum = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    vacationTypeId = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    startDate = table.Column<DateOnly>(type: "date", nullable: false),
                    endDate = table.Column<DateOnly>(type: "date", nullable: false),
                    vacationDaysTotal = table.Column<int>(type: "int", nullable: false),
                    reqStateId = table.Column<int>(type: "int", nullable: false),
                    approvedById = table.Column<int>(type: "int", nullable: true),
                    deniedById = table.Column<int>(type: "int", nullable: true),
                    employeeNum1 = table.Column<int>(type: "int", nullable: false),
                    vacationTypeId1 = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    RequestStatereqStateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacationRequest", x => x.reqId);
                    table.ForeignKey(
                        name: "FK_VacationRequest_Employee_employeeNum1",
                        column: x => x.employeeNum1,
                        principalTable: "Employee",
                        principalColumn: "employeeNum",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VacationRequest_RequestState_RequestStatereqStateId",
                        column: x => x.RequestStatereqStateId,
                        principalTable: "RequestState",
                        principalColumn: "reqStateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VacationRequest_Vacation_vacationTypeId1",
                        column: x => x.vacationTypeId1,
                        principalTable: "Vacation",
                        principalColumn: "vacationTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_departmentId",
                table: "Employee",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_positionId",
                table: "Employee",
                column: "positionId");

            migrationBuilder.CreateIndex(
                name: "IX_VacationRequest_employeeNum1",
                table: "VacationRequest",
                column: "employeeNum1");

            migrationBuilder.CreateIndex(
                name: "IX_VacationRequest_RequestStatereqStateId",
                table: "VacationRequest",
                column: "RequestStatereqStateId");

            migrationBuilder.CreateIndex(
                name: "IX_VacationRequest_vacationTypeId1",
                table: "VacationRequest",
                column: "vacationTypeId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VacationRequest");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "RequestState");

            migrationBuilder.DropTable(
                name: "Vacation");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Position");
        }
    }
}
