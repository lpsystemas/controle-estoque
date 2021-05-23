using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consts
{
  public class Constantes
  {
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

  }
}
