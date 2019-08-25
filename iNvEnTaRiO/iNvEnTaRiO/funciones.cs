using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iNvEnTaRiO
{
    class funciones : Form
    {
      
        //public static DataSet Ejecutar(string ConexionBBS)
        //{
        //    SqlConnection Conetion = new SqlConnection("Data Source=ITACKI\\SQLEXPRESS;Initial Catalog=NomiPro;Integrated Security=True");
        //    DataSet ds = new DataSet();
        //    SqlDataAdapter dp = new SqlDataAdapter(ConexionBBS, Conetion);
        //    dp.Fill(ds);
        //    return ds;
        //}
        public  void Cerrar()
        {
            Application.Exit();            
        }
    }

}
