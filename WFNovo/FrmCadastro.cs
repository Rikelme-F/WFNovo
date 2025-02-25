using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFNovo
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnVerCadastros_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.nome = txtNome.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.bairro = txtBairro.Text;
            cliente.estado = txtEstado.Text;
            cliente.telefone = txtEstado.Text;
            cliente.celular = txtCelular.Text;
            cliente.email = txtEmail.Text;

            FrmVerCadastro frmVerCadastro = new FrmVerCadastro(cliente);
            frmVerCadastro.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
