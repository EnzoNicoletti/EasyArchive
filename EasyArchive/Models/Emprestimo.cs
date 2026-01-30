namespace EasyArchive.Models
{
    public class Emprestimo
    {
        public int EmprestimoId { get; set; }
        public int AlunoId { get; set; }
        public Aluno? Aluno { get; set; }
        public int LivroId { get; set; }
        public Livro? Livro { get; set; }
        public DateOnly DataEmprestimo { get; set; }
        public DateOnly DataDevolucao { get; set; }
    }
}
