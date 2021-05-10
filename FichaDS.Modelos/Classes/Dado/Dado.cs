using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaDS.Modelos.Classes.Dado
{
    public class Dado
    {
        Random rnd = new Random();
        public int Rolar(int lados)
        {
            return rnd.Next(1, lados);
        }
    }
}
