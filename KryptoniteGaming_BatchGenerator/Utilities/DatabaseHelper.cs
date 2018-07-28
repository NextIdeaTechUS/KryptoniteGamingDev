using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KryptoniteGaming_BatchGenerator.Utilities
{
    public static class DatabaseHelper
    {


        public static String GetConnectionString()
        {
            return Properties.Settings.Default.ConnectionString;
        }

        public static DataSet RunQuery(String QueryString)
        {
            DataSet dsReturn = new DataSet();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(QueryString, GetConnectionString());
            sqlAdapter.SelectCommand.CommandTimeout = 60000;
            sqlAdapter.Fill(dsReturn);
            return dsReturn;
        }

        public static void RunCommand(String CommandString)
        {
            SqlConnection sqlConnection = new SqlConnection(GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public static void InsertNewBatch(String Outcome, Decimal Amount, Int32 Pos1, Int32 Pos2, Int32 Pos3, Int32 GameId)
        {
            String strSQL = "insert into [Batch] (Outcome, Amount, Pos1, Pos2, Pos3, GameId, CreateDate, Processed) values ('" + Outcome + "', " + Amount.ToString() + ", " + Pos1.ToString() + ", " + Pos2.ToString() + ", " + Pos3.ToString() + ", " + GameId.ToString() + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', 0)";
            RunCommand(strSQL);
        }

        public static void MarkAllProcessed()
        {
            RunCommand("update [Batch] set Processed = 1");
        }
    }
}
