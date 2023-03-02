using DnDApi.Enums;
using System.ComponentModel.DataAnnotations;

namespace DnDApi.Shared.DTOs
{
    public class Race
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Size { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Speed { get; set; }
        
        public string FlySpeed { get; set; }
        
        public string SwimSpeed { get; set; }
        
        public ICollection<Feature> Features { get; set; }
        
        public ICollection<SubRace> SubRaces { get; set; }
    }
}
