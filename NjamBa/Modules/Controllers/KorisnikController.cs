using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NjamBa.Data;
using NjamBa.Data.Models;
using System;
    using NjamBa.Modules.ViewModels;
using System.Security.Cryptography;

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

        }
        [HttpPost("KorisnikRegistracija")]

        public async Task<IActionResult> RegistracijaKorisnika([FromBody] KorisnikRegistracijaVM x)
        {
           if(_dbContext.Korisnik.Any(u => u.Email == x.Email))
            {
                return BadRequest("Email vec u upotrebi.");
            }


            var objekat = new Korisnik
            {

                Ime = x.Ime,
                Prezime = x.Prezime,
                Adresa = x.Adresa,
                DatumRodjenja = x.DatumRodjenja,
                BrojTelefona = x.BrojTelefona,
                Email = x.Email,
                HashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(x.Password, 13),
                KazneniBodovi = 0,
                NagradniBodovi = 0,
                VerifikacijskiToken = CreateRandomToken(),

            };
            if (BCrypt.Net.BCrypt.EnhancedVerify(x.ConfirmPassword, objekat.HashedPassword))
                _dbContext.Add(objekat);//priprema sql
            else
                return BadRequest("Sifre se ne podudaraju.");


           await _dbContext.SaveChangesAsync();
            return Ok("Korisnik uspjesno registrovan");
        }
        private string CreateRandomToken()
        {
            return Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
        }



    }
}
