﻿using BLL.Compra.Consistencias;
using DAL;
using ModeloDB.Compra;
using ModeloDB.Compra.Interfaces;
using System;
using System.Data;

namespace BLL.Compra
{
    public class BLLCompra
    {
        private readonly DALConexao _conexao;

        public BLLCompra(DALConexao conexao)
        {
            _conexao = conexao;
        }

        #region Propriedades
        public ICompra DALObj
        {
            get
            {
                if (_dalObj == null)
                    _dalObj = new DALCompra(_conexao);
                return _dalObj;
            }
        }
        private ICompra _dalObj = null;

        public DALUtils Utils
        {
            get
            {
                if (_utils == null)
                    _utils = new DALUtils(_conexao);
                return _utils;
            }
        }
        private DALUtils _utils = null;

        #endregion

        public void IncluirCompra(
            ModeloCompra modelo,
            string operacao)
        {
            ConsistenciasCompra.ValidaCamposObrigatoriosCompra(
                modelo,
                operacao);

            DALObj.Incluir(modelo);
        }

        public void AlterarCompra(
            ModeloCompra modelo,
            string operacao)
        {
            ConsistenciasCompra.ValidaCamposObrigatoriosCompra(
                modelo,
                operacao);

            DALObj.Alterar(modelo);
        }

        public void ExcluirCompra(int codigo)
        {
            DALObj.Excluir(codigo);
        }

        public DataTable LocalizarCompraPorNomeFornecedor(string nomeFornecedor)
        {
            return DALObj.LocalizarPorNomeFornecedor(nomeFornecedor);
        }

        public DataTable LocalizarCompraPorCodigoFornecedor(int codigoFornecedor)
        {
            return DALObj.LocalizarPorCodigoFornecedor(codigoFornecedor);
        }

        public DataTable LocalizarCompraPorParcelasEmAberto()
        {
            return DALObj.LocalizarPorParcelasEmAberto();
        }

        public DataTable LocalizarCompraPorData(DateTime dtInicial, DateTime dtFinal)
        {
            return DALObj.LocalizarPorData(dtInicial, dtFinal);
        }

        public DataTable LocalizarTodasCompras()
        {
            return DALObj.LocalizarTodas();
        }

        public ModeloCompra CarregarCompra(int codigo)
        {
            return DALObj.CarregaCompra(codigo);
        }
    }
}
