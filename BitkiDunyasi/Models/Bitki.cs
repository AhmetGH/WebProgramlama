using System.ComponentModel.DataAnnotations;

namespace BitkiDunyasi.Models
{
	public class Bitki
	{
		[Key]
	    public int BitkiID { get; set; }
		[Required(ErrorMessage = "Bitki adı girmek zorunldur.")]
		[Display(Name = "Bitki Adı Giriniz")]
		public string bitkiAdi { get; set; }
		[Required(ErrorMessage = "Bitki için açıklama zorunludur.")]
        [Display(Name = "Bitki İçin Açıklama Giriniz")]
        public string aciklama { get; set; }
        [Required(ErrorMessage = "Bitki için Resim eklemek zorunludur.")]
        [Display(Name = "Bitki İçin Resim Ekleyiniz")]
        public string Resim { get; set; }

		public ICollection<Usercomment>? Usercomments { get; set; }
	}
}
