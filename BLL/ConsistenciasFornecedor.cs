using Ferramentas;
using ModeloDB;
using System;
using static ConstsEnumerados.Constantes;
using System.Collections.Generic;

namespace BLL
{
  public static class ConsistenciasFornecedor
  {

    public static void ValidaCamposObrigatorios(ModeloFornecedor modelo, string operacao)
    {
      if (modelo.ForCod <= 0 && operacao == Alterar)
        throw new Exception("O Código do Fornecedor é obrigatório");

      if (Convert.ToString(modelo.ForNome).Trim().Length == 0)
        throw new Exception("O nome do Fornecedor é obrigatório");

      if (Convert.ToString(modelo.ForCnpj).Trim().Length == 0)
        throw new Exception("O campo CNPJ é obrigatório");

      if (Convert.ToString(modelo.ForCelular).Trim().Length == 0)
        throw new Exception("O campo Celular é obrigatório");

      if (Convert.ToString(modelo.ForEmail).Trim().Length == 0)
        throw new Exception("O campo E-mail é obrigatório");
    }

    public static void ValidaPreenchimentoCnpj(ModeloFornecedor modelo)
    {
      if (!Validacao.ValidaCnpj(modelo.ForCnpj))
        throw new Exception("O CNPJ digitado é inválido. Favor digitar um numero de CNPJ válido!");
    }

    public static void ValidaPreenchimentoCEP(ModeloFornecedor modelo)
    {
      if (!Validacao.ValidaCep(modelo.ForCep))
        throw new Exception("CEP inválido!! \n Favor inserir um CEP válido para a busca correta do endereço.");
    }

    public static void ValidaPreenchimentoEmail(ModeloFornecedor modelo)
    {
      if (!Validacao.ValidaEmail(modelo.ForEmail))
        throw new Exception("Digite um E-mail válido");
    }

    
  }
}
