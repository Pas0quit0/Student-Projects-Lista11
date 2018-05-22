using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis e instâncias
            string nome;
            int nota;
            Media value = new Media();

            //Atribuições
            do
            {
                Console.Write("Digite o nome da disciplina: ");
                nome = Console.ReadLine();
                
                Console.WriteLine();
            }
            while (!(value.SetNome(nome)));

            do
            {
                Console.Write("Digite a nota do primeiro bimestre: ");
                nota = int.Parse(Console.ReadLine());
                
            } while (!(value.SetNota1(nota)));

            do
            {
                Console.Write("Digite a nota do segundo bimestre: ");
                nota = int.Parse(Console.ReadLine());                
            } while (!(value.SetNota2(nota)));

            do
            {
                Console.Write("Digite a nota final: ");
                nota = int.Parse(Console.ReadLine());                
            } while (!(value.SetNotaf(nota)));

            //Resultado
            Console.WriteLine();
            Console.WriteLine("Valor da média: " + value.MediaFinal());

            Console.ReadKey();
        }
    }
}
