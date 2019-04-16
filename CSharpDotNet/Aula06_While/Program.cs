using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_While
{
    class CalculaPoupanca
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");
            double valorInvestido = 1000.0;
            int contador = 1;

            double fatorDeRendimento = 0.0036; //0.36%

            while (contador <= 12 && contador > 0)
            {
                valorInvestido = valorInvestido + valorInvestido * fatorDeRendimento;

                Console.WriteLine("Após " + contador + " mês(es), você terá R$ " + valorInvestido + ".");

                //contador = contador + 1;
                //contador += 1; Pode ser utilizado para números diferentes de 1, tanto maiores quanto menores
                ++contador; //Utilizando a forma simplificada;
            }

            Console.ReadLine();
        }
    }
}
