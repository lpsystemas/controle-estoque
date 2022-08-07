using System.Data;

namespace ModeloDB.SubCategoria
{
  public interface ISubCategoria
  {
    void Incluir(ModeloSubCategoria modelo);
    void Alterar(ModeloSubCategoria modelo);
    void Excluir(int codigo);
    DataTable Localizar(string nome);
    ModeloSubCategoria CarregaSubCategoria(int codigo);
  }
}
