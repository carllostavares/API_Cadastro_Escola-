﻿using System.ComponentModel.DataAnnotations;

namespace Escola.Domain.Entities
{
    public class Professor
    {
        [Key]
        [Required(ErrorMessage ="O campo cpf é obrigatório")]
        [StringLength(11)]

        public string ?Cpf { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(200)]
        public string ?Nome { get; set;}

        [Required(ErrorMessage = "O campo dataNascimento é obrigatório")]
        [StringLength(200)]
        public string ?DataNascimento { get; set; }


        [Required(ErrorMessage = "O campo disciplina é obrigatório")]
        [StringLength(200)]
        public string ?Disciplina { get; set; }
    }
}
