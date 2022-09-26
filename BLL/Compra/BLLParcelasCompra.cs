using BLL.Compra.Consistencias;
using DAL;
using ModeloDB.Compra;
using ModeloDB.Compra.Interfaces;
using System.Data;

namespace BLL.Compra
{
    public class BLLParcelasCompra
    {
        private readonly DALConexao _conexao;

        public BLLParcelasCompra(DALConexao conexao)
        {
            _conexao = conexao;
        }
        
        public IParcelasCompra DALObj
        {
            get
            {
                if (_dalObj == null)
                    _dalObj = new DALParcelasCompra(_conexao);
                return _dalObj;
            }
        }
        private IParcelasCompra _dalObj = null;

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

        public void IncluirParcelas(
            ModeloParcelasCompra modelo,
            string operacao)
        {
            ConsistenciasParcelasCompra.ValidaCamposObrigatoriosParcelasCompra(
                modelo,
                operacao);

            ConsistenciasParcelasCompra.ConsisteAnoVencimentoParcela(modelo.PcoDataVecto);

            DALObj.Incluir(modelo);
        }

        public void AlterarParcela(
            ModeloParcelasCompra modelo,
            string operacao)
        {
            ConsistenciasParcelasCompra.ValidaCamposObrigatoriosParcelasCompra(
                modelo,
                operacao);

            ConsistenciasParcelasCompra.ConsisteAnoVencimentoParcela(modelo.PcoDataVecto);

            DALObj.Alterar(modelo);
        }

        public void ExcluirParcela(
            ModeloParcelasCompra modelo,
            string operacao)
        {
            ConsistenciasParcelasCompra.ValidaCamposObrigatoriosParcelasCompra(
                modelo,
                operacao);            

            DALObj.Excluir(modelo);
        }

        public void ExcluirTodasAsParcela(
            ModeloParcelasCompra modelo,
            string operacao)
        {
            ConsistenciasParcelasCompra.ValidaCamposObrigatoriosParcelasCompra(
                modelo,
                operacao);

            DALObj.ExcluirTodasAsParcelas(modelo.ComCod);
        }

        public DataTable LocalizarPorCodigoDaCompra(
            ModeloParcelasCompra modelo)
        {
            return DALObj.Localizar(modelo.ComCod);
        }

        public ModeloParcelasCompra CarregaParcelasDaCompra(int codigoParcela, int codigoCompra)
        {
            return DALObj.CarregaParcelasCompra(codigoParcela, codigoCompra);
        }

        public void EfetuarPagamentoParcelas(
            ModeloParcelasCompra modelo)
        {
            ConsistenciasParcelasCompra.ConsisteDataPagamentoPreenchida(modelo.PcoDataPagto);

            DALObj.EfetuaPagamentoParcela(
                modelo.ComCod,
                modelo.PcoCod,
                modelo.PcoDataPagto);                
        }
    }
}
