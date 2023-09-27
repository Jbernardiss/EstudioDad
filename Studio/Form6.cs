using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class Form6 : Form
    {
        MySqlDataReader dadosModalidades;
        List<Modalidade> arrayModalidades = new List<Modalidade>();

        private void carregarComboBox()
        {
            dadosModalidades = Modalidade.consultarTodasModalidades();

            comboBoxModalidade.Items.Clear();

            while (dadosModalidades.Read())
            {
                int id = (int) dadosModalidades["idEstudio_Modalidade"];
                string desc = dadosModalidades["descricaoModalidade"].ToString();
                double preco = (double) dadosModalidades["precoModalidade"];
                int qtdeAlunos = (int) dadosModalidades["qtdeAlunos"];
                int qtdeAulas = (int) dadosModalidades["qtdeAulas"];

                comboBoxModalidade.Items.Add(dadosModalidades["descricaoModalidade"].ToString());
                arrayModalidades.Add(new Modalidade(id, desc, preco, qtdeAlunos, qtdeAulas));
            }

            DAO_Conexao.con.Close();
        }

        public Form6()
        {
            InitializeComponent();

            carregarComboBox();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(arrayModalidades[comboBoxModalidade.SelectedIndex].excluirModalidade())
            {
                MessageBox.Show("Modalidade excluída com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao excluir modalidade!");

            }

            comboBoxModalidade.SelectedIndex = -1;
            carregarComboBox();
        }
    }
}
