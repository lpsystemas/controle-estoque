using System.Data;

namespace ModeloDB.Cliente
{
    public interface ICliente
    {
        void Incluir(ModeloCliente modelo);
        void Alterar(ModeloCliente modelo);
        void Excluir(int codigo);
        DataTable Localizar(int tipoPesquisaCliente, string valorPesquisa);
        ModeloCliente CarregaClientePorCodigo(int codigo);
        ModeloCliente CarregaClientePorCpfCnpj(string cpfCnpj);
    }
}
