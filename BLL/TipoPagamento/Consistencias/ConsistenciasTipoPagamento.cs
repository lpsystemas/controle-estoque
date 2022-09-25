using ModeloDB.TipoPagamento;
using System;
using static ConstsEnumerados.Constantes;

namespace BLL.TipoPagamento.Consistencias
{
    public static class ConsistenciasTipoPagamento
    {
        public static void ValidaCamposObrigatorios(
            ModeloTipoPagamento modelo,
            string operacao)
        {
            if (modelo.TPagtoNome.Trim().Length == 0)
                throw new Exception("O nome do tipo de pagamento é obrigatório");

            if (modelo.TPagtoCod <= 0 && operacao == Alterar)
                throw new Exception("O código do tipo de pagamento é obrigatório");
        }
    }
}
