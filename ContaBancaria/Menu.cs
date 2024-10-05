using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Menu
    {
        int i = 1;
        public bool MenuOp = true;
        public int escolhaMenu;
        public int valorDeposito;
        public int valorSacar;
        
        public void menuUser(bool autenticacao)
        {
            Login l = new Login();
            ContaUser contaUser = new ContaUser();
            while (autenticacao && MenuOp)
            {

                
                Console.WriteLine($"\n\nBem vindo {l.Username}.\nEscolha abaixo a opção que desejar:");
                Console.WriteLine("(1) Ver saldo\n(2) Depositar\n(3) Sacar\n(0) Sair");
                Console.Write("\n->");

                escolhaMenu = int.Parse( Console.ReadLine() );

                switch(escolhaMenu)
                {

                    case 1:
                        contaUser.Painel();
                        break;

                    case 2:
                        Console.Write("Qual a quantidade que gostaria de depositar?:");
                        valorDeposito = int.Parse( Console.ReadLine() );
                        contaUser.Depositar(valorDeposito);


                        break;
                    case 3:
                        Console.Write("Qual o valor que gostaria de sacar?:");
                        valorSacar = int.Parse( Console.ReadLine() );
                        contaUser.Sacar(valorSacar);

                        break;

                    case 0:
                        MenuOp = false;
                        Console.WriteLine("Você foi deslogado da sua conta.");
                        break;

                    default:
                        Console.WriteLine("\nA opção digitada não existe. Tente novamente.\n");
                        break;
                }
            }

            Console.ReadKey();

        }
        
       


    }
}