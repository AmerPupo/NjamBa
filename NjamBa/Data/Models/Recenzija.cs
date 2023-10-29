using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NjamBa.Data.Models
{
    public class Recenzija
    {
        [Key, Column(Order = 0)]

        public int KorisnikId { get; set; }

        [Key, Column(Order = 1)]

        public int RestoranId { get; set; }

        public float Ocjena { get; set; }
        public string? Opis { get; set; }
        public byte[]? Slika { get; set; }  
        
    }
}
