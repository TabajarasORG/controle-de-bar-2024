using GestaoDeBar.Dominio;

namespace GestaoDeBar.WinApp.ModuloProduto
{
    public partial class TelaProdutoForm : Form
    {
        private Produto produto;

        public Produto Produto
        {
            set
            {
                txtId.Value = value.Id;
                txtNome.Text = value.Nome;
                txtPreco.Value = value.Preco;
            }
            get
            {
                return produto;
            }
        }


        public TelaProdutoForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Value);
            string nome = txtNome.Text;
            decimal preco = txtPreco.Value;

            produto = new Produto(id,nome,preco);

            List<string> erros = produto.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipal.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

        }
    }
}
