using GestaoDeBar.Dominio.Compartilhado;

namespace GestaoDeBar.Dominio
{
    public class Produto : EntidadeBase
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}