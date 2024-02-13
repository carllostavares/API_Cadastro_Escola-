using System.ComponentModel.DataAnnotations;

namespace Escola.Domain.Entities
{
    public class Materia
    {
        [Key]
        [Required(ErrorMessage ="O campo nome é obrigatódio!")]
        public string? Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatódio!")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "O campo carga horario é obrigatódio!")]
        public int? CargaHoraria { get; set; }

        [Required(ErrorMessage = "O campo cpf professor é obrigatódio!")]
        public string? CpfProfessor { get; set; }

    }
}
