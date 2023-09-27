using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio
{
    class DAO_Conexao
    {
        public static MySqlConnection con;
        public static Boolean getConexao(String endereco, String banco, String user, String senha) 
        {
            Boolean retorno = false;
            try
            {
                con = new MySqlConnection("server=" + endereco + ";User ID=" + user + ";" + "database=" + banco + 
                    "; password=" + senha + "; SslMode = none");
                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return retorno;
        }

        internal static object getConexao()
        {
            throw new NotImplementedException();
        }

        public static Boolean cadastroUsuario(string usuario, string senha, int tipo)
        {
            bool cad = false;
            try
            {
                con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Usuario (usuario, senha, tipo) " +
                    "values ('" + usuario + "','" + senha + "'," + tipo + ")", con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return cad;
        }
        

        public static int buscaTipoUsuario(string usuario, string senha)
        {
            int tipo = 0;
            try
            {
                con.Open();
                MySqlCommand select = new MySqlCommand("select * from Estudio_Usuario where usuario = '" + usuario + "' and senha = '" + senha + "'", con);
                MySqlDataReader resultado =  select.ExecuteReader();
                if(resultado.Read())
                {
                    tipo = Convert.ToInt32(resultado["tipo"].ToString());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return tipo;
        }

    }
}
