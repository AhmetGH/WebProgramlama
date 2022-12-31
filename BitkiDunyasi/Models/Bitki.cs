using System.ComponentModel.DataAnnotations;

namespace BitkiDunyasi.Models
{
	public class Bitki
	{
		[Key]
	    public int BitkiID { get; set; }
		[Required]
		public string bitkiAdi { get; set; }
		[Required]
		public string aciklama { get; set; }
		public int Resim { get; set; }

		public ICollection<Usercomment>? Usercomments { get; set; }
	}
}
