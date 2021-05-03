using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        public enum Opcoes
        {
            Quadrado = 1,
            Triangulo = 2,
            Retangulo = 3,
            Circulo = 4,
            Sair = 0

        }
        static void Main(string[] args)
        {
            Opcoes opcao = Opcoes.Quadrado;

            while((opcao = GetOpcao()) != Opcoes.Sair)
            {
                CalculaForma calc = null;

                switch(opcao)
                {
                    case Opcoes.Quadrado:
                        calc = FazerQuadrado();
                        break;
                    case Opcoes.Triangulo:
                        calc = FazerTriangulo();
                        break;
                    case Opcoes.Retangulo:
                        calc = FazerRetangulo();
                        break;
                    case Opcoes.Circulo:
                        calc = FazerCirculo();
                        break;
                    default:
                        break;
                }
                Console.WriteLine($" A área do {opcao} é {calc.CalcForma}");
                Console.WriteLine();
            }
            Environment.Exit(0);

        }

        private static CirculoClass FazerCirculo()
        {
            double raio = GetDouble("Raio Círculo : ");
            return new CirculoClass() { Raio = raio };
        }

        private static RetanguloClass FazerRetangulo()
        {
            double lado1 = GetDouble("Lado X retângulo : ");
            double lado2 = GetDouble("Lado Y retângulo : ");
            return new RetanguloClass() 
            { 
                Lado1 = lado1,
                Lado2 = lado2 
            };
        }

        private static TrianguloClass FazerTriangulo()
        {
            double Base = GetDouble("Base triângulo : ");
            double altura = GetDouble("Altura triângulo : ");
            return new TrianguloClass() 
            {
                Base = Base, 
                Altura = altura 
            };
        }

        private static QuadradoClass FazerQuadrado()
        {
            double lado = GetDouble("Lado Quadrado : ");
            return new QuadradoClass() { Lado = lado };
        }

        private static Opcoes GetOpcao()
        {
            Console.WriteLine("Escolha um item para calcular :");
            Console.WriteLine("\t{0} - Quadrado", (int)Opcoes.Quadrado);
            Console.WriteLine("\t{0} - Triângulo", (int)Opcoes.Triangulo);
            Console.WriteLine("\t{0} - Retângulo", (int)Opcoes.Retangulo);
            Console.WriteLine("\t{0} - Círculo", (int)Opcoes.Circulo);
            Console.WriteLine("\t{0} - Sair", (int)Opcoes.Sair);
            Console.WriteLine("Escolha : ");

            string value = Console.ReadLine();

            Opcoes selecionado;
            if (!Enum.TryParse(value, out selecionado) || !Enum.IsDefined(typeof(Opcoes), selecionado ))
            {
                Console.WriteLine("Opção incorreta, Escolha outra!");
                return GetOpcao();
            }
            return selecionado;

        }

        private static double GetDouble(string str)
        {
            bool isTrue = false;
            double valor = 0;

            while(!isTrue)
            {
                Console.Write(str);
                isTrue = double.TryParse(Console.ReadLine(), out valor);
            }
            return valor;
        }
    }
}
