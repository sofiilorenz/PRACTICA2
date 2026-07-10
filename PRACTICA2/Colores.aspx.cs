using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRACTICA2
{
    public partial class Colores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // cargar dropdownlist

            // 1ra vez: isPostBack == FALSE
            // recarga: isPostBack == TRUE
            // para evitar que se dupliquen las recargas, podemos preguntar el estado del postback
            
            // si es la primera vez q ejecuto mi pagina, hacer:
            if (!IsPostBack)
            {
                ddl_colores.Items.Add("Azul");
                ddl_colores.Items.Add("Rojo");
                ddl_colores.Items.Add("Verde");

                //otra forma de agregar ---> como objeto
                //ListItem itemRosa = new ListItem();
                //itemRosa.Text = "Rosa";
                //itemRosa.Value = "4";

                //ddl_colores.Items.Add(itemRosa);

                //otra forma de agregar ---> como coleccion
                //ListItemCollection coleccion = new ListItemCollection();
                //coleccion.Add(new ListItem("Marron","5"));

                //ddl_colores.DataSource = coleccion;
                //ddl_colores.DataTextField = "Text";
                //ddl_colores.DataValueField = "Value";
                //ddl_colores.DataBind();
            }
            
        }

        protected void bttn_elegir_color_Click(object sender, EventArgs e)
        {
            lbl_color.Text = ddl_colores.SelectedItem.ToString();
        }
    }
}