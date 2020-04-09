using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.OFSM.Dominio.Entidades
{
    public abstract class Pessoa
    {
        public string Endereco { get; set; }
        public int TelefoneResidencial { get; set; }
        public int TelefoneCelular { get; set; }
        public int RG { get; set; }
        public int CPF { get; set; }
    }
}
