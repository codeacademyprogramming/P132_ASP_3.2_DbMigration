using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class Service
    {
        public int Id { get; set; }
        [MaxLength(35)]
        public string Title { get; set; }
        [MaxLength(300)]
        public string Desc { get; set; }
        [Required]
        [MaxLength(20)]
        public string Icon { get; set; }
    }
}
