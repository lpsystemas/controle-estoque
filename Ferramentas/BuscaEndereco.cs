using System;
using System.Data;
using static ConstsEnumerados.Constantes; 



namespace Ferramentas
{
    public class BuscaEndereco
    {
        static public String cep = string.Empty;
        static public String cidade = string.Empty;
        static public String estado = string.Empty;
        static public String endereco = string.Empty;
        static public String bairro = string.Empty;

        public static Boolean verificaCEP(String CEP)
        {
            bool flag = false;
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", CEP);
                ds.ReadXml(xml);

                if (ds.Tables[0].Rows[0]["resultado"].ToString() == CepNaoEncontrado)
                {
                  endereco = string.Empty;
                  bairro = string.Empty;
                  cidade = string.Empty;
                  estado = string.Empty;                  
                  flag = false;                  
                }                  
                else 
                {
                  endereco = ds.Tables[0].Rows[0]["logradouro"].ToString();
                  bairro = ds.Tables[0].Rows[0]["bairro"].ToString();
                  cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                  estado = ds.Tables[0].Rows[0]["uf"].ToString();
                  cep = CEP;
                  flag = true;
                }
                
            }
            catch (Exception)
            {
                endereco = string.Empty;
                bairro = string.Empty;
                cidade = string.Empty;
                estado = string.Empty;
                cep = string.Empty;
            }
            return flag;
        }
    }
}
