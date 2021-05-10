using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FichaDS.Infra.Data;

namespace FichaDS
{
    public partial class CadastroPainel : Form
    {
        Connection con = new Connection();
        static private string NomeDoJogador { get; set; }
        static private string NomeDoHeroi { get; set; }
        static private string Classe { get; set; }
        static private int Nivel { get; set; }
        static private int Vigor { get; set; }
        static private int Conhecimento { get; set; }
        static private int Fortitude { get; set; }
        static private int Vitalidade { get; set; }
        static private int Forca { get; set; }
        static private int Destreza { get; set; }
        static private int Inteligencia { get; set; }
        static private int Fe { get; set; }
        static private int Sorte { get; set; }
        static private int IdSepulcro { get; set; }

        public CadastroPainel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaStatus();
        }

        private void txtConhecimento_TextChanged(object sender, EventArgs e)
        {

        }
        private string GetComboClasseString()
        {
            string option = Convert.ToString(comboClasse.SelectedItem);
            return option;
        }
        private void AtualizaStatus()
        {
            string option = GetComboClasseString();
            switch (option)
            {
                case "Cavaleiro":
                    Nivel = 9;
                    Vigor = 12;
                    Conhecimento = 10;
                    Fortitude = 11;
                    Vitalidade = 15;
                    Forca = 13;
                    Destreza = 12;
                    Inteligencia = 9;
                    Fe = 9;
                    Sorte = 7;
                    break;
                case "Mercenário":
                    Nivel = 8;
                    Vigor = 11;
                    Conhecimento = 12;
                    Fortitude = 11;
                    Vitalidade = 10;
                    Forca = 10;
                    Destreza = 16;
                    Inteligencia = 10;
                    Fe = 8;
                    Sorte = 9;
                    break;
                case "Guerreiro":
                    Nivel = 7;
                    Vigor = 14;
                    Conhecimento = 6;
                    Fortitude = 12;
                    Vitalidade = 11;
                    Forca = 16;
                    Destreza = 9;
                    Inteligencia = 8;
                    Fe = 9;
                    Sorte = 11;
                    break;
                case "Arauto":
                    Nivel = 9;
                    Vigor = 12;
                    Conhecimento = 10;
                    Fortitude = 9;
                    Vitalidade = 12;
                    Forca = 12;
                    Destreza = 11;
                    Inteligencia = 8;
                    Fe = 13;
                    Sorte = 11;
                    break;
                case "Ladrão":
                    Nivel = 5;
                    Vigor = 10;
                    Conhecimento = 11;
                    Fortitude = 10;
                    Vitalidade = 9;
                    Forca = 9;
                    Destreza = 13;
                    Inteligencia = 10;
                    Fe = 8;
                    Sorte = 14;
                    break;
                case "Assasino":
                    Nivel = 10;
                    Vigor = 10;
                    Conhecimento = 14;
                    Fortitude = 11;
                    Vitalidade = 10;
                    Forca = 10;
                    Destreza = 14;
                    Inteligencia = 11;
                    Fe = 9;
                    Sorte = 10;
                    break;
                case "Feiticeiro":
                    Nivel = 6;
                    Vigor = 9;
                    Conhecimento = 16;
                    Fortitude = 9;
                    Vitalidade = 7;
                    Forca = 7;
                    Destreza = 12;
                    Inteligencia = 16;
                    Fe = 7;
                    Sorte = 12;
                    break;
                case "Piromante":
                    Nivel = 8;
                    Vigor = 11;
                    Conhecimento = 12;
                    Fortitude = 10;
                    Vitalidade = 8;
                    Forca = 12;
                    Destreza = 9;
                    Inteligencia = 14;
                    Fe = 14;
                    Sorte = 7;
                    break;
                case "Clérigo":
                    Nivel = 7;
                    Vigor = 10;
                    Conhecimento = 14;
                    Fortitude = 9;
                    Vitalidade = 7;
                    Forca = 12;
                    Destreza = 8;
                    Inteligencia = 7;
                    Fe = 16;
                    Sorte = 13;
                    break;
                case "Despojado":
                    Nivel = 1;
                    Vigor = 10;
                    Conhecimento = 10;
                    Fortitude = 10;
                    Vitalidade = 10;
                    Forca = 10;
                    Destreza = 10;
                    Inteligencia = 10;
                    Fe = 10;
                    Sorte = 10;
                    break;
            }

            txtNivel.Text = Convert.ToString(Nivel);
            txtVigor.Text = Convert.ToString(Vigor);
            txtConhecimento.Text = Convert.ToString(Conhecimento);
            txtFortitude.Text = Convert.ToString(Fortitude);
            txtVitalidade.Text = Convert.ToString(Vitalidade);
            txtForca.Text = Convert.ToString(Forca);
            txtDestreza.Text = Convert.ToString(Destreza);
            txtInteligencia.Text = Convert.ToString(Inteligencia);
            txtFe.Text = Convert.ToString(Fe);
            txtSorte.Text = Convert.ToString(Sorte);

            string desc = GetClasseDescricao(option);
            txtDescricaoClasse.Text = desc;
        }

