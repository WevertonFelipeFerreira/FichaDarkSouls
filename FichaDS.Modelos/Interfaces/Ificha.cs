using FichaDS.Modelos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaDS.Modelos.Interface
{
    interface Ificha : Iid,IAtributos,IItens
    {

        string NomeDoJogador { get; set; }
        string NomeDoHeroi { get; set; }
        string Classe { get; set; }
        int Nivel { get; set; }
        public int PM { get; set; }
        public int PV { get; set; }

    }
}
