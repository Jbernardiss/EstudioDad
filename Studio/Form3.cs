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
    public partial class Form3 : Form
    {
        bool alunoExiste = false;

        public Form3()
        {
            InitializeComponent();
        }


        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(e.KeyChar == 13)
            {

                Aluno aluno = new Aluno(txtCPF.Text);


                try
                {    
                    MySqlDataReader dadosAluno = aluno.consultarAluno();

                    if(dadosAluno.Read())
                    {
                        MessageBox.Show("Usuário já existe!");

                        txtNome.Text = dadosAluno["nomeAluno"].ToString();
                        txtEndereco.Text = dadosAluno["ruaAluno"].ToString();
                        txtNumero.Text = dadosAluno["numeroAluno"].ToString();
                        txtBairro.Text = dadosAluno["bairroAluno"].ToString();
                        txtComplemento.Text = dadosAluno["complementoAluno"].ToString();
                        txtCEP.Text = dadosAluno["CEPAluno"].ToString();
                        txtCidade.Text = dadosAluno["cidadeAluno"].ToString();
                        txtEstado.Text = dadosAluno["estadoAluno"].ToString();
                        txtTelefone.Text = dadosAluno["telefoneAluno"].ToString();
                        txtEmail.Text = dadosAluno["emailAluno"].ToString();

                        alunoExiste = true;
                        btnCadastrar.Text = "Atualizar";
                    } 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DAO_Conexao.con.Close();
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text, txtNome.Text, txtEndereco.Text, txtNumero.Text, txtBairro.Text, txtComplemento.Text, txtCEP.Text, txtCidade.Text, txtEstado.Text,
                txtTelefone.Text, txtEmail.Text);

            if(alunoExiste == false)
            {
                if (aluno.cadastroAluno())
                {
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro no cadastro.");
                }
            }
            else if(alunoExiste == true) 
            { 
                if(aluno.atualizarAluno())
                {
                    MessageBox.Show("Cadastro atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro na atualização.");
                }

                btnCadastrar.Text = "Cadastrar";
            }
            

            txtCPF.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtComplemento.Text = "";
            txtCEP.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtTelefone.Text = ""; 
            txtEmail.Text = "";
        }
    }
}
