using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferenciaBancaria
{
    public class ContaBancaria
    {
        public long NumeroConta { get; private set; }
        public string Titular { get; set; }
        private decimal Saldo;

        public ContaBancaria(long numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = 0;
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public bool Sacar(decimal valor)
        {
            if (valor > 0 && Saldo >= valor)
            {
                Saldo -= valor;
                return true; // Saque bem-sucedido
            }
            return false; // Falha no saque
        }

        public decimal ConsultarSaldo()
        {
            return Saldo;
        }

        public bool Transferir(ContaBancaria contaDestino, decimal valor)
        {
            if (this.Sacar(valor))
            {
                contaDestino.Depositar(valor);
                return true; // Transferência bem-sucedida
            }
            return false; // Falha na transferência
        }
    }
}
