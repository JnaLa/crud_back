﻿using crud_back.Data;
using crud_back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace crud_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiscsController : ControllerBase
    {
        /*private static List<Disc> _discs = new List<Disc>
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
        */

        private readonly DiscDbContext _discDbContext;

        public DiscsController(DiscDbContext discDbContext)
        {
            _discDbContext = discDbContext;
        }

        [HttpGet]

        public async Task<IActionResult> GetAllDiscs()
        {
            var discs = await _discDbContext.Discs.ToListAsync();

            return Ok(discs);
        }

        [HttpPost]

        public async Task<IActionResult> AddDisc([FromBody] Disc discRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _discDbContext.Discs.AddAsync(discRequest);
            await _discDbContext.SaveChangesAsync();

            return Ok(discRequest);
        }
    }
}