using NjamBa.Data;
namespace NjamBa.Modules.ViewModels
{
    public class KorisnikRegistracijaVM
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }


    }
}
