﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proiect
{
    interface DataLayerInterface
    {
       

  
        DataTable checkLoginData(string user, string pass);
        DataTable FilmeZi(int zi);
    
    }
}
