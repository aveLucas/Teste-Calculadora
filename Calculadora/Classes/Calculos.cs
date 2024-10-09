using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using calculos.Classes;

namespace Calculadora.Classes
{
    public class Calculos
    {
        
        Menu menu = new Menu();
      
        public void Soma()
        {
            bool loop = true;
            while (loop){
                Console.Clear();
                menu.Title("Soma");
                Console.Write("  Valor 1: ");
                int x = int.Parse(Console.ReadLine()!);
                Console.Write("  Valor 2: ");
                int y = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"  A soma de {x} e {y} é: {x + y}");  
                Thread.Sleep(1000);

                Console.WriteLine("\n  Deseja realizar mais um cálculo?");
                Console.Write($"  S/N: ");
                string opcao = Console.ReadLine()!;  
                switch (opcao)
                {
                    case "S" or "s": loop = true;
                        break;
                    case "N" or "n": loop = false;
                                    Console.WriteLine("  Retornando ao menu...");
                                     Thread.Sleep(1000);
                                     menu.MenuOp();
                        break;
                    default: loop = false; 
                             Console.WriteLine("\n  Opção Inválida!");
                             Thread.Sleep(1000);
                             Console.WriteLine("  Retornando ao menu...");
                             Thread.Sleep(1000);
                             menu.MenuOp();
                        break;
                }
            }


       
        }
        
