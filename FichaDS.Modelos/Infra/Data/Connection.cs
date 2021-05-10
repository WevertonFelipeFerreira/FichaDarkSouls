using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FichaDS.Infra.Data
{
  public class Connection
    {
      static string connection = @"Data Source=meuservidorpessoal.database.windows.net;Initial Catalog=FichaDarkSouls;User ID=WevertonFerreira;Password=@Meubancodedados321;Connect Timeout=200;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
      readonly SqlConnection con = new SqlConnection(connection);
        public SqlConnection conectar() 
        {
            return con;
        }
        public SqlConnection Open() 
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
                return con;
            }
            else return con;

        }
        public SqlConnection Close()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
                return con;
            }
            else return con;
        }
    }
}
