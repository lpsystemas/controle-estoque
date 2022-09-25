using System;
using System.Data;

namespace ModeloDB.Venda.Interfaces
{
    public interface IParcelasVenda
    {
        void Incluir(ModeloParcelasVenda modelo);
        void Alterar(ModeloParcelasVenda modelo);
        void Excluir(ModeloParcelasVenda modelo);
        void ExcluirTodasAsParcelas(int codigoVenda);
        DataTable Localizar(int codigoVenda);
        ModeloParcelasVenda CarregaModeloParcelasVenda(
            int codigoParcela,
            int codigoVenda);
        ModeloParcelasVenda EfetuaRecebimentoParcela(
            int codigoVenda,
            int codigoParcela,
            DateTime dtRecebimento);
    }
}
