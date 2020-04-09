using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.OFSM.Dominio.Entidades
{
    public class Professor : Pessoa
    {
        public int IdProfessor { get; set; }
        public string NomeProfessor { get; set; }
        public Aluno Aluno { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
    }
}
