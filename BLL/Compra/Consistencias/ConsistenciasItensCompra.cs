using ModeloDB.Compra;
using System;
using static ConstsEnumerados.Constantes;

namespace BLL.Compra.Consistencias
{
    public static class ConsistenciasItensCompra
    {
        public static void ValidaCamposObrigatoriosItensCompra(
           ModeloItensCompra modelo,
           string operacao)
        {
            if (modelo.ComCod <= 0 && 
                operacao == Alterar ||
                operacao == Excluir)
                throw new Exception("O código da compra é obrigatório");

            if (modelo.ItcCod <= 0)
                throw new Exception("O código do item da compra é obrigatório");

            if (modelo.ItcQtde <= 0)
                throw new Exception("A quantidade deve ser maior do que zero");

            if (modelo.ItcValor <= 0)
                throw new Exception("O valor do item deve ser maior do que zero");

            if(modelo.ProCod <= 0)
                throw new Exception("O código do produto é obrigatório");
        }
    }
}
