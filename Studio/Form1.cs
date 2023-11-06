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
        int tipoUsuario;

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
            tipoUsuario = DAO_Conexao.buscaTipoUsuario(textBox1.Text, textBox2.Text);

            if (tipoUsuario == 1)
            {
                MessageBox.Show("Login realizado com sucesso | Admininstrador");
                menuStrip1.Visible = true;
                groupBox1.Visible = false;
            }
            else if (tipoUsuario == 2)
            {
                MessageBox.Show("Login realizado com sucesso | Usuário Comum");
                menuStrip2.Visible = true;
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
            Form5 form5 = new Form5(tipoUsuario);
            form5.MdiParent = this;
            form5.Show();
        }

        private void excluirModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.MdiParent = this;
            form6.Show();
        }

        private void criarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.MdiParent = this;
            form7.Show();
        }

        private void excluirTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.MdiParent = this;
            form8.Show();
        }

        private void atualizarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(tipoUsuario);
            form9.MdiParent = this;
            form9.Show();
        }

        private void cadastrarAlunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void excluirAlunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.MdiParent = this;
            form4.Show();
        }

        private void consultarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(tipoUsuario);
            form5.MdiParent = this;
            form5.Show();
        }

        private void consultarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(tipoUsuario);
            form9.MdiParent = this;
            form9.Show();
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.MdiParent = this;
            form10.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.MdiParent = this;
            form11.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.MdiParent = this;
            form11.Show();
        }

        private void reativarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.MdiParent = this;
            form12.Show();
        }
    }
}
