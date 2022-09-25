using BLL.Cliente.Consistencias;
using DAL;
using ModeloDB.Cliente;
using ModeloDB.Cliente.Interfaces;
using System.Data;

namespace BLL.Cliente
{
    public class BLLCliente
    {
        private readonly DALConexao conexao;

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

        public void IncluirCliente(
            ModeloCliente modelo,
            string operacao)
        {
            ConsistenciasCliente.ValidaCamposObrigatorios(modelo, operacao);
            ConsistenciasCliente.ValidaPreenchimentoCEP(modelo);
            ConsistenciasCliente.ValidaPreenchimentoCpf_Cnpj(modelo);
            ConsistenciasCliente.ValidaPreenchimentoEmail(modelo);
            DALObj.Incluir(modelo);
        }

        public void AlterarCliente(
            ModeloCliente modelo,
            string operacao)
        {
            ConsistenciasCliente.ValidaCamposObrigatorios(modelo, operacao);
            ConsistenciasCliente.ValidaPreenchimentoCEP(modelo);
            ConsistenciasCliente.ValidaPreenchimentoCpf_Cnpj(modelo);
            ConsistenciasCliente.ValidaPreenchimentoEmail(modelo);
            DALObj.Alterar(modelo);
        }

        public void ExcluirCliente(int codigo)
        {
            DALObj.Excluir(codigo);
        }

        public DataTable LocalizarCliente(
            int tipoPesquisa,
            string valorPesquisa)
        {
            return DALObj.Localizar(tipoPesquisa, valorPesquisa);
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
