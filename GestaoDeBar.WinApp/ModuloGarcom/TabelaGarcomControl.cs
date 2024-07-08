using GestaoDeBar.Dominio.ModuloGarcom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeBar.WinApp.ModuloGarcom
{
    public partial class TabelaGarcomControl : UserControl
    {
        public TabelaGarcomControl()
        {
            InitializeComponent();

            gridViewGarcom.Columns.AddRange(ObterColunas());

            //GridViewGarcom.ConfigurarGridSomenteLeitura();
            //GridViewGarcom.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Garcom> Garcons)
        {
            gridViewGarcom.Rows.Clear();

            foreach (Garcom g in Garcons)
                gridViewGarcom.Rows.Add(g.Id, g.Nome);
        }

        //public int ObterRegistroSelecionado()
        //{
        //    return GridViewGarcom.SelecionarId();
        //}

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
