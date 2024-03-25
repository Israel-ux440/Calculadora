namespace Calculadora.ConsoleApp1
//Nossa calculadora deve ter a possibilidade de fazer várias operações de soma

// requisito 03
//Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração

 // requisito 04 
 // Nossa calculadora deve ter a possibilidade de fazer as quatro operações básicas da matemática

 // Requisito 05
 // Nossa calculadora deve realizar as operações com "0"

 // Requisito 06 
 // Nossa calculadora deve validar as opções do menu

// Requisito 07
// Nossa calculadora deve realizar  as operações com números com as duas casas decimais 
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            

            while (true) 
            {
                Console.Clear();

                Console.WriteLine("Calculadora Tabajara 2024\n");

                Console.WriteLine();

                Console.WriteLine("Digite 1 para Adicionar");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");
                Console.WriteLine("Digite 4 para dividir");


                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                if (operacao == "S" || operacao == "s")
                    break;




                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "S" && operacao != "s")
                {
                    Console.WriteLine("Operação inválida, tente novamente!");
                    Console.ReadLine();

                    continue;
                }

                Console.WriteLine("Digite o primeiro número");

                
                string primeiroNumeroString = "";
           

                primeiroNumeroString = Console.ReadLine();

                double primeiroNumero = Convert.ToDouble(primeiroNumeroString);


                Console.WriteLine("Digite o segundo número");

                string segundoNumeroString = Console.ReadLine();

                double segundoNumero = Convert.ToDouble(segundoNumeroString);

                double resultado = 0;

                if (operacao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }

               else if (operacao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }

                else if (operacao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }

                else if (operacao == "4")


                {
                    // checar se o numero é 0

                    while(segundoNumero == 0)
                     // caso for 0, pedir  para o usuário digitar de novo
                    {
                        Console.WriteLine("Segundo número não pode ser zero, tente novamente!");

                        Console.WriteLine("Digite o número novamente!");

                        segundoNumero = Convert.ToInt32 (Console.ReadLine()); 
                    }
                    
                    resultado = primeiroNumero / segundoNumero;
                }

                Console.WriteLine("O resultado é: " + resultado);

                Console.ReadLine();

                Console.WriteLine("Você deseja sair da calculadora? (S/N)");

                string resposta = Console.ReadLine();

               
               

            }

              
            
   


        }
    }
}
