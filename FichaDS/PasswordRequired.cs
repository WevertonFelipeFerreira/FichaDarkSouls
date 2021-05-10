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
using FichaDS.Modelos.Infra.Data;
using FichaDS.Infra.Data;

namespace FichaDS
{
    public partial class PasswordRequired : Form
    {
        static Connection con = new Connection();
        static MasterPassword master = new MasterPassword();
        static int Id;
        public PasswordRequired(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == master.Pass())
            {
                DialogResult dialogResult = MessageBox.Show($"Você tem certeza? A ficha de id: {Id} sera excluida permanentemente,", "Confirmação!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string comand = $"delete from Ficha where id = {Id}";
                    SqlCommand com = new SqlCommand(comand, con.conectar());
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("A ficha foi excluida.");
                    this.Close();
                    GC.Collect();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                    GC.Collect();
                }
            }
            else MessageBox.Show("A senha esta incorreta.");
            txtPassword.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordRequired_Load(object sender, EventArgs e)
        {

        }
    }
}
