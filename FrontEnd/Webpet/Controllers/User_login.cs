using Microsoft.AspNetCore.Mvc;
using Webpet.data;
using Webpet.Models;
using System.Data.Entity;

namespace Webpet.Controllers
{
    public class User_login : Controller
    {

        private readonly DataContext _context;

        public User_login(DataContext context)
        {
            _context = context;
        }

        [HttpPost("create_user")]
        public async Task<ActionResult<Users_Data>> create(User_Data User_input)
        {

            _context.User.Add(User_input);
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
