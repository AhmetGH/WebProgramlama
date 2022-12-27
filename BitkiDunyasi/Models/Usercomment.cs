using System.ComponentModel.DataAnnotations;

namespace BitkiDunyasi.Models
{
	public class Usercomment
	{
		[Key]
		public int kullaniciYorumId { get; set; }
		public String kullaniciYorumu { get; set; }

		public UserDetails UserDetails { get; set; }
		public Bitki Bitki { get; set; }
	}
}