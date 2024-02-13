using Escola.Application.Interfaces;
using Escola.Domain.Entities;
using Escola.Infraestrutura.Interfaces;

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
            try
            {
                Materia materia = new Materia();
                materia.Id = id;
                materia.Name = nome;
                materia.CargaHoraria = cargaHoraria;
                materia.CpfProfessor = cpf;

                _materiaRepositorio.SalvarMateria(materia);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }


        }

        public List<Materia> RetornaMateria()
        {
            try
            {
                var materias = _materiaRepositorio.BuscaMateria();
                return materias;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }
    }
}
