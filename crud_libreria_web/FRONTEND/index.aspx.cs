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

        protected void gvMain_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                            int id_libro = Convert.ToInt32(rows.Cells[1].Text);
                            string titulo = rows.Cells[2].Text;
                            

                            
                           
                        }
                    }


                }
            }


            
        }
    }
}