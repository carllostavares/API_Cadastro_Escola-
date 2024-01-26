using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Escola.Domain.Entities
{
    public class Aluno
    {
        [Key]
        [Required(ErrorMessage = "O campo Id é obrigatório!")]
        public string ?IdCpf { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório!")]
        [StringLength(200)]
        public string ?Nome { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório!")]
        [StringLength(300)]
        public string DataNascimento { get; set; }
    }
}
