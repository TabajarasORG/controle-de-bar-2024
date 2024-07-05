namespace GestaoDeBar.Dominio.Compartilhado
{
    public abstract class EntidadeBase
    {
        public abstract List<string> Validar();

        public abstract void AtualizarRegistro(EntidadeBase novoRegistro);
    }
}
