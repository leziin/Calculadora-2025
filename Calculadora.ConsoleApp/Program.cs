namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        
       
        {
            Console.WriteLine("calculadora tabajara 2025");
            Console.WriteLine("===========================");
            Console.WriteLine("digite 1 para somar ");
            Console.WriteLine("digite 2 para subtrair ");
            Console.WriteLine("digite 5 para sair ");

            Console.WriteLine("digite uma opcao");

            string opcao = Console.ReadLine();
            string OpcaoValidada = opcao.ToUpper();


            if (OpcaoValidada == "s")
            {
                return;
            }


            Console.WriteLine("digite o primeiro numero");
            string PrimeiroNumero = Console.ReadLine();// aqui a informaçao esta sendo recolhida como string.


            int Numero1 = Convert.ToInt32(PrimeiroNumero);//aqui esta sendo feita a conversao de string para int.
            Console.WriteLine("digite o segundo numero");


            string SegundoNumero = Console.ReadLine();// aqui a informaçao esta sendo recolhida como string.
            int Numero2 = Convert.ToInt32(SegundoNumero);//aqui esta sendo feita a conversao de string para int.

            int resultado = Numero1 + Numero2;
            Console.WriteLine("o resultado e "+resultado);
            Console.ReadLine();


        }
    }
}
