﻿using DAL;
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

    public void IncluirProduto(ModeloProduto modelo, string operacao)
    {
      ConsistenciasProduto.ValidaCamposObrigatorios(modelo, operacao);
      DALObj.Incluir(modelo);
    }

    public void AlterarProduto(ModeloProduto modelo, string operacao)
    {
      ConsistenciasProduto.ValidaCamposObrigatorios(modelo, operacao);
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
