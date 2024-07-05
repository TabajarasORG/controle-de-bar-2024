using GestaoDeBar.Dominio.Compartilhado;
using GestaoDeBar.Dominio.ModuloPedido;

namespace GestaoDeBar.Dominio.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public int Id { get; set; }
        
        public Pedido Pedido { get; set; }

        public int ValorConta { get; set; }

        public DateTime DataConta { get; set; }

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