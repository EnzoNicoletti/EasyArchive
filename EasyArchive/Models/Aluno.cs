using System.ComponentModel.DataAnnotations;

namespace EasyArchive.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        [Required]
        public string? Nome { get; set; }
        [Required]
        public string? Curso { get; set; }
        [Required]
        public int RM { get; set; }
    }
}
