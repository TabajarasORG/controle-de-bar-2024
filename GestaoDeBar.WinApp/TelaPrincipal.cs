using GestaoDeBar.Infra.Compartilhado;
using GestaoDeBar.Infra.ModuloProduto;
using GestaoDeBar.WinApp.Compartilhado;
using GestaoDeBar.WinApp.ModuloProduto;

namespace GestaoDeBar.WinApp
{
    public partial class TelaPrincipal : Form
    {
        ControladorBase controlador;

        RepositorioProduto repositorioProduto;

        public static TelaPrincipal Instancia { get; private set; }

        public TelaPrincipal()
        {
            InitializeComponent();
            GestaoDeBarDbContext dbContext = new GestaoDeBarDbContext();
            lblTipo.Text = string.Empty;

            Instancia = this;

            repositorioProduto = new RepositorioProduto(dbContext);
        }

        public void AtualizarRodape(string texto)
        {
            lblStripStatus.Text = texto;
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorProduto(repositorioProduto);

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipo.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Text = controladorSelecionado.ToolTipAdicionar;
            btnEditar.Text = controladorSelecionado.ToolTipEditar;
            btnExcluir.Text = controladorSelecionado.ToolTipExcluir;
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemObjeto = controladorSelecionado.ObterListagem();
            listagemObjeto.Dock = DockStyle.Fill;

            painelRegistros.Controls.Clear();
            painelRegistros.Controls.Add(listagemObjeto);
        }

    }
}
