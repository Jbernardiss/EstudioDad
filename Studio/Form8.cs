using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio
{
    public partial class Form8 : Form
    {
        List<Modalidade> arrayModalidades = new List<Modalidade>();

        public Form8()
        {
            InitializeComponent();
            carregarModalidade();
        }

        void carregarModalidade()
        {
            MySqlDataReader dadosModalidades = Modalidade.consultarTodasModalidades();

            cBoxModalidade.Items.Clear();
            arrayModalidades.Clear();

            int id;
            string descricao;
            double preco;
            int qtde_alunos;
            int qtde_aulas;
            
            while(dadosModalidades.Read())
            {
                id = (int)dadosModalidades["idEstudio_Modalidade"];
                descricao = dadosModalidades["descricaoModalidade"].ToString();
                preco = (double)dadosModalidades["precoModalidade"];
                qtde_alunos = (int)dadosModalidades["qtdeAlunos"];
                qtde_aulas = (int)dadosModalidades["qtdeAulas"];
                arrayModalidades.Add(new Modalidade(id, descricao, preco, qtde_alunos, qtde_aulas));

                cBoxModalidade.Items.Add(dadosModalidades["descricaoModalidade"].ToString());
            }

            DAO_Conexao.con.Close();
        }

        void carregarDiaDaSemana()
        {
            MySqlDataReader dadosTurmas = Turma.consultarTurmaPorModalidade(arrayModalidades[cBoxModalidade.SelectedIndex].Id);

            cBoxDiaDaSemana.Items.Clear();
            cBoxDiaDaSemana.Enabled = true;

            while(dadosTurmas.Read())
            {
                if(cBoxDiaDaSemana.Items.IndexOf(dadosTurmas["diaSemanaTurma"].ToString()) < 0)
                {
                    cBoxDiaDaSemana.Items.Add(dadosTurmas["diaSemanaTurma"].ToString());
                }
            }

            DAO_Conexao.con.Close();
        }

        void carregarHora()
        {
            MySqlDataReader dadosTurmas = Turma.consultarTurmaPorModalidadeEDia(arrayModalidades[cBoxModalidade.SelectedIndex].Id, cBoxDiaDaSemana.Text);

            cBoxHora.Items.Clear();
            cBoxHora.Enabled = true;

            while(dadosTurmas.Read())
            {
                cBoxHora.Items.Add(dadosTurmas["horaTurma"].ToString());
            }

            DAO_Conexao.con.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                if (Turma.excluirTurma(arrayModalidades[cBoxModalidade.SelectedIndex].Id, cBoxDiaDaSemana.Text, cBoxHora.Text))
                {
                    MessageBox.Show("Turma excluída com sucesso!");

                    cBoxModalidade.SelectedIndex = -1;
                    carregarModalidade();
                    cBoxDiaDaSemana.Enabled = false;
                    cBoxHora.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Erro ao excluir a turma.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("O campo modalidade não pode estar vazio!");
            }
        }

        private void cBoxModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxDiaDaSemana.SelectedIndex = -1;
            cBoxHora.Enabled = false;
            if(cBoxModalidade.SelectedIndex != -1)
            {
                carregarDiaDaSemana();
            }
        }

        private void cBoxDiaDaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxHora.SelectedIndex = -1;
            if (cBoxModalidade.SelectedIndex != -1)
            {
                carregarHora();
            }
        }
    }
}
