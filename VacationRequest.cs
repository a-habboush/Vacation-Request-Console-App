using System.ComponentModel.DataAnnotations;


namespace VacationRequestTask
{
	public class VacationRequest
	{
		[Key]
		public int reqId { get; set; }

		[Required]
		public DateTime reqSubmitDate { get; set; }


		[Required]
		[MaxLength(100)]
		public string reqDescription { get; set; }


		// no [key] because not pk here
		[Required]
		[MaxLength(6)]
		public int employeeNum { get; set; }

		public char vacationTypeId { get; set; }

		[Required]
		public DateOnly startDate { get; set; }

		[Required]
		public DateOnly endDate { get; set; }

		[Required]
		public int vacationDaysTotal { get; set; }

		[Required]
		public int reqStateId { get; set; }

		public int? approvedById { get; set; }

		public int? deniedById { get; set; }







		public virtual Employee Employee { get; set; }
		public virtual Vacation Vacation { get; set; }

		public virtual RequestState RequestState { get; set; }



	}
}
