using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PrimeiroProjeto
{
    class Conta
    {
        private int _numero;
        private string _titular;
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            _numero = numero;
            _titular = titular;
        }

        public Conta(int numero, string titular, double valordeposito) : this (numero, titular)
        {
            if (valordeposito > 0.00)
            {
                Saldo += valordeposito;
            }
        }

        public void Deposito(double valordeposito)
        {
            if (valordeposito > 0.00)
            {
                Saldo += valordeposito;
            }
        }

        public void Saque(double valorsaque)
        {
            if (valorsaque > 0.00)
            {
                Saldo -= (valorsaque + 5.00);
            }
        }


        public override string ToString()
        {
            return "Conta " + _numero + ", Titular: " + _titular + ", Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
