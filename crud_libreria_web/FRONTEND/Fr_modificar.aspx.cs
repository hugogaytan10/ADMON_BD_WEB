using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crud_libreria_web.FRONTEND
{
    public partial class Fr_modificar : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //AQUI RECUPERAMOS EL DATO Y LO PASAMOS A NUESTROS CAMPOS 
            string titu = Request.QueryString.Get("titulo");
            txtTitulo.Text = titu;
        }

        protected void btn_regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}