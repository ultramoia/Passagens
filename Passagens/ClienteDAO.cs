using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteDAO
    {
        public static List<Cliente> clientes = new List<Cliente>();

        public void add(Cliente c)
        {
            ClienteDAO.clientes.Add(c);
        }

        public Cliente buscar (string nome)
        {
            var resultado = ClienteDAO.clientes.Where(c => c.nome.Equals(nome)).FirstOrDefault();
            return (Cliente) resultado;
        }
    }
}
