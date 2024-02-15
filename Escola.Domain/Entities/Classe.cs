using System.ComponentModel.DataAnnotations;

namespace Escola.Domain.Entities
{
    public class Classe
    {
        [StringLength(11)]
        public string? CpfAluno { get; set; }

        [Required(ErrorMessage = "O campo IdMateria é obrigatório!")]
        public int? IdMateria { get; set; }

        [Required(ErrorMessage = "O campo Sala é obrigatório!")]
        public string? Sala { get; set; }

        public string? NomeProfessor { get; set; }

        public string? NomeMateria { get; set; }

        public List<string>? NomeAluno { get; set; }


    }
}
