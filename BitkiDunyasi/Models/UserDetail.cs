using Microsoft.AspNetCore.Identity;

namespace BitkiDunyasi.Models
{
    public class UserDetail :IdentityUser
    {
        public int UserDetailID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public int Tecrube { get; set; }

		public ICollection<Belirleyici> Belirleyici { get; set; }
    }
}