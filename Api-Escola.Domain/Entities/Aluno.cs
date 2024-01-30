using System.ComponentModel.DataAnnotations;

namespace Api.Escola.Domain.Entities
{
    public class Alunos
    {
        [Key]
        [Required(ErrorMessage = "O campo Id é obrigatório!")]
        public string ?IdCpf { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório!")]
        [StringLength(200)]
        public string ?Nome { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório!")]
        [StringLength(300)]
        public string ?DataNascimento { get; set; }

    }
}
