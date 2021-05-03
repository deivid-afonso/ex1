using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public class CirculoClass : CalculaForma
    {
        public double Raio { get; set; }

        public override double CalcForma => Math.Pow(Raio, 2) * Math.PI;
    }
}
