using System.ComponentModel.DataAnnotations;

namespace VacationRequestTask
{
	public class Employee
	{

		[Key]
		[Required]
		[MaxLength(6)]
		public int employeeNum { get; set; }



		[Required]
		[MaxLength(20)]
		public string employeeName { get; set; }



		// for foriegn keys
		public int departmentId { get; set; }
		public virtual Department Department { get; set; }

		public int positionId { get; set; }

		public virtual Position Position { get; set; }



		public char genderCode { get; set; }


		[MaxLength(6)]
		public int? reportedToId { get; set; }



		public int remainingVacationDays { get; set; }


		// using decimal with precision 2 gave me a lot of exceptions
		public int salary { get; set; }



		//constructor, default days
		public Employee(string name, int sal, int? reported, int depId, int posId, char gender)
		{

			employeeName = name;
			departmentId = depId;
			positionId = posId;
			reportedToId = reported;
			genderCode = gender;
			salary = sal;

			remainingVacationDays = 24;
		}

		private Employee() { }

	}
}