//using ContaBancaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    



    static class Program
    {
        


        static void Main(string[] args)
        {
            /*#region Declaração Classes

            Login l = new Login();
            ContaUser contaUser = new ContaUser();
            Menu menu = new Menu();
            #endregion

            Console.Write("User:");
            string user = Console.ReadLine();
            Console.Write("Senha:");
            string senha = Console.ReadLine();

            

            l.AuthConta(user, senha, l.Auth);
            //menu.menuUser(l.Auth);
            */
            Iniciar();


        }

        public static void Iniciar()
        {

            #region Declaração Classes

            Login l = new Login();
            ContaUser contaUser = new ContaUser();
            Menu menu = new Menu();
            #endregion

            Console.Write("User:");
            string user = Console.ReadLine();
            Console.Write("Senha:");
            string senha = Console.ReadLine();



            l.AuthConta(user, senha, l.Auth);
            //menu.menuUser(l.Auth);
        }
    }
}