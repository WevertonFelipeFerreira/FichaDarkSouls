using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaDS.Modelos.Interfaces
{
    interface IAtributos
    {
        int Vigor { get; set; }
        int Conhecimento { get; set; }
        int Fortitude { get; set; }
        int Vitalidade { get; set; }
        int Forca { get; set; }
        int Destreza { get; set; }
        int Inteligencia { get; set; }
        int Fe { get; set; }
        int Sorte { get; set; }
        int DefesaFisica { get; set; }
        int DefesaMagica { get; set; }
        int AtaqueFisico { get; set; }
        int AtaqueMagico { get; set; }
    }
}
