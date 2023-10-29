using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
namespace NjamBa.Data.Models
{
    public class Korisnik
    {
        [Key]
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string BrojTelefona { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }
        public int KazneniBodovi { get; set; }
        public int NagradniBodovi { get; set; }

        public int NagradniBodovi { get; set; }
        
    }
}
