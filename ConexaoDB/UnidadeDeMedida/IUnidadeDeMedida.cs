using System.Data;

namespace ModeloDB.UnidadeDeMedida
{
  public interface IUnidadeDeMedida
  {
    void Incluir(ModeloUnidadeDeMedida modelo);
    void Alterar(ModeloUnidadeDeMedida modelo);
    void Excluir(int codigo);
    DataTable Localizar(string nome);
    ModeloUnidadeDeMedida CarregaUnidadeDeMedida(int codigo);
  }
}
