using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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


        public bool verificaCPF(string CPF) //string CPF - sem parâmetro
        {
            int soma, resto, cont = 0;
            soma = 0;

            CPF = CPF.Trim();
            CPF = CPF.Replace(",", "");
            CPF = CPF.Replace(".", "");
            CPF = CPF.Replace("-", "");

            for (int i = 0; i < CPF.Length; i++)
            {
                int a = CPF[0] - '0';
                int b = CPF[i] - '0';

                if (a == b) cont++;
            }

            if (cont == 11) return false;

            for (int i = 1; i <= 9; i++) soma += int.Parse(CPF.Substring(i - 1, 1)) * (11 - i);

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11)) resto = 0;

            if (resto != int.Parse(CPF.Substring(9, 1))) return false;

            soma = 0;

            for (int i = 1; i <= 10; i++) soma += int.Parse(CPF.Substring(i - 1, 1)) * (12 - i);

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11)) resto = 0;

            if (resto != int.Parse(CPF.Substring(10, 1))) return false;

            return true;
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            byte[] foto = ConverterFotoParaByteArray();

            Aluno aluno = new Aluno(txtCPF.Text, txtNome.Text, txtEndereco.Text, txtNumero.Text, txtBairro.Text, txtComplemento.Text, txtCEP.Text, txtCidade.Text, txtEstado.Text,
                txtTelefone.Text, txtEmail.Text, foto);

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

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Abrir Foto";
            dialog.Filter = "JPG (*.jpg)|*.jpg" + "|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dialog.OpenFile());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel carregar a foto: " + ex.Message);
                }
            }
            dialog.Dispose();
        }

        private byte[] ConverterFotoParaByteArray()
        {
            using (var stream = new System.IO.MemoryStream())
            {
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                //deslocamento de bytes em relação ao parâmetro original
                //redefine a posição do fluxo para a gravação
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                //Lê um bloco de bytes e grava os dados em um buffer (stream)
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text);

            if (txtCPF.Text.Length == 14)
            {
                if (verificaCPF(txtCPF.Text))
                {
                    try
                    {


                        MySqlDataReader dadosAluno = aluno.consultarAluno();

                        if (dadosAluno.Read())
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

                            try
                            {
                                string imagem = Convert.ToString(DateTime.Now.ToFileTime());
                                byte[] bimage = (byte[])dadosAluno["fotoAluno"];
                                FileStream fs = new FileStream(imagem, FileMode.CreateNew, FileAccess.Write);
                                fs.Write(bimage, 0, bimage.Length - 1);
                                fs.Close();
                                pictureBox1.Image = Image.FromFile(imagem);
                            }
                            catch
                            {
                                pictureBox1.Image = Image.FromFile("negado.png");
                                MessageBox.Show("Erro ao carregar a foto");
                            }

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
                else
                {
                    MessageBox.Show("CPF Inválido");

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
    }
}