        private string GetClasseDescricao(string classeEscolhida)
        {
            con.Open();
            string pesquisaDescricao = $"SELECT * FROM Classes WHERE Classe = '{classeEscolhida}'";
            SqlCommand Command = new SqlCommand(pesquisaDescricao, con.conectar());
            SqlDataReader leitor = Command.ExecuteReader();
            string Descricao = "";

            while (leitor.Read())
            {
                Descricao = leitor["Descricao"].ToString();
            }
            con.Close();
            return Descricao;
        }

        private void txtTeste_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            bool NomeHeroiEVazio = CheckNomeHeroi();
            bool NomeJogadorEVazio = CheckNomeJogador();
            bool checkClasse = CheckClass();
            if (NomeJogadorEVazio == true)
            {
                MessageBox.Show("Insira um nome para o jogador.", "Aviso!");
                return;
            }
            else if (NomeHeroiEVazio == true) 
            {
                MessageBox.Show("Insira um nome para o heroi.", "Aviso!");
                return;
            }else if (checkClasse == true)
            {
                NomeDoHeroi = txtHeroi.Text;
                NomeDoJogador = txtJogador.Text;
                Classe = GetComboClasseString();
                string nomeSepulcro = GetItemNome();
                IdSepulcro = GetIdSepulcro(nomeSepulcro);
                string comando = $"insert into ficha values ('{NomeDoJogador}','{NomeDoHeroi}','{Classe}',{Nivel},{Vigor},{Conhecimento}," +
                    $"{Fortitude},{Vitalidade},{Forca},{Destreza},{Inteligencia},{Fe},{Sorte},{IdSepulcro},0,0,0,0,0,0,0,0,100,100,3,0,0,0,0,0)";
                SqlCommand cadastrar = new SqlCommand(comando, con.conectar());
                con.Open();
                cadastrar.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cadastrado");
                this.Close();
                GC.Collect();
            }
            else
            {
                MessageBox.Show($"Insira uma classe valida!");
                ZerarCampos();
                return;
            }

        }

        private int GetIdSepulcro(string nomeItem)
        {
            con.Open();
            string pesquisaDescricao = $"SELECT * FROM Item_Sepulcro WHERE Item_Sepulcro = '{nomeItem}'";
            SqlCommand Command = new SqlCommand(pesquisaDescricao, con.conectar());
            SqlDataReader leitor = Command.ExecuteReader();
            string Descricao = "";

            while (leitor.Read())
            {
                Descricao = leitor["Id"].ToString();
            }
            con.Close();
            return Convert.ToInt32(Descricao);
        }

        private bool CheckNomeHeroi()
        {
            if (txtHeroi.Text == "")
            {
                return true;
            }
            else return false;
        }

        private bool CheckNomeJogador()
        {
            if (txtJogador.Text == "")
            {
                return true;
            }
            else return false;
        }

        private bool CheckClass()
        {
            if (comboClasse.Text == "Cavaleiro" || comboClasse.Text == "Mercenário" || comboClasse.Text == "Guerreiro" || comboClasse.Text == "Arauto" ||
                  comboClasse.Text == "Ladrão" || comboClasse.Text == "Assasino" || comboClasse.Text == "Feiticeiro" || comboClasse.Text == "Piromante" ||
                  comboClasse.Text == "Clérigo" || comboClasse.Text == "Despojado")
            {
                return true;
            }
            return false;
        }
        private void ZerarCampos()
        {
            txtNivel.Text = "";
            txtVigor.Text = "";
            txtConhecimento.Text = "";
            txtFortitude.Text = "";
            txtVitalidade.Text = "";
            txtForca.Text = "";
            txtDestreza.Text = "";
            txtInteligencia.Text = "";
            txtFe.Text = "";
            txtSorte.Text = "";
            txtDescricaoClasse.Text = "";
            txtDescricaoItem.Text = "";
            Nivel = 0;
            Vigor = 0;
            Conhecimento = 0;
            Fortitude = 0;
            Vitalidade = 0;
            Forca = 0;
            Destreza = 0;
            Inteligencia = 0;
            Fe = 0;
            Sorte = 0;
        }

        private void txtDescricaoItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboItemSepulcro_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaDescricaoItem();
        }

        private void AtualizaDescricaoItem()
        {
            string nome = GetItemNome();

            string desc = GetItemDescricao(nome);
            txtDescricaoItem.Text = desc;
        }

        private string GetItemNome()
        {
            string desc = Convert.ToString(comboItemSepulcro.Text);

            return desc;
        }
        public string GetItemDescricao(string nomeItem)
        {
            con.Open();
            string pesquisaDescricao = $"SELECT * FROM Item_Sepulcro WHERE Item_Sepulcro = '{nomeItem}'";
            SqlCommand Command = new SqlCommand(pesquisaDescricao, con.conectar());
            SqlDataReader leitor = Command.ExecuteReader();
            string Descricao = "";

            while (leitor.Read())
            {
                Descricao = leitor["Descricao"].ToString();
            }
            con.Close();
            return Descricao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
        }

        private void CadastroPainel_Load(object sender, EventArgs e)
        {
        }
    }

}
