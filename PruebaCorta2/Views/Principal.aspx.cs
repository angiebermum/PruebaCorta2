using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PruebaCorta2.Database;



namespace PruebaCorta2.Views
{
    public partial class Principal : System.Web.UI.Page
    {
        // Clase que representa una página web ASP.NET para cargar y mostrar los datos
        protected void Page_Load(object sender, EventArgs e)
        {
            // Se utiliza la clase ResortsContext para crear un nuevo contexto de base de datos
            using (var context = new ResortsContext())
            {
                // Se obtiene una lista de todos los elementos de la base de datos
                var resorts = context.Resorts.ToList();

                // Se asigna la lista de resorts como fuente de datos para el control repResorts
                repResorts.DataSource = resorts;

                // Se enlaza el control repResorts con la fuente de datos
                repResorts.DataBind();
            }

        }
    }
}



