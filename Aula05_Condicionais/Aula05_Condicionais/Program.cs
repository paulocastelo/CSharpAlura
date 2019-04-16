using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            double vlDeducao = 0.0;
            double vlIR = 0.0;
            double salario = 3800.0;
            if (salario < 1900.0)
            {
                vlIR = 0.0;
                vlDeducao = 0.0;
            }
            else
            {
                if (salario >= 1900.0 && salario <= 2800.0)
                {
                    double taxaIR = 0.075;
                    vlIR = salario * taxaIR;
                    vlDeducao = 142.0;
                }
                else
                {
                    if (salario >= 2800.1 && salario <= 3751.0)
                    {
                        double taxaIR = 0.15;
                        vlIR = salario * taxaIR;
                        vlDeducao = 350.0;
                    }
                    else
                    {
                        double taxaIR = 0.225;
                        vlIR = salario * taxaIR;
                        vlDeducao = 636.0;
                    }
                }
            }
            Console.WriteLine ("Os resultados referentes aos valores informados são:");
            Console.WriteLine("Salario: " + salario + ".");
            Console.WriteLine ("A sua alíquota é de 15%, ou seja o valor é " + vlIR + ".");
            Console.WriteLine("Você pode deduzir até " + vlDeducao + ".");
            Console.WriteLine("Pressione alguma tecla para continuar. . .");
            Console.ReadLine();

        }
    }
}

/*De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;
De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636.*/