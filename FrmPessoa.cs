using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_cadastro
{
    public partial class FrmPessoa : Form
    {
        private OperacaoCadastro operacaoCadastro;
        private Pessoa pessoa;

        public FrmPessoa(OperacaoCadastro operacaoCadastro, Pessoa pessoa)
        {
            InitializeComponent();

            this.operacaoCadastro = operacaoCadastro;
            this.pessoa = pessoa;

            if (operacaoCadastro == OperacaoCadastro.Alterar || operacaoCadastro == OperacaoCadastro.Consultar)
            {
                edNome.Text = pessoa.nome;
                edTelefone.Text = pessoa.telefone;
            }

            buCancelar.Visible = operacaoCadastro != OperacaoCadastro.Consultar;
            edNome.Enabled = operacaoCadastro != OperacaoCadastro.Consultar;
            edTelefone.Enabled = operacaoCadastro != OperacaoCadastro.Consultar;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPessoa_Load(object sender, EventArgs e)
        {

        }

        private void buOk_Click(object sender, EventArgs e)
        {
            if(operacaoCadastro != OperacaoCadastro.Consultar)
            {
                pessoa.nome = edNome.Text;
                pessoa.telefone = edTelefone.Text;
            }
        }

        public static bool executar(OperacaoCadastro operacaoCadastro, Pessoa pessoa)
        {
            FrmPessoa frmPessoa = new FrmPessoa(operacaoCadastro, pessoa);
            try
            {
                return frmPessoa.ShowDialog() == DialogResult.OK;
            }
            finally
            {
                frmPessoa.Dispose();
            }
        }
    }
}
