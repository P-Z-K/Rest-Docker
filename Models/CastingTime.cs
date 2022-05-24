using System.ComponentModel.DataAnnotations;

namespace DDSpells.Models
{
    public class CastingTime
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
