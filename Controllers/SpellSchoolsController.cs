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
    public class SpellSchoolsController : ControllerBase
    {
        private readonly DataContext _context;

        public SpellSchoolsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/SpellSchools
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SpellSchool>>> GetSpellSchools()
        {
            return await _context.SpellSchools.ToListAsync();
        }

        // GET: api/SpellSchools/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SpellSchool>> GetSpellSchool(int id)
        {
            var spellSchool = await _context.SpellSchools.FindAsync(id);

            if (spellSchool == null)
            {
                return NotFound();
            }

            return spellSchool;
        }
    }
}
