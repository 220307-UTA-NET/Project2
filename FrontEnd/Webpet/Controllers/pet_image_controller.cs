using Microsoft.AspNetCore.Http;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Webpet.data;
using Webpet.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Net.Http;




namespace Webpet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pet_image_controller : ControllerBase
    {

        private readonly DataContext _context;

        public pet_image_controller(DataContext context)
        {
            _context = context;
        }


        [HttpGet("Getimages")]
        public async Task<ActionResult<string>> GetAllNames()
        {
            string names = null;
            foreach (var name in _context.animal_Names) { names = name.Animal_name; }
            return Ok(names);
        }

        [HttpGet("pet")]
        public async Task<FileResult> Getimage(int Id)
        {
            var pet = await _context.Images.FindAsync(Id);

            return File(pet.image, pet.ContentType, pet.Name);

        }

        //public async Task<ContentResult> CreateNewUserWithPost([FromBody] List<User> newAccts)
        //{

        //    foreach (var stringUserItem in newAccts)
        //    {
        //        string username = stringUserItem.Username;
        //        string password = stringUserItem.UserPassword;
        //        string firstName = stringUserItem.FirstName;
        //        string lastName = stringUserItem.LastName;
        //        await _repository.CreateNewUser(username, password, firstName, lastName);
        //    }

        //    return new ContentResult() { StatusCode = 201 };
        //}

        [HttpPost("create")]
        public async Task<ContentResult> CreateNewAnimalAcctWithPost([FromBody] List<AnimalName> newNames)
        {
            AnimalName newA = new AnimalName();
            foreach (var stringAnimalItem in newNames)
            {
                newA.Animal_name = stringAnimalItem.Animal_name;
                
                //await _context.animal_Names(animal);
            }
            _context.animal_Names.Add(newA);
            await _context.SaveChangesAsync();


            return new ContentResult() { StatusCode = 201 };

        }







        /*
                [HttpPost("create")]
                public async Task<ActionResult<AnimalName>> create(string Animal)
                {

                    AnimalName animal = new AnimalName();
                    animal.Animal_name = Animal;
                    DataContext context1 = _context;
                    context1.animal_Names.Add(animal);

                    await context1.SaveChangesAsync();

                    return Ok();
                }

        */


        [HttpPost]
        public async Task<ActionResult<pet_image>> Index(IFormFile postedFile)
        {
            if (postedFile != null)
            {
                
                if (postedFile.Length > 0)
                {
                    byte[] bytes = null;
                    string Name1;
                    string ContentType;

                    using (var ms = new MemoryStream())
                    {
                        postedFile.CopyTo(ms);
                        bytes = ms.ToArray();
                        Name1 = Path.GetFileName(postedFile.Name);
                        ContentType = postedFile.ContentType;
                        //ContentType = Path.GetExtension(postedFile.ContentType);
                    }

                    var pluto = new pet_image { Name = Name1, image = bytes, ContentType = ContentType };

                    _context.Images.Add(pluto);


                    //_context.animal_Names.Add(number);


                    await _context.SaveChangesAsync();
                    //DbSet<pluto> Images;
                    // public DbSet<pet_image> Images { get; set; }

                    return Ok();

                    //return new ContentK?Result() { StatusCode = 201 };
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest();
            }
        }
    }










    //[HttpPost("pet")]
    //public IActionResult create([FromBody] data.pet_image request)
    //{
    //    return Ok();
    //}


    //[HttpPost]
    //public ActionResult Index(IFormFile postedFile)
    //{
    //    byte[] bytes;
    //    using (BinaryReader br = new BinaryReader(postedFile.OpenReadStream()))
    //    {
    //        bytes = br.ReadBytes(postedFile.Length);
    //    }

    //    _context.Images.Add(new Models.pet_image
    //    {
    //        Name = Path.GetFileName(postedFile.Name),
    //        image = bytes,
    //        Id = 1,
    //    });
    //    /* FilesEntities entities = new FilesEntities();
    //     entities.tblFiles.Add(new tblFile
    //     {
    //         Name = Path.GetFileName(postedFile.Name),
    //         ContentType = postedFile.ContentType,
    //         Data = bytes
    //     });
    //     entities.SaveChanges();*/
    //    return RedirectToAction("Index");
    //}
}
