using System.ComponentModel.DataAnnotations;

namespace Escola.Domain.Entities
{
    public class Classe
    {
        [Required(ErrorMessage = "O campo cpf é obrigatório!")]
        [StringLength(11)]
        public string? CpfAluno { get; set; }

        [Required(ErrorMessage = "O campo IdMateria é obrigatório!")]
        public string? IdMateria { get; set; }

        [Required(ErrorMessage = "O campo Sala é obrigatório!")]
        public string? Sala { get; set; }
    }
}
