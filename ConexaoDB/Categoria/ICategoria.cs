using System.Data;


namespace ModeloDB.Categoria
{
  public interface ICategoria
  { 
    void Incluir(ModeloCategoria modelo);
    void Alterar(ModeloCategoria modelo);
    void Excluir(int codigo);
    DataTable Localizar(string nome);
    ModeloCategoria CarregaCategoria(int codigo);
  }
}
