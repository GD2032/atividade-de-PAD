using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePad2C_GabrielDias_EduardoFrans
{
    class Conta
    {
        int numeroConta;
        string nome;
        int saldo;

        public string mostrarNome()
        {
            return this.nome;
        }
        public int mostrarNumeroConta()
        {
            return this.numeroConta;
        }
        public int mostrarSaldo()
        {
            return this.saldo;
        }

        public Conta()
        {
            this.saldo = 0;
            this.numeroConta = 0;
            this.nome = "";
        }
        public Conta(int numeroConta, string nome, int saldo)
        {
            this.saldo = saldo;
            this.numeroConta = numeroConta;
            this.nome = nome;
        }
        public void debitarValor(int debito)
        {
            if(this.saldo - debito < 0)
            {
                this.saldo = 0;
            }
            else
            {
                this.saldo -= debito;
            }
        }
        public void creditarValor(int credito)
        {
            this.saldo += credito;
        }
        public void transferencia(Conta contaDestino, int valor)
        {
            debitarValor(valor);
            contaDestino.creditarValor(valor);
        }
    }
}
