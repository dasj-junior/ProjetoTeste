using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroconta;
            string titularconta;
            char depositoinicial;
            double valordeposito = 0.00;
            double valorsaque = 0.00;


            Console.Write("Entre o número da conta: ");
            numeroconta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            titularconta = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            depositoinicial = char.Parse(Console.ReadLine());

            Conta conta;
            if (depositoinicial == 's')
            {
                Console.Write("Entre um valor para o depósito inicial: ");
                valordeposito = double.Parse(Console.ReadLine());
                Console.Write("\n");

                conta = new Conta(numeroconta,titularconta,valordeposito);
            }
            else
            {
                Console.Write("\n");
                conta = new Conta(numeroconta, titularconta);
            }
            

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta.ToString() + "\n");

            Console.Write("Entre um valor para depósito: ");
            valordeposito = double.Parse(Console.ReadLine());

            conta.Deposito(valordeposito);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta.ToString() + "\n");

            Console.Write("Entre um valor para saque: ");
            valorsaque = double.Parse(Console.ReadLine());

            conta.Saque(valorsaque);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta.ToString() + "\n");

            Console.WriteLine("Dorival Junior / 2020");

            Console.WriteLine("GitHub");


            Console.ReadKey();
        }
    }
}
