using ModeloDB.Compra;
using System;
using static ConstsEnumerados.Constantes;

namespace BLL.Compra.Consistencias
{
    public static class ConsistenciasCompra
    {
        public static void ValidaCamposObrigatoriosCompra(
            ModeloCompra modelo,
            string operacao)
        {
            if (modelo.ComCod <= 0 && operacao == Alterar)
                throw new Exception("O código da compra dever ser maior do que zero");

            if (modelo.ComNParcelas <= 0)
                throw new Exception("O número de parcelas dever ser maior do que zero");

            if (modelo.ForCod <= 0)
                throw new Exception("O código do fornecedor deve ser informado");

            if (modelo.ComTotal <= 0)
                throw new Exception("O valor da compra deve ser informado");            
        }        
    }
}
