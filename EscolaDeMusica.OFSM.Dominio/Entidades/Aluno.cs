using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.OFSM.Dominio.Entidades
{
    public class Aluno : Pessoa
    {
        public int IdAluno { get; set; }
        public string NomeAluno { get; set; }
        public Boolean InstrumentoProprio { get; set; }
        public string Motivacao { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataMatricula { get; set; }
        public Boolean Matriculado { get; set; }
        
    }
}
