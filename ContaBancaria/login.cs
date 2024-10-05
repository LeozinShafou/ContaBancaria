using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Login
    {
        private string _username = "leo";
        private string _password = "123";
        private bool _auth = false;

        public bool Auth { get { return _auth; } set { _auth = value; } }
        public string Username { get { return _username; } }
        public string Password { get { return _password; } }

        public static void User(string username, string password)
        {
             
            //_username = username;
            //_password = password;

            
        }

        public void AuthConta(string username, string password, bool autenticacao)
        {
            Menu menu = new Menu();
            
            
            if (username == null || password == null)
            {
                Console.WriteLine("O campo de Login está vazio");
                TentarNovamente();

            }
            else if (username == Username && password == Password)
            {
                Console.WriteLine("Login efetuado com sucesso!");
                Auth = true;
                menu.menuUser(Auth);
            }
            else
            {

                Console.WriteLine("Usuário ou senha incorretos.");
                TentarNovamente();
                
            }
        }

        public void TentarNovamente()
        {
            string tentativa;
            //int loopTentativa = 0;

            while (true)  //loopTentativa == 0
            {


                Console.Write("\nGostaria de tentar novamente?(s/n):");
                tentativa = Console.ReadLine();
                switch (tentativa)
                {
                    case "s":
                        //loopTentativa++;
                        Console.Clear();
                        Program.Iniciar();
                        break;
                    case "n":
                        //loopTentativa++;
                        break;
                    default:
                        Console.WriteLine("Opção incorreta. Tente novamente.");
                        break;
                }
            }
            

        }
    }
}