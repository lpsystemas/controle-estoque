using ModeloDB.Compra;
using System;
using static ConstsEnumerados.Constantes;

namespace BLL.Compra.Consistencias
{
    public static class ConsistenciasParcelasCompra
    {
        public static void ValidaCamposObrigatoriosParcelasCompra(ModeloParcelasCompra modelo, string operacao)
        {
            if (modelo.PcoCod <= 0 &&
                operacao == Inserir ||
                operacao == Alterar ||
                operacao == Excluir)
                throw new Exception("O código da parcela é obrigatório");

            if (modelo.ComCod <= 0 &&
                operacao == Inserir ||
                operacao == Alterar ||
                operacao == Excluir)
                throw new Exception("O código da compra é obrigatório");

            if (modelo.PcoValor <= 0 &&
                operacao == Inserir ||
                operacao == Alterar)
                throw new Exception("O valor da parcela é obrigatório");                        
        }

        public static void ConsisteAnoVencimentoParcela(DateTime dataVencimento)
        {
            DateTime data = DateTime.Now;

            if (dataVencimento.Year < data.Year)
                throw new Exception("Ano de vencimento da parcela inferior ao ano atual");
        }
    }
}
