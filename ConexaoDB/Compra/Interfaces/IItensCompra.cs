using System.Data;

namespace ModeloDB.Compra.Interfaces
{
    public interface IItensCompra
    {
        void Incluir(ModeloItensCompra modelo);
        void Alterar(ModeloItensCompra modelo);
        void Excluir(ModeloItensCompra modelo);
        void ExcluirTodosOsItens(int codigo);
        DataTable LocalizarItens(int codigo);
        ModeloItensCompra CarregaItensCompra(int codigoItem, int codigoCompra, int codigoProduto);
    }
}
