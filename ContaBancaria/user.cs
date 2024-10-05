using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class ContaUser
    {
        private int id;
        private int _valorConta = 200;

        public int ValorConta { get { return _valorConta; } }


        
        public void Painel() 
        {
            Console.WriteLine($"Valor: {ValorConta}\n\n");
            Console.WriteLine("Aperte qualquer tecla para voltar");
            Console.ReadKey();
            Console.Clear();
        }

        public void Depositar(int valorDepositado) {

            _valorConta += valorDepositado;
            Console.WriteLine($"\nFoi depositado {valorDepositado} em sua conta. Agora você tem {ValorConta}");
            Console.ReadKey();
            Console.Clear();
        
        }

        public void Sacar(int valorSacado)
        {
            

            if (valorSacado > ValorConta)
            {
                Console.WriteLine("O valor pedido foi negado. Sua conta não possui esse valor.");
            }
            else
            {

                _valorConta -= valorSacado;
                Console.WriteLine($"\nFoi depositado {valorSacado} em sua conta. Agora você tem {ValorConta}");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
