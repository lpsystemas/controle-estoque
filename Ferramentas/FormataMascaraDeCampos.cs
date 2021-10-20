using System.Windows.Forms;
using static ConstsEnumerados.Enumerados;

namespace Ferramentas
{
  public static class FormataMascaraDeCampos
  {
    public static void FormataMascaraCampoCpfCnpj(CampoParaFormatacao campo, TextBox valorCampoCpfCnpj)
    {
      switch (campo)
      {
        case CampoParaFormatacao.CPF:
          valorCampoCpfCnpj.MaxLength = 14;

          if (valorCampoCpfCnpj.Text.Length == 3)
          {
            valorCampoCpfCnpj.Text = valorCampoCpfCnpj.Text + ".";
            valorCampoCpfCnpj.SelectionStart = valorCampoCpfCnpj.Text.Length + 1;
          }
          else if (valorCampoCpfCnpj.Text.Length == 7)
          {
            valorCampoCpfCnpj.Text = valorCampoCpfCnpj.Text + ".";
            valorCampoCpfCnpj.SelectionStart = valorCampoCpfCnpj.Text.Length + 1;
          }
          else if (valorCampoCpfCnpj.Text.Length == 11)
          {
            valorCampoCpfCnpj.Text = valorCampoCpfCnpj.Text + "-";
            valorCampoCpfCnpj.SelectionStart = valorCampoCpfCnpj.Text.Length + 1;
          }
          break;

        case CampoParaFormatacao.CNPJ:
          valorCampoCpfCnpj.MaxLength = 18;

          if (valorCampoCpfCnpj.Text.Length == 2 || valorCampoCpfCnpj.Text.Length == 6)
          {
            valorCampoCpfCnpj.Text = valorCampoCpfCnpj.Text + ".";
            valorCampoCpfCnpj.SelectionStart = valorCampoCpfCnpj.Text.Length + 1;
          }
          else if (valorCampoCpfCnpj.Text.Length == 10)
          {
            valorCampoCpfCnpj.Text = valorCampoCpfCnpj.Text + "/";
            valorCampoCpfCnpj.SelectionStart = valorCampoCpfCnpj.Text.Length + 1;
          }
          else if (valorCampoCpfCnpj.Text.Length == 15)
          {
            valorCampoCpfCnpj.Text = valorCampoCpfCnpj.Text + "-";
            valorCampoCpfCnpj.SelectionStart = valorCampoCpfCnpj.Text.Length + 1;
          }
          break;

      }
    }

    public static void FormataMascaraTelefone(CampoParaFormatacao campo, TextBox valorCampoTelefone)
    {
      if (campo == CampoParaFormatacao.TELEFONE)
      {
        valorCampoTelefone.MaxLength = 13;

        if (valorCampoTelefone.Text.Length == 0)
        {
          valorCampoTelefone.Text = valorCampoTelefone.Text + "(";
          valorCampoTelefone.SelectionStart = valorCampoTelefone.Text.Length + 1;
        }
        else if (valorCampoTelefone.Text.Length == 3)
        {
          valorCampoTelefone.Text = valorCampoTelefone.Text + ")";
          valorCampoTelefone.SelectionStart = valorCampoTelefone.Text.Length + 1;
        }
        else if (valorCampoTelefone.Text.Length == 8)
        {
          valorCampoTelefone.Text = valorCampoTelefone.Text + "-";
          valorCampoTelefone.SelectionStart = valorCampoTelefone.Text.Length + 1;
        }
      }

      if (campo == CampoParaFormatacao.CELULAR)
      {
        valorCampoTelefone.MaxLength = 14;

        if (valorCampoTelefone.Text.Length == 0)
        {
          valorCampoTelefone.Text = valorCampoTelefone.Text + "(";
          valorCampoTelefone.SelectionStart = valorCampoTelefone.Text.Length + 1;
        }
        else if (valorCampoTelefone.Text.Length == 3)
        {
          valorCampoTelefone.Text = valorCampoTelefone.Text + ")";
          valorCampoTelefone.SelectionStart = valorCampoTelefone.Text.Length + 1;
        }
        else if (valorCampoTelefone.Text.Length == 9)
        {
          valorCampoTelefone.Text = valorCampoTelefone.Text + "-";
          valorCampoTelefone.SelectionStart = valorCampoTelefone.Text.Length + 1;
        }
      }
    }
    
    public static void FormataMascaraCEP(CampoParaFormatacao campo, TextBox ValorCampoCEP)
    {
      if(campo == CampoParaFormatacao.CEP)
      {
        ValorCampoCEP.MaxLength = 9;
        
        if (ValorCampoCEP.Text.Length == 5)
        {
          ValorCampoCEP.Text = ValorCampoCEP.Text + "-";
          ValorCampoCEP.SelectionStart = ValorCampoCEP.Text.Length + 1;
        }
      }      
    }
  }
}
