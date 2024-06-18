using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm231101_Rm231026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S = 0;
            Console.WriteLine("Iniciar? S/N");
            string Resp = Console.ReadLine().ToUpper();

            while (Resp == "S")
            {
                Console.WriteLine("Você deseja:");
                Console.WriteLine("   Efetuar Depósito (1)");
                Console.WriteLine("   Efetuar Saque (2)");
                Console.WriteLine("   Efetuar Pagamento (3)");
                Console.WriteLine("   Consultar Saldo (4)");
                
                int Resp2 = int.Parse(Console.ReadLine());

                switch (Resp2) 
                {
                    case 1:
                        S = D(S);
                        break;
                    case 2:
                        S = SA(S);
                        break;
                    case 3:
                        S = P(S);
                        break;
                    case 4:
                        CS(S);
                        break;
                    default:
                        Console.WriteLine("Opção não encontrata. ERROR.");
                        break;
                }

                Console.WriteLine("Deseja continuar? S/N");
                Resp = Console.ReadLine().ToUpper();
            }
        }

        static double D(double Sa)
        {
            Console.WriteLine("Qual valor deseja depositar: ");
            double VD = double.Parse(Console.ReadLine());

            Sa += VD;

            return Sa;
        }
        static double SA(double Sa)
        {
            Console.WriteLine("Qual valor deseja Sacar: ");
            double VS = double.Parse(Console.ReadLine());

            if (VS > Sa)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                Sa -= VS;
            }
            
            return Sa;
        }
        static double P(double Sa)
        {
            Console.WriteLine("Qual valor deseja Pagar: ");
            double VP = double.Parse(Console.ReadLine());

            double S = Sa;
            if (VP > S)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                S -= VP;
            }

            return S;
        }
        static void CS(double Sa)
        {
            double S = Sa;
            Console.WriteLine("Saldo: " + S);
        }
    }
}
