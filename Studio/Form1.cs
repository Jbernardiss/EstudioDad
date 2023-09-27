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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202232", "cl202232", "Th30n3Wh0Kn0ck$"))
            {
                Console.WriteLine("Connectado");
            }
            else
            {
                Console.WriteLine("Erro de conexão");
            }
        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadLogin cadLogin = new CadLogin();
            cadLogin.MdiParent = this;
            cadLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipoUsuario = DAO_Conexao.buscaTipoUsuario(textBox1.Text, textBox2.Text);

            if (tipoUsuario == 1)
            {
                MessageBox.Show("Login realizado com sucesso | Admininstrador");
                menuStrip1.Visible = true;
                groupBox1.Visible = false;
            }
            else if (tipoUsuario == 2)
            {
                MessageBox.Show("Login realizado com sucesso | Usuário Comum");
                menuStrip1.Visible = true;
                groupBox1.Visible = false;
            }
            else if (tipoUsuario == 0)
            {
                MessageBox.Show("Falha ao realizar login");
            }
            else
            {
                MessageBox.Show("Não");
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.MdiParent = this;
            form4.Show();
        }

        private void criarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.MdiParent = this;
            form5.Show();
        }

        private void excluirModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.MdiParent = this;
            form6.Show();
        }
    }
}
