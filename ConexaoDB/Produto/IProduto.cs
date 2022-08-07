﻿using System.Data;


namespace ModeloDB.Produto
{
    public interface IProduto
    {
        void Incluir(ModeloProduto modelo);
        void Alterar(ModeloProduto modelo);
        void Excluir(int codigo);
        DataTable Localizar(string nome);
        ModeloProduto CarregaProduto(int codigo);
    }
}
