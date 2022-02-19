using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using crud_libreria_web.BACKEND;
using CheckBox = System.Web.UI.WebControls.CheckBox;
using crud_libreria_web.POJOS;

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

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach(GridViewRow rows in gvMain.Rows)
            {
                if (rows.RowType == DataControlRowType.DataRow)
                {
                    //BUSCAMOS NUESTRO CHECK DENTRO DEL GRID
                    CheckBox check = (rows.Cells[0].FindControl("checklista") as CheckBox);

                    if (check != null)
                    {
                        if (check.Checked)
                        {
                            //RECUPERAMOS LOS DATOS PARA ELIMINAR
                            int id_libro = Convert.ToInt32(rows.Cells[1].Text);

                            //CREAMOS UN OBJETO LIBROS PARA ELIMINAR
                            cl_libros aux = new cl_libros();
                            aux.id_libro = id_libro;

                            //procedemos a liminarlo
                            cl_librosDAO dao = new cl_librosDAO();

                            //cambiamos de color lo seleccionado
                            rows.Cells[0].BackColor = Color.FromArgb(250, 0, 0);
                            rows.Cells[1].BackColor = Color.FromArgb(250, 0, 0);
                            rows.Cells[2].BackColor = Color.FromArgb(250, 0, 0);
                            if (dao.eliminar(aux))
                            {
                                gvMain.DataSource = dao.mostrar_todo();
                                gvMain.DataBind();
                            }
                        }
                    }

                    
                }
            }
        }

        protected void btn_agegar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Fr_agregar.aspx");
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {

            //CHECAMOS CUAL QUIERE MODIFICAR TOMARÁ EL PRIMERO QUE SELECCIONE
            foreach (GridViewRow rows in gvMain.Rows)
            {
                if (rows.RowType == DataControlRowType.DataRow)
                {
                    //BUSCAMOS NUESTRO CHECK DENTRO DEL GRID
                    CheckBox check = (rows.Cells[0].FindControl("checklista") as CheckBox);

                    if (check != null)
                    {
                        if (check.Checked)
                        {
                            //RECUPERAMOS LOS DATOS
                            string id_libro = rows.Cells[1].Text;
                            string titulo = rows.Cells[3].Text;
                            string isb = rows.Cells[2].Text;
                            string numero_edicion = rows.Cells[4].Text;
                            string anio_publicacion = rows.Cells[5].Text;
                            string nombre_autores = rows.Cells[6].Text;
                            string pais_publicacion = rows.Cells[7].Text;
                            string sinopsis = rows.Cells[8].Text;
                            string carrera = rows.Cells[9].Text;
                            string materia = rows.Cells[10].Text;

                            //LE PASAMOS EL PARAMTERO DELA FORMA QUERYSTRING
                            //nombrePagina ? nombreVariable = valor que le pasamos al otro form
                            Session["titu"] = titulo;
                            Session["isb"] = isb;
                            Session["numero_edicion"] = numero_edicion;
                            Session["anio_publicacion"] = anio_publicacion;
                            Session["autores"] = nombre_autores;
                            Session["pais"] = pais_publicacion;
                            Session["sinopsis"] = sinopsis;
                            Session["carrera"] = carrera;
                            Session["materia"] = materia;
                            Session["id_li"] = id_libro;

                            Response.Redirect("Fr_modificar.aspx");

                        }
                    }


                }
            }


            
        }

       
    }
}