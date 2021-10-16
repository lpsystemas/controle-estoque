using Ferramentas;
using ModeloDB;
using System;
using static Consts.Constantes;
using System.Collections.Generic;

namespace BLL
{
  public static class ConsistenciasUnidadeDeMedida
  {

    public static void ValidaCamposObrigatorios(ModeloUnidadeDeMedida modelo, string operacao)
    {
      if (modelo.UmedNome.Trim().Length == 0 && operacao == Inserir || operacao == Alterar)
        throw new Exception("O nome da Unidade de Medida é obrigatório");

      if (modelo.UmedCod <= 0 && operacao == Alterar)
        throw new Exception("O Código da Unidade de Medida é obrigatória");
    }
  }
}
