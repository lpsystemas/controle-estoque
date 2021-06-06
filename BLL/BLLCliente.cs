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
  public class BLLCliente
  {
    private DALConexao conexao;

    public BLLCliente(DALConexao conexao)
    {
      this.conexao = conexao;
    }

    #region Propriedades
    public ICliente DALObj
    {
      get
      {
        if (_dalObj == null)
          _dalObj = new DALCliente(conexao);
        return _dalObj;
      }
    }
    private ICliente _dalObj = null;

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

    public void IncluirCliente(ModeloCliente modelo)
    {
      if (modelo.CliNome.Trim().Length == 0)
        throw new Exception("O nome do Cliente é obrigatório");

      if (modelo.CliCpfCnpj.Trim().Length == 0)
        throw new Exception("O campo CPF/CNPJ do cliente é obrigatória");  

      if (modelo.CliCelular.Trim().Length == 0)
        throw new Exception("O campo Telefone/Celular do Cliente é obrigatório");

      if (modelo.CliEmail.Trim().Length == 0)
        throw new Exception("O campo E-mail do Cliente é obrigatório");

      DALObj.Incluir(modelo);
    }

    public void AlterarCliente(ModeloCliente modelo)
    {
      if (modelo.CliCod <= 0)
        throw new Exception("O Código do Cliente é obrigatório");

      if (modelo.CliNome.Trim().Length == 0)
        throw new Exception("O nome do Cliente é obrigatório");

      if (modelo.CliCpfCnpj.Trim().Length == 0)
        throw new Exception("O campo CPF/CNPJ do cliente é obrigatória");

      if (modelo.CliRgInscricaoEstadual.Trim().Length == 0)
        throw new Exception("O campo RG/IE do cliente é obrigatório");

      if (modelo.CliTelefone.Trim().Length == 0 || modelo.CliCelular.Trim().Length == 0)
        throw new Exception("O campo Telefone/Celular do Cliente é obrigatório");

      DALObj.Alterar(modelo);
    }

    public void ExcluirCliente(int codigo)
    {
      DALObj.Excluir(codigo);
    }

    public DataTable LocalizarCliente(string nome)
    {
      return DALObj.Localizar(nome);
    }

    public ModeloCliente CarregaCliente(int codigo)
    {
      return DALObj.CarregaClientePorCodigo(codigo);
    }
    public ModeloCliente CarregaCliente(string cpfCnpj)
    {
      return DALObj.CarregaClientePorCpfCnpj(cpfCnpj);
    }
  }
}
