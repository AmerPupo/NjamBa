using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
namespace NjamBa.Data.Models
{
    public class Stol
    {
        [Key]
        public int StolId { get; set; }
        public int BrojStola {  get; set; }
        public bool Zauzet {  get; set; }
        public bool Rezervisan { get; set; }
        public int RestoranId { get; set; }
        
    }
}
