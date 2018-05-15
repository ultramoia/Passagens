using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumindoServico.ServiceReference1;

namespace ConsumindoServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = this.txtNome.Text;
            string cpf = this.txtCPF.Text;

            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente clienteCadastro = new Cliente();
                clienteCadastro.nome = nome;
                clienteCadastro.CPF = cpf;
                servico.add(clienteCadastro);

                MessageBox.Show("Cliente cadastrado com sucesso");
            }
            catch (Exception)
            {
                // salva log
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = this.txtNome.Text;

            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente resultado = servico.buscar(nome);
                txtCPF.Text = resultado.CPF;
            }
            catch (Exception)
            {
                // salva log
            }
        }
    }
}
