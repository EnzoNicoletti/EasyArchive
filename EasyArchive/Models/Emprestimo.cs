using System.ComponentModel.DataAnnotations;

namespace EasyArchive.Models
{
    public class Emprestimo
    {
        public int EmprestimoId { get; set; }
        [Required]
        [Display(Name = "Aluno")]
        public int AlunoId { get; set; }
        [Required]
        public Aluno? Aluno { get; set; }
        [Required]
        [Display(Name = "Livro a ser emprestado")]
        public int LivroId { get; set; }
        [Required]
        public Livro? Livro { get; set; }
        [Required]
        [Display(Name = "Data de Empréstimo")]
        public DateOnly DataEmprestimo { get; set; }
        [Required]
        [Display(Name = "Data de Devolução")]
        public DateOnly DataDevolucao { get; set; }
    }
}
