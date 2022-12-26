using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebProgramlama.Models
{
    public class UserDetails:IdentityUser
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public int Tecrube { get; set; }
    }
}
