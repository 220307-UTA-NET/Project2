using Microsoft.AspNetCore.Mvc;
using Webpet.data;
using Webpet.Models;
using System.Data.Entity;

namespace Webpet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class User_login : Controller
    {

        private readonly DataContext _context;

        public User_login(DataContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<Users_Data>> create(User_Data create_user)
        {

            _context.User.Add(create_user);
            await _context.SaveChangesAsync();

            return Ok();
        }




        [HttpGet("User")]
        public async Task<User_Data> Getuser(int Id)
        {


            var User = await _context.User.FindAsync(Id);




            return (User);
        }
    }
}
