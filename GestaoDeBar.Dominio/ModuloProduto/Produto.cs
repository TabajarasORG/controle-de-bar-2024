using GestaoDeBar.Dominio.Compartilhado;

namespace GestaoDeBar.Dominio
{
    public class Produto : EntidadeBase
    {
        public Produto(int id,string nome, decimal preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Produto produto = (Produto)novoRegistro;

            Id = produto.Id;
            Nome = produto.Nome;
            Preco= produto.Preco;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (Preco <= 0 )
                erros.Add("O campo \"preco\" é obrigatório");

            return erros;
        }
    }
}