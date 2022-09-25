using System.Data;

namespace ModeloDB.Venda.Interfaces
{
    public interface IItensVenda
    {
        void Incluir(ModeloItensVenda modelo);
        void Alterar(ModeloItensVenda modelo);
        void Excluir(ModeloItensVenda modelo);
        void ExcluirTodosOsItens(int codigoVenda);
        DataTable Localizar(int codigoVenda);
        ModeloItensVenda CarregaItensVenda(int codigoItemVenda, int codigoVenda, int codigoProduto);
    }
}
