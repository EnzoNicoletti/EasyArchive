using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyArchive.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        [Required]
        public string? Titulo { get; set; }
        [Required]
        public string? Autor { get; set; }
        [Required]
        public string? Editora { get; set; }
        [Required]
        [Display(Name = "Ano de Publicação")]
        public DateOnly AnoPublicacao { get; set; }
        public bool Emprestado { get; set; }
    }
}
