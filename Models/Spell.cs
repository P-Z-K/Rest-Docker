using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDSpells.Models
{
    public class Spell
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0, 9)]
        public int SpellLevel { get; set; }

        [Required]
        [ForeignKey("SpellId")]
        public int SpellId { get; set; }
        [Required]
        public SpellSchool SpellSchool { get; set; }


        [Required]
        public bool Verbal { get; set; }
        [Required]
        public bool Somatic { get; set; }
        [Required]
        public string Material { get; set; }
        [Required]


        public string Range { get; set; }
        [Required]
        public string Duration { get; set; }

        [Required]
        [ForeignKey("ClassId")]
        public int ClassId { get; set; }
        [Required]
        public Class Class { get; set; }
    }
}
