using GestaoDeBar.Dominio;
using GestaoDeBar.Infra.Compartilhado;

namespace GestaoDeBar.Infra.ModuloProduto
{
    public class RepositorioProduto
    {
        GestaoDeBarDbContext dbContext;

        public RepositorioProduto(GestaoDeBarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Cadastrar(Produto produto)
        {
            dbContext.Produtos.Add(produto);
            dbContext.SaveChanges();
        }

        public bool Editar(int id, Produto produtoEditado)
        {
            Produto produto = dbContext.Produtos.Find(id);

            if (produto == null)
                return false;

            produto.AtualizarRegistro(produtoEditado);

            dbContext.Produtos.Update(produto);
            dbContext.SaveChanges();
            return true;
        }

        public bool Excluir(int id)
        {
            Produto produto = dbContext.Produtos.Find(id);

            if (produto == null)
                return false;

            dbContext.Produtos.Remove(produto);
            dbContext.SaveChanges();

            return true;
        }

        public Produto SelecionarPorId(int id)
        {
            return dbContext.Produtos.Find(id);
        }

        public List<Produto> SelecionarTodos()
        {
            return dbContext.Produtos.ToList();
        }
    }
}
