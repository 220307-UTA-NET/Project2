using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Webpet.data;
using Webpet.Models;

namespace Webpet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class pet_dates_controller : Controller
    {

        private readonly DataContext _context;

        public pet_dates_controller(DataContext context)
        {
            _context = context;
        }

        [HttpPost("dates")]
        public async Task<ActionResult<pet_Dates_Table>> create(pet_Dates_Table pet_dates)
        {

            _context.PetDate.Add(pet_dates);
            await _context.SaveChangesAsync();

            return Ok();

        }

        [HttpGet("appoitments")]
        public async Task<List<pet_Dates_Table>> Getappoitments()
        {







            return (_context.PetDate.ToList());
        }


    }
}
