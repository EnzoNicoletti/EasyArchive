using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyArchive.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        [Required(ErrorMessage = "Informe o título do livro")]
        [StringLength(30, ErrorMessage = "O título do livro tem que ter 30 caracteres no máximo.")]
        public string? Titulo { get; set; }
        [Required(ErrorMessage = "Informe o autor do livro")]
        [StringLength(30, ErrorMessage = "O Autor do livro tem que ter 30 caracteres no máximo.")]
        public string? Autor { get; set; }
        [Required(ErrorMessage = "Informe a editora do livro")]
        [StringLength(30, ErrorMessage = "A editora do livro tem que ter 30 caracteres no máximo.")]
        public string? Editora { get; set; }
        [Required(ErrorMessage = "Informe o ano de publicação")]
        [DataType(DataType.Password)]
        [Display(Name = "Ano de Publicação")]
        [Range(1000, 2026, ErrorMessage = "Escreva um ano válido")]
        public int AnoPublicacao { get; set; }
        public bool Emprestado { get; set; }
    }
}
