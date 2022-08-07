namespace ModeloDB.TipoPagamento
{
    public class ModeloTipoPagamento
  {
    private int tPagto_cod;
    public int TPagtoCod
    {
      get { return this.tPagto_cod; }
      set { this.tPagto_cod = value; }
    }

    private string tPagto_nome;
    public string TPagtoNome
    {
      get { return this.tPagto_nome; }
      set { this.tPagto_nome = value; }
    }

    public ModeloTipoPagamento()
    {
      this.TPagtoCod = 0;
      this.TPagtoNome = string.Empty;
    }

    public ModeloTipoPagamento(int tPagtoCod, string tPagtoNome)
    {
      this.TPagtoCod = tPagtoCod;
      this.tPagto_nome = tPagtoNome;
    }
  }
}
