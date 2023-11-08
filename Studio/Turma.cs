using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio
{
    class Turma
    {
        private string professor, dia_semana, hora, descModalidade;
        private int modalidade, id, numeroAlunosTurma;
        

        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public string DescModalidade { get => descModalidade; set => descModalidade = value; }
        public int Id { get => id; set => id = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; }
        public int NumeroAlunosTurma { get => numeroAlunosTurma; set => numeroAlunosTurma = value; }

        public Turma(int id, string professor, string dia_semana, string hora, string descModalidade)
        {
            this.id = id;
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.descModalidade = descModalidade;
        }

        public Turma(int id, string professor, string dia_semana, string hora, string descModalidade, int modalidade, int numeroAlunosTurma)
        {
            this.id = id;
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.descModalidade = descModalidade;
            this.Modalidade = modalidade;
            this.NumeroAlunosTurma = numeroAlunosTurma;
        }

        public Turma(int modalidade, string professor, string dia_semana, string hora)
        {
            this.Modalidade = modalidade;
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
        }

        public Turma(int modalidade)
        {
            this.Modalidade = modalidade;
        }

        public Turma(int modalidade, string dia_semana)
        {
            this.Modalidade = modalidade;
            this.dia_semana = dia_semana;
        }

        public bool cadastrarTurma()
        {
            bool cadastro = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand($"INSERT INTO Estudio_Turma (idModalidade, professorTurma, diaSemanaTurma, horaTurma, nAlunosTurma) VALUES ('{Modalidade}', '{professor}', '{dia_semana}', '{hora}', 0) ", DAO_Conexao.con);
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

        public bool atualizarTurma()
        {
            bool atualizado = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand($"UPDATE Estudio_Turma set professorTurma = '{professor}', diaSemanaTurma = '{dia_semana}', horaTurma = '{hora}' where idEstudio_Turma = {id}", DAO_Conexao.con);
                sql.ExecuteNonQuery();
                atualizado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return atualizado;
        }

        public bool adicionarAluno(string cpfAluno)
        {
            bool adicionado = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand($"INSERT INTO Estudio_TurmaAluno (cpfAluno, idEstudio_Turma) VALUES ('{cpfAluno}', {id}", DAO_Conexao.con);
                sql.ExecuteNonQuery();
                adicionado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return adicionado;
        }

        static public MySqlDataReader consultarTurmaPorModalidade(int idModalidade)
        {
            MySqlDataReader dadosTurmas = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT * FROM Estudio_Turma WHERE idModalidade = {idModalidade} AND ativo = 1", DAO_Conexao.con);
                dadosTurmas = sql.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return dadosTurmas;
        }

        static public MySqlDataReader consultarTurmaPorModalidadeEDia(int idModalidade, string diaSemana)
        {
            MySqlDataReader dadosTurmas = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand($"SELECT * FROM Estudio_Turma WHERE idModalidade = {idModalidade} AND diaSemanaTurma = '{diaSemana}' AND ativo = 1", DAO_Conexao.con);
                dadosTurmas = sql.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return dadosTurmas;
        }

        static public bool excluirTurma(int idModalidade, string diaSemana, string hora)
        {
            bool excluido = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand($"UPDATE Estudio_Turma SET ativo = 0 WHERE idModalidade = {idModalidade} AND diaSemanaTurma = '{diaSemana}' AND horaTurma = '{hora}'", DAO_Conexao.con);
                sql.ExecuteNonQuery();
                excluido = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return excluido;
        }

        static public bool excluirTurmaPorIdTurma(int idTurma)
        {
            bool excluido = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand($"UPDATE Estudio_Turma SET ativo = 0 WHERE idEstudio_Turma = {idTurma}", DAO_Conexao.con);
                sql.ExecuteNonQuery();
                excluido = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return excluido;
        }

        static public MySqlDataReader consultarTodasTurmasComDescModalidade()
        {
            MySqlDataReader dadosTurmas = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("SELECT Estudio_Turma.*, Estudio_Modalidade.descricaoModalidade from Estudio_Turma inner join Estudio_Modalidade on Estudio_Modalidade.idEstudio_Modalidade = Estudio_Turma.idModalidade WHERE Estudio_Turma.ativo = 1", DAO_Conexao.con);
                dadosTurmas = sql.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return dadosTurmas;
        }
    }
}
