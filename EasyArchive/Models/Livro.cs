using System.ComponentModel.DataAnnotations;

namespace EasyArchive.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        [Required (ErrorMessage = "Informe o título do livro")]
        public string? Titulo { get; set; }
        [Required(ErrorMessage = "Informe o autor do livro")]
        public string? Autor { get; set; }
        [Required(ErrorMessage = "Informe a editora do livro")]
        public string? Editora { get; set; }
        [Required(ErrorMessage = "Informe o ano de publicação")]
        [Display(Name = "Ano de Publicação")]
        [MaxLength(4, ErrorMessage = "O ano de publicação tem que ter exatamente 4 dígitos.")]
        [MinLength(4, ErrorMessage = "O ano de publicação tem que ter exatamente 4 dígitos.")]
        public int AnoPublicacao { get; set; }
        public bool Emprestado { get; set; }
    }
}
