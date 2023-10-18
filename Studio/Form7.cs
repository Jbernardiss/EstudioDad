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
    public partial class Form7 : Form
    {
        List<Modalidade> arrayModalidades = new List<Modalidade>();
        public Form7()
        {
            InitializeComponent();
            carregarModalidades();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtModalidade.Text == "")
                {
                    MessageBox.Show("Selecione uma modalidade!");
                }
                else
                {
                    Turma turma = new Turma(arrayModalidades[dataGridView1.CurrentCell.RowIndex].Id, txtProfessor.Text, txtDiaDaSemana.Text, txtHora.Text);
                    if (turma.cadastrarTurma())
                    {
                        MessageBox.Show("Cadastrado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro no cadastro!");
                    }
                }

                txtDiaDaSemana.Text = "";
                txtHora.Text = "";
                txtProfessor.Text = "";
                txtModalidade.Text = "";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void carregarModalidades()
        {
            MySqlDataReader dadosModalidades;
            dadosModalidades = Modalidade.consultarTodasModalidades();

            while (dadosModalidades.Read())
            {
                int id = (int)dadosModalidades["idEstudio_Modalidade"];
                string desc = dadosModalidades["descricaoModalidade"].ToString();
                double preco = (double)dadosModalidades["precoModalidade"];
                int qtdeAlunos = (int)dadosModalidades["qtdeAlunos"];
                int qtdeAulas = (int)dadosModalidades["qtdeAulas"];
                arrayModalidades.Add(new Modalidade(id, desc, preco, qtdeAlunos, qtdeAulas));

                dataGridView1.Rows.Add(dadosModalidades["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtModalidade.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
