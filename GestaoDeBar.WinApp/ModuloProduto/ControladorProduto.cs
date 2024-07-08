using GestaoDeBar.Dominio;
using GestaoDeBar.Infra.ModuloProduto;
using GestaoDeBar.WinApp.Compartilhado;

namespace GestaoDeBar.WinApp.ModuloProduto
{

    public class ControladorProduto : ControladorBase
    {
        private RepositorioProduto repositorioProduto;
        private TabelaProdutoControl tabelaProduto;

        public ControladorProduto(RepositorioProduto repositorioProduto)
        {
            this.repositorioProduto = repositorioProduto;
        }

        public override string TipoCadastro => "Produtos";

        public override string ToolTipAdicionar => "Cadastrar Produto";

        public override string ToolTipEditar => "Editar Produto";

        public override string ToolTipExcluir => "Excluir Produto";

        public override void Adicionar()
        {
            TelaProdutoForm telaProduto = new TelaProdutoForm();

            DialogResult  resultado = telaProduto.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Produto novoProduto = telaProduto.Produto;

            repositorioProduto.Cadastrar(novoProduto);

            CarregarProdutos();
        }

        public override void Editar()
        {
            TelaProdutoForm telaProdutoForm = new TelaProdutoForm();

            int idSelecionado = tabelaProduto.ObterRegistroSelecionado();

            Produto produtoSelecionado = repositorioProduto.SelecionarPorId(idSelecionado);

            if (produtoSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaProdutoForm.Produto = repositorioProduto.SelecionarPorId(idSelecionado);

            DialogResult resultado = telaProdutoForm.ShowDialog();

            if(resultado != DialogResult.OK ) 
                return;

            Produto produtoEditado = telaProdutoForm.Produto;

            repositorioProduto.Editar(idSelecionado, produtoEditado);

            CarregarProdutos();
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaProduto.ObterRegistroSelecionado();

            Produto produtoSelecionado = repositorioProduto.SelecionarPorId(idSelecionado);

            if (produtoSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{produtoSelecionado.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioProduto.Excluir(produtoSelecionado.Id);

            CarregarProdutos();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaProduto == null)
                tabelaProduto = new TabelaProdutoControl();

            CarregarProdutos();

            return tabelaProduto; ;

        }


        private void CarregarProdutos()
        {
            List<Produto> produtos = repositorioProduto.SelecionarTodos();

            tabelaProduto.AtualizarRegistros(produtos);
        }
    }
}
