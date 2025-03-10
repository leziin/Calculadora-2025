namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)


        {


            while (true)
            {
                Console.Clear();
                Console.WriteLine("calculadora tabajara 2025");
                Console.WriteLine("===========================");
                Console.WriteLine("digite 1 para somar ");
                Console.WriteLine("digite 2 para subtrair ");
                Console.WriteLine("digite 3 para multiplicar ");
                Console.WriteLine("digite 4 para dividir ");
                Console.WriteLine("digite 5 tabuada ");
                Console.WriteLine("digite S para sair ");
                Console.WriteLine("===========================");
                Console.WriteLine("digite uma opcao");

                string opcao = Console.ReadLine().ToUpper(); // se o usuario digitar s minusculo ele converte para maiusculo. 




                if (opcao == "S")
                {
                    break;

                }
                if (opcao == "5")
                {
                    Console.Clear();
                    Console.WriteLine("==========================");
                    Console.WriteLine("tabuada");
                    Console.WriteLine("============================ ");

                    Console.WriteLine("digite um numero");
                    int numero = 0;
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    for (int contador = 1; contador <= 10; contador++)
                    {
                        int resultadoTabuada = numeroTabuada * contador;
                        string LinhaTabuada =($"{numeroTabuada} x {contador} = {resultadoTabuada}");
                        Console.WriteLine(LinhaTabuada);
                        //Console.ReadLine();
                    }
                    Console.ReadLine();
                    continue;

                }

                Console.WriteLine("digite o primeiro numero");
                string PrimeiroNumero = Console.ReadLine();// aqui a informaçao esta sendo recolhida como string.


                decimal Numero1 = Convert.ToDecimal(PrimeiroNumero);//aqui esta sendo feita a conversao de string para int.
                Console.WriteLine("digite o segundo numero");


                string SegundoNumero = Console.ReadLine();// aqui a informaçao esta sendo recolhida como string.
                decimal Numero2 = Convert.ToDecimal(SegundoNumero);//aqui esta sendo feita a conversao de string para int.

                decimal resultado = 0;

                if (opcao == "1")
                {
                    resultado = Numero1 + Numero2;
                }

                else if (opcao == "2")
                {
                    resultado = Numero1 - Numero2;
                }
                else if (opcao == "3")
                {
                    resultado = Numero1 * Numero2;
                }
                else if (opcao == "4")
                {
                    //    if (Numero2 !=0) 
                    //    {

                    //        resultado = Numero1 / Numero2;
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("voce tentou uma divisao por 0 ");
                    //        Console.ReadLine();
                    //        continue;

                    //    }
                    //}
                    if (Numero2 == 0)
                    {
                        Console.WriteLine("não e possivel dividir por 0");
                        Console.ReadLine();
                        continue;
                    }

                    Console.WriteLine("o resultado e " + resultado.ToString("f2"));



                    Console.WriteLine("voce deseja continuar  digite s/n");

                    string opcaoContinuar = Console.ReadLine().ToUpper();

                    if (opcaoContinuar != "S")
                    {


                        break;
                    }


                }









            }
        }
    }
}