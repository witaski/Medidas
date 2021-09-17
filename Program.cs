using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {   
            Double metrosDigitado, metrosParaCm, metrosParaKm;
            Console.Write("Entre com a medida em metros (m): ");
            metrosDigitado = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n----Equivalente----");

            metrosParaCm = metrosDigitado*100;


            Console.WriteLine($"{metrosParaCm} cm");

            Console.WriteLine($"{metrosDigitado} m");

            metrosParaKm = metrosDigitado/1000;

            Console.WriteLine($"{metrosParaKm} km");
        }
    }
}
