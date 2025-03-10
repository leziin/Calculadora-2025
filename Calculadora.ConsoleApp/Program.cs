namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)


        {
           
          
            while (true) {
                Console.Clear();
                Console.WriteLine("calculadora tabajara 2025");
                Console.WriteLine("===========================");
                Console.WriteLine("digite 1 para somar ");
                Console.WriteLine("digite 2 para subtrair ");
                Console.WriteLine("digite 5 para sair ");
                Console.WriteLine("===========================");
                Console.WriteLine("digite uma opcao");

                string opcao = Console.ReadLine().ToUpper(); // se o usuario digitar s minusculo ele converte para maiusculo. 




                if (opcao == "S")
                {
                    break;
                  
                }


                Console.WriteLine("digite o primeiro numero");
                string PrimeiroNumero = Console.ReadLine();// aqui a informaçao esta sendo recolhida como string.


                int Numero1 = Convert.ToInt32(PrimeiroNumero);//aqui esta sendo feita a conversao de string para int.
                Console.WriteLine("digite o segundo numero");


                string SegundoNumero = Console.ReadLine();// aqui a informaçao esta sendo recolhida como string.
                int Numero2 = Convert.ToInt32(SegundoNumero);//aqui esta sendo feita a conversao de string para int.

                int resultado = 0;

                if (opcao == "1")
                {
                    resultado = Numero1 + Numero2;
                }

                else
                {
                    resultado = Numero1 - Numero2;
                }
            Console.WriteLine("o resultado e "+ resultado);
            Console.ReadLine();


                Console.WriteLine("voce deseja continuar  digite s/n");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "s")
                {
                    break;
                }

                Console.ReadLine();
            }









        }
    }
}
   