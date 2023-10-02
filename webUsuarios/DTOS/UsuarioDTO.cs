using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webUsuarios.DTOS
{
    public class UsuarioDTO
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string sexo { get; set; }
        public DateTime fechanacimiento { get; set; }
    }
}