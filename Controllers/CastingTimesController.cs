using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DDSpells.Models;

namespace DDSpells.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastingTimesController : ControllerBase
    {
        private readonly DataContext _context;

        public CastingTimesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/CastingTimes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CastingTime>>> GetCastingTimes()
        {
            return await _context.CastingTimes.ToListAsync();
        }

        // GET: api/CastingTimes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CastingTime>> GetCastingTime(int id)
        {
            var castingTime = await _context.CastingTimes.FindAsync(id);

            if (castingTime == null)
            {
                return NotFound();
            }

            return castingTime;
        }
    }
}
