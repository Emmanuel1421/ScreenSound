using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraList
{
    public class Titular
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
    }

    public class Conta : Titular
    {
        private double saldo;
        private double limite;
        private int agencia;
        private int numeroConta;

        public string Id { get; set; } = string.Empty;
        public Titular Titular { get; set; }
        public double Limite { get { return limite; }
            set 
            {
                
                limite = value;
            }
        }
        public int NumeroConta
        {   get { return numeroConta; }
            set
            {
                numeroConta = value;
            }
        }
        public int Agencia 
        {   get { return agencia; }
            set
            {
                agencia = value;
            }
        }
        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value >= 0)
                {
                    saldo = value;
                }
                else
                {
                    Console.WriteLine("Valor inválido");
                }
            }
        }
        public int Senha { get; set; }

        public void ApresentacaoConta() 
        {
            Console.WriteLine($"Conta nº {this.NumeroConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}"); 
        }
    }
}
