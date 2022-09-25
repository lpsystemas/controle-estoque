using System;
using System.Data;

namespace ModeloDB.Venda.Interfaces
{
    public interface IVenda
    {
        void Incluir(ModeloVenda modelo);
        void Alterar(ModeloVenda modelo);
        void Excluir(int codigoVenda);
        bool CancelarVenda(int codigoVenda);
        DataTable LocalizarPorCodigo(int codigoVenda);
        DataTable LocalizarPorNomeCliente(string nomeCliente);
        DataTable LocalizarTodasVendas();
        DataTable LocalizarPorParcelasEmAberto();
        DataTable LocalizarPorData(
            DateTime dtInicial,
            DateTime dtFinal);
        int QuantidadeParcelasNaoPagas(int codigoVenda);
        ModeloVenda CarregaVenda(int codigoVenda);
    }
}
