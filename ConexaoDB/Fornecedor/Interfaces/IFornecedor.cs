using System.Data;

namespace ModeloDB.Fornecedor.Interfaces
{
    public interface IFornecedor
    {
        void Incluir(ModeloFornecedor modelo);
        void Alterar(ModeloFornecedor modelo);
        void Excluir(int codigo);
        DataTable Localizar(int tipoPesquisaFornecedor, string valorPesquisa);
        ModeloFornecedor CarregaFornecedorPorCodigo(int codigo);
        ModeloFornecedor CarregaFornecedorPorCnpj(string cnpj);
    }
}
