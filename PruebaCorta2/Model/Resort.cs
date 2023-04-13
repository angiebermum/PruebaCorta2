using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaCorta2.Model
{
    [Table("Resorts")]

    // Clase que representa un resort en una base de datos, mapeada a la tabla "Resorts"
    public class Resort
    {
        // Propiedad que representa el nombre y se define como llave primaria
        [Key]
        public string Name { get; set; }

        // Propiedad que representa la descripción 
        public string Description { get; set; }

        // Propiedad que representa la foto 
        public string Photo { get; set; }

        // Propiedad que representa el precio 
        public decimal Price { get; set; }
    }
}

