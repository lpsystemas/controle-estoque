using ModeloDB.UnidadeDeMedida;
using System;
using static ConstsEnumerados.Constantes;

namespace BLL.UnidadeDeMedida
{
    public static class ConsistenciasUnidadeDeMedida
    {

        public static void ValidaCamposObrigatorios(
            ModeloUnidadeDeMedida modelo,
            string operacao)
        {
            if (modelo.UmedNome.Trim().Length == 0)
                throw new Exception("O nome da Unidade de Medida é obrigatório");

            if (modelo.UmedCod <= 0 && operacao == Alterar)
                throw new Exception("O Código da Unidade de Medida é obrigatória");
        }
    }
}
