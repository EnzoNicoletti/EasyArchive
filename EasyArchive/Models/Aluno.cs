using System.ComponentModel.DataAnnotations;

namespace EasyArchive.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        [Required(ErrorMessage = "Escreva o nome do aluno")]
        [StringLength(50, ErrorMessage = "O nome do aluno não pode ter mais que 50 caracteres.")]
        [Display(Name = "Nome do Aluno")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Escreva o curso do aluno")]
        [StringLength(30, ErrorMessage = "O Curso do aluno não pode ter mais que 30 caracteres.")]
        [Display(Name = "Curso do Aluno")]
        public string? Curso { get; set; }
        [Required(ErrorMessage = "O RM do aluno é obrigatório")]
        [MaxLength(4, ErrorMessage = "O RM do aluno tem que ter exatamente 4 dígitos.")]
        [MinLength(4, ErrorMessage = "O RM do aluno tem que ter exatamente 4 dígitos.")]
        [Display(Name = "RM do Aluno")]
        public int RM { get; set; }
    }
}
