using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crud_libreria_web.FRONTEND
{
    public partial class Fr_agregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_regrear_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}