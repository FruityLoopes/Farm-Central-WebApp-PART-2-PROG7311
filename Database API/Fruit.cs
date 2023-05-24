using Microsoft.Data.SqlClient;
using System.Data;

namespace Database_API
{
    public class Fruit : IProduct
    {
        string[] IProduct.GetProduct()
        {
            DbLink db = new DbLink();

            SqlConnection dbConn = new SqlConnection(db.connStr);
            dbConn.Open();

            string sql = "spGetFruit";
            db.dbComm = new SqlCommand(sql, dbConn);
            db.dbComm.CommandType = CommandType.StoredProcedure;

            db.dataReader = db.dbComm.ExecuteReader();
            int i = 0;
            List<string> fruits = new List<string>();
            while (db.dataReader.Read())
            {
                fruits.Add(db.dataReader.GetValue(0).ToString());
                

            }

            string[] fruit = fruits.ToArray();

            db.dataReader.Close();
            int x = db.dbComm.ExecuteNonQuery();


            dbConn.Close();
            return fruit;
        }
    }
}
