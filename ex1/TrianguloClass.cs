using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public class TrianguloClass : CalculaForma
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public override double CalcForma => (Base * Altura) / 2;
    }
}