        public void Subtração()
        {
            bool loop = true;
            while(loop)
            {
                Console.Clear();
                menu.Title("Subtração");
                Console.Write("  Valor 1: ");
                int x = int.Parse(Console.ReadLine()!);
                Console.Write("  Valor 2: ");
                int y = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"  A subtração de {x} e {y} é: {x - y}");
                Thread.Sleep(1000);

                Console.WriteLine("\n  Deseja realizar mais um cálculo?");
                Console.Write($"  S/N: ");
                string opcao = Console.ReadLine()!;  
                switch (opcao)
                {
                    case "S" or "s": loop = true;
                        break;
                    case "N" or "n": loop = false;
                                    Console.WriteLine("  Retornando ao menu...");
                                     Thread.Sleep(1000);
                                     menu.MenuOp();
                        break;
                    default: loop = false; 
                             Console.WriteLine("\n  Opção Inválida!");
                             Thread.Sleep(1000);
                             Console.WriteLine("  Retornando ao menu...");
                             Thread.Sleep(1000);
                             menu.MenuOp();
                        break;
                }
            }

        }
  
        public void Multiplicação()
        {
            bool loop = true;
            while(loop)
            {
                Console.Clear();
                menu.Title("Multiplicação");
                Console.Write("  Valor 1: ");
                int x = int.Parse(Console.ReadLine()!);
                Console.Write("  Valor 2: ");
                int y = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"  {x} vezes {y} é: {x * y}");
                Thread.Sleep(1000);

                Console.WriteLine("\n  Deseja realizar mais um cálculo?");
                Console.Write($"  S/N: ");
                string opcao = Console.ReadLine()!;  
                switch (opcao)
                {
                    case "S" or "s": loop = true;
                        break;
                    case "N" or "n": loop = false;
                                    Console.WriteLine("  Retornando ao menu...");
                                     Thread.Sleep(1000);
                                     menu.MenuOp();
                        break;
                    default: loop = false; 
                             Console.WriteLine("\n  Opção Inválida!");
                             Thread.Sleep(1000);
                             Console.WriteLine("  Retornando ao menu...");
                             Thread.Sleep(1000);
                             menu.MenuOp();
                        break;
                }
            }

        }

        public void Divisão()
        {
            bool loop = true;
            while(loop)
            {
                Console.Clear();
                menu.Title("Divisão");
                Console.Write("  Valor 1: ");
                int x = int.Parse(Console.ReadLine()!);
                Console.Write("  Valor 2: ");
                int y = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"  {x} dividido por {y} é: {x / y}");
                Thread.Sleep(1000);

                Console.WriteLine("\n  Deseja realizar mais um cálculo?");
                Console.Write($"  S/N: ");
                string opcao = Console.ReadLine()!;  
                switch (opcao)
                {
                    case "S" or "s": loop = true;
                        break;
                    case "N" or "n": loop = false;
                                    Console.WriteLine("  Retornando ao menu...");
                                     Thread.Sleep(1000);
                                     menu.MenuOp();
                        break;
                    default: loop = false; 
                             Console.WriteLine("\n  Opção Inválida!");
                             Thread.Sleep(1000);
                             Console.WriteLine("  Retornando ao menu...");
                             Thread.Sleep(1000);
                             menu.MenuOp();
                        break;
                }
            }
        }
        
        public void Potência()
        {
            bool loop = true;
            while(loop)
            {
                Console.Clear();
                menu.Title("Potência");
                Console.Write("  Valor 1: ");
                int x = int.Parse(Console.ReadLine()!);
                Console.Write("  Valor 2: ");
                int y = int.Parse(Console.ReadLine()!);
                double potencia = Math.Pow(x,y);
                Console.WriteLine($"  {x} elevado a {y} é: {potencia}");
                Thread.Sleep(1000);

                Console.WriteLine("\n  Deseja realizar mais um cálculo?");
                Console.Write($"  S/N: ");
                string opcao = Console.ReadLine()!;  
                switch (opcao)
                {
                    case "S" or "s": loop = true;
                        break;
                    case "N" or "n": loop = false;
                                     Console.WriteLine("  Retornando ao menu...");
                                     Thread.Sleep(1000);
                                     menu.MenuOp();
                        break;
                    default: loop = false; 
                             Console.WriteLine("\n  Opção Inválida!");
                             Thread.Sleep(1000);
                             Console.WriteLine("  Retornando ao menu...");
                             Thread.Sleep(1000);
                             menu.MenuOp();
                        break;
                }
            }
        }

        public void Seno()
        {
            bool loop = true;
            while(loop)
            {
                Console.Clear();
                menu.Title("Seno");
                Console.Write("  Digite o ângulo: ");
                double angulo = int.Parse(Console.ReadLine()!);
                double radiano = angulo * Math.PI / 180;
                double seno = Math.Sin(radiano);
                Console.WriteLine($"  O Seno de {angulo}° é: {Math.Round(seno, 4)}");
                Thread.Sleep(1000);

                Console.WriteLine("\n  Deseja realizar mais um cálculo?");
                Console.Write($"  S/N: ");
                string opcao = Console.ReadLine()!;  
                switch (opcao)
                {
                    case "S" or "s": loop = true;
                        break;
                    case "N" or "n": loop = false;
                                     Console.WriteLine("  Retornando ao menu...");
                                     Thread.Sleep(1000);
                                     menu.MenuOp();
                        break;
                    default: loop = false; 
                             Console.WriteLine("\n  Opção Inválida!");
                             Thread.Sleep(1000);
                             Console.WriteLine("  Retornando ao menu...");
                             Thread.Sleep(1000);
                             menu.MenuOp();
                        break;
                }
        }
    }
        
        public void Coseno()
        {
            bool loop = true;
            while(loop)
            {
                Console.Clear();
                menu.Title("Coseno");
                Console.Write("  Digite o ângulo: ");
                double angulo = int.Parse(Console.ReadLine()!);
                double radiano = angulo * Math.PI / 180;
                double coseno = Math.Cos(radiano);
                Console.WriteLine($"  O Coseno de {angulo}° é: {Math.Round(coseno, 4)}");
                Thread.Sleep(1000);

                Console.WriteLine("\n  Deseja realizar mais um cálculo?");
                Console.Write($"  S/N: ");
                string opcao = Console.ReadLine()!;  
                switch (opcao)
                {
                    case "S" or "s": loop = true;
                        break;
                    case "N" or "n": loop = false;
                                     Console.WriteLine("  Retornando ao menu...");
                                     Thread.Sleep(1000);
                                     menu.MenuOp();
                        break;
                    default: loop = false; 
                             Console.WriteLine("\n  Opção Inválida!");
                             Thread.Sleep(1000);
                             Console.WriteLine("  Retornando ao menu...");
                             Thread.Sleep(1000);
                             menu.MenuOp();
                        break;
            }
            }
        }
        
        public void Tangente()
        {
            bool loop = true;
            while(loop)
            {
                Console.Clear();
                menu.Title("Tangente");
                Console.Write("  Digite o ângulo: ");
                double angulo = int.Parse(Console.ReadLine()!);
                double radiano = angulo * Math.PI / 180;
                double tangente = Math.Tan(radiano);
                Console.WriteLine($"  A Tangente de {angulo}° é: {Math.Round(tangente, 4)}");
                Thread.Sleep(1000);

                Console.WriteLine("\n  Deseja realizar mais um cálculo?");
                Console.Write($"  S/N: ");
                string opcao = Console.ReadLine()!;  
                switch (opcao)
                {
                    case "S" or "s": loop = true;
                        break;
                    case "N" or "n": loop = false;
                                     Console.WriteLine("  Retornando ao menu...");
                                     Thread.Sleep(1000);
                                     menu.MenuOp();
                        break;
                    default: loop = false; 
                             Console.WriteLine("\n  Opção Inválida!");
                             Thread.Sleep(1000);
                             Console.WriteLine("  Retornando ao menu...");
                             Thread.Sleep(1000);
                             menu.MenuOp();
                        break;
                }
            }
        }

        public void RaizQuadrada()
        {
            bool loop = true;
            while(loop)
            {
                Console.Clear();
                menu.Title("Raiz quadrada");
                Console.Write("  Digite o valor: ");
                double x = int.Parse(Console.ReadLine()!);
                double raiz = Math.Sqrt(x);
                Console.WriteLine($"  A Raiz quadrada de {x} é: {Math.Round(raiz, 1)}");
                Thread.Sleep(1000);

                Console.WriteLine("\n  Deseja realizar mais um cálculo?");
                Console.Write($"  S/N: ");
                string opcao = Console.ReadLine()!;  
                switch (opcao)
                {
                    case "S" or "s": loop = true;
                        break;
                    case "N" or "n": loop = false;
                                     Console.WriteLine("  Retornando ao menu...");
                                     Thread.Sleep(1000);
                                     menu.MenuOp();
                        break;
                    default: loop = false; 
                             Console.WriteLine("\n  Opção Inválida!");
                             Thread.Sleep(1000);
                             Console.WriteLine("  Retornando ao menu...");
                             Thread.Sleep(1000);
                             menu.MenuOp();
                        break;
                 }
            }
        }

        public void Incremento()
        {
            bool loop = true;
            while(loop)
            {
                Console.Clear();
                menu.Title("Incremento");
                Console.Write("  Digite o valor: ");
                int x = int.Parse(Console.ReadLine()!);
                Console.Write("  Digite o limite: ");
                int y = int.Parse(Console.ReadLine()!);
                
                while(x < y)
                {
                    x++;
                    Console.WriteLine("  --");
                    Console.WriteLine($"  {x}");
                }

                Thread.Sleep(1000);

                Console.WriteLine("\n  Deseja realizar mais um cálculo?");
                Console.Write($"  S/N: ");
                string opcao = Console.ReadLine()!;  
                switch (opcao)
                {
                    case "S" or "s": loop = true;
                        break;
                    case "N" or "n": loop = false;
                                     Console.WriteLine("  Retornando ao menu...");
                                     Thread.Sleep(1000);
                                     menu.MenuOp();
                        break;
                    default: loop = false; 
                             Console.WriteLine("\n  Opção Inválida!");
                             Thread.Sleep(1000);
                             Console.WriteLine("  Retornando ao menu...");
                             Thread.Sleep(1000);
                             menu.MenuOp();
                        break;
                }
            }

        }

        public void Decremento()
        {
            bool loop = true;
            while(loop)
            {
                Console.Clear();
                menu.Title("Decremento");
                Console.Write("  Digite o valor: ");
                int x = int.Parse(Console.ReadLine()!);
                Console.Write("  Digite o limite: ");
                int y = int.Parse(Console.ReadLine()!);
                
                while(x > y)
                {
                    x--;
                    Console.WriteLine("  --");
                    Console.WriteLine($"  {x}");
                }  

                Thread.Sleep(1000);

                Console.WriteLine("\n  Deseja realizar mais um cálculo?");
                Console.Write($"  S/N: ");
                string opcao = Console.ReadLine()!;  
                switch (opcao)
                {
                    case "S" or "s": loop = true;
                        break;
                    case "N" or "n": loop = false;
                                     Console.WriteLine("  Retornando ao menu...");
                                     Thread.Sleep(1000);
                                     menu.MenuOp();
                        break;
                    default: loop = false; 
                             Console.WriteLine("\n  Opção Inválida!");
                             Thread.Sleep(1000);
                             Console.WriteLine("  Retornando ao menu...");
                             Thread.Sleep(1000);
                             menu.MenuOp();
                        break;
                }
            }
        }
           
    }
}