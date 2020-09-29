using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.Saldo = 50;

            Cliente cliente = new Cliente();
            cliente.Nome = "Felipe";
            cliente.CPF = "132.232.252-33";
            cliente.Profissao = "Tester";

            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);

            Console.WriteLine(conta.Saldo);
        }
    }
}
