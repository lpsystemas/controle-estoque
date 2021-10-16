using Ferramentas;
using ModeloDB;
using System;
using static Consts.Constantes;
using System.Collections.Generic;

namespace BLL
{
  public static class ConsistenciasTipoPagamento
  {
    public static void ValidaCamposObrigatorios(ModeloTipoPagamento modelo, string operacao)
    {
      if (modelo.TPagtoNome.Trim().Length == 0 && operacao == Inserir || operacao == Alterar)
        throw new Exception("O nome do tipo de pagamento é obrigatório");

      if (modelo.TPagtoCod <= 0 && operacao == Alterar)
        throw new Exception("O código do tipo de pagamento é obrigatório");
    }    
  }
}
