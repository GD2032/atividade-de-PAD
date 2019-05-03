using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePad2C_GabrielDias_EduardoFrans
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração dos objetos e variaveis
            Conta cliente1 = new Conta(1234, "Maria Fernanda", 0);
            Conta cliente2 = new Conta(1235, "Paulo Ricardo", 0);
            string C = "Nº da conta: ";
            string N = "\nNome: ";
            string S = "\nSaldo: ";
            //exercicio
            cliente2.creditarValor(100);
            cliente1.creditarValor(250);
            cliente1.debitarValor(35);
            cliente1.transferencia(cliente2, 20);
            Console.WriteLine(C + cliente1.mostrarNumeroConta() + N + cliente1.mostrarNome() + S + cliente1.mostrarSaldo());
            Console.WriteLine("\n" + C + cliente2.mostrarNumeroConta() + N + cliente2.mostrarNome()+ S + cliente2.mostrarSaldo());



        }
    }
}
