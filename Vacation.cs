using System.ComponentModel.DataAnnotations;

namespace VacationRequestTask
{
	public class Vacation
	{

		[Key]
		public char vacationTypeId { get; set; }

		public string vacationTypeName { get; set; }


	}
}