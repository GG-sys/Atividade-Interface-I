using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Interface_I
{
    internal class Computador : IProduto
    {
        private bool ePerecivel = false;

        public bool EPerecivel
        {
            get { return ePerecivel; }
        }

        public Fornecedor RecuperarFornecedor()
        {
            return new Fornecedor("Positivo");
        }

        public void RegistrarVenda(Cliente cliente)
        {
            Console.WriteLine("Registra venda do cliente " + cliente.nome);
        }
    }
}
