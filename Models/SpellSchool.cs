using System.ComponentModel.DataAnnotations;

namespace DDSpells.Models
{
    public class SpellSchool
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
