using Microsoft.AspNetCore.Http;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Webpet.data;
using Webpet.Models;

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


        [HttpGet("Getimage")]
        public IActionResult Get()
        {
            string hi = "hello";
            return Ok(hi);
        }


        [HttpPost("create")]
        public IActionResult create([FromBody] image_data request)
        {
            return Ok();
        }


        [HttpPost]
        public ActionResult Index(IFormFile postedFile)
        {
            byte[] bytes;
            using (BinaryReader br = new BinaryReader(postedFile.OpenReadStream()))
            {
                bytes = br.ReadBytes(postedFile.Length);
            }

            _context.Images.Add(new pet_image
            {
                Name = Path.GetFileName(postedFile.Name),
                image = bytes,
                Id = 1,
            });
            /* FilesEntities entities = new FilesEntities();
             entities.tblFiles.Add(new tblFile
             {
                 Name = Path.GetFileName(postedFile.Name),
                 ContentType = postedFile.ContentType,
                 Data = bytes
             });
             entities.SaveChanges();*/
            return RedirectToAction("Index");
        }

    }
}
