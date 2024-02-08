using System.ComponentModel.DataAnnotations;

namespace Escola.Domain.Entities
{
    public class Alunos
    {
        [Key]
        [Required(ErrorMessage = "O campo cpf é obrigatório!")]
        [StringLength(11)]
        public string ?Cpf { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório!")]
        [StringLength(200)]
        public string ?Nome { get; set; }

        [Required(ErrorMessage = "O campo dataNascimento é obrigatório!")]
        [StringLength(300)]
        public string ?DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo IdMateria é obrigatório!")]
        [StringLength(300)]
        public string? IdMateria { get; set; }

    }
}
