﻿namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculadora tabajara 2025");
            Console.WriteLine("digite o primeiro numero");
            string PrimeiroNumero = Console.ReadLine();// aquui a informaçao esta sendo recolhida como string.
            int Numero1 = Convert.ToInt32(PrimeiroNumero);//aqui esta sendo feita a conversao de string para int.
            Console.WriteLine("digite o segundo numero");
            string SegundoNumero = Console.ReadLine();
            int Numero2 = Convert.ToInt32(SegundoNumero);

            int resultado = Numero1 + Numero2;
            Console.WriteLine("o resultado e "+resultado);

            Console.ReadLine();




        }
    }
}
