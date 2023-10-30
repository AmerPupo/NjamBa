using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NjamBa.Data;
using NjamBa.Data.Models;
using System;
    using NjamBa.Modules.ViewModels;

namespace NjamBa.Modules.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {

        private readonly ApplicationDbContext _dbContext; 
        public KorisnikController(ApplicationDbContext applicationDbContext)
        {
                this._dbContext = applicationDbContext; 

            //KONJINAAAAAAAAAAAAAA
        }
        //Ovo je testiranje
        [HttpPost]

        public Korisnik RegistracijaKorisnika([FromBody] KorisnikRegistracijaVM x)
        {
            Korisnik? objekat;

            if (x.KorisnikId == 0)
            {
                objekat = new Korisnik();
                _dbContext.Add(objekat);//priprema sql
            }
            else
            {
                objekat = _dbContext.Korisnik.Find(x.KorisnikId);
            }

            objekat.Ime = x.Ime;
            objekat.Prezime = x.Prezime;

            _dbContext.SaveChanges();
            return objekat;
        }



    }
}
