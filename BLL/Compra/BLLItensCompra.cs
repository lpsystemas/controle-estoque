using BLL.Compra.Consistencias;
using DAL;
using ModeloDB.Compra;
using ModeloDB.Compra.Interfaces;
using System.Data;

namespace BLL.Compra
{
    public class BLLItensCompra
    {
        private readonly DALConexao _conexao;

        public BLLItensCompra(DALConexao conexao)
        {
            _conexao = conexao;
        }
        
        public IItensCompra DALObj
        {
            get
            {
                if (_dalObj == null)
                    _dalObj = new DALItensCompra(_conexao);
                return _dalObj;
            }
        }
        private IItensCompra _dalObj = null;

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

        public void Alterar(
            ModeloItensCompra modelo,
            string operacao)
        {
            ConsistenciasItensCompra.ValidaCamposObrigatoriosItensCompra(
                modelo,
                operacao);

            DALObj.Alterar(modelo);
        }

        public ModeloItensCompra CarregaItensCompra(int codigoItem, int codigoCompra, int codigoProduto)
        {
            throw new System.NotImplementedException();
        }

        public void Excluir(
            ModeloItensCompra modelo,
            string operacao)
        {
            ConsistenciasItensCompra.ValidaCamposObrigatoriosItensCompra(
                modelo,
                operacao);

            DALObj.Excluir(modelo);                
        }

        public void ExcluirTodosOsItens(int codigo)
        {
            DALObj.ExcluirTodosOsItens(codigo);
        }

        public void Incluir(
            ModeloItensCompra modelo,
            string operacao)
        {
            ConsistenciasItensCompra.ValidaCamposObrigatoriosItensCompra(
                modelo,
                operacao);

            DALObj.Incluir(modelo);
        }

        public DataTable LocalizarItens(int codigo)
        {
            return DALObj.LocalizarItens(codigo);
        }
    }
}
