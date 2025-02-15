using System.ComponentModel.DataAnnotations;

namespace VacationRequestTask
{
	public class RequestState
	{

		[Key]
		public int reqStateId { get; set; }


		[Required]
		[MaxLength(10)]
		public string reqStateName { get; set; }

	}
}