using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace NjamBa.Data.Models
{
    public class Nagrada
    {

        public int NagradaId { get; set; }

        public string NazivNagrade { get; set; }
       

        public int  PotrebniBodovi { get; set; }        

        public string Opis { get; set; }    


        public string UgostiteljskiObjekatId { get; set; }

        [ForeignKey(nameof(UgostiteljskiObjekatId))] 
        public UgostiteljskiObjekat UgostiteljskiObjekat { get; set; }  
    }
}
