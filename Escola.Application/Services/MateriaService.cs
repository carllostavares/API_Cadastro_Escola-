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
    internal class MateriaService : IMateriaService
    {
        private readonly IMateriaRepositorio _materiaRepositorio;

        public MateriaService(IMateriaRepositorio materiaRepositorio)
        {
            _materiaRepositorio = materiaRepositorio;
        }

        public Materia InserirMateria(Materia materia)
        {
            var novaMateria = _materiaRepositorio.SalvarMateria(materia);

            return novaMateria;
        }
    }
}
