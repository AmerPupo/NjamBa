using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NjamBa.Data.Models
{
    public class UgostiteljskiObjekat
    {

        [Key]
        public string UgostiteljskiObjekatId { get; set; }


        public string NazivObjekta { get; set; }

        public string AdresaObjekta { get; set; }


       

        public int GradId { get; set; }

        [ForeignKey(nameof(GradId))]
        public Grad Grad { get; set; }      
        
       
        
    }
}
