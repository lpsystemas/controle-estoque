using DAL;
using Ferramentas;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConstsEnumerados.Constantes;

namespace BLL
{
  public class BLLFornecedor
  {
    private DALConexao conexao;

    public BLLFornecedor(DALConexao conexao)
    {
      this.conexao = conexao;
    }

    #region Propriedades
    public IFornecedor DALObj
    {
      get
      {
        if (_dalObj == null)
          _dalObj = new DALFornecedor(conexao);
        return _dalObj;
      }
    }
    private IFornecedor _dalObj = null;

    public DALUtils Utils
    {
      get
      {
        if (_utils == null)
          _utils = new DALUtils(conexao);
        return _utils;
      }
    }
    private DALUtils _utils = null;

    
    #endregion

    public void IncluirFornecedor(ModeloFornecedor modelo, string operacao)
    {
      ConsistenciasFornecedor.ValidaCamposObrigatorios(modelo, operacao);
      ConsistenciasFornecedor.ValidaPreenchimentoCEP(modelo);
      ConsistenciasFornecedor.ValidaPreenchimentoCnpj(modelo);
      ConsistenciasFornecedor.ValidaPreenchimentoEmail(modelo);
      DALObj.Incluir(modelo);
    }

    public void AlterarFornecedor(ModeloFornecedor modelo, string operacao)
    {
      ConsistenciasFornecedor.ValidaCamposObrigatorios(modelo, operacao);
      ConsistenciasFornecedor.ValidaPreenchimentoCEP(modelo);
      ConsistenciasFornecedor.ValidaPreenchimentoCnpj(modelo);
      ConsistenciasFornecedor.ValidaPreenchimentoEmail(modelo);
      DALObj.Alterar(modelo);
    }

    public void ExcluirFornecedor(int codigo)
    {
      DALObj.Excluir(codigo);
    }

    public DataTable LocalizarFornecedor(int tipoPesquisa, string valorPesquisa)
    {
      return DALObj.Localizar(tipoPesquisa, valorPesquisa);
    }

    public ModeloFornecedor CarregaFornecedor(int codigo)
    {
      return DALObj.CarregaFornecedorPorCodigo(codigo);
    }
    public ModeloFornecedor CarregaFornecedor(string cnpj)
    {
      return DALObj.CarregaFornecedorPorCnpj(cnpj);
    }
  }
}
