using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio
{
    class Matricula
    {
        string cpfAluno;
        int idTurma;

        public Matricula(string cpfAluno, int idTurma)
        {
            this.cpfAluno = cpfAluno;
            this.idTurma = idTurma;
        }

        public string CpfAluno { get => cpfAluno; set => cpfAluno = value; }
        public int IdTurma { get => idTurma; set => idTurma = value; }


        public bool cadastrarMatricula()
        {
            bool cadastrado = false;
            MySqlDataReader dadosTurma;
            MySqlCommand sql;

            try
            {
                DAO_Conexao.con.Open();
                sql = new MySqlCommand($"INSERT INTO Estudio_Matricula (cpfAluno, idTurma) VALUES('{cpfAluno}', {idTurma})", DAO_Conexao.con);
                sql.ExecuteNonQuery();

                sql = new MySqlCommand($"SELECT * from Estudio_Turma where idEstudio_Turma = {idTurma}", DAO_Conexao.con);
                dadosTurma = sql.ExecuteReader();

                dadosTurma.Read();
                int currentAlunos = Convert.ToInt32(dadosTurma["nAlunosTurma"].ToString());
                DAO_Conexao.con.Close();

                DAO_Conexao.con.Open();
                sql = new MySqlCommand($"UPDATE Estudio_Turma SET nAlunosTurma = '{currentAlunos + 1}' where idEstudio_Turma = {idTurma}", DAO_Conexao.con);
                sql.ExecuteNonQuery();

                cadastrado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return cadastrado;
        }

        public static bool matriculaExiste(string cpfAluno, int idTurma)
        {
            bool existe = false;
            MySqlDataReader dadosMatricula = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT * FROM Estudio_Matricula where cpfAluno = '{cpfAluno}' and idTurma = {idTurma}", DAO_Conexao.con);
                dadosMatricula = sql.ExecuteReader();

                if(dadosMatricula.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return existe;
        }

        public bool apagarMatricula()
        {
            bool apagado = false;
            MySqlDataReader dadosTurma;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand($"DELETE FROM Estudio_Matricula where cpfAluno = '{cpfAluno}' and idTurma = {idTurma}", DAO_Conexao.con);
                // MySqlCommand sql = new MySqlCommand($"UPDATE Estudio_Matricula set ativa = 0 where cpfAluno = '{cpfAluno}' and idTurma = {idTurma}", DAO_Conexao.con);
                sql.ExecuteNonQuery();
                apagado = true;

                sql = new MySqlCommand($"SELECT * from Estudio_Turma where idEstudio_Turma = {idTurma}", DAO_Conexao.con);
                dadosTurma = sql.ExecuteReader();

                dadosTurma.Read();
                int currentAlunos = Convert.ToInt32(dadosTurma["nAlunosTurma"].ToString());
                DAO_Conexao.con.Close();

                DAO_Conexao.con.Open();
                sql = new MySqlCommand($"UPDATE Estudio_Turma SET nAlunosTurma = '{currentAlunos - 1}' where idEstudio_Turma = {idTurma}", DAO_Conexao.con);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return apagado;
        }

        public static MySqlDataReader consultarMatriculas()
        {
            MySqlDataReader dadosMatricula = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT Estudio_Aluno.nomeAluno, Estudio_Matricula.*, Estudio_Turma.idModalidade, Estudio_Modalidade.descricaoModalidade FROM (((Estudio_Aluno INNER JOIN Estudio_Matricula ON Estudio_Aluno.CPFAluno = Estudio_Matricula.cpfAluno) INNER JOIN Estudio_Turma ON Estudio_Matricula.idTurma = Estudio_Turma.idEstudio_Turma) INNER JOIN Estudio_Modalidade ON Estudio_Modalidade.idEstudio_Modalidade = Estudio_Turma.idModalidade)", DAO_Conexao.con);
                dadosMatricula = sql.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dadosMatricula;
        }

        public static MySqlDataReader consultarMatriculasPorIdTurma(int idTurma)
        {
            MySqlDataReader dadosMatricula = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT Estudio_Aluno.nomeAluno, Estudio_Matricula.idTurma FROM Estudio_Aluno INNER JOIN Estudio_Matricula ON Estudio_Aluno.CPFAluno = Estudio_Matricula.cpfAluno WHERE idTurma = {idTurma}", DAO_Conexao.con);
                dadosMatricula = sql.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dadosMatricula;
        }
    }
}
