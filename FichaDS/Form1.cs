using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FichaDS.Infra.Data;
using System.Media;

namespace FichaDS
{
    public partial class Form1 : Form
    {
        private bool reproduzindo = false;
        private SoundPlayer player = new SoundPlayer("sound/SoulOfCinder.wav");
        static Connection con = new Connection();
        public Form1()
        {
            InitializeComponent();
            
            player.Load();
            player.PlayLooping();
            reproduzindo = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridCadastrados();
        }
        public void GridCadastrados()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT Id,NomeHeroi,NomeJogador,Classe,Nivel FROM Ficha", con.conectar());
                SqlDataAdapter st = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                st.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (SqlException) 
            {
                MessageBox.Show("O seu IP não esta cadastrado no servidor!\nAlgumas funcionalidades podem não estar disponíveis.","ALERTA");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Digite o id abaixo!");
                return;
            }
            try
            {
                int id = GetTxtID();
                bool checkId = CheckId(id);
                if (checkId == false)
                {
                    PasswordRequired pass = new PasswordRequired(id);
                    pass.Show();
                }
                else MessageBox.Show("O id não existe");
            }
            catch (FormatException)
            {
                MessageBox.Show("O id deve ser somente numero.", "ERRO");
                txtId.Text = "";
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Digite o id abaixo!");
                return;
            }
            try
            {
                int id = GetTxtID();
                bool checkId = CheckId(id);
                if (checkId == false)
                {
                    // Aqui vai a implementação da ficha
                    FichaPainel painel = new FichaPainel(id);
                    painel.Show();
                }
                else MessageBox.Show("O id não existe");
            }
            catch (FormatException) 
            {
                MessageBox.Show("O id deve ser somente numero.","ERRO");
                txtId.Text = "";
                return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CadastroPainel cad = new CadastroPainel();
            cad.Show();
        }

        private void btnAttGrid_Click(object sender, EventArgs e)
        {
            GridCadastrados();
        }
        public int GetTxtID() 
        {
                int id = Convert.ToInt32(txtId.Text);
                return id;
        }
        private bool CheckId(int id)
        {
            string comando = $"Select Id from Ficha WHERE Id = {id}";
            int idEncontrado = -1;
            SqlCommand verificar = new SqlCommand(comando, con.conectar());
            con.Open();
            idEncontrado = Convert.ToInt32(verificar.ExecuteScalar());
            if (idEncontrado == 0)
            {
                return true;
            }
            else return false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDiceRoller_Click(object sender, EventArgs e)
        {
            DiceRoller dice = new DiceRoller();
            dice.Show();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            if (reproduzindo == true)
            {
                player.Stop();
                reproduzindo = false;
                labelPausado.Visible = true;
                return;
            }else if (reproduzindo == false) 
            {
                player.PlayLooping();
                reproduzindo = true;
                labelPausado.Visible = false;
                return;
            }
            
        }
    }
}
