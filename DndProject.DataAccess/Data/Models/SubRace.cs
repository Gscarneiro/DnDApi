using System.ComponentModel.DataAnnotations;

namespace DnDProject.Models
{
    public class SubRace
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public ICollection<Feature> Features { get; set; }
    }
}
