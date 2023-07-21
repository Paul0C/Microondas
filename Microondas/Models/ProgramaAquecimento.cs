using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microondas.Models
{
    public class ProgramaAquecimento
    {
        public string Nome { get; set;}
        public string Alimento { get; set;}
        public int Tempo { get; set;}
        public int Potencia { get; set;}
        public string CaracterAquecimento { get; set;}
        public string Instrucoes { get; set;}
    }
}