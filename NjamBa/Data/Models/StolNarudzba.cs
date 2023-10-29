using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NjamBa.Data.Models
{
    public class StolNarudzba
    {
        [Key, Column(Order = 0)]
        public int StolId { get; set; }
      

        [Key, Column(Order = 1)]
        public int NarudzbaId { get; set; }
     

      public int? KorisnikId { get; set; }
        
    }
}
