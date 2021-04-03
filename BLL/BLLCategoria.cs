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
  public class BLLCategoria 
  {
    private DALConexao conexao;

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

    public void IncluirCategoria(ModeloCategoria modelo)
    {
      if (modelo.CatNome.Trim().Length == 0)
        throw new Exception("O nome da categoria é obrigatória");      
     
      DALObj.Incluir(modelo);
    }

    public void AlterarCategoria(ModeloCategoria modelo)
    {
      if (modelo.CatCod <= 0)
        throw new Exception("O Código da categoria é obrigatória");

      if (modelo.CatNome.Trim().Length == 0)
        throw new Exception("O nome da categoria é obrigatória");      
   
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
