using DAL;
using ModeloDB;
using System;
using System.Data;
using System.Security;

namespace BLL
{
  public class BLLUnidadeDeMedida
  {
    private DALConexao conexao;

    public BLLUnidadeDeMedida(DALConexao conexao)
    {
      this.conexao = conexao;
    }

    #region Propriedades
    public IUnidadeDeMedida DALObj
    {
      get
      {
        if (_dalObj == null)
          _dalObj = new DALUnidadeDeMedida(conexao);
        return _dalObj;
      }
    }
    private IUnidadeDeMedida _dalObj = null;

    public DALUnidadeDeMedida DAL
    {
      get
      {
        if (_dal == null)
          _dal = new DALUnidadeDeMedida(conexao);
        return _dal;
      }
    }
    private DALUnidadeDeMedida _dal = null;

    #endregion

    public void AlterarUnidadeDeMedida(ModeloUnidadeDeMedida modelo)
    {
      if (modelo.UmedCod <= 0)
        throw new Exception("O Código da Unidade de Medida é obrigatória");

      if (modelo.UmedNome.Trim().Length == 0)
        throw new Exception("O nome da Unidade de Medida é obrigatório");
      
      DALObj.Alterar(modelo);
    }

    public ModeloUnidadeDeMedida CarregaUnidadeDeMedida(int codigo)
    {
      return DALObj.CarregaUnidadeDeMedida(codigo);
    }

    public void ExcluirUnidadeDeMedida(int codigo)
    {
      DALObj.Excluir(codigo);
    }
    
    public void IncluirUnidadeDeMedida(ModeloUnidadeDeMedida modelo)
    {
      if (modelo.UmedNome.Trim().Length == 0)
        throw new Exception("O nome da Unidade de Medida é obrigatório");

      if (DAL.VerificaUnidadeDeMedidaCadastrada(modelo.UmedNome.Trim()))
        throw new Exception("Unidade já cadastrada");

      DALObj.Incluir(modelo);
    }

    public DataTable LocalizarUnidadeDeMedida(string nome)
    {
      return DALObj.Localizar(nome);
    }
  }
}
