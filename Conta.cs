using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_contabancaria
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(string mensagem) : base(mensagem) { }
    }
    
    public class Conta
    {
        public Conta(string numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            saldo = 0.0m;
        }
        public string Numero { get; }
        public string Titular { get; }
        private decimal saldo;


        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Depósito de R${valor:F2} realizado com sucesso. \nSaldo em conta: R${saldo:F2}");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor > saldo)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para o saque.");
            }
            if (valor > 0)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso. \nSaldo em conta: R${saldo:F2}.");
            }
            else
            {
                Console.WriteLine("Valor de saque inválido.");
            }
        }
    }
}