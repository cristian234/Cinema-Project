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
    class UserBUS:BusinessInterface
    {
        DataLayerInterface _userDAO = new UserDAO();

        /// <constructor>
        /// Constructor UserBUS
        /// </constructor>
        public UserBUS()
        {
            _userDAO = new UserDAO();
        }

        public int CheckLoginBus(string user, string pass)
        {
            DataTable dt = new DataTable();

            dt = _userDAO.checkLoginData(user, pass);
            foreach (DataRow dr in dt.Rows)
            {
                if (string.Compare(dr["username"].ToString(), user) == 0 && string.Compare(dr["password"].ToString(), pass) == 0)
                {
                    return 1;
                }


            }

            return 0;
        }

      

    }
}
