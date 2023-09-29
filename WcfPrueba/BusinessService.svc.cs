using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfPrueba
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IBusiness
    {
        public DataTable GetUsuario(int idusuario)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            using (SqlConnection lSQLConn = new SqlConnection(connStr))
            {
                string lsResponse = "";
               // string connStr = "";


                //SqlConnection lSQLConn = null;
                //Declare a DataAdapter and a DataSet
                
                DataTable lDS = new DataTable();

                //...Execution section

                // create and open a connection object
               // lSQLConn = new SqlConnection(connStr);
                lSQLConn.Open();
                //The CommandType must be StoredProcedure if we are using an ExecuteScalar
                using (SqlCommand lSQLCmd = new SqlCommand())
                {
                    lSQLCmd.Connection = lSQLConn;
                    lSQLCmd.CommandType = CommandType.StoredProcedure;
                    lSQLCmd.CommandText = "spSelectUsuario";
                    lSQLCmd.Parameters.Add(new SqlParameter("@id", idusuario));
                    
                    using (SqlDataAdapter lDA = new SqlDataAdapter(lSQLCmd))
                    {

                        //Fill the DataAdapter with a SelectCommand
                        lDA.Fill(lDS);
                        return lDS;

                    }
                }
                


               
            }
            
            
           
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
