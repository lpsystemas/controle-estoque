using DAL;
using ModeloDB;
using System;
using System.Data;


namespace BLL
{
  public class BLLSubCategoria
  {
    private DALConexao conexao;

    public BLLSubCategoria(DALConexao conexao)
    {
      this.conexao = conexao;
    }

    #region Prorpiedades
    public ISubCategoria DALObj
    {
      get
      {
        if (_dalObj == null)
          _dalObj = new DALSubCategoria(conexao);
        return _dalObj;
      }
    }
    private ISubCategoria _dalObj = null;

    public DALSubCategoria DAL
    {
      get
      {
        if (_dal == null)
          _dal = new DALSubCategoria(conexao);
        return _dal;
      }
    }
    private DALSubCategoria _dal = null;

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

    public void AlterarSubCategoria(ModeloSubCategoria modelo)
    {
      if (modelo.CatCod <= 0)
        throw new Exception("O Código da categoria é obrigatória");

      if (modelo.SCatCod <= 0)
        throw new Exception("O Código da SubCategoria é obrigatório");

      if (modelo.SCatNome.Trim().Length == 0)
        throw new Exception("O nome da SubCategoria é obrigatório"); 
      
      DALObj.Alterar(modelo);
    }

    public ModeloSubCategoria CarregaSubCategoria(int codigo)
    {      
      return DALObj.CarregaSubCategoria(codigo);
    }

    public void ExcluirSubCategoria(int codigo)
    {      
      DALObj.Excluir(codigo);
    }

    public void IncluirSubCategoria(ModeloSubCategoria modelo)
    {
      if (modelo.SCatNome.Trim().Length == 0)
        throw new Exception("O nome da SubCategoria é obrigatório");

      if (modelo.CatCod <= 0)
        throw new Exception("O Código da Categoria é obrigatório");
      
      DALObj.Incluir(modelo);
    }

    public DataTable LocalizarSubCategoria(string nome)
    {      
      return DALObj.Localizar(nome);
    }

    public DataTable CarregarCategoria()
    {
      return Utils.CarregaComboBoxCategoria();
    }
  }
}
