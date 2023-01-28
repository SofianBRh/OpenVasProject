using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MediaLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Autor { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        public bool Readed { get; set; }
        [Range(0, 20, ErrorMessage = "La veleur de la note doit être en {1} et {2}")]
        public int? Note { get; set; }
        public string? Label { get; set; }

        // Foreign Key Relation
        [Required]
        [StringLength(450)]
        public string UserId { get; set; } = string.Empty;

    }
}