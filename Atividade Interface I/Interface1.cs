using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Interface_I
{
    internal interface IProduto
    {
        bool EPerecivel { get; }
        Fornecedor RecuperarFornecedor();
        void RegistrarVenda(Cliente cliente);

    }
}
