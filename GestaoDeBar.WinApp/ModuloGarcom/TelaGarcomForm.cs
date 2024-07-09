using GestaoDeBar.Dominio.ModuloGarcom;

namespace GestaoDeBar.WinApp.ModuloGarcom
{
    public partial class TelaGarcomForm : Form
    {
        private Garcom garcom;
        public Garcom Garcom
        {
            set
            {
                txtId.Value = value.Id;
                txtNome.Text = value.Nome;
            }
            get
            {
                return garcom;
            }
        }

        public TelaGarcomForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            if (txtId.Value == 0)
            {
                garcom = new Garcom(nome);
            }
            else
            {
                int id = Convert.ToInt32(txtId.Value);
                garcom = new Garcom(id, nome);
            }


            List<string> erros = garcom.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipal.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
