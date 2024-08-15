using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis:
            double c, f, k;

            //Exibição de mensagens (titulo e linha se separação):
            Console.WriteLine(" Conversor de Temperaturas ");
            Console.WriteLine("--------------------------------------------------");

            //Entrada de temperatura em Celsius:
            Console.Write("Insira a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");

            //Conversão para Fahrenheit:
            f = (c * 9 / 5) + 32;

            //Conversão para Kelvin:
            k = c + 273.15;

            //Exibição dos resultados:
            Console.WriteLine(c + " Graus Celsius = " + f + " Graus em Fahrenheit");
            Console.WriteLine(c + " Graus Celsius = " + k + " Graus em Kelvin");
            Console.WriteLine("--------------------------------------------------");

            //Pausa antes de fechar o programa:
            Console.ReadKey();


        }
    }
}
