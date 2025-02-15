namespace VacationRequestTask
{
	internal class Program
	{
		static void Main(string[] args)
		{





			using (var dbcontext = new AppDBContext())
			{
				MainScreen();


				// objective 2: adding to db 



				//var departments = new List<Department>
				//{
				//	new Department { departmentName = "Human Resources" },
				//	new Department { departmentName = "Finance" },
				//	new Department { departmentName = "IT" },
				//	new Department { departmentName = "Marketing" },
				//	new Department { departmentName = "Operations" },
				//	new Department { departmentName = "Sales" },
				//	new Department { departmentName = "Legal" },
				//	new Department { departmentName = "Customer Support" },
				//	new Department { departmentName = "Security" },
				//	new Department { departmentName = "Product Research" },
				//	new Department { departmentName = "Administration" },
				//	new Department { departmentName = "Engineering" },
				//	new Department { departmentName = "Procurement" },
				//	new Department { departmentName = "Logistics" },
				//	new Department { departmentName = "Product Management" },
				//	new Department { departmentName = "Business Development" },
				//	new Department { departmentName = "Compliance" },
				//	new Department { departmentName = "Public Relations" },
				//	new Department { departmentName = "Training & Development" },
				//	new Department { departmentName = "Health & Safety" }
				//};
				//dbcontext.Departments.AddRange(departments);
				//dbcontext.SaveChanges();



				//var positions = new List<Position>
				//{
				//	new Position { positionName = "Software Engineer" },
				//	new Position { positionName = "Project Manager" },
				//	new Position { positionName = "HR Manager" },
				//	new Position { positionName = "Marketing Manager" },
				//	new Position { positionName = "Sales Representative" },
				//	new Position { positionName = "Operations Executive" },
				//	new Position { positionName = "Finance Analyst" },
				//	new Position { positionName = "Data Scientist" },
				//	new Position { positionName = "Network Administrator" },
				//	new Position { positionName = "IT Support" },
				//	new Position { positionName = "Graphic Designer" },
				//	new Position { positionName = "SEO Specialist" },
				//	new Position { positionName = "Content Writer" },
				//	new Position { positionName = "Security Officer" },
				//	new Position { positionName = "Legal Advisor" },
				//	new Position { positionName = "Supply Chain Manager" },
				//	new Position { positionName = "Customer Service Rep" },
				//	new Position { positionName = "Product Owner" },
				//	new Position { positionName = "General Consultant" },
				//	new Position { positionName = "Compliance Officer" }
				//};

				//dbcontext.Position.AddRange(positions);
				//dbcontext.SaveChanges();


				//	IMPORTANT: IDENTITY IDS DIDNT GET RESET WHILE I WAS TESTING HERE BEFORE AND THE SAMPLE ID NUMBERS I USED WORK
				//	ON MY MACHINE FOR TESTING BUT HAVE TO BE ADJUSTED ON A NEW BUILD OF THE APP AS THEY WOULD START FROM 0


				//var employees = new List<Employee>
				//	{
				//new Employee("Mohammad Ahmad", 10000,38,363, 21,'M'),
				//new Employee("Yousef Ashraf", 7000, 37, 365, 26,'M'),
				//new Employee("Salma Mohannad", 8000,36, 363, 21,'F'),
				//new Employee("Nick Allan", 5000,39, 369, 34,'M'),
				//new Employee("Feras Sobhi", 6520, 38, 368, 37,'M'),
				//new Employee("Kareem Abdulrahman", 10520, 36, 362, 27,'M'),
				//new Employee("Baraa Hamed", 9100,39, 374 , 36,'M'),
				//new Employee("Reem Wajeeh", 7125, 41, 361, 23,'F'),
				//new Employee("Sarah Othman", 12000,40, 366, 25,'F'),
				//new Employee("Fahad Salem", 13300, 43, 375,  38,'M'),
				//new Employee("Alice Johnson",9500 , 45, 375 , 39,'F')
				//};

				//dbcontext.Employee.AddRange(employees);
				//dbcontext.SaveChanges();





				void MainScreen()
				{

					Console.Clear();
					Console.WriteLine("Welcome to the vacation request system! How can we help today? " +
						"\n 1. Edit an Employee's Details" +
						"\n 2. submit new vacation request"

						);


					string input = Console.ReadLine();
					switch (input)
					{

						case "1":
							Console.Clear();
							Console.WriteLine("Enter the Employee's id:");
							int input2 = Convert.ToInt32(Console.ReadLine());
							//finding employee from id
							var editedEmployee = dbcontext.Employee.FirstOrDefault(e => e.employeeNum == input2);


							if (editedEmployee == null)
							{
								throw new Exception("Employee not found.");
							}

							Console.WriteLine("\n Choose the info you want to edit: \n 1. Department \n 2.Position \n 3. Name \n 4. Salary");
							string typeInput = Console.ReadLine();
							switch (typeInput)
							{
								case "1":
									Console.Clear();
									Console.WriteLine("Enter the new Department's id:");
									int newdepId = Convert.ToInt32(Console.ReadLine());

									editedEmployee.departmentId = newdepId;
									dbcontext.SaveChanges();

									Console.WriteLine("department edited successfully \n");
									System.Threading.Thread.Sleep(2000);

									MainScreen();
									break;


								case "2":
									Console.Clear();
									Console.WriteLine("Enter the new Position's id:");
									int newposId = Convert.ToInt32(Console.ReadLine());

									editedEmployee.positionId = newposId;
									dbcontext.SaveChanges();

									Console.WriteLine("position edited successfully \n");
									System.Threading.Thread.Sleep(2000);

									MainScreen();
									break;


								case "3":
									Console.Clear();
									Console.WriteLine("Enter the new Employee Name:");
									string newEmpName = Console.ReadLine();

									editedEmployee.employeeName = newEmpName;
									dbcontext.SaveChanges();

									Console.WriteLine("Employee Name edited successfully \n");
									System.Threading.Thread.Sleep(2000);

									MainScreen();
									break;


								case "4":
									Console.Clear();
									Console.WriteLine("Enter the new Employee Salary:");
									int newEmpSalary = Convert.ToInt32(Console.ReadLine());

									editedEmployee.salary = newEmpSalary;
									dbcontext.SaveChanges();

									Console.WriteLine("Employee Salary edited successfully \n");
									System.Threading.Thread.Sleep(2000);

									MainScreen();
									break;



								default:
									Console.WriteLine("Invalid choice. Please try again.");
									System.Threading.Thread.Sleep(2000);
									MainScreen();
									break;
							}
							break;


						case "2":
							Console.Clear();
							Console.WriteLine("Enter the Employee's id:");
							int inputNewVac = Convert.ToInt32(Console.ReadLine());

							var newVacEmployee = dbcontext.Employee.FirstOrDefault(e => e.employeeNum == inputNewVac);

							if (newVacEmployee == null)
							{
								throw new Exception("Employee not found.");
							}

							Console.WriteLine("Select Vacation Type by writing the corresponding letter: (Sick: S, Unpaid: U, Annual: A, Day Off: D, Business Trip: B):");
							char inputVacType = Convert.ToChar(Console.ReadLine());

							Console.WriteLine("Enter a Description for the vacation reason: ");
							string inputDesc = Console.ReadLine();

							Console.WriteLine("Enter the start date for the vacation in this format yyyy-mm-dd:");
							DateOnly inputStartDate = DateOnly.Parse(Console.ReadLine());

							Console.WriteLine("Enter the end date for the vacation in this format yyyy-mm-dd:");
							DateOnly inputEndDate = DateOnly.Parse(Console.ReadLine());

							int vacationDays = (inputEndDate.ToDateTime(TimeOnly.MinValue) - inputStartDate.ToDateTime(TimeOnly.MinValue)).Days;


							int requestStateId = 1;

							DateTime RequestSubmissionDate = DateTime.Now;

							var newVacationRequest = new VacationRequest
							{
								reqSubmitDate = RequestSubmissionDate,
								reqDescription = inputDesc,
								employeeNum = newVacEmployee.employeeNum,
								vacationTypeId = inputVacType,
								startDate = inputStartDate,
								endDate = inputEndDate,
								vacationDaysTotal = vacationDays,
								reqStateId = requestStateId,

							};


							dbcontext.VacationRequest.Add(newVacationRequest);
							dbcontext.SaveChanges();


							break;


						default:
							Console.WriteLine("Invalid choice. Please try again.");
							System.Threading.Thread.Sleep(2000);
							MainScreen();
							break;

					}
				}











				//		//objective 4: linq queries

				//		// DTO is below

				//		//1. 
				//		List<EmployeeDTO> GetAllEmployees()
				//		{

				//			{
				//				return dbcontext.Employee
				//					.Select(e => new EmployeeDTO
				//					{
				//						EmployeeNumber = e.employeeNum,
				//						Name = e.employeeName,
				//						Department = e.Department.departmentName,
				//						Salary = e.salary,
				//					})
				//					.ToList();
				//			}
				//		}



				//		//2.
				//		List<EmployeeDetailsDTO> GetEmployeeByNumber(int employeeNum)
				//		{

				//				return dbcontext.Employee

				//					.Where(e => e.employeeNum == employeeNum)
				//					.Select(e => new EmployeeDetailsDTO
				//					{
				//						EmployeeNumber = e.employeeNum,
				//						Name = e.employeeName,
				//						DepartmentName = e.Department.departmentName,
				//						PositionName = e.Position.positionName,
				//						ReportedTo = e.Manager != null ? e.Manager.employeeName : "N/A",
				//						VacationDaysLeft = e.vacationDaysLeft
				//					})
				//					.FirstOrDefault();

				//		}





				//		//3.
				//		List<EmployeeDTO> GetEmployeesWithPendingVacations()
				//		{

				//				return dbcontext.Employee

				//					.Where(e => e.VacationRequest.Any(vr => vr.RequestState.stateName == "Pending"))
				//					.Select(e => new EmployeeDTO
				//					{
				//						EmployeeNumber = e.employeeNum,
				//						Name = e.employeeName,
				//						Department = e.Department.departmentName,
				//						Salary = e.salary
				//					})
				//					.ToList();

				//		}



				//		// 4. 

				//		List<VacationHistoryDTO> GetApprovedVacations(string employeeNum)
				//		{

				//				return dbcontext.VacationRequest

				//					.Where(vr => vr.Employee.employeeNum == employeeNum && vr.RequestState.stateName == "Approved")
				//					.Select(vr => new VacationHistoryDTO
				//					{
				//						VacationType = vr.vacationType,
				//						Description = vr.description,
				//						Duration = $"{vr.daysRequested} days",
				//						ApprovedBy = vr.ApprovedBy.employeeName
				//					})
				//					.ToList();

				//		}



				//		//5.


				//		 List<PendingVacationDTO> GetPendingVacationRequests(int managerId)
				//		{

				//				return dbcontext.VacationRequest

				//					.Where(vr => vr.RequestState.stateName == "Pending" && vr.Employee.managerId == managerId)
				//					.Select(vr => new PendingVacationDTO
				//					{
				//						Description = vr.description,
				//						EmployeeNumber = vr.Employee.employeeNum,
				//						EmployeeName = vr.Employee.employeeName,
				//						SubmittedOn = vr.submittedDate,
				//						Duration = vr.daysRequested == 14 ? "2 weeks" : $"{vr.daysRequested} days",
				//						StartDate = vr.startDate,
				//						EndDate = vr.startDate.AddDays(vr.daysRequested),
				//						EmployeeSalary = vr.Employee.salary
				//					})
				//					.ToList();

				//		}






				//	}
				//}
				//		public class EmployeeDTO
				//		{
				//		public int EmployeeNumber { get; set; }
				//		public string Name { get; set; }
				//		public string Department { get; set; }

				//		public int ReportedTo;

				//		public int VacationDaysLeft;

				//		public string PositionName { get; set; }
				//		public decimal Salary { get; set; }
				//		}

				//		public class EmployeeDetailsDTO
				//		{
				//			public int EmployeeNumber { get; set; }
				//			public string Name { get; set; }
				//			public string DepartmentName { get; set; }
				//			public string PositionName { get; set; }
				//			public string ReportedTo { get; set; }
				//			public int VacationDaysLeft { get; set; }
				//		}


				//		public class VacationHistoryDTO
				//		{
				//			public string VacationType { get; set; }
				//			public string Description { get; set; }
				//			public string Duration { get; set; }
				//			public string ApprovedBy { get; set; }
				//		}

				//		public class PendingVacationDTO
				//		{
				//			public string Description { get; set; }
				//			public string EmployeeNumber { get; set; }
				//			public string EmployeeName { get; set; }
				//			public DateTime SubmittedOn { get; set; }
				//			public string Duration { get; set; }
				//			public DateTime StartDate { get; set; }
				//			public DateTime EndDate { get; set; }
				//			public decimal EmployeeSalary { get; set; }
				//		}




			}
		}
	}
}



