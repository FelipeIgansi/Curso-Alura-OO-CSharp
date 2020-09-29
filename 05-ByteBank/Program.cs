using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente Gabriela = new Cliente();

            Gabriela.nome = "Gabriela";
            Gabriela.profissao = "Desenvolvedora C#";
            Gabriela.cpf = "033.333.333-55";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = Gabriela; 
            conta.saldo = 500;
            conta.agencia = 535;
            conta.numero = 2565452;



            Console.WriteLine(Gabriela.nome);
        }
    }
}
