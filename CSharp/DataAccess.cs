using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SqlConnection sqlcon;
            SqlCommand sqlCmd;
            SqlDataAdapter da;
            SqlDataReader dr;
           
            string conString, qryString;

            conString = "data source=BLT10128\\SQLEXPRESS2014;Initial Catalog=Northwind; Integrated Security=True;";
            sqlcon = new SqlConnection(conString);

            

            qryString = "select ProductName from Products";
            sqlCmd = new SqlCommand(qryString, sqlcon);
            sqlcon.Open();
            dr = sqlCmd.ExecuteReader();
            da = new SqlDataAdapter();
            while (dr.Read())
            {
                Console.WriteLine("ProduuctName:{0}", dr["ProductName"]);

            }

            dr.Close();
            sqlcon.Close();
        }
    }
}
