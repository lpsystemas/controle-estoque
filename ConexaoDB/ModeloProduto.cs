using System;
using System.IO;

namespace ModeloDB
{
    public class ModeloProduto
  {
    //Código do Produto   
    private int prod_Cod;
    
    public int ProdCod
    {
      get { return this.prod_Cod; }
      set { this.prod_Cod = value; }
    }

    //Nome do Produto
    private string prod_Nome;

    public string ProdNome
    {
      get { return this.prod_Nome; }
      set { this.prod_Nome = value; }
    }

    //Descrição do Produto
    private string prod_Desc;

    public string ProdDesc
    {
      get { return this.prod_Desc; }
      set { this.prod_Desc = value; }
    }

    //Foto do Produto
    private byte[] prod_Foto;

    public byte[] ProdFoto
    {
      get { return this.prod_Foto; }
      set { this.prod_Foto = value; }
    }

    //Valor Pago do Produto
    private double prod_ValorPago;

    public double ProdValorPago
    {
      get { return this.prod_ValorPago; }
      set { this.prod_ValorPago = value; }
    }

    //Valor de Venda do Produto
    private double prod_ValorVenda;

    public double ProdValorVenda
    {
      get { return this.prod_ValorVenda; }
      set { this.prod_ValorVenda = value; }
    }

    //Quantidade do Produto
    private double prod_Quantidade;

    public double ProdQuantidade
    {
      get { return this.prod_Quantidade; }
      set { this.prod_Quantidade = value; }
    }

    //Unidade de Medida do Produto
    private int umed_Cod;

    public int UmedCod
    {
      get { return this.umed_Cod; }
      set { this.umed_Cod = value; }
    }

    //Categoria do Produto
    private int cat_Cod;

    public int CatCod
    {
      get { return this.cat_Cod; }
      set { this.cat_Cod = value; }
    }

    //SubCategoria do Produto
    private int sCat_Cod;

    public int SCatCod
    {
      get { return this.sCat_Cod; }
      set { this.sCat_Cod = value; }
    }

    public ModeloProduto()
    {
      this.ProdCod = 0;
      this.ProdNome = string.Empty;
      this.ProdDesc = string.Empty;      
      this.ProdValorPago = 0;
      this.ProdValorVenda = 0;
      this.ProdQuantidade = 0;
      this.UmedCod = 0;
      this.CatCod = 0;
      this.SCatCod = 0;
    }

    public ModeloProduto(int codProduto, string nomeProd, string descProd, byte[] fotoProd, double valorPago,
                         double valorVenda, double quantidade, int codUmed, int CodCat, int CodSCat)
    {
      this.ProdCod = codProduto;
      this.ProdNome = nomeProd;
      this.ProdDesc = descProd;
      this.ProdFoto = fotoProd;
      this.ProdValorPago = valorPago;
      this.ProdValorVenda = valorVenda;
      this.ProdQuantidade = quantidade;
      this.UmedCod = codUmed;
      this.CatCod = CodCat;
      this.SCatCod = CodSCat;
    }

    public ModeloProduto(int codProduto, string nomeProd, string descProd, string fotoProd, double valorPago,
                     double valorVenda, double quantidade, int codUmed, int CodCat, int CodSCat)
    {
      this.ProdCod = codProduto;
      this.ProdNome = nomeProd;
      this.ProdDesc = descProd;
      this.CarregaImagem(fotoProd);
      this.ProdValorPago = valorPago;
      this.ProdValorVenda = valorVenda;
      this.ProdQuantidade = quantidade;
      this.UmedCod = codUmed;
      this.CatCod = CodCat;
      this.SCatCod = CodSCat;
    }

    public void CarregaImagem(string caminhoImagem)
    {
      try
      {
        if (string.IsNullOrEmpty(caminhoImagem))
          return;

        FileInfo arquivoImagem = new FileInfo(caminhoImagem);

        FileStream fileStream = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read, FileShare.Read);

        this.ProdFoto = new byte[Convert.ToInt32(arquivoImagem.Length)];

        int iBytesRead = fileStream.Read(this.ProdFoto, 0, Convert.ToInt32(arquivoImagem.Length));
        fileStream.Close();
      }
      catch(Exception ex)
      {
        throw new Exception(ex.Message.ToString());
      }
    }
  }
}
