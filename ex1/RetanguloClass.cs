using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public class RetanguloClass : CalculaForma
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public override double CalcForma => Lado1 * Lado2;
    }
}
