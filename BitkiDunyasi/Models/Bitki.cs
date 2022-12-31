using System.ComponentModel.DataAnnotations;

namespace BitkiDunyasi.Models
{
	public class Bitki
	{
		[Key]
	    public int BitkiID { get; set; }
		[Required]
		[Display(Name ="Bitki Adı Giriniz")]
		public string bitkiAdi { get; set; }
		[Required]
        [Display(Name = "Bitki İçin Açıklama Giriniz")]
        public string aciklama { get; set; }
        [Display(Name = "Bitki İçin Resim Ekleyiniz")]
        public int Resim { get; set; }

		public ICollection<Usercomment>? Usercomments { get; set; }
	}
}
