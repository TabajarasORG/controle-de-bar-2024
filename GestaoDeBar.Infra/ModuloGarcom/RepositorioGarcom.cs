using GestaoDeBar.Dominio.ModuloGarcom;
using GestaoDeBar.Infra.Compartilhado;

namespace GestaoDeBar.Infra.ModuloGarcom
{
    internal class RepositorioGarcom
    {
        GestaoDeBarDbContext dbContext;

        public RepositorioGarcom(GestaoDeBarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Cadastrar(Garcom garcom)
        {
            dbContext.Garcons.Add(garcom);
            dbContext.SaveChanges();
        }

        public bool Editar(int id, Garcom garcomAtualizado)
        {
            Garcom garcom = dbContext.Garcons.Find(id)!;

            if (garcom == null)
                return false;

            garcom.AtualizarRegistro(garcomAtualizado);

            dbContext.Garcons.Update(garcom);
            dbContext.SaveChanges();

            return true;
        }

        public bool Excluir(int id)
        {
            Garcom garcon = dbContext.Garcons.Find(id)!;

            if (garcon == null)
                return false;

            dbContext.Garcons.Remove(garcon);
            dbContext.SaveChanges();

            return true;
        }

        public Garcom SelecionarPorId(int id)
        {
            return dbContext.Garcons.Find(id)!;
        }

        public List<Garcom> SelecionarTodos()
        {
            return dbContext.Garcons.ToList();
        }
    }
}
