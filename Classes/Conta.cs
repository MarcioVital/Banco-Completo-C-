using System;
using System.Collections.Generic;
using System.Text;

namespace banco_poo
{
    class Conta
    {
       private TipoConta TipoConta { get; set; }       
       private string nome { get; set; }
       private double saldo { get; set; }            
       private double credito { get; set; }

       public Conta (TipoConta tipoConta, string nome, double saldo, double credito)
        {
            this.TipoConta = tipoConta;
            this.nome = nome;
            this.saldo = saldo;
            this.credito = credito;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Tipo de Conta: " + this.TipoConta  + "  |  ";
            retorno += "Nome do Cliente: " + this.nome + "  |  ";
            retorno += "Saldo Atual: " + this.saldo + "  |  ";
            retorno += "Seu Crédito: " + this.credito;

            return retorno;
        }

        public bool sacar (double valorSaque)
        {
            if (this.saldo - valorSaque < (this.credito * -1))
            {
                Console.WriteLine("Saldo Insuficiente!");
                Console.WriteLine();
                return false;
            }
            this.saldo -= valorSaque;
            Console.WriteLine("Oi {0}, seu Saldo agora é R${1}"  
                , this.nome, this.saldo);
            Console.WriteLine();
            return true;
           
        }

        public void Depositar(double valorDeposito)
        {
            this.saldo += valorDeposito;
            Console.WriteLine("{0}, agora Você tem R${1} em sua conta", this.nome, this.saldo);
            Console.WriteLine();

        }

        
        
    }
}
