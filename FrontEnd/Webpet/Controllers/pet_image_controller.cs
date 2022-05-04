using Microsoft.AspNetCore.Http;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Webpet.data;
using Webpet.Models;
using System.Data.Entity;


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
        public async Task<ActionResult<string>> Get()


        [HttpGet("Getimages")]
        public async Task<ActionResult<string>> Get()
        {
            string names = null;
            foreach (var name in _context.animal_Names) { names = name.anmial_name; }

            return Ok(names);
        }



        [HttpGet("pet")]
        public async Task<FileResult> Getimage(int Id)
        {


            var pet = await _context.Images.FindAsync(Id);




            return File(pet.image, pet.ContentType, pet.Name);
        }




        [HttpPost("create")]
        public async Task<ActionResult<animals_names>> create(animal_name number)
        {

            _context.animal_Names.Add(number);
            await _context.SaveChangesAsync();

        [HttpGet("Getimage")]
        public IActionResult Get()

        {
            string names = null;
            foreach (var name in _context.animal_Names) { names = name.anmial_name; }

            return Ok(names);
        }



        [HttpGet("pet")]
        public async Task<FileResult> Getimage(int Id)
        {


            var pet = await _context.Images.FindAsync(Id);




            return File(pet.image, pet.ContentType, pet.Name);
        }




        [HttpPost("create")]
        public async Task<ActionResult<animals_names>> create(animal_name number)
        {


            _context.animal_Names.Add(number);
            await _context.SaveChangesAsync();


            return Ok();
        }


        [HttpPost]

        public async Task<ActionResult<pet_image>> Index(IFormFile postedFile)


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
                    }


                    var pluto = new pet_image { Name = Name1, image = bytes, ContentType = ContentType };

                    _context.Images.Add(pluto);

                    await _context.SaveChangesAsync();
                }
            }

            return Ok("posted");
        }

        [HttpPost("pet_profile")]
        public async Task<ActionResult<pet_profile>> post([FromQuery] pet_profile_data pet_information, IFormFile postedFile)
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
                    }


                    var duke = new pet_profile { Name = Name1, image = bytes, ContentType = ContentType, Pet_Name = pet_information.Pet_Name, Pet_behavior = pet_information.Pet_behavior };

                    _context.Pet.Add(duke);

                    await _context.SaveChangesAsync();
                }
            }

            return Ok("posted");
        }



        
        [HttpGet("Pet_image")]
        public async Task<FileResult> Get_pet_image(int Id)
        {
            string names = null;
            var pet = await _context.Pet.FindAsync(Id);

            return File(pet.image, pet.ContentType, pet.Name);
        }
    }
}


        public ActionResult Index(IFormFile postedFile)

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
                    }


                    var pluto = new pet_image { Name = Name1, image = bytes, ContentType = ContentType };

                    _context.Images.Add(pluto);

                    await _context.SaveChangesAsync();
                }
            }

            return Ok("posted");
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [HttpPost("pet_profile")]
        public async Task<ActionResult<pet_profile>> post([FromQuery] pet_profile_data pet_information, IFormFile postedFile)
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
                    }


                    var duke = new pet_profile { Name = Name1, image = bytes, ContentType = ContentType, Pet_Name = pet_information.Pet_Name, Pet_behavior = pet_information.Pet_behavior };

                    _context.Pet.Add(duke);

                    await _context.SaveChangesAsync();
                }
            }

            return Ok("posted");
        }



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///
        [HttpGet("Pet_image")]
        public async Task<FileResult> Get_pet_image(int Id)
        {
            string names = null;
            var pet = await _context.Pet.FindAsync(Id);

            return File(pet.image, pet.ContentType, pet.Name);
        }
    }
}

