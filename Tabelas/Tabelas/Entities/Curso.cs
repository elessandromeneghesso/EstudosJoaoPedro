using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabelas.Entities
{
    public class Curso
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string IdProfessor { get; set; }
        public string Periodo { get; set; }
        public string IdAluno { get; set; }

        //public Curso(int id, string nome, string idProfessor, string periodo, string idAluno)
        //{
        //    Id=id;
        //    Nome=nome;
        //    IdProfessor=idProfessor;
        //    Periodo=periodo;
        //    IdAluno=idAluno;
        //}
    }
}
