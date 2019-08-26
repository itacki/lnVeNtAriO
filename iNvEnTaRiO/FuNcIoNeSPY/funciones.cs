using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FuNcIoNeSPY
{
    public class funciones
    {
       public static DataTable ejecutable(string comando)
        {
          
            string ruta = @"Data Source=itacki\sqlexpress;Initial Catalog=InVeNtArIo;Integrated Security=True";
            SqlConnection connection = new SqlConnection(ruta);
            connection.Open();
            string query = comando;
            SqlCommand command = new SqlCommand(query,connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
            
        }


    }
}
