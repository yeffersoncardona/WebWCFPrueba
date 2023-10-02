using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfPrueba
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBusiness
    {

        [OperationContract]
        String GetUsuario(int value);
        [OperationContract]
        string CreateUsuario(string nombre, string sexo, DateTime fechanacimiento);
        [OperationContract]
        string GetAllUsuarios();
        [OperationContract]
        string UpdateUsuario(int id, string nombre, string sexo, DateTime fechanacimiento);
        [OperationContract]
        string DeleteUsuario(int idusuario);
    }

}
