using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;




namespace Proiect

{
    class UserDAO:DataLayerInterface
    {
        private SqlConnection connection1;
        private dbConnection conn;

        /// <constructor>
        /// Constructor UserDAO
        /// </constructor>
        public UserDAO()
        {
            conn = new dbConnection();
            connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
           
        }


       

        public DataTable checkLoginData(string user, string pass)
        {

            return conn.executeSelectQuery("SELECT Username,Password FROM dbo.USERS");// IMI RETURNEAZA IN BUSINESS 

        }

        public DataTable FilmeZi(int zi)
        {
            string querry = string.Format("SELECT NumeFilm, DurataFilm, DataLansare, InformatiiFilm, Pret, DataInceperii, DataTerminarii, Zi FROM dbo.ListInfoFilmZi WHERE (Zi = @Zi)");
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Zi", SqlDbType.Int);
            param[0].Value = zi;
            return conn.executeSelectQuery(querry, param);
        }

     
    }
}
