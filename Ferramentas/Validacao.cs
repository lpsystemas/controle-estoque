﻿

namespace Ferramentas
{
  public static class Validacao
  {
    /// <summary>
    /// Método ValidaCpf
    /// </summary>
    /// <param name="cpf">Número do Cpf</param>
    /// <returns></returns>
    public static bool ValidaCpf(string cpf)
    {
      int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
      int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
      int soma, resto;
      string tempCpf, digito;

      cpf = cpf.Trim();
      cpf = cpf.Replace(".", "").Replace("-", "").Replace(" ", "");

      if (cpf.Length != 11)
      {
        return false;
      }
      else
      {
        tempCpf = cpf.Substring(0, 9);

        soma = 0;
        for (int i = 0; i < 9; i++)
          soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

        resto = soma % 11;
        if (resto < 2)
          resto = 0;
        else
          resto = 11 - resto;

        digito = resto.ToString();
        tempCpf = tempCpf + digito;

        soma = 0;
        for (int i = 0; i < 10; i++)
          soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

        resto = soma % 11;
        if (resto < 2)
          resto = 0;
        else
          resto = 11 - resto;

        digito = digito + resto.ToString();
        return cpf.EndsWith(digito);
      }
    }
    
    /// <summary>
    /// Método ValidaCnpj
    /// </summary>
    /// <param name="cnpj">Número do Cnpj</param>
    /// <returns></returns>
    public static bool ValidaCnpj(string cnpj)
    {
      int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
      int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
      int soma, resto;
      string digito, tempCnpj;

      cnpj = cnpj.Trim();
      cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");

      if (cnpj.Length != 14)
      {
        return false;
      }
      else
      {
        tempCnpj = cnpj.Substring(0, 12);

        soma = 0;
        for (int i = 0; i < 12; i++)
          soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

        resto = (soma % 11);
        if (resto < 2)
          resto = 0;
        else
          resto = 11 - resto;

        digito = resto.ToString();
        tempCnpj = tempCnpj + digito;

        soma = 0;
        for (int i = 0; i < 13; i++)
          soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

        resto = (soma % 11);
        if (resto < 2)
          resto = 0;
        else
          resto = 11 - resto;

        digito = digito + resto.ToString();
        return cnpj.EndsWith(digito);
      }
    }

    public static bool ValidaCep(string cep)
    {
      return System.Text.RegularExpressions.Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));
    }
  }
}
