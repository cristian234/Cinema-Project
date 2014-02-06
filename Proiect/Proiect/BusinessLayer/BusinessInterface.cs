using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



namespace Proiect
{
    interface BusinessInterface
    {
        // functii 
        int CheckLoginBus(string user, string pass);
      
 
    }
}
