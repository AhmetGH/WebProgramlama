using System.ComponentModel.DataAnnotations;

namespace BitkiDunyasi.Models
{
	public class Bitki
	{
	    public int BitkiID { get; set; }
		[Required]
		public string bitkiAdi { get; set; }
		[Required]
		public string aciklama { get; set; }
		public int Resim { get; set; }
		[Required]
		public int BelirleyiciID { get; set; }
		[Required]
		public Belirleyici Belirleyici { get; set; }

		public ICollection<Usercomment> Usercomment { get; set; }
	}
}
