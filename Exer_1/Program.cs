using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis e instâncias
            double raio;
            Circulo value = new Circulo();

            //Atribuições
            do
            { 
                Console.Write("Digite valor do raio (raio > 0): ");
                raio = int.Parse(Console.ReadLine());
                value.SetRaio(raio);
            }
            while (!(value.SetRaio(raio)));

            //Classes e métodos gerais
            value.AreaCirculo();
            value.CircunCirculo();

            //Resultado
            Console.WriteLine(); 
            Console.WriteLine("Valor da área: " + value.ValorArea());
            Console.WriteLine("Valor da circunferência: " + value.ValorCircunferencia());

            Console.ReadKey();
        }
    }
}
