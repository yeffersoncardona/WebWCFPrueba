using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webUsuarios.BusinessServiceReference;

namespace webUsuarios
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (BusinessClient reference = new BusinessClient())
            {
                var consulta = reference.GetUsuario(1);

                reference.Close();
            }

        }
    }
}