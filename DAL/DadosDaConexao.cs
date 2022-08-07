namespace DAL
{
    public class DadosDaConexao
  {
    public static string servidor = string.Empty;
    public static string banco = string.Empty;
    public static string usuario = string.Empty;
    public static string senha = string.Empty;
    public static string StringDeConexao
    {
      get { return string.Format(@"Data Source={0};
                                   Initial Catalog={1};
                                   User ID={2};
                                   Password={3}", servidor, banco, usuario, senha);}
    }
  }
}
