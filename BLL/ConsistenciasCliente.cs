using Ferramentas;
using ModeloDB.Cliente;
using System;
using static ConstsEnumerados.Constantes;
using static ConstsEnumerados.Enumerados;

namespace BLL
{
  public static class ConsistenciasCliente
  {

    public static void ValidaCamposObrigatorios(ModeloCliente modelo, string operacao)
    {
      if (modelo.CliCod <= 0 && operacao == Alterar)
        throw new Exception("O Código do Cliente é obrigatório");

      if (Convert.ToString(modelo.CliNome).Trim().Length == 0)
        throw new Exception("O nome do Cliente é obrigatório");

      if (Convert.ToString(modelo.CliCpfCnpj).Trim().Length == 0)
        throw new Exception("O campo CPF/CNPJ é obrigatória");

      if (Convert.ToString(modelo.CliCelular).Trim().Length == 0)
        throw new Exception("O campo Celular é obrigatório");

      if (Convert.ToString(modelo.CliEmail).Trim().Length == 0)
        throw new Exception("O campo E-mail é obrigatório");
    }

    public static void ValidaPreenchimentoCpf_Cnpj(ModeloCliente modelo)
    {
      if (modelo.CliTipo == Convert.ToInt32(TipoClienteFornecedor.Pessoa_Fisica) && !Validacao.ValidaCpf(modelo.CliCpfCnpj))
        throw new Exception("O CPF digitado é inválido. Favor digitar um numero de CPF válido!");

      if (modelo.CliTipo == Convert.ToInt32(TipoClienteFornecedor.Pessoa_Juridica) && !Validacao.ValidaCnpj(modelo.CliCpfCnpj))
        throw new Exception("O CNPJ digitado é inválido. Favor digitar um numero de CNPJ válido!");
    }

    public static void ValidaPreenchimentoCEP(ModeloCliente modelo)
    {
      if (!Validacao.ValidaCep(modelo.CliCep))
        throw new Exception("CEP inválido!! \n Favor inserir um CEP válido para a busca correta do endereço.");
    }

    public static void ValidaPreenchimentoEmail(ModeloCliente modelo)
    {
      if (!Validacao.ValidaEmail(modelo.CliEmail))
        throw new Exception("Digite um E-mail válido");
    }


  }
}
