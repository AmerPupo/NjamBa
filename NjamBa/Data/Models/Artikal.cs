using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
namespace NjamBa.Data.Models
{
    public class Artikal
    {
        [Key]
        public int ArtikalId { get; set; }
        public string NazivArtikla { get; set; }
        public byte[] SlikaArtikla { get; set; }
        public float CijenaArtikla { get; set; }
        public string? OpisArtikla { get; set; }
        public int RestoranId {  get; set; }
        
    }
}
