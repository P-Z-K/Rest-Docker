using Microsoft.EntityFrameworkCore;

namespace DDSpells.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Spell> Spells { get; set; }
        public DbSet<SpellSchool> SpellSchools { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<CastingTime> CastingTimes { get; set; }
    }
}
