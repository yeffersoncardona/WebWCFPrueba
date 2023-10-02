using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webUsuarios.BusinessServiceReference;
using webUsuarios.DTOS;

namespace webUsuarios
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {

            int idusuario = Convert.ToInt16(txtIdUsuario.Value);
            List<UsuarioDTO> usuario = new List<UsuarioDTO>();
            using (BusinessClient reference = new BusinessClient())
            {
                var consulta = reference.GetUsuario(idusuario);
                usuario = JsonConvert.DeserializeObject<List< UsuarioDTO>>(consulta);

                //DataTable dtusuario = (DataTable)JsonConvert.DeserializeObject(consulta, typeof(DataTable));
                //GridView1.DataSource = dtusuario;
                GridView1.DataSource = usuario;
                GridView1.DataBind();
                GridView1.Visible = true;
                reference.Close();
            }
           
            GridView1.Visible = true;

        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            List<UsuarioDTO> usuario = new List<UsuarioDTO>();
            using (BusinessClient reference = new BusinessClient())
            {
                var consulta = reference.GetAllUsuarios();
                usuario = JsonConvert.DeserializeObject<List<UsuarioDTO>>(consulta);

                
                GridView1.DataSource = usuario;
                GridView1.DataBind();
                GridView1.Visible = true;
                reference.Close();
            }

            GridView1.Visible = true;
        }
    }
}