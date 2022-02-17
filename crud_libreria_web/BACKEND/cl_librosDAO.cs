using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using crud_libreria_web.POJOS;

namespace crud_libreria_web.BACKEND
{
    public class cl_librosDAO
    {
        public  List<cl_libros> mostrar_todo()
        {
            try
            {
                string consulta = "Select * from libros;";
                SqlCommand comando = new SqlCommand(consulta);
                DataTable tabla = cl_conexion.ejecutarConsulta(comando);
                List<cl_libros> lista = new List<cl_libros>();
                foreach(DataRow rows in tabla.Rows)
                {
                    cl_libros aux = new cl_libros();

                    aux.id_libro = Convert.ToInt32(rows[0].ToString());
                    aux.isbn = rows[1].ToString();
                    aux.titulo = rows[2].ToString();
                    aux.numero_edicion = Convert.ToInt32(rows[3].ToString());
                    aux.anio_publicacion = Convert.ToInt32(rows[4].ToString());
                    aux.nombre_autores = rows[5].ToString();
                    aux.pais_publicacion = rows[6].ToString();
                    aux.sinopsis = rows[7].ToString();
                    aux.carrera = rows[8].ToString();
                    aux.materia = rows[9].ToString();
                    
                    lista.Add(aux);
                }
                return lista;
                
            }
            catch (Exception ex) { return null; }
        }
        public bool eliminar(cl_libros libro)
        {
            try
            {
                string delete = "Delete from libros where id = @ID;";
                SqlCommand comando = new SqlCommand(delete);
                comando.Parameters.AddWithValue("ID", libro.id_libro);
                cl_conexion.ejecutarSentencia(comando);
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public bool agregar(cl_libros libro)
        {
            try
            {
                string insert = "insert into libros(isbn, titulo, numero_edicion,anio_publicacion, nombre_autores,pais_publicacion, " +
                    "sinopsis, carrera, materia ) values(@Isbn, @Titulo, @no_edicion, @Anio_publicacion," +
                    " @Nombre_autores, @Pais, @Sinopsis, @Carrera, @Materia);";

                SqlCommand comando = new SqlCommand(insert);
                comando.Parameters.AddWithValue("Isbn", libro.isbn);
                comando.Parameters.AddWithValue("Titulo", libro.titulo);
                comando.Parameters.AddWithValue("no_edicion", libro.numero_edicion);
                comando.Parameters.AddWithValue("Anio_publicacion", libro.anio_publicacion);
                comando.Parameters.AddWithValue("Nombre_autores", libro.nombre_autores);
                comando.Parameters.AddWithValue("Pais", libro.pais_publicacion);
                comando.Parameters.AddWithValue("Sinopsis", libro.sinopsis);
                comando.Parameters.AddWithValue("Carrera", libro.carrera);
                comando.Parameters.AddWithValue("Materia", libro.materia);


                cl_conexion.ejecutarSentencia(comando);
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public bool actualizar(cl_libros libro)
        {
            try
            {
                string update = "UPDATE libros set isbn =@Isbn, titulo= @Titulo, numero_edicion= @edicion," +
                    " anio_publicacion = @anio, nombre_autores = @autores, pais_publicacion = @pais, sinopsis = @Sinopsis, " +
                    " carrera = @Carrera, materia = @Materia where id = @ID; ";
                SqlCommand comando = new SqlCommand(update);
                comando.Parameters.AddWithValue("Isbn",libro.isbn);
                comando.Parameters.AddWithValue("Titulo", libro.titulo);
                comando.Parameters.AddWithValue("edicion", libro.numero_edicion);
                comando.Parameters.AddWithValue("anio", libro.anio_publicacion);
                comando.Parameters.AddWithValue("autores", libro.nombre_autores);
                comando.Parameters.AddWithValue("pais", libro.pais_publicacion);
                comando.Parameters.AddWithValue("Sinopsis", libro.sinopsis);
                comando.Parameters.AddWithValue("Carrera", libro.carrera);
                comando.Parameters.AddWithValue("Materia", libro.materia);

                cl_conexion.ejecutarSentencia(comando);
                return true;
            }
            catch (Exception ex) { return false; }
        }
    }
}