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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            carregarTabela();
        }

        public void carregarTabela()
        {
            MySqlDataReader dados = Matricula.consultarMatriculas();

            while(dados.Read())
            {
                dataGridView1.Rows.Add(dados["nomeAluno"].ToString(), dados["descricaoModalidade"].ToString() + "#" + dados["idTurma"].ToString());
            }

            DAO_Conexao.con.Close();
        }
    }
}
