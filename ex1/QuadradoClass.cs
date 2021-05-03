using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public class QuadradoClass : CalculaForma
    {
        public double Lado { get; set; }
        public override double CalcForma => Lado * Lado;
    }
}
