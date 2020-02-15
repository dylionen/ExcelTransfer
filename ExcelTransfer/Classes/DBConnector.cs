using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTransfer.Classes
{
 
    class DBConnector
    {
        private String connectionString;
        private SqlConnection cnn;
        private bool isConnected;

        public DBConnector()
        {
            isConnected = false;
            generateConnectionString();
            ConnectToDB();
        }

        private void generateConnectionString()
        {
            connectionString = @"Data Source=ADAMPC\SQL;Initial Catalog=DemoDB;User ID=sa;Password=adam13";
        }

        public void ConnectToDB()
        {
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
            }catch(SqlException e)
            {
                isConnected = false;
                return;
            }
            isConnected = true;
        }



        public bool getIsConnected() {
            return isConnected; 
        }



        public bool isTableExists(String name)
        {
            SqlCommand command = cnn.CreateCommand();
            command.CommandText = String.Format(@"IF(EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' " +
                " AND TABLE_NAME = '{0}')) BEGIN select 1 as 'Column' END ELSE select 0 as 'Column'", name); ;


            StringBuilder stringBuilder = new StringBuilder();

            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                //stringBuilder.Append(ReadSingleRow((IDataRecord)sqlDataReader));
                stringBuilder.Append(sqlDataReader[0]);
                if (sqlDataReader[0].ToString().Equals("1"))
                {
                    sqlDataReader.Close();
                    return true;
                }
            } 

            sqlDataReader.Close();
            //return stringBuilder.ToString();
            return false;
        }

        private String ReadSingleRow(IDataRecord record)
        {
            return String.Format("{0}\n", record[0]);
        }







    }
}
