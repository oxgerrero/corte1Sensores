using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Edatos n = new datos().obDatos();
        tbProximidad.Text = n.Proximidad;
        tbInfrarrojo.Text = n.Infrarrojo;
        tbTemperatura.Text = n.Temperatura;
        tbHumedad.Text = n.Humedad;
    }

    protected void timer1_Tick(object sender, EventArgs e)
    {

    }
}