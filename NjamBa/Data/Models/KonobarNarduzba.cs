using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NjamBa.Data.Models
{
    public class KonobarNarudzba
    {
        [Key, Column(Order = 0)]
        public int KonobarId { get; set; }
      

        [Key, Column(Order = 1)]
        public int NarudzbaId { get; set; }
     

       public bool Placeno { get; set; }    
        
    }
}
