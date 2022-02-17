using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using crud_libreria_web.BACKEND;

namespace crud_libreria_web.FRONTEND
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_mostar_Click(object sender, EventArgs e)
        {
            cl_librosDAO obj = new cl_librosDAO();
            gvMain.DataSource = obj.mostrar_todo();
            gvMain.DataBind();
        }
    }
}