using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRACTICA2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttn_calcular_Click(object sender, EventArgs e)
        {
            //primero, hay que parsear un string a numero

            int numero = int.Parse(tb_ingreso_numero.Text);

            //generamos la tabla

            string tabla = "<table border='1'";
            tabla += "<tr><td>Producto</td> <td>Resultado</td></tr>";
            for(int i = 1; i <= 10 ; i++)
            {
                tabla += "<tr>";
                tabla += "<td>" + i + " x " + numero + "</td>";
                tabla += "<td>" + i * numero + "</td>";
                tabla += "</tr>";
            }
            tabla += "</table>";
            lbl_tabla.Text = tabla;
            tb_ingreso_numero.Text = "";
        }
    }
}