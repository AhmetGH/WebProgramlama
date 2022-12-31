using Microsoft.AspNetCore.Identity;

namespace BitkiDunyasi.Models
{
    public class UserDetail :IdentityUser
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public int Tecrube { get; set; }

    }
}