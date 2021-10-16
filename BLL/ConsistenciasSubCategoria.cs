﻿using Ferramentas;
using ModeloDB;
using System;
using static Consts.Constantes;
using System.Collections.Generic;

namespace BLL
{
  public static class ConsistenciasSubCategoria
  {
    public static void ValidaCamposObrigatorios(ModeloSubCategoria modelo, string operacao)
    {
      if (modelo.SCatNome.Trim().Length == 0 && operacao == Inserir || operacao == Alterar)
        throw new Exception("O nome da SubCategoria é obrigatório");

      if (modelo.CatCod <= 0 && operacao == Inserir || operacao == Alterar)
        throw new Exception("O Código da Categoria é obrigatório");

      if (modelo.SCatCod <= 0 && operacao == Alterar)
        throw new Exception("O Código da SubCategoria é obrigatório");
    }    
  }
}
