using System;
using System.Data;

namespace ModeloDB.Compra.Interfaces
{
    public interface IParcelasCompra
    {
        void Incluir(ModeloParcelasCompra modelo);
        void EfetuaPagamentoParcela(int codCompra, int pcoCod, DateTime dtPagamento);
        void Alterar(ModeloParcelasCompra modelo);
        void Excluir(ModeloParcelasCompra modelo);
        void ExcluirTodasAsParcelas(int codCompra);
        DataTable Localizar(int codCompra);
        ModeloParcelasCompra CarregaParcelasCompra(int pcoCod, int codCompra);
    }
}
