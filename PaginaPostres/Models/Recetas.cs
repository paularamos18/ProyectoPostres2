using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginaPostres.Models
{
    public class Recetas
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Ingredientes { get; set; }

        public string Procedimiento { get; set; }
    }
}