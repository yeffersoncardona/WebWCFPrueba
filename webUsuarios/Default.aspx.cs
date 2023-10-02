using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webUsuarios.BusinessServiceReference;

namespace webUsuarios
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            


        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string Sexo = ddlSexo.SelectedValue;

            DateTime fechanacimiento = Calendar1.SelectedDate;

            using (BusinessClient reference = new BusinessClient())
            {
               var resultado = reference.CreateUsuario(nombre, Sexo, fechanacimiento);
                lblmensaje.Text = resultado;
            }

            
           

            //    //DataTable dtusuario = (DataTable)JsonConvert.DeserializeObject(consulta, typeof(DataTable));
            //    //GridView1.DataSource = dtusuario;
            //    GridView1.DataSource = usuario;
            //    GridView1.DataBind();
            //    GridView1.Visible = true;
            //    reference.Close();
            //}

            //GridView1.Visible = true;
        }
    }
}