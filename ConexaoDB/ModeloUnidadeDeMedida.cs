namespace ModeloDB
{
    public class ModeloUnidadeDeMedida
  {
    private int umed_cod;
    public int UmedCod
    {
      get { return umed_cod; }
      set { this.umed_cod = value; }
    }

    private string umed_nome;

    public string UmedNome
    {
      get { return umed_nome; }
      set { this.umed_nome = value; }
    }

    public ModeloUnidadeDeMedida()
    {
      this.UmedCod = 0;
      this.UmedNome = string.Empty;
    }

    public ModeloUnidadeDeMedida(int umedCodigo, string umedNome)
    {
      this.UmedCod = umedCodigo;
      this.UmedNome = umedNome;
    }

  }
}
