using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio
{
    public partial class Form11 : Form
    {
        List<Turma> arrTurmas = new List<Turma>();
        
        public Form11()
        {
            InitializeComponent();
            carregarTurmas();
            //carregarTabela();
        }

        public void carregarTurmas()
        {
            MySqlDataReader dadosTurma = Turma.consultarTodasTurmasComDescModalidade();
 
            while (dadosTurma.Read())
            {
                comboBoxTurmas.Items.Add($"{dadosTurma["descricaoModalidade"]}#{dadosTurma["idEstudio_Turma"]}");
                arrTurmas.Add(new Turma(Int32.Parse(dadosTurma["idEstudio_Turma"].ToString()), dadosTurma["professorTurma"].ToString(), dadosTurma["diaSemanaTurma"].ToString(), dadosTurma["horaTurma"].ToString(), dadosTurma["descricaoModalidade"].ToString(), Int32.Parse(dadosTurma["idModalidade"].ToString()), Int32.Parse(dadosTurma["nAlunosTurma"].ToString())));
            }

            DAO_Conexao.con.Close();
        }

        public void carregarTabela()
        {
            MySqlDataReader dados = Matricula.consultarMatriculasPorIdTurma(arrTurmas[comboBoxTurmas.SelectedIndex].Id);

            dataGridViewAlunos.Rows.Clear();

            while (dados.Read())
            {
                dataGridViewAlunos.Rows.Add(dados["nomeAluno"].ToString());
            }

            DAO_Conexao.con.Close();
        }

        private void comboBoxTurmas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDiaSemana.Text = arrTurmas[comboBoxTurmas.SelectedIndex].Dia_semana;
            txtHora.Text = arrTurmas[comboBoxTurmas.SelectedIndex].Hora;
            txtQtdeAlunos.Text = $"{arrTurmas[comboBoxTurmas.SelectedIndex].NumeroAlunosTurma}";

            carregarTabela();
        }
    }
}
