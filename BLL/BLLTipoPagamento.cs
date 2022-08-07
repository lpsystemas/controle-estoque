using DAL;
using ModeloDB;
using System.Data;

namespace BLL
{
    public class BLLTipoPagamento
  {
    private DALConexao conexao;

    public BLLTipoPagamento(DALConexao conexao)
    {
      this.conexao = conexao;
    }

    #region Propriedades
    public ITipoPagamento DALObj
    {
      get
      {
        if (_dalObj == null)
          _dalObj = new DALTipoPagamento(conexao);
        return _dalObj;
      }
    }
    private ITipoPagamento _dalObj = null;

    #endregion

    public void IncluirTipoDePagamento(ModeloTipoPagamento modelo, string operacao)
    {
      ConsistenciasTipoPagamento.ValidaCamposObrigatorios(modelo, operacao);
      DALObj.Incluir(modelo);
    }

    public void AlterarTipoDePagamento(ModeloTipoPagamento modelo, string operacao)
    {
      ConsistenciasTipoPagamento.ValidaCamposObrigatorios(modelo, operacao);
      DALObj.Alterar(modelo);
    }

    public void ExcluirTipoDePagamento(int codigo)
    {
      DALObj.Excluir(codigo);
    }

    public DataTable LocalizarTipoDePagamento(string nome)
    {
      return DALObj.Localizar(nome);
    }

    public ModeloTipoPagamento CarregaTipoDePagamento(int codigo)
    {
      return DALObj.CarregaTipoDePagamento(codigo);
    }
  }
}
