using System.ComponentModel.DataAnnotations;

namespace EasyArchive.Models
{
    public class Emprestimo
    {
        public int EmprestimoId { get; set; }
        [Required(ErrorMessage = "Informe o aluno do empréstimo")]
        [Display(Name = "Aluno a emprestar")]
        public int AlunoId { get; set; }
        [Required]
        public Aluno? Aluno { get; set; }
        [Required(ErrorMessage = "Informe o livro a ser emprestado")]
        [Display(Name = "Livro a ser emprestado")]
        public int LivroId { get; set; }
        [Required]
        public Livro? Livro { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data do Empréstimo")]
        public DateTime DataEmprestimo { get; set; }
        [Required]
        [Display(Name = "Data de Devolução")]
        [DataType(DataType.Date, ErrorMessage = "Informe uma data válida.")]
        public DateOnly DataDevolucao { get; set; }
    }
}
