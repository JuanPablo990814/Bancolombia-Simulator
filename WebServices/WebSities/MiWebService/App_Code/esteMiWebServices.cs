using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de esteMiWebServices
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class esteMiWebServices : System.Web.Services.WebService
{


    public esteMiWebServices()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public double mtOperaciones(double Intereses,double Dias)
    {
        double resultado;
        Intereses = 1 + (Intereses / 100);
        Dias = Dias / 360;

        resultado = Math.Pow(Intereses, Dias);

        return Math.Round(((resultado - 1)), 3);
    }

}
