using System.ComponentModel.DataAnnotations;

namespace BitkiDunyasi.Models
{
	public class Usercomment
	{
		public int UsercommentID { get; set; }
		public string kullaniciYorumu { get; set; }

		[Required]
		public int BitkiID { get; set; }
		[Required]

		public int BelirleyiciID { get; set; }

		[Required]
		public Belirleyici Belirleyici { get; set; }
		[Required]
		public Bitki Bitki { get; set; }
	}
}