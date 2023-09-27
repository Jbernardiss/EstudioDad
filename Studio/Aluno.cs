using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio
{
    class Aluno
    {
        private string cpf;
        private string nome;
        private string rua;
        private string numero;
        private string bairro;
        private string complemento;
        private string cep;
        private string cidade;
        private string estado;
        private string telefone;
        private string email;
        private byte[] foto;
        private bool ativo;


        public Aluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, string cep, string cidade, string estado, string telefone, 
        string email, byte[] foto) {
            setCpf(cpf);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCep(cep);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
            setFoto(foto);
            setAtivo(true);
        }
        public Aluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, string cep, string cidade, string estado, string telefone,
        string email)
        {
            setCpf(cpf);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCep(cep);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
            setFoto(foto);
            setAtivo(true);
        }

        public Aluno()
        {

        }

        public Aluno(string cpf)
        {
            setCpf(cpf);
        }

        public bool cadastroAluno()
        {
            
            bool cadastro = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Aluno (CPFAluno, nomeAluno, ruaAluno, numeroAluno, bairroAluno, complementoAluno, CEPAluno, " +
                    "cidadeAluno, estadoAluno, telefoneAluno, emailAluno) values " + "('" + cpf + "','" + nome + "','" + rua + "','" + numero + "','" + bairro + "','" +
                     complemento + "','" + cep + "','" + cidade + "','" + estado + "','" + telefone + "','" + email + "')", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cadastro = true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return cadastro;
        }

        public bool alunoExiste()
        {
            bool existe = false;
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno WHERE CPFAluno='" + cpf + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
                if(resultado.Read())
                {
                    existe = true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return existe;
        }

        public MySqlDataReader consultarAluno()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno WHERE CPFAluno='" + cpf + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }

        public bool excluirAluno()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Aluno set ativo = 0 where CPFAluno = '" + cpf + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

                DAO_Conexao.con.Close();
            }
            return exc;
        }

        public bool atualizarAluno()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update Estudio_Aluno set nomeAluno = '" + nome + "', ruaAluno = '" + rua + "', numeroAluno = '" + numero + "', bairroAluno = '" + bairro + "', complementoAluno ='" + complemento + "',CEPAluno='" + cep + "', cidadeAluno='" + cidade + "', estadoAluno='" + estado + "', telefoneAluno = '" + telefone+ "', emailAluno = '" + email + "' where CPFAluno = '" + cpf + "'", DAO_Conexao.con);
                atualiza.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }

        public string getCpf()
        {
            return cpf;
        }

        public void setCpf(String cpf)
        {
            this.cpf = cpf;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public string getRua()
        {
            return rua;
        }

        public void setRua(String rua)
        {
            this.rua = rua;
        }

        public string getNumero()
        {
            return numero;
        }

        public void setNumero(String numero)
        {
            this.numero = numero;
        }

        public string getBairro()
        {
            return bairro;
        }

        public void setBairro(String bairro)
        {
            this.bairro = bairro;
        }

        public string getComplemento()
        {
            return complemento;
        }

        public void setComplemento(String complmento)
        {
            this.complemento = complmento;
        }

        public string getCep()
        {
            return cep;
        }

        public void setCep(String cep)
        {
            this.cep = cep;
        }

        public string getCidade()
        {
            return cidade;
        }

        public void setCidade(String cidade)
        {
            this.cidade = cidade;
        }

        public string getEstado()
        {
            return estado;
        }

        public void setEstado(String estado)
        {
            this.estado = estado;
        }

        public string getTelefone()
        {
            return telefone;
        }

        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public byte[] getFoto()
        {
            return foto;
        }

        public void setFoto(byte[] foto)
        {
            this.foto = foto;
        }

        public bool isAtivo()
        {
            return ativo;
        }

        public void setAtivo(bool ativo)
        {
            this.ativo = ativo;
        }
    }
}
