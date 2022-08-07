using DAL;
using ModeloDB.UnidadeDeMedida;
using System;
using System.Data;

namespace BLL
{
  public class BLLUnidadeDeMedida
  {
    private readonly DALConexao conexao;

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

    public void AlterarUnidadeDeMedida(ModeloUnidadeDeMedida modelo, string operacao)
    {
      ConsistenciasUnidadeDeMedida.ValidaCamposObrigatorios(modelo, operacao);    
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
    
    public void IncluirUnidadeDeMedida(ModeloUnidadeDeMedida modelo, string operacao)
    {
      ConsistenciasUnidadeDeMedida.ValidaCamposObrigatorios(modelo, operacao);

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
