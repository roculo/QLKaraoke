using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKaraoke
{
    class DatabaseConnect
    {
       public static SqlConnection myConn = new SqlConnection("Server=DESKTOP-UNV9GNN\\SQLEXPRESS;Initial Catalog=QLKaraoke_DB;Integrated Security=True");
       public static QLKaraoke_DBEntities db = new QLKaraoke_DBEntities();

    }
}
