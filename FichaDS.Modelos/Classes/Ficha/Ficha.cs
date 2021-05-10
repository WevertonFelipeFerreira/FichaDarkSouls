using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FichaDS.Modelos.Interface;

namespace FichaDS.Modelos.Classes.Ficha
{
    public class Ficha : Ificha
    {
        public int Id { get; set; }
        public string NomeDoJogador {get; set;}
        public string NomeDoHeroi {get; set;}
        public string Classe {get; set;}
        public int Nivel {get; set;}
        public int PM {get; set;}
        public int PV {get; set;}
        public int Vigor {get; set;}
        public int Conhecimento {get; set;}
        public int Fortitude {get; set;}
        public int Vitalidade {get; set;}
        public int Forca {get; set;}
        public int Destreza {get; set;}
        public int Inteligencia {get; set;}
        public int Fe {get; set;}
        public int Sorte {get; set;}
        public int DefesaFisica {get; set;}
        public int DefesaMagica {get; set;}
        public int AtaqueFisico {get; set;}
        public int AtaqueMagico {get; set;}
        public int IdSepulcro {get; set;}
        public int IdArmadura {get; set;}
        public int IdElmo {get; set;}
        public int IdManopla {get; set;}
        public int IdPerna {get; set;}
        public int IdArma1 {get; set;}
        public int IdArma2 {get; set;}
        public int IdArma3 {get; set;}
        public int IdArma4 {get; set;}
        public int Estus {get; set;}
    }
}
