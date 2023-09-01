using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ONT3010_Demo_1.Models;
using Microsoft.Data.SqlClient;

namespace ONT3010_Demo_1.Data
{
    public class DB
    {
        SqlConnection sqlConnection = new SqlConnection("Server=sict-sql.mandela.ac.za;Database=GRP-03-35-ItJustWorksDB;User Id=GRP-03-35;Password=grp-03-35-soit2023#;Trusted_Connection=False;");
        
        public int Login_Check(LoginCheck login) 
        {
            SqlCommand command = new SqlCommand("sp_Login", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Email", login.Email);
            command.Parameters.AddWithValue("@Password", login.Password);
            SqlParameter oblogin = new SqlParameter();
            oblogin.ParameterName = "@IsValid";
            oblogin.SqlDbType = SqlDbType.Bit;
            oblogin.Direction = ParameterDirection.Output;
            command.Parameters.Add(oblogin);
            sqlConnection.Open();
            command.ExecuteNonQuery();
            int result = Convert.ToInt32(oblogin.Value);
            sqlConnection.Close();
            return result;
        }
    }
}
