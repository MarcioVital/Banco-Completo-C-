using System;
using System.Collections.Generic;

namespace banco_poo
{
    class Program
    {

       static List<Conta> listContas = new List<Conta> ();
        static void Main(string[] args)
        {

            string opcaoUsuario = obterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;

                    case "2":
                        InserirConta();
                        break;

                    case "3":
                        Transferir();
                        break;

                    case "4":
                        Sacar();
                        break;
                        
                    case "5":
                        Depositar();
                        break;

                    case "C":
                        Console.Clear();
                        break;


                    default:
                        Console.WriteLine("Preste Atenção! Digite uma das Opções!");
                        Console.WriteLine();
                        break;



                }
                opcaoUsuario = obterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por Utilizar nossos Serviços!");
            Console.ReadLine();

            
        }

        private static void Transferir()
        {
            Console.WriteLine("Qual é sua conta?");
            int numConta = int.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("Qual é a conta que você vai Transferir?");
            int numContaTranferida = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Quanto você vai transferir?");
            double valorTransferencia = double.Parse(Console.ReadLine());
            Console.WriteLine();

            listContas[numConta].sacar(valorTransferencia);
            listContas[numContaTranferida].Depositar(valorTransferencia);
        }

        private static void Sacar()
        {
            Console.WriteLine("Qual é sua conta?");
            int numConta = int.Parse(Console.ReadLine());
            Console.WriteLine();

          
            Console.WriteLine("Quanto quer sacar?");
            double valorSaque = double.Parse(Console.ReadLine());
            Console.WriteLine();

            listContas[numConta].sacar(valorSaque);

            

        }

        private static void Depositar()
        {
            Console.WriteLine("Qual é sua conta?");
            int numConta = int.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("Quanto você vai Depositar?");
            double valorDepositado = double.Parse(Console.ReadLine());
            Console.WriteLine();

            listContas[numConta].Depositar(valorDepositado);





            Console.WriteLine();
        }

        private static void ListarContas()
        {
            if (listContas.Count == 0)
            {
                Console.WriteLine("Seu Banco ainda não possui contas Ativas!");
                Console.WriteLine();
                return;
            }
            for(int i = 0; i < listContas.Count; i++)
            {
                
                Console.WriteLine("Conta: " + i + " - " + listContas[i]);
            }
            Console.WriteLine();



        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserindo Nova Conta:");
            Console.WriteLine();

            Console.WriteLine("1 - Pessoa Física  \n" +
                              "2 - Pessoa Jurídica");
            int tipoContaEnum = int.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("Qual o Nome do Cliente?");
            string nomeCliente = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Qual valor de Depósito Inicial?");
            double valorDeposito = double.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("Qual valor de crédito?");
            double valorCredito = double.Parse(Console.ReadLine());
            Console.WriteLine();


            Conta novaConta = new Conta(tipoConta:(TipoConta) tipoContaEnum,
                                        nome: nomeCliente,
                                        saldo: valorDeposito,
                                        credito: valorCredito);

            listContas.Add(novaConta);

        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine("Banco do Marcio na Área");
            Console.WriteLine("Informe uma das Opções abaixo: ");
            Console.WriteLine();

            Console.WriteLine("1 - Listar Todas as Contas");
            Console.WriteLine("2 - Inserir nova Conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Saque");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair do Sistema");
            Console.WriteLine();


            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

    }
}
