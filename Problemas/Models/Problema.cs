using System.ComponentModel.DataAnnotations;

namespace Problemas.Models
{
    public class Problema
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string More { get; set; }
    }
}
    