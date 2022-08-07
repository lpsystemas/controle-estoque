﻿using ModeloDB.Categoria;
using System;
using static ConstsEnumerados.Constantes;

namespace BLL.Categoria
{
  public static class ConsistenciasCategoria
  {
    public static void ValidaCamposObrigatorios(ModeloCategoria modelo, string operacao)
    {
      if (modelo.CatNome.Trim().Length == 0)
        throw new Exception("O nome da categoria é obrigatória");

      if (modelo.CatCod <= 0 && operacao == Alterar)
        throw new Exception("O Código da categoria é obrigatória");      
    }    
  }
}
