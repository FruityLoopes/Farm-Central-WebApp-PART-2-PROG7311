using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace Database_API
{
    public class DbLink
    {
        public string connStr = "Data Source = st10085138server.database.windows.net; Initial Catalog = ProgPart2; user = cka00; password = Password01"; //connect string for database

        public SqlCommand dbComm;
        public SqlDataAdapter dbAdapter;
        public SqlDataReader dataReader;
        public DataTable dt;
    }
}
