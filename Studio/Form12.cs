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
    public partial class Form12 : Form
    {

        MySqlDataReader dados;
        List<Aluno> alList = new List<Aluno>();
        public Form12()
        {
            InitializeComponent();
            carregarAlunosInativos();
        }

        public void carregarAlunosInativos()
        {
            Aluno al = new Aluno();
            dados = al.consultarAlunosInativos();

            cBoxAlunos.Items.Clear();

            while (dados.Read())
            {
                string nome = dados["nomeAluno"].ToString();
                string cpf = dados["CPFAluno"].ToString();

                Aluno aluno = new Aluno(cpf, nome);
                alList.Add(aluno);
                cBoxAlunos.Items.Add(dados["nomeAluno"].ToString());
            }

            DAO_Conexao.con.Close();
        }

        private void btnReativar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(alList[cBoxAlunos.SelectedIndex].getCpf());
            if (aluno.alunoExiste())
            {
                if (aluno.reativarAluno())
                {
                    MessageBox.Show("Aluno reativado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Houve um erro ao reativar o aluno!");
                }
                carregarAlunosInativos();
            }

        }
    }
}