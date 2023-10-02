using Newtonsoft.Json;
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
        public string GetUsuario(int idusuario)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            using (SqlConnection lSQLConn = new SqlConnection(connStr))
            {
                string lsResponse = "";
                
                DataTable lDS = new DataTable();

                //...Execution section

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
                     return   ConvertDataTableToJson( lDS);

                    }
                }
                               
            }
            
        }
        public string ConvertDataTableToJson(DataTable dataTable)
        {
            // Convierte el DataTable a una lista de diccionarios
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();

            foreach (DataRow row in dataTable.Rows)
            {
                var dict = new Dictionary<string, object>();
                foreach (DataColumn col in dataTable.Columns)
                {
                    dict[col.ColumnName] = row[col];
                }
                list.Add(dict);
            }

            // Serializa la lista de diccionarios a JSON
            string json = JsonConvert.SerializeObject(list, Formatting.Indented);

            return json;
        }
        public string CreateUsuario(string nombre,string sexo,DateTime fechanacimiento)
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                using (SqlConnection lSQLConn = new SqlConnection(connStr))
                {
                    string lsResponse = "";

                    DataTable lDS = new DataTable();

                    //...Execution section

                    lSQLConn.Open();
                    //The CommandType must be StoredProcedure if we are using an ExecuteScalar
                    using (SqlCommand lSQLCmd = new SqlCommand())
                    {
                        lSQLCmd.Connection = lSQLConn;
                        lSQLCmd.CommandType = CommandType.StoredProcedure;
                        lSQLCmd.CommandText = "spInsertUsuario";
                        lSQLCmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                        lSQLCmd.Parameters.Add(new SqlParameter("@sexo", sexo));

                        lSQLCmd.Parameters.Add(new SqlParameter("@fechanacimiento", fechanacimiento));

                        using (SqlDataAdapter lDA = new SqlDataAdapter(lSQLCmd))
                        {

                            //Fill the DataAdapter with a SelectCommand
                            lDA.Fill(lDS);
                            return ConvertDataTableToJson(lDS);

                        }
                    }

                }
                return "Se guardo correctamente";
            }
            catch (Exception ex)
            {

                return "Error al guardar"+ex.Message;
            }
            
        }
        public string GetAllUsuarios()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            using (SqlConnection lSQLConn = new SqlConnection(connStr))
            {
                string lsResponse = "";

                DataTable lDS = new DataTable();

                //...Execution section

                lSQLConn.Open();
                //The CommandType must be StoredProcedure if we are using an ExecuteScalar
                using (SqlCommand lSQLCmd = new SqlCommand())
                {
                    lSQLCmd.Connection = lSQLConn;
                    lSQLCmd.CommandType = CommandType.StoredProcedure;
                    lSQLCmd.CommandText = "spSelectListadoUsuarios";
                   

                    using (SqlDataAdapter lDA = new SqlDataAdapter(lSQLCmd))
                    {

                        //Fill the DataAdapter with a SelectCommand
                        lDA.Fill(lDS);
                        return ConvertDataTableToJson(lDS);

                    }
                }

            }

        }
    }
}
