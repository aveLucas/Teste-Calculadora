using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Calculadora.Classes;

namespace calculos.Classes
{
    public class Menu
    {
        public void MenuOp()
        {
            Calculos calculos = new Calculos();
            bool loop = true;
            while(loop)
            {
                Console.Clear();

                Title("Calculadora");
                
                Console.WriteLine("  1 - Soma");
                Console.WriteLine("  2 - Subtração");
                Console.WriteLine("  3 - Multiplicação");
                Console.WriteLine("  4 - Divisão");
                Console.WriteLine("  5 - Raiz quadrada");
                Console.WriteLine("  6 - Potência");
                Console.WriteLine("  7 - Seno");
                Console.WriteLine("  8 - Coseno");
                Console.WriteLine("  9 - Tangente");
                Console.WriteLine("  10 - incremento");
                Console.WriteLine("  11 - decremento");
                Console.WriteLine("  0 - Sair");
                Console.Write("  Digite sua opção: ");

                int opcao = Convert.ToInt32(Console.ReadLine()!);
                switch (opcao)
                {
                    case 1: calculos.Soma();
                        break;
                    case 2: calculos.Subtração();
                        break;
                    case 3: calculos.Multiplicação();
                        break;
                    case 4: calculos.Divisão();
                        break;
                    case 5: calculos.RaizQuadrada();
                        break;
                    case 6: calculos.Potência();
                        break;
                    case 7: calculos.Seno();
                        break;
                    case 8: calculos.Coseno();
                        break;
                    case 9: calculos.Tangente();
                        break;
                    case 10: calculos.Incremento();
                        break;
                    case 11: calculos.Decremento();
                        break;
                    case 0: Console.WriteLine("  Desligando...");
                            Thread.Sleep(1000);
                            Environment.Exit(0);
                        break;
                    default: Console.WriteLine("  Opção Inválida!");
                             Thread.Sleep(1000);
                             loop = true;
                        break;
                }
            }
        }


        public void Title(string titulo)
        {
            int quantidadeDeLetras = titulo.Length ;
            string traço = string.Empty.PadLeft(quantidadeDeLetras, '-');
            Console.WriteLine(traço);
            Console.WriteLine(titulo);
            Console.WriteLine(traço + "\n");
        }


    }
}