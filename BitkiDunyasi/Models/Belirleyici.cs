using System.ComponentModel.DataAnnotations;

namespace BitkiDunyasi.Models
{
	public class Belirleyici
	{
		[Key]
		public int BelirleyiciID { get; set; }

		[Required]
		public UserDetail UserDetail { get; set; }
		public ICollection<Usercomment> Usercomment { get; set; }
		public ICollection<Bitki> Bitki { get; set; }
	}
}
