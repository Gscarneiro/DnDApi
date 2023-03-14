using System.ComponentModel.DataAnnotations;

namespace DnDApi.Shared.DTOs
{
    public class Feature
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
