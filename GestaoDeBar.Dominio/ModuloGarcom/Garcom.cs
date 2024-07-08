using GestaoDeBar.Dominio.Compartilhado;

namespace GestaoDeBar.Dominio.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public Garcom(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Garcom novoGarcom = (Garcom)novoRegistro;

            Nome = novoGarcom.Nome;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O nome deve ser preenchido!");

            else if (Nome.Trim().Length < 3)
                erros.Add("O nome deve conter ao menos 3 caracteres!");

            return erros;
        }
    }
}