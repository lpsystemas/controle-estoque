using Ferramentas;
using ModeloDB;
using System;
using static Consts.Constantes;
using System.Collections.Generic;

namespace BLL
{
  public static class ConsistenciasProduto
  {

    public static void ValidaCamposObrigatorios(ModeloProduto modelo, string operacao)
    {
      if (modelo.ProdNome.Trim().Length == 0)
        throw new Exception("O Nome do Produto é obrigatório");

      if (modelo.ProdDesc.Trim().Length == 0)
        throw new Exception("A Descrição do Produto é obrigatória");

      if (modelo.ProdValorVenda <= 0)
        throw new Exception("O Valor de venda do Produto é obrigatório");

      if (modelo.ProdQuantidade <= 0)
        throw new Exception("O quantidade do Produto deve ser maior ou igual a zero");

      if (modelo.UmedCod <= 0)
        throw new Exception("O código da Unidade de Medida é obrigatório");

      if (modelo.CatCod <= 0)
        throw new Exception("O código da Categoria é obrigatório");

      if (modelo.ProdCod <= 0 && operacao == Alterar)
        throw new Exception("O código do Produto é obrigatório");
    }
  }
}
