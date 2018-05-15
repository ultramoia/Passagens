using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public Cliente buscar(string nome)
        {
            ClienteDAO dao = new ClienteDAO();
            return dao.buscar(nome);
        }

        public bool add(string nome, string cpf)
        {
            Cliente c = new Cliente();
            c.nome = nome;
            c.CPF = cpf;
            ClienteDAO dao = new ClienteDAO();
            dao.add(c);

            return true;
        }

        public List<Cliente> getClientes()
        {
            return ClienteDAO.clientes;
        }
    }
}
