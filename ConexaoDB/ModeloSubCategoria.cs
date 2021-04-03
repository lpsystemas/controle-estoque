using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDB
{
  public class ModeloSubCategoria
  {
    //Codigo da Categoria
    private int cat_cod;
    public int CatCod
    {
      get { return this.cat_cod; }
      set { this.cat_cod = value; }
    }

    //Codigo da SubCategoria
    private int scat_cod;
    public int SCatCod
    {
      get { return this.scat_cod; }
      set { this.scat_cod = value; }
    }
    //Nome da SubCategoria
    private string scat_nome;
    public string SCatNome
    {
      get { return this.scat_nome; }
      set { this.scat_nome = value; }
    }

    public ModeloSubCategoria()
    {
      this.CatCod = 0;
      this.SCatCod = 0;
      this.SCatNome = string.Empty;
    }

    public ModeloSubCategoria(int catCod, int sCatCod, string sCatNome)
    {
      this.CatCod = catCod;
      this.SCatCod = sCatCod;
      this.SCatNome = sCatNome;
    }
  }
}
