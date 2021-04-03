using DAL;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public void IncluirTipoDePagamento(ModeloTipoPagamento modelo)
    {
      if (modelo.TPagtoNome.Trim().Length == 0)
        throw new Exception("O nome da categoria é obrigatória");

      DALObj.Incluir(modelo);
    }

    public void AlterarTipoDePagamento(ModeloTipoPagamento modelo)
    {
      if (modelo.TPagtoCod <= 0)
        throw new Exception("O Código da categoria é obrigatória");

      if (modelo.TPagtoNome.Trim().Length == 0)
        throw new Exception("O nome da categoria é obrigatória");

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
