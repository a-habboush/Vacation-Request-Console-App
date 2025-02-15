using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VacationRequestTask
{
	public class Position
	{

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int positionId { get; set; }



		[Required]
		[MaxLength(30)]
		public string positionName { get; set; }

	}
}