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
  public class BLLProduto
  {
    private DALConexao conexao;

    public BLLProduto(DALConexao conexao)
    {
      this.conexao = conexao;
    }

    #region Propriedades
    public IProduto DALObj
    {
      get
      {
        if (_dalObj == null)
          _dalObj = new DALProduto(conexao);
        return _dalObj;
      }
    }
    private IProduto _dalObj = null;

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

    public void IncluirProduto(ModeloProduto modelo)
    {
      if (modelo.ProdNome.Trim().Length == 0)
        throw new Exception("O nome do Produto é obrigatório");

      if (modelo.ProdDesc.Trim().Length == 0)
        throw new Exception("A Descrição do Produto é obrigatória");

      if(modelo.ProdValorVenda <= 0)
        throw new Exception("O Valor de venda do Produto é obrigatório");

      if (modelo.ProdQuantidade <= 0)
        throw new Exception("O quantidade do Produto deve ser maior ou igual a zero");

      if (modelo.UmedCod <= 0)
        throw new Exception("O código da Unidade de Medida é obrigatório");

      if (modelo.CatCod <= 0)
        throw new Exception("O código da Categoria é obrigatório");

      if (modelo.SCatCod <= 0)
        throw new Exception("O código da SubCategoria é obrigatório");

      DALObj.Incluir(modelo);
    }

    public void AlterarProduto(ModeloProduto modelo)
    {
      if(modelo.ProdCod <= 0)
        throw new Exception("O código do Produto é obrigatório");

      if (modelo.ProdNome.Trim().Length == 0)
        throw new Exception("O Nome do Produto é obrigatório");

      if (modelo.ProdDesc.Trim().Length == 0)
        throw new Exception("A Descrição do Produto é obrigatória");

      if (modelo.ProdValorVenda <= 0)
        throw new Exception("O Valor de venda do Produto é obrigatório");

      if (modelo.ProdQuantidade <= 0)
        throw new Exception("O quantidade do Produto deve ser maior ou igual a zero");

      if (modelo.UmedCod <= 0)
        throw new Exception("O código da Unidade de Medida é obrigatório");

      if (modelo.CatCod <= 0)
        throw new Exception("O código da Categoria é obrigatório");      

      DALObj.Alterar(modelo);
    }

    public void ExcluirProduto(int codigo)
    {
      DALObj.Excluir(codigo);
    }

    public DataTable LocalizarProduto(string nome)
    {
      return DALObj.Localizar(nome);
    }

    public ModeloProduto CarregaProduto(int codigo)
    {
      return DALObj.CarregaProduto(codigo);
    }
  }
}
