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
            cliente.nome = "Felipe";
            cliente.cpf = "132.232.252-33";
            cliente.profissao = "Tester";

            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.nome);

            Console.WriteLine(conta.Saldo);
        }
    }
}
