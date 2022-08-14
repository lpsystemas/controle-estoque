using System;
using System.Data;

namespace ModeloDB.Compra
{
    public interface ICompra
    {
        void Incluir(ModeloCompra modelo);
        void Alterar(ModeloCompra modelo);
        void Excluir(int codigo);
        DataTable LocalizarTodas();
        DataTable LocalizarPorCodigoFornecedor(int codigo);
        DataTable LocalizarPorNomeFornecedor(string nome);
        DataTable LocalizarPorData(DateTime dtInicial, DateTime dtFinal);
        DataTable LocalizarPorParcelasEmAberto();
        int QuantidadeParcelasNaoPagas(int codigo);
        ModeloCompra CarregaCompra(int codigo);
    }
}
