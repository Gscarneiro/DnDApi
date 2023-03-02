using System.ComponentModel.DataAnnotations;

namespace DnDProject.Models
{
    public class Feature
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }


        public ICollection<Class> Classes { get; set; }

        public ICollection<SubClass> SubClasses { get; set; }
        
        public ICollection<Race> Races { get; set; }
        
        public ICollection<SubRace> SubRaces { get; set; }
    }
}
