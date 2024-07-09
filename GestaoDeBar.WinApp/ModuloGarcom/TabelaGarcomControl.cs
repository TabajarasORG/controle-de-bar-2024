using GestaoDeBar.Dominio.ModuloGarcom;
using GestaoDeBar.WinApp.Compartilhado;
namespace GestaoDeBar.WinApp.ModuloGarcom
{
    public partial class TabelaGarcomControl : UserControl
    {
        public TabelaGarcomControl()
        {
            InitializeComponent();

            gridViewGarcom.Columns.AddRange(ObterColunas());

            gridViewGarcom.ConfigurarGridSomenteLeitura();
            gridViewGarcom.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Garcom> Garcons)
        {
            gridViewGarcom.Rows.Clear();

            foreach (Garcom g in Garcons)
                gridViewGarcom.Rows.Add(g.Id, g.Nome);
        }

        public int ObterRegistroSelecionado()
        {
            return gridViewGarcom.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" }
            };
        }
    }
}
