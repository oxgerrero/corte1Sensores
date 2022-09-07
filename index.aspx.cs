using Newtonsoft.Json;
using System;
using System.Threading;


public partial class index : System.Web.UI.Page
{
    System.IO.Ports.SerialPort Arduino;

    protected void Page_Load(object sender, EventArgs e)
    {
        String entro="1";
        if (Session["entro"] != null)
        {
            entro = Session["entro"].ToString();
        }
        
        if (entro.Equals("2"))
        {
            Arduino = (System.IO.Ports.SerialPort)Session["arduino"];
        }
        else
        {
            Arduino = new System.IO.Ports.SerialPort();
            Arduino.PortName = "COM5";
            Arduino.BaudRate = 9600;
            Arduino.Open();
            Session["entro"] = 2;
            Session["arduino"] = Arduino;
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Arduino.IsOpen)
        {
            Arduino.Close();
        }
        else
        {
            Arduino.Open();
        }
    }

    public void timer1_Tick(object sender, EventArgs e)
    {
        String entrada = Arduino.ReadLine();
        Edatos n = new Edatos();
        n = JsonConvert.DeserializeObject<Edatos>(entrada);
        
        tbProximidad.Text = n.Proximidad;
        tbInfrarrojo.Text = n.Infrarrojo;
        tbTemperatura.Text = n.Temperatura;
        tbHumedad.Text = n.Humedad;

        new datos().insertarDatos(n);
    }
}