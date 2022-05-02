using Microsoft.AspNetCore.Mvc;
using Webpet.data;
using Webpet.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Webpet.Controllers;
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

        [HttpPost("create")]
        public async Task<ContentResult> CreateNewAnimalAcctWithPost([FromBody] List<AnimalName> newNames)
        {
            AnimalName newA = new AnimalName();
            foreach (var stringAnimalItem in newNames)
            {
                newA.Animal_name = stringAnimalItem.Animal_name;
            }
            _context.animal_Names.Add(newA);
            await _context.SaveChangesAsync();


            return new ContentResult() { StatusCode = 201 };

        }


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
                    }

                    var pluto = new pet_image { Name = Name1, image = bytes, ContentType = ContentType };

                    _context.Images.Add(pluto);

                    await _context.SaveChangesAsync();

                    return Ok();

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
}

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
/*
[Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
*/