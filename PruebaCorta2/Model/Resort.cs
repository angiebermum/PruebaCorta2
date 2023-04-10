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
        // Propiedad que representa el nombre del resort y se define como clave primaria
        [Key]
        public string Name { get; set; }

        // Propiedad que representa la descripción del resort 
        public string Description { get; set; }

        // Propiedad que representa la foto del resort 
        public string Photo { get; set; }

        // Propiedad que representa el precio del resort 
        public decimal Price { get; set; }
    }
}

