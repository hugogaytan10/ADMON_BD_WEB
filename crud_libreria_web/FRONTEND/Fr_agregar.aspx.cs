using crud_libreria_web.BACKEND;
using crud_libreria_web.POJOS;
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
        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            cl_libros obj = new cl_libros();
            obj.isbn = txtISBN.Text;
            obj.titulo = txtTITULO.Text;
            obj.numero_edicion = Convert.ToInt32(txtEDICION.Text);
            obj.anio_publicacion = Convert.ToInt32(txtAÑO.Text);
            obj.nombre_autores = txtAUTOR.Text;
            obj.pais_publicacion = txtPAIS.Text;
            obj.sinopsis = txtSINOPSIS.Text;
            obj.carrera = txtCARRERA.Text;
            obj.materia = txtMATERIA.Text;

            cl_librosDAO cLibrosDAO = new cl_librosDAO();

            cLibrosDAO.agregar(obj);

        }
        protected void btn_regrear_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
            cl_librosDAO obj = new cl_librosDAO();
        }
    }
}