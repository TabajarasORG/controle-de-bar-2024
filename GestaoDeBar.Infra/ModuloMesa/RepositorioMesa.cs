using GestaoDeBar.Dominio;
using GestaoDeBar.Infra.Compartilhado;

namespace GestaoDeBar.Infra;

public class RepositorioMesa
{
    GestaoDeBarDbContext dbContext;

    public RepositorioMesa(GestaoDeBarDbContext dbContext)
    {
        this.dbContext = dbContext;
    }


    public void Cadastrar(Mesa mesa)
    {
        dbContext.Mesas.Add(mesa);
        dbContext.SaveChanges();
    }


    public bool Excluir(int id)
    {
        Mesa mesa = dbContext.Mesas.Find(id);

        if (mesa == null)
            return false;

        dbContext.Mesas.Remove(mesa);
        dbContext.SaveChanges();

        return true;
    }

    public Mesa SelecionarPorId(int id)
    {
        return dbContext.Mesas.Find(id);
    }
}
