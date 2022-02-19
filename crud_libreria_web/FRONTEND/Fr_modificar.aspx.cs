using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using crud_libreria_web.POJOS;
using crud_libreria_web.BACKEND;

namespace crud_libreria_web.FRONTEND
{
    public partial class Fr_modificar : System.Web.UI.Page
    {

        int id_libro;
        protected void Page_Load(object sender, EventArgs e)
        {
          
            //AQUI RECUPERAMOS EL DATO Y LO PASAMOS A NUESTROS CAMPOS 
            string titu = Convert.ToString(Session["titu"]);
            string isb = Convert.ToString(Session["isb"]);
            string numero_edicion = Convert.ToString(Session["numero_edicion"]);
            string anio_publicacion = Convert.ToString(Session["anio_publicacion"]);
            string nombre_autor = Convert.ToString(Session["autores"]);
            string pais_publicacion = Convert.ToString(Session["pais"]);
            string sinopsis = Convert.ToString(Session["sinopsis"]);
            string carrera = Convert.ToString(Session["carrera"]);
            string materia = Convert.ToString(Session["materia"]);
            //RECUPERAMOS EL ID DEL LIBRO
            id_libro = Convert.ToInt32(Session["id_li"]);
            //LOS ASIGNAMOS A LOS CAMPOS
            txtTITULO.Text = titu;
            
            txtSINOPSIS.Text = sinopsis;
            txtPAIS.Text = pais_publicacion;
            txtMATERIA.Text = materia;
            txtISBN.Text = isb;
            txtEDICION.Text = numero_edicion;
            txtCARRERA.Text = carrera;
            txtAUTOR.Text = nombre_autor;
            txtANIO.Text = anio_publicacion;
            //INHABILITAMOS LOS BOTONES
            txtTITULO.Enabled = false;
            txtSINOPSIS.Enabled = false;
            txtCARRERA.Enabled = false;
            txtISBN.Enabled = false;
            txtPAIS.Enabled = false;
            txtEDICION.Enabled = false;
            txtANIO.Enabled = false;
            txtAUTOR.Enabled = false;
            txtMATERIA.Enabled = false;
        }

        protected void btn_regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            //RECUPERAMOS LOS DATOS A MODIFICAR
            string titulo = txtTITULO.Text;
            string sinopsis = txtSINOPSIS.Text;
            string pais = txtPAIS.Text;
            string materia = txtMATERIA.Text;
            string isbn = txtIsbnNuevo.Text;
            string edicion = txtEDICION.Text;
            string carrera = txtCARRERA.Text;
            string autores = txtAUTOR.Text;
            string anio = txtANIO.Text;
            //HACEMOS EL OBJETO DE LIBRO
            cl_libros libro = new cl_libros();
            libro.id_libro = id_libro;
            libro.isbn = isbn;
            libro.titulo = titulo;
            libro.pais_publicacion = pais;
            libro.numero_edicion = Convert.ToInt32(edicion);
            libro.carrera = carrera;
            libro.materia = materia;
            libro.sinopsis = sinopsis;
            libro.nombre_autores = autores;
            libro.anio_publicacion = Convert.ToInt32(anio);
            //PROCEDEMOS A CREAR UN DAO Y MODIFICAR
            cl_librosDAO dao = new cl_librosDAO();
            try
            {
                dao.actualizar(libro);
            }
            catch (Exception ex) { }


        }

        
    }
}