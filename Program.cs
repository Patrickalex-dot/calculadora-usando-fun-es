using System;

namespace calculadora_usando_funções
{
    class Program
    {
        static decimal SomarNumeros(decimal a, decimal b)
        {
            return a + b;
        }
        static decimal SubtrairNumeros(decimal a, decimal b)
        {
            return a - b;
        }
        static decimal MultiplicarNumeros(decimal a, decimal b)
        {
            return a * b;
        }
        static decimal DividirNumeros(decimal a, decimal b)
        {

            return a / b;
        }
        static void Main(string[] args)
        {
            decimal num1;
            decimal num2;
            int opcao = -1;
           
             

            while (opcao != (int)operacao.Sair)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("------------------MENU-------------------");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine();
                Console.WriteLine("1- adição");
                Console.WriteLine("2- subtração");
                Console.WriteLine("3- multiplicação");
                Console.WriteLine("4- divisão");
                Console.WriteLine("0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == (int)operacao.Sair) {
                    Console.WriteLine("Você parou de executar o sistema");
                }




                if (opcao == (int)operacao.adicao)
                {
                    Console.WriteLine("Digite o primeiro numero que deseja efetuar o calculo");
                    num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero que deseja efetuar o calculo");
                    num2 = Convert.ToDecimal(Console.ReadLine());

                    decimal retorno = SomarNumeros(num1, num2);
                    Console.WriteLine("O valor da soma é igual a " + retorno);
                }
                else if (opcao == (int)operacao.subtracao)
                {
                    Console.WriteLine("Digite o primeiro numero que deseja efetuar o calculo");
                    num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero que deseja efetuar o calculo");
                    num2 = Convert.ToDecimal(Console.ReadLine());

                    decimal retorno = SubtrairNumeros(num1, num2);
                    Console.WriteLine("O valor da soma é igual a " + retorno);
                }
                else if (opcao == (int)operacao.multiplicacao)
                {
                    Console.WriteLine("Digite o primeiro numero que deseja efetuar o calculo");
                    num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero que deseja efetuar o calculo");
                    num2 = Convert.ToDecimal(Console.ReadLine());

                    decimal retorno = MultiplicarNumeros(num1, num2);
                    Console.WriteLine("O valor da soma é igual a " + retorno);
                }
                if (opcao == (int)operacao.divisao)
                {
                    Console.WriteLine("Digite o primeiro numero que deseja efetuar o calculo");
                    num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero que deseja efetuar o calculo");
                    num2 = Convert.ToDecimal(Console.ReadLine());

                    if (num1 == 0 && num2 == 0)
                    {
                        Console.WriteLine("seu programa parou de executar");
                    }
                    else
                    {
                        decimal retorno = DividirNumeros(num1, num2);
                        Console.WriteLine("O valor da soma é igual a " + retorno);
                    }

                }
            }
            
               
        }
    }
    enum operacao
    {
        Sair,
        adicao,
        subtracao,
        multiplicacao,
        divisao,

    }
}



            
        
      
    

