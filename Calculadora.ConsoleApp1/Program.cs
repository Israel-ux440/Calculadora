﻿namespace Calculadora.ConsoleApp1
//Nossa calculadora deve ter a possibilidade de fazer várias operações de soma

// requisito 03
//Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração

 // requisito 04 
 // Nossa calculadora deve ter a possibilidade de fazer as quatro operações básicas da matemática


{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            bool deveContinuar = true;

            while (true) 
            {
                Console.Clear();

                Console.WriteLine("Calculadora Tabajara 2024");

                Console.WriteLine("Digite 1 para Adicionar");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");


                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                if (operacao == "S")
                {   
                    
                    break;
                }

                Console.WriteLine("Digite o primeiro número");

                
                string primeiroNumeroString = "";
           

                primeiroNumeroString = Console.ReadLine();

                int primeiroNumero = Convert.ToInt32(primeiroNumeroString);


                Console.WriteLine("Digite o segundo número");

                string segundoNumeroString = Console.ReadLine();

                int segundoNumero = Convert.ToInt32(segundoNumeroString);

                int resultado = 0;

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


                Console.WriteLine("O resultado é: " + resultado);

                Console.ReadLine();

                Console.WriteLine("Você deseja sair da calculadora? (S/N)");

                string resposta = Console.ReadLine();

               
               

            }

              
            
   


        }
    }
}
