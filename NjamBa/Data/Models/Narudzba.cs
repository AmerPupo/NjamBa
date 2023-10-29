using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
namespace NjamBa.Data.Models
{
    public class Narudzba
    {
        [Key]
        public int NarudzbaId { get; set; }
        public List<Artikal> Artikli { get; set; }
        public float UkupnaCijena { get; set; }
        public DateTime VrijemeNarucivanja { get; set; }
        public bool Gotova { get; set; }
        
    }
}
