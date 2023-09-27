using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio
{
    class Modalidade
    {

        private int id;
        private string descricao;
        private double preco;
        private int qtde_alunos;
        private int qtde_aulas;

        public Modalidade(int id, string descricao, double preco, int qtde_alunos, int qtde_aulas)
        {
            this.id = id;
            this.descricao = descricao;
            this.preco = preco;
            this.qtde_alunos = qtde_alunos;
            this.qtde_aulas = qtde_aulas;
        }

        public Modalidade(string descricao, double preco, int qtde_alunos, int qtde_aulas)
        {
            this.descricao = descricao;
            this.preco = preco;
            this.qtde_alunos = qtde_alunos;
            this.qtde_aulas = qtde_aulas;
        }

        public Modalidade(int id)
        {
            this.id = id;
        }

        public Modalidade(string descricao)
        {
            this.descricao = descricao;
        }

        public Modalidade()
        {
        }
        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Qtde_alunos { get => qtde_alunos; set => qtde_alunos = value; }
        public int Qtde_aulas { get => qtde_aulas; set => qtde_aulas = value; }

        
        public bool cadastrarModalidade() 
        {
            bool cadastro = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("INSERT INTO Estudio_Modalidade (descricaoModalidade, precoModalidade, qtdeAlunos, qtdeAulas) values" + 
                    "('" + descricao + "', " + preco + ", " + qtde_alunos + ", " + qtde_aulas + ")", DAO_Conexao.con);
                sql.ExecuteNonQuery();
                cadastro = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return cadastro;
        }

        static public MySqlDataReader consultarTodasModalidades()
        {
            MySqlDataReader dadosModalidade = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM Estudio_Modalidade WHERE ativa = 1", DAO_Conexao.con);
                dadosModalidade = sql.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return dadosModalidade;
        }

        public bool excluirModalidade()
        {
            bool excluido = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("UPDATE Estudio_Modalidade set ativa = 0 where idEstudio_Modalidade = '" + id + "'", DAO_Conexao.con);
                sql.ExecuteNonQuery();
                excluido = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return excluido;
        }        

        public bool atualizarModalidade()
        {
            bool atualizado = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("UPDATE Estudio_Modalidade set descricaoModalidade = '" + descricao + "', precoModalidade = " + preco + ", qtdeAlunos = " + qtde_alunos + ", qtdeAulas = " + qtde_aulas + " where idEstudio_Modalidade = '" + id + "'", DAO_Conexao.con);
                sql.ExecuteNonQuery();
                atualizado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); //Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return atualizado;
        }
    }
}
