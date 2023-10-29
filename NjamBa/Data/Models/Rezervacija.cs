using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
namespace NjamBa.Data.Models
{
    public class Rezervacija
    {
        [Key]
        public int RezervacijaId { get; set; }
        public int KorisnikId { get; set; }
        public int StolId { get; set; }
        public DateTime VrijemeRezervacije { get; set; }
        public int BrojOsoba { get; set; }
        
    }
}
