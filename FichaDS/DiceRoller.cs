using FichaDS.Infra.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FichaDS.Modelos.Classes.Dado;

namespace FichaDS
{
    public partial class DiceRoller : Form
    {
        ToolTip tooltip1 = new ToolTip();
        Dado dado = new Dado();
        Connection con = new Connection();

        static int Tentativas;
        static int Id;
        static int Dados;
        static int Lados;

        public DiceRoller()
        {
            InitializeComponent();
            HistoricoAtt();
            txtRolagem.ScrollBars = ScrollBars.Vertical;
            Tentativas = 0;
            txtTentativas.Text = Convert.ToString(Tentativas);
            tooltip1.SetToolTip(this.btnLimpar, "Limpa os campos");
            tooltip1.SetToolTip(this.button1, "Checa Id e numero de tentativas");
            tooltip1.SetToolTip(this.btnAtualiza, "Atualiza ultima rolagem!");
            tooltip1.SetToolTip(this.btnRolar, "Rola o(s) dado(s)!");
        }

        private void btnRolar_Click(object sender, EventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(txtId.Text);
                Dados = Convert.ToInt32(txtDados.Text);
                Lados = Convert.ToInt32(txtLados.Text)+1;
                bool checkID = CheckID(Id);
                if (checkID == false)
                {
                    MessageBox.Show($"O id {Id} não existe!", "NOT FOUND!");
                    txtId.Text = "";
                    return;
                }
                if (Dados < 1)
                {
                    MessageBox.Show("Deve ter no mínimo 1 dado", "ERRO!");
                    return;
                }
                if (Lados < 3)
                {
                    MessageBox.Show("Um dado deve ter no mínimo 3 lados", "ERRO!");
                    return;
                }
                int id = Convert.ToInt32(txtId.Text);
                con.Open();
                string pesquisaDescricao = $"SELECT * FROM Ficha WHERE Id = '{id}'";
                SqlCommand Command = new SqlCommand(pesquisaDescricao, con.conectar());
                SqlDataReader leitor = Command.ExecuteReader();
                string tenta = "";

                while (leitor.Read())
                {
                    tenta = leitor["Tentativas"].ToString();
                }
                int tentativa = Convert.ToInt32(tenta);
                Tentativas = tentativa;
                txtTentativas.Text = Convert.ToString(Tentativas);
                con.Close();

                int soma = 0;
                txtRolagem.Clear();
                for (int i = 1; i <= Dados; i++)
                {
                    if (Tentativas == 0)
                    {
                        MessageBox.Show("Você não possui tentativas!");
                        return;
                    }
                    int rolagem = dado.Rolar(Lados);
                    soma += rolagem;
                    txtRolagem.Text += $"- O {i}° dado rolou {rolagem}{Environment.NewLine}";
                }
                Tentativas -= 1;
                txtTentativas.Text = Convert.ToString(Tentativas);
                txtTotal.Text = Convert.ToString(soma);
                string nomeJogador = GetNomeJogador(Id);
                SqlCommand com = new SqlCommand($"UPDATE Ficha SET Tentativas = {Tentativas} WHERE Id = {Id}\n" +
                    $"UPDATE Roll SET dados ={Dados},lados = {Lados}, Nome = '{nomeJogador}', soma = {soma} WHERE Id = 1", con.conectar());
                con.Open();
                com.ExecuteNonQuery();
                con.Close();

                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Valores devem ser somente numeros inteiros!", "ERRO");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Id muito grande!", "ERRO");
                return;
            }
            catch (SqlException) 
            {
                MessageBox.Show("Erro de banco de dados!", "ERRO");
                return;
            }
        }
        private bool CheckID(int id) 
        {
            string comando = $"Select Id from Ficha WHERE Id = {id}";
            int idEncontrado = -1;
            SqlCommand verificar = new SqlCommand(comando, con.conectar());
            con.Open();
            idEncontrado = Convert.ToInt32(verificar.ExecuteScalar());
            if (idEncontrado == 0)
            {
                return false;
            }
            else return true;
        }

        private void txtRolagem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDados.Clear();
            txtLados.Clear();
            txtRolagem.Clear();
            txtTotal.Clear();
            txtTentativas.Text = Convert.ToString(Tentativas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                con.Open();
                string pesquisaDescricao = $"SELECT * FROM Ficha WHERE Id = '{id}'";
                SqlCommand Command = new SqlCommand(pesquisaDescricao, con.conectar());
                SqlDataReader leitor = Command.ExecuteReader();
                string tenta = "";

                while (leitor.Read())
                {
                    tenta = leitor["Tentativas"].ToString();
                }
                int tentativa = Convert.ToInt32(tenta);
                Tentativas = tentativa;
                txtTentativas.Text = Convert.ToString(Tentativas);
                con.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("O Id não existe ou não existe!");
                con.Close();
                txtId.Clear();
                return;
            }
            catch (OverflowException) 
            {
                MessageBox.Show("O Id é muito grande!");
                con.Close();
                txtId.Clear();
                return;
            }
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            HistoricoAtt();
        }
        private string GetNomeJogador(int id) 
        {
            con.Open();
            string pesquisaDescricao = $"SELECT * FROM Ficha WHERE Id = '{id}'";
            SqlCommand Command = new SqlCommand(pesquisaDescricao, con.conectar());
            SqlDataReader leitor = Command.ExecuteReader();
            string nome = "";

            while (leitor.Read())
            {
                nome = leitor["NomeJogador"].ToString();
            }
            con.Close();
            return nome;
        }
        public void HistoricoAtt() 
        {
            string pesquisaDados = $"SELECT * FROM Roll WHERE Id = '1'";
            SqlCommand Command = new SqlCommand(pesquisaDados, con.conectar());
            con.Open();
            SqlDataReader leitor = Command.ExecuteReader();
            string nome = "";
            string dados = "";
            string lados = "";
            string soma = "";

            while (leitor.Read())
            {
                nome = leitor["Nome"].ToString();
                dados = leitor["dados"].ToString();
                lados = leitor["lados"].ToString();
                soma = leitor["soma"].ToString();
            }
            int ladosConvertidos = Convert.ToInt32(lados);
            con.Close();
            txtHistorico.Text = $"O jogador {nome} rolou {dados} D{ladosConvertidos-1} com o valor total de {soma}";
        }

        private void txtHistorico_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
