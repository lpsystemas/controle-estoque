namespace ConstsEnumerados
{
    public class Enumerados
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
    public enum TipoPesquisa
    {
      CPF = 0,
      CPNJ = 1,
      NOME = 2

    }

    public enum CampoParaFormatacao
    {
      CPF = 0,
      CNPJ = 1,
      CEP = 2,
      TELEFONE,
      CELULAR
    }
  }
}
