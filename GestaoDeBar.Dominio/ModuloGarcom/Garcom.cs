using GestaoDeBar.Dominio.Compartilhado;

namespace GestaoDeBar.Dominio.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {
        public int Id { get; set; }

        public string Nome { get; set; }

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