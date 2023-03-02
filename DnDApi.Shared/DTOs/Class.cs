using System.ComponentModel.DataAnnotations;

namespace DnDApi.Shared.DTOs
{
    public class Class
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public int HitDice { get; set; }

        [Required]
        public string SavingThrows { get; set; }

        [Required]
        public string Skills { get; set; }

        public string ArmorProficiency { get; set; }

        public string WeaponProficiency { get; set; }

        public string ToolsProficiency { get; set; }

        public ICollection<Feature> Features { get; set; }

        public ICollection<SubClass> SubClasses { get; set; }
    }
}
