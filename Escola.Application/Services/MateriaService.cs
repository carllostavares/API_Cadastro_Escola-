using Escola.Application.Interfaces;
using Escola.Domain.Entities;
using Escola.Infraestrutura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Application.Services
{
    public class MateriaService : IMateriaService
    {
        private readonly IMateriaRepositorio _materiaRepositorio;

        public MateriaService(IMateriaRepositorio materiaRepositorio)
        {
            _materiaRepositorio = materiaRepositorio;
        }

        public void InserirMateria(string id, string nome, int cargaHoraria, string cpf)
        {
            Materia materia = new Materia();
            materia.Id = id;
            materia.Name = nome;
            materia.CargaHoraria = cargaHoraria;
            materia.Cpf = cpf;

            _materiaRepositorio.SalvarMateria(materia);

        }
    }
}
