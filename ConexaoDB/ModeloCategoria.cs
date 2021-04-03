using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDB
{
  public class ModeloCategoria
  {
    //Codigo da Categoria
    private int cat_cod;
    public int CatCod 
    {
      get { return this.cat_cod; } 
      set { this.cat_cod = value; } 
    }

    //Nome da Categoria
    private string cat_nome;
    public string CatNome
    {
      get { return this.cat_nome; }
      set { this.cat_nome = value; }
    }

    public ModeloCategoria()
    {
      this.CatCod = 0;
      this.CatNome = string.Empty;
    }

    public ModeloCategoria(int catCod, string catNome)
    {
      this.CatCod = catCod;
      this.CatNome = catNome;
    }
  }
}
