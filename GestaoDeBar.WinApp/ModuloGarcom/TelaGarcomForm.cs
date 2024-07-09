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
    public partial class TelaGarcomForm : Form
    {
        private Garcom garcom;
        public Garcom Garcom
        {
            get
            {
                return garcom;
            }
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
            }
        }

        public TelaGarcomForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;

            garcom = new Garcom(id, nome);
        }
    }
}
