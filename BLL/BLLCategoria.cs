using DAL;
using ModeloDB.Categoria;
using System.Data;

namespace BLL
{
    public class BLLCategoria 
  {
    private readonly DALConexao conexao;

    public BLLCategoria(DALConexao conexao)
    {
      this.conexao = conexao;
    }

    #region Propriedades
    public ICategoria DALObj
    {
      get
      {
        if (_dalObj == null)
          _dalObj = new DALCategoria(conexao);
        return _dalObj;
      }
    }
    private ICategoria _dalObj = null;

    #endregion

    public void IncluirCategoria(ModeloCategoria modelo, string operacao)
    {
      ConsistenciasCategoria.ValidaCamposObrigatorios(modelo, operacao);      
      DALObj.Incluir(modelo);
    }

    public void AlterarCategoria(ModeloCategoria modelo, string operacao)
    {
      ConsistenciasCategoria.ValidaCamposObrigatorios(modelo, operacao);    
      DALObj.Alterar(modelo);
    }

    public void ExcluirCategoria(int codigo)
    {      
      DALObj.Excluir(codigo);
    }

    public DataTable LocalizarCategoria(string nome)
    {      
      return DALObj.Localizar(nome);
    }

    public ModeloCategoria CarregaCategoria(int codigo)
    {      
      return DALObj.CarregaCategoria(codigo);      
    }
  }
}
