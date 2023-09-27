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
    public partial class Form5 : Form
    {
        MySqlDataReader dadosModalidades;
        List<Modalidade> arrayModalidades = new List<Modalidade>();
        bool atualizando = false;

        public Form5()
        {
            InitializeComponent();

            carregarComboBox();
        }

        private void carregarComboBox()
        {
            dadosModalidades = Modalidade.consultarTodasModalidades();

            comboBoxDescricao.Items.Clear();
            arrayModalidades = new List<Modalidade>();

            while (dadosModalidades.Read())
            {
                int id = (int)dadosModalidades["idEstudio_Modalidade"];
                string desc = dadosModalidades["descricaoModalidade"].ToString();
                double preco = (double)dadosModalidades["precoModalidade"];
                int qtdeAlunos = (int)dadosModalidades["qtdeAlunos"];
                int qtdeAulas = (int)dadosModalidades["qtdeAulas"];

                comboBoxDescricao.Items.Add(dadosModalidades["descricaoModalidade"].ToString());
                arrayModalidades.Add(new Modalidade(id, desc, preco, qtdeAlunos, qtdeAulas));
            }

            DAO_Conexao.con.Close();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {   
            try
            {
                if(comboBoxDescricao.Text == "")
                {
                    throw new Exception();
                }

                
                if(atualizando)
                {
                    Modalidade modalidade = new Modalidade(Convert.ToInt32(arrayModalidades[comboBoxDescricao.SelectedIndex].Id.ToString()), comboBoxDescricao.Text, Convert.ToDouble(txtPreco.Text), Convert.ToInt32(txtQtdeAluno.Text), Convert.ToInt32(txtQtdeAula.Text));
                    if (modalidade.atualizarModalidade())
                    {
                        MessageBox.Show("Modalidade atualizada com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Houve um erro ao atualizar a modalidade");
                    }
                }
                else
                {
                    Modalidade modalidade = new Modalidade(comboBoxDescricao.Text, Convert.ToDouble(txtPreco.Text), Convert.ToInt32(txtQtdeAluno.Text), Convert.ToInt32(txtQtdeAula.Text));
                    if (modalidade.cadastrarModalidade())
                    {
                        MessageBox.Show("Modalidade cadastrada com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Houve um erro ao cadastrar a modalidade");
                    }
                }
                

                comboBoxDescricao.Text = "";
                txtPreco.Text = "";
                txtQtdeAluno.Text = "";
                txtQtdeAula.Text = "";
                btnCadastrar.Text = "Cadastrar";
                atualizando = false;
                comboBoxDescricao.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nenhum dos campos pode estar vazio");
            }
            finally
            {
                carregarComboBox();
            }
        }

        private void comboBoxDescricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxDescricao.SelectedIndex != -1)
            {
                txtPreco.Text = arrayModalidades[comboBoxDescricao.SelectedIndex].Preco.ToString();
                txtQtdeAluno.Text = arrayModalidades[comboBoxDescricao.SelectedIndex].Qtde_alunos.ToString();
                txtQtdeAula.Text = arrayModalidades[comboBoxDescricao.SelectedIndex].Qtde_aulas.ToString();
                btnCadastrar.Text = "Atualizar";
                atualizando = true;
            }
            else
            {
                atualizando = false;
            } 
        }
    }
}
