using ModeloDB.Compra;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALCompra : ICompra
    {
        private readonly DALConexao _conexao;
        public DALCompra(DALConexao conexao)
        {
            _conexao = conexao;
        }

        public void Alterar(ModeloCompra modelo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"UPDATE COMPRA SET COM_DATA = @COM_DATA, 
                                                          COM_NFISCAL = @COM_NFISCAL,
                                                          COM_TOTAL = @COM_TOTAL,
                                                          COM_NPARCELAS = @COM_NPARCELAS,
                                                          COM_STATUS = @COM_STATUS,
                                                          FOR_COD = @FOR_COD,
                                                          TPA_COD = @TPA_COD 
                                                    WHERE COM_COD = @CODIGO";

                command.Parameters.AddWithValue("@CODIGO", modelo.ComCod);
                command.Parameters.Add("@COM_DATA", SqlDbType.DateTime);
                command.Parameters["@COM_DATA"].Value = modelo.ComData;
                command.Parameters.AddWithValue("@COM_NFISCAL", modelo.ComNFiscal);
                command.Parameters.AddWithValue("@COM_TOTAL", modelo.ComTotal);
                command.Parameters.AddWithValue("@COM_NPARCELAS", modelo.ComNParcelas);
                command.Parameters.AddWithValue("@COM_STATUS", modelo.ComStatus);
                command.Parameters.AddWithValue("@FOR_COD", modelo.ForCod);
                command.Parameters.AddWithValue("@TPA_COD", modelo.TpaCod);

                _conexao.Conectar();
                command.ExecuteNonQuery();
                _conexao.Desconectar();
            }
        }

        public ModeloCompra CarregaCompra(int codigo)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int codigo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"DELETE FROM COMPRA 
                                              WHERE COM_COD = @CODIGO";

                command.Parameters.AddWithValue("@CODIGO", codigo);

                _conexao.Conectar();
                command.ExecuteNonQuery();
                _conexao.Desconectar();
            }
        }

        public void Incluir(ModeloCompra modelo)
        {
            throw new NotImplementedException();
        }

        public DataTable LocalizarPorCodigoFornecedor(int codigo)
        {
            throw new NotImplementedException();
        }

        public DataTable LocalizarPorData(DateTime dtInicial, DateTime dtFinal)
        {
            throw new NotImplementedException();
        }

        public DataTable LocalizarPorNomeFornecedor(string nome)
        {
            throw new NotImplementedException();
        }

        public DataTable LocalizarPorParcelasEmAberto()
        {
            throw new NotImplementedException();
        }

        public DataTable LocalizarTodas()
        {
            throw new NotImplementedException();
        }

        public int QuantidadeParcelasNaoPagas(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}
