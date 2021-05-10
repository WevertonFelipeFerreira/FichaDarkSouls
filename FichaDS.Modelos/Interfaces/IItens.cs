using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaDS.Modelos.Interfaces
{
    interface IItens
    {
        int IdSepulcro { get; set; }
        int IdArmadura { get; set; }
        int IdElmo { get; set; }
        int IdManopla { get; set; }
        int IdPerna { get; set; }
        int IdArma1 { get; set; }
        int IdArma2 { get; set; }
        int IdArma3 { get; set; }
        int IdArma4 { get; set; }
        int Estus { get; set; }
    }
}
