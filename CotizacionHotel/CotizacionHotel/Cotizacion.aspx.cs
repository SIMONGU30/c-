using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CotizacionHotel
{
    public partial class Cotizacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCotizar_Click(object sender, EventArgs e)
        {
            int cotizacion;
            cotizacion = Convert.ToInt32(txtNumeroDias.Text) * Convert.ToInt32(txtNumeroPersonas.Text) * Convert.ToInt32(txtValorPersona.Text) + Convert.ToInt32(txtAlimentacionPersona.Text) * Convert.ToInt32(txtNumeroPersonas.Text);

            lblCotizacion.Text = Convert.ToString(cotizacion);
            txtCotizacion.Text = Convert.ToString(cotizacion);
        }
    }
}