using GestaoDeBar.Dominio;
using GestaoDeBar.WinApp.Compartilhado;

namespace GestaoDeBar.WinApp.ModuloProduto
{
    public partial class TabelaProdutoControl : UserControl
    {
        public TabelaProdutoControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(GerarColunas());

            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Produto> produtos)
        {
            grid.Rows.Clear();

            foreach (Produto produto in produtos)
            {
                grid.Rows.Add(produto.Id,produto.Nome,produto.Preco);
            }
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private static DataGridViewColumn[] GerarColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "id", HeaderText = "ID"},
                new DataGridViewTextBoxColumn { DataPropertyName = "nome", HeaderText = "Nome"},
                new DataGridViewTextBoxColumn {DataPropertyName = "preco", HeaderText = "Preco"}
            };
        }
    }
}
