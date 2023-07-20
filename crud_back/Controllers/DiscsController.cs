using crud_back.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace crud_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiscsController : ControllerBase
    {
        private static List<Disc> _discs = new List<Disc>
        {
            new Disc { Id = 1, Name = "Destroyer", Type = "Driver", Plastic = "Star", Speed = 12, Glide = 5, Turn = -1, Fade = 3 },
            new Disc { Id = 2, Name = "Buzz", Type = "Midrange", Plastic = "ESP", Speed = 5, Glide = 4, Turn = 0, Fade = 2 },
            new Disc { Id = 3, Name = "P2", Type = "Putter", Plastic = "D-line", Speed = 2, Glide = 3, Turn = 0, Fade = 1 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Disc>> Get()
        {
            return Ok(_discs);
        }
    }
}
