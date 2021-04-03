using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDB
{
  public interface ITipoPagamento
  {
    void Incluir(ModeloTipoPagamento modelo);
    void Alterar(ModeloTipoPagamento modelo);
    void Excluir(int codigo);
    DataTable Localizar(string nome);
    ModeloTipoPagamento CarregaTipoDePagamento(int codigo);
  }
}
