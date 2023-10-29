using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NjamBa.Data;
using NjamBa.Data.Models;

namespace NjamBa.Modules.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {

        private readonly ApplicationDbContext _dbcontext; 
        public KorisnikController(ApplicationDbContext applicationDbContext)
        {
                this._dbcontext = applicationDbContext; 
        }

        [HttpPost]

        public Korisnik RegistracijaKorisnika( )



    }
}
