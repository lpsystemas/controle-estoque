using DAL;
using ModeloDB.SubCategoria;
using System.Data;


namespace BLL.SubCategoria
{
  public class BLLSubCategoria
  {
    private readonly DALConexao conexao;

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

    public void AlterarSubCategoria(ModeloSubCategoria modelo, string operacao)
    {
      ConsistenciasSubCategoria.ValidaCamposObrigatorios(modelo, operacao);
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

    public void IncluirSubCategoria(ModeloSubCategoria modelo, string operacao)
    {
      ConsistenciasSubCategoria.ValidaCamposObrigatorios(modelo, operacao);
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
