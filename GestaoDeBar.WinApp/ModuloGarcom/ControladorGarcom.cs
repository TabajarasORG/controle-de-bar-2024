using GestaoDeBar.Dominio;
using GestaoDeBar.Dominio.ModuloGarcom;
using GestaoDeBar.Infra.ModuloGarcom;
using GestaoDeBar.WinApp.Compartilhado;

namespace GestaoDeBar.WinApp.ModuloGarcom
{
    public class ControladorGarcom : ControladorBase
    {
        private RepositorioGarcom repositorioGarcom;
        private TabelaGarcomControl tabelaGarcom;

        public ControladorGarcom(RepositorioGarcom repositorioGarcom)
        {
            this.repositorioGarcom = repositorioGarcom;
        }

        public override string TipoCadastro => "Garcons";

        public override string ToolTipAdicionar => "Cadastrar Garcon";

        public override string ToolTipEditar => "Editar Garcon";

        public override string ToolTipExcluir => "Excluir Garcon";

        public override void Adicionar()
        {
            TelaGarcomForm telaGarcom = new();

            DialogResult resultado = telaGarcom.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Garcom novoGarcom = telaGarcom.Garcom;

            repositorioGarcom.Cadastrar(novoGarcom);

            CarregarProdutos();
        }

        public override void Editar()
        {
            TelaGarcomForm telaProdutoForm = new();

            int idSelecionado = tabelaGarcom.ObterRegistroSelecionado();

            Garcom garcomEditado = repositorioGarcom.SelecionarPorId(idSelecionado);

            if (garcomEditado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaProdutoForm.Garcom = repositorioGarcom.SelecionarPorId(idSelecionado);

            DialogResult resultado = telaProdutoForm.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Garcom garcom = telaProdutoForm.Garcom;

            repositorioGarcom.Editar(idSelecionado, garcom);

            CarregarProdutos();
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaGarcom.ObterRegistroSelecionado();

            Garcom garcomSelecionado = repositorioGarcom.SelecionarPorId(idSelecionado);

            if (garcomSelecionado == null)
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
                $"Você deseja realmente excluir o registro \"{garcomSelecionado.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioGarcom.Excluir(garcomSelecionado.Id);

            CarregarProdutos();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaGarcom == null)
                tabelaGarcom = new TabelaGarcomControl();

            CarregarProdutos();

            return tabelaGarcom; ;

        }


        private void CarregarProdutos()
        {
            List<Garcom> garcons = repositorioGarcom.SelecionarTodos();

            tabelaGarcom.AtualizarRegistros(garcons);
        }
    }
}
