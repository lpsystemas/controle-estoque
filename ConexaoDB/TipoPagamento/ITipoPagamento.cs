using System.Data;

namespace ModeloDB.TipoPagamento
{
    public interface ITipoPagamento
    {
        void Incluir(ModeloTipoPagamento modelo);
        void Alterar(ModeloTipoPagamento modelo);
        void Excluir(int codigo);
        DataTable Localizar(string nome);
        ModeloTipoPagamento CarregaTipoDePagamento(int codigo);
    }
}
