using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NjamBa.Data.Models
{
    public class KorisnikBodovi
    {


        [Key, Column(Order = 0)]

        public int KorisnikId { get; set; }

        [Key, Column(Order = 1)]

        public string UgostiteljskiObjekatId { get; set; }



        public int BrojBodova { get; set; } 



    }
}
