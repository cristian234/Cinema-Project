﻿using System;
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

     
    }
}
