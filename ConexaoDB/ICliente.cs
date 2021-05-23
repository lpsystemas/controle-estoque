using System.Data;

namespace ModeloDB
{
  public interface ICliente
  {
    void Incluir(ModeloCliente modelo);
    void Alterar(ModeloCliente modelo);
    void Excluir(int codigo);
    DataTable Localizar(string nome);
    ModeloCliente CarregaCliente(int codigo);
  }
}
