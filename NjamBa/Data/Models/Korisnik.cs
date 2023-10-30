using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NjamBa.Data.Models
{
    public class Korisnik
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string? VerifikacijskiToken { get; set; }
        public DateTime? Verifikovan {  get; set; }
        public string? PasswordResetToken { get; set; }
        public DateTime? ResetTokenIstice { get; set; }
        public string HashedPassword { get; set; }
        public string BrojTelefona { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }
        public int KazneniBodovi { get; set; }
        public int NagradniBodovi { get; set; }

        
    }
}
