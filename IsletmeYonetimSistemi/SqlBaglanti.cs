using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GöreselProgramlama_Proje
{
    internal class sqlbaglanti
    {
        private string baglantimetni = "server=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\LENOVO\\DESKTOP\\MASAÜSTÜ UYGULAMASI\\IsletmeDB.mdf;Integrated Security=SSPI";
        public SqlConnection baglantiOn()
        {
            try
            {
                SqlConnection con = new SqlConnection(baglantimetni);
                con.Open();
                return con;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void baglantiOff(SqlConnection con)
        {
            try
            {
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
