using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consts
{
  public class Constantes
  {
    public const string Inserir = "Inserir";
    public const string Alterar = "Alterar";
    public const string Excluir = "Excluir";

    public const string CepNaoEncontrado = "0";
    public const string CepEncontrado = "1";
    public enum OperacaoFormulario
    {
      Inserir_Localizar = 1,
      Salvar_Cancelar = 2,
      Alterar_Excluir_Cancelar = 3
    }

    public enum TipoClienteFornecedor
    {
      Pessoa_Fisica = 0,
      Pessoa_Juridica = 1
    }
    public enum TipoPesquisaCliente
    {
      Nome = 0,
      CPF_CNPJ = 1
    }
  }
}
