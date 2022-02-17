using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crud_libreria_web.POJOS
{
    public class cl_libros
    {
        public int id_libro { get; set; }
        public string isbn { get; set; }
        public string titulo { get; set; }
        public int numero_edicion { get; set; }
        public int anio_publicacion { get; set; }
        public string nombre_autores { get; set; }
        public string pais_publicacion { get; set; }
        public string sinopsis { get; set; }
        public string carrera { get; set; }
        public string materia { get; set; }


        
    }
}