using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Library_4;

namespace KonchaVadym_SoapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        int IService1.F4(int x, int y)
        {
            return Library_4.KI3_Class_4.F4(x,y);
        }

        DataTable IService1.GetAllElements()
        {
            DataTable T;
            string DB = @"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=ChemistryStaff; Integrated Security=True";
            string Query = "SELECT Mt.ID, Name, Formular, St.Class, MolWeight, State FROM Compounds as Mt INNER JOIN Classes as St ON Mt.Class = St.ID";
            using (SqlConnection Conn = new SqlConnection(DB))
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                Conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(Query, DB);
                da.Fill(ds); //filling info in ds 
                T = ds.Tables[0];
                return T;
            }
        }

        DataTable IService1.GetElementByID(int ID)
        {
            DataTable T;
            string DB = @"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=ChemistryStaff; Integrated Security=True";
            string Query = $"SELECT * from Compounds WHERE ID = {ID}";
            using (SqlConnection Conn = new SqlConnection(DB))
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                Conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(Query, DB);
                da.Fill(ds); //filling info in ds 
                T = ds.Tables[0];
                return T;
            }
        }
    }
}
