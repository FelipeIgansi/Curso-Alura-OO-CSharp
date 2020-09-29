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
            //Cliente Gabriela = new Cliente();

            // Gabriela.nome = "Gabriela";
            // Gabriela.profissao = "Desenvolvedora C#";
            // Gabriela.cpf = "033.333.333-55";

            ContaCorrente conta = new ContaCorrente();
            

            // conta.titular = Gabriela;
            // conta.titular = new Cliente();

            // conta.titular.nome = "Gabriela Costa";
            // conta.titular.cpf = "033.333.333-55";
            // conta.titular.profissao = "Desenvolvedora C#";

            conta.saldo = 500;
            conta.agencia = 535;
            conta.numero = 2565452;

            if (conta.titular == null)
            {
                Console.WriteLine("A referencia para < conta.titular > está null");
            }

            // Console.WriteLine(Gabriela.nome);
            Console.WriteLine(conta.titular);
            // Console.WriteLine(conta.titular.nome);
            // Console.WriteLine(conta.titular.cpf);
            // Console.WriteLine(conta.titular.profissao);


        }
    }
}
