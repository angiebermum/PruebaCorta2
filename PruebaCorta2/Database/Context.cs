using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PruebaCorta2.Model;


namespace PruebaCorta2.Database

{

    // Clase que representa el contexto de la base de datos Resorts
    public class ResortsContext : DbContext
    {

        // Constructor que crea un nuevo contexto de base de datos con la cadena de conexión especificada
        public ResortsContext() : base(@"Server=DESKTOP-5DRNVDJ\MSSQLSERVER01;Database=Prueba;Integrated Security=True")
        {

        }

        // Propiedad que representa la tabla "Resorts" de la base de datos y permite realizar operaciones básicas sobre ella
        public DbSet<Resort> Resorts { get; set; }
    }
}


