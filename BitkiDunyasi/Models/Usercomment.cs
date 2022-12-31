using System.ComponentModel.DataAnnotations;

namespace BitkiDunyasi.Models
{
	public class Usercomment
	{
		public int UsercommentID { get; set; }
		public string kullaniciYorumu { get; set; }

		public int BitkiID { get; set; }

		public Bitki Bitki { get; set; }
	}
}