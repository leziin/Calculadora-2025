namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("calculadoa tabajara 2025");
            Console.WriteLine("digite o primeiro numero");
            string primeironumerostring  = Console.ReadLine();
            int primeironumero = Convert.ToInt32(primeironumerostring);
            Console.WriteLine("digite o segundo  numero");
            string segundonumeroString = Console.ReadLine();
            int SegundoNumero = Convert.ToInt32(primeironumerostring);

            int resultado = primeironumero + SegundoNumero;

            Console.WriteLine("o resultado e " + resultado);



       
            Console.ReadLine();




        }
    }
}
