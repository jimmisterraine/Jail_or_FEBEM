using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _Jail_or_FEBEM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando VAI SER PRESO?");
            char linha = ' ';
            Console.Write(linha);
            Console.Write(linha);

            Console.WriteLine("Digite a sua idade");
            int idade = int.Parse(Console.Read());

            if (idade >= 17)
            {
                Console.WriteLine("Infelizmente você não pode ser preso e vai pra FEBEM!");
            }
            else 
            {
                Console.WriteLine("Parabéns, você já pode ser preso!");
            }


            
            Console.Write(linha);
            Console.WriteLine("Execução finalizada. Tecle ENTER para encerrar");
            Console.ReadLine();
        }
    }
}