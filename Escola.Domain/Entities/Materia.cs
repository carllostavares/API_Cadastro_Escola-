using System.ComponentModel.DataAnnotations;

namespace Escola.Domain.Entities
{
    public class Materia
    {
        [Key]
        [Required(ErrorMessage ="O campo nome é obrigatódio!")]
        public string? id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatódio!")]
        public string? name { get; set; }

        [Required(ErrorMessage = "O campo carga horario é obrigatódio!")]
        public string? cargaHorario { get; set; }

        [Required(ErrorMessage = "O campo cpf professor é obrigatódio!")]
        public string? Cpf { get; set; }

    }
}
