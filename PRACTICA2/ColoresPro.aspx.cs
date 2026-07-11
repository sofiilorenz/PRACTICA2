using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRACTICA2
{
    public partial class ColoresPro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddl_colores_pro.Items.Add("Azul");
                ddl_colores_pro.Items.Add("Rojo");
                ddl_colores_pro.Items.Add("Verde");
            }
        }

        //ENABLE AUTOPOSTBACK
        protected void ddl_colores_pro_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_color_pro.Text = ddl_colores_pro.SelectedItem.ToString();
        }
    }
}