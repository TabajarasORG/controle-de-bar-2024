using GestaoDeBar.Dominio.Compartilhado;
using GestaoDeBar.Dominio.ModuloGarcom;

namespace GestaoDeBar.Dominio.ModuloPedido
{
    public class Pedido : EntidadeBase
    {
        public int Id { get; set; }

        public Produto Produto { get; set; }

        public Mesa Mesa { get; set; }

        public Garcom Garcom { get; set; }

        public int QuantidadeProduto { get; set; }

        public int ValorTotal { get; set; }

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