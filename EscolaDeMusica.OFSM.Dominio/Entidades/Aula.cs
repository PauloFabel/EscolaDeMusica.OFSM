using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.OFSM.Dominio.Entidades
{
    public class Aula
    {
        public Aluno AlunoRealizandoAula { get; set; }
        public Professor ProfessorResponsavel { get; set; }
        public DateTime DataAulaRealizada { get; set; }
    }
}
