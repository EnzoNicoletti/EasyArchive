namespace EasyArchive.Models
{
    public class Emprestimo
    {
        public int EmprestimoId { get; set; }
        public int AlunoId { get; set; }
        public Aluno? Aluno { get; set; }
        public int LivroId { get; set; }
        public Livro? Livro { get; set; }
        [Required]
        [Display(Name = "Data de Empréstimo")]
        [DataType(DataType.Date, ErrorMessage = "Informe uma data válida.")]
        public DateOnly DataEmprestimo { get; set; }
        [Required]
        [Display(Name = "Data de Devolução")]
        [DataType(DataType.Date, ErrorMessage = "Informe uma data válida.")]
        public DateOnly DataDevolucao { get; set; }
    }
}
