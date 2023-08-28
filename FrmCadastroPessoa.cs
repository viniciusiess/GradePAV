namespace gui_cadastro
{
    public partial class FrmCadastroPessoa : Form
    {
        TabelaPessoa tabela;
        public FrmCadastroPessoa()
        {
            InitializeComponent();
            tabela = new TabelaPessoa();

            dgvPessoa.DataSource = tabela;

            dgvPessoa.Columns[0].Width = 300;
            dgvPessoa.Columns[1].Width = 300;
        }

        private void FrmCadastroPessoa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            if(FrmPessoa.executar(OperacaoCadastro.Incluir, pessoa))
            {
                tabela.incluir(pessoa);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            tabela.selecionar(dgvPessoa.CurrentRow.Index, pessoa);
            if(FrmPessoa.executar(OperacaoCadastro.Alterar, pessoa))
            {
                tabela.alterar(dgvPessoa.CurrentRow.Index, pessoa);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            tabela.selecionar(dgvPessoa.CurrentRow.Index, pessoa);
            FrmPessoa.executar(OperacaoCadastro.Consultar, pessoa);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabela.excluir(dgvPessoa.CurrentRow.Index);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}