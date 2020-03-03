using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Controlador
{
    public class clsVariables
    {
        public long Cedula { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public int idUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public DataTable dttProductos { get; set; }

        public double Ingresos { get; set; }
        public double Egresos { get; set; }
        public int Deudas { get; set; }
        public int Score { get; set; }
        

        public int NumeroCuenta { get; set; }
        public string TipoProducto { get; set; }
        public string TipoCredito { get; set; }
        public double Deuda{ get; set; }

        public double ValPrestamo { get; set; }
        public double NumCuotas { get; set; }
        public string TipoPrestamo { get; set; }

        public double InteresesVehi { get; set; } = 24;
        public double InteresesVivi { get; set; } = 12;
        public double InteresesLi { get; set; } = 32;
        public double DiaMes { get; set; }  = 30;
        public double FlujoCaja { get; set; }
        
        public string Estado { get; set; }
        public double SumatoriaDeudas { get; set; }
        public double ValInteres { get; set; }

        public string Mensaje1 { get; set; }
        public string Mensaje2 { get; set; }
        public string Mensaje3 { get; set; }
        public string Mensaje4 { get; set; }

        public double ValorTotal { get; set; }
        public double ValorTotalconCadaMes { get; set; }
        public double InteresMes { get; set; }
        public double TasaMensual { get; set; }
        public double TasaAnual { get; set; }

    }
}
