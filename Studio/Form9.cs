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
    public partial class Form9 : Form
    {
        List<Turma> arrayTurma = new List<Turma>();

        public Form9()
        {
            InitializeComponent();
            carregarTurma();

        }

        private void carregarTurma()
        {
            MySqlDataReader dadosTurma = Turma.consultarTodasTurmasComDescModalidade();

            cBoxturma.Items.Clear();
            arrayTurma.Clear();

            while(dadosTurma.Read())
            {
                int idTurma = (int)dadosTurma["idEstudio_turma"];
                string professor = (string)dadosTurma["professorTurma"];
                string diaSemana = (string)dadosTurma["diaSemanaTurma"];
                string horaTurma = (string)dadosTurma["horaTurma"];
                string descModalidade = (string)dadosTurma["descricaoModalidade"];

                arrayTurma.Add(new Turma(idTurma, professor, diaSemana, horaTurma, descModalidade));
                cBoxturma.Items.Add($"{descModalidade}#{idTurma}");
            }

            DAO_Conexao.con.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"{arrayTurma[cBoxturma.SelectedIndex].Id}");
                Turma turma = new Turma(arrayTurma[cBoxturma.SelectedIndex].Id, txtProfessor.Text, txtDiaDaSemana.Text, txthora.Text, txtModalidade.Text);
                if (turma.atualizarTurma())
                {
                    MessageBox.Show("Atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar!");
                }

                carregarTurma();
                txtModalidade.Text = "";
                txtProfessor.Text = "";
                txtDiaDaSemana.Text = "";
                txthora.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cBoxturma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxturma.SelectedIndex != -1) {

                txtModalidade.Text = arrayTurma[cBoxturma.SelectedIndex].DescModalidade;
                txtProfessor.Text = arrayTurma[cBoxturma.SelectedIndex].Professor;
                txtDiaDaSemana.Text = arrayTurma[cBoxturma.SelectedIndex].Dia_semana;
                txthora.Text = arrayTurma[cBoxturma.SelectedIndex].Hora;
            }
        }
    }
}
