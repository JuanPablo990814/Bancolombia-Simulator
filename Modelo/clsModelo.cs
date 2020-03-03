using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelo
{
    public class clsModelo
    {

        #region Definicion de Variables

        SqlConnection cnnBaseDatos = null;
        SqlCommand cmdConsCliente = null;  //metodo de consulta
        SqlDataReader drConsCliente = null;
        DataTable dttConsCliente = null;
        string cadenaConexion = string.Empty;

        #endregion


        #region Constructor
        public clsModelo()
        {
            cadenaConexion = ("Data Source =(localdb)\\LOCALSERVER-JP; Initial Catalog = DB_Bancolombia; Integrated Security= True");
        }

        #endregion

        // En Construccion
        #region Metodo para la Consultar el Usuario Asesor

        public DataTable mtVerificarUsuarioMod(string recibeUsuario,string recibeContraseña)
        {
            cnnBaseDatos = new SqlConnection(cadenaConexion);
            dttConsCliente = new DataTable();
            cmdConsCliente = new SqlCommand();

            //Preparar comando SQL

            cmdConsCliente.Connection = cnnBaseDatos;
            cmdConsCliente.CommandType = CommandType.Text;
            cmdConsCliente.CommandText = "exec sp_VerificarAsesor '"+recibeUsuario+"','"+recibeContraseña+"'";

            //Abre conexion y ejecuta consulta

            cnnBaseDatos.Open();
            drConsCliente = cmdConsCliente.ExecuteReader();
            dttConsCliente.Load(drConsCliente);
            cnnBaseDatos.Close();

            return dttConsCliente;

        }

        #endregion

        public DataTable mtBuscarClienteMod(long recibeCedula)
        {
            cnnBaseDatos = new SqlConnection(cadenaConexion);
            dttConsCliente = new DataTable();
            cmdConsCliente = new SqlCommand();

            //Preparar comando SQL

            cmdConsCliente.Connection = cnnBaseDatos;
            cmdConsCliente.CommandType = CommandType.Text;
            cmdConsCliente.CommandText = "select* from tblClientes where ced = " + recibeCedula;

            //Abre conexion y ejecuta consulta

            cnnBaseDatos.Open();
            drConsCliente = cmdConsCliente.ExecuteReader();
            dttConsCliente.Load(drConsCliente);
            cnnBaseDatos.Close();

            return dttConsCliente;
        }

        public void mtBorrarClienteMod(long recibeCedula)
        {
            cnnBaseDatos = new SqlConnection(cadenaConexion);
            cmdConsCliente = new SqlCommand();

            //Preparar comando SQL

            cmdConsCliente.Connection = cnnBaseDatos;
            cmdConsCliente.CommandType = CommandType.Text;
            cmdConsCliente.CommandText = "delete from tblClientes where ced ="+recibeCedula;

            //Abre conexion y ejecuta consulta

            cnnBaseDatos.Open();
            drConsCliente = cmdConsCliente.ExecuteReader();
            cnnBaseDatos.Close();
        }

        public void mtInsertarClienteMod(long recibeCedula, string recibeNombre, string recibeDireccion, string recibeTelefono)
        {
            cnnBaseDatos = new SqlConnection(cadenaConexion);
            cmdConsCliente = new SqlCommand();

            //Preparar comando SQL

            cmdConsCliente.Connection = cnnBaseDatos;
            cmdConsCliente.CommandType = CommandType.Text;
            cmdConsCliente.CommandText = "insert into tblClientes values(" + recibeCedula + ",'" + recibeNombre + "','" + recibeTelefono + "','" + recibeDireccion + "')";

            //Abre conexion y ejecuta consulta

            cnnBaseDatos.Open();
            drConsCliente = cmdConsCliente.ExecuteReader();
            cnnBaseDatos.Close();
        }

        public void mtModificarClienteMod(long recibeCedula, string recibeNombre, string recibeDireccion, string recibeTelefono)
        {
            cnnBaseDatos = new SqlConnection(cadenaConexion);
            cmdConsCliente = new SqlCommand();

            //Preparar comando SQL

            cmdConsCliente.Connection = cnnBaseDatos;
            cmdConsCliente.CommandType = CommandType.Text;
            cmdConsCliente.CommandText = "exec sp_ModificarCliente " + recibeCedula + ",'" + recibeNombre + "'," + recibeTelefono + ",'" + recibeDireccion + "'";

            //Abre conexion y ejecuta consulta

            cnnBaseDatos.Open();
            drConsCliente = cmdConsCliente.ExecuteReader();
            cnnBaseDatos.Close();
        }
        public DataTable mtInfoFinancieraMod(long recibeCedula)
        {
            cnnBaseDatos = new SqlConnection(cadenaConexion);
            dttConsCliente = new DataTable();
            cmdConsCliente = new SqlCommand();

            //Preparar comando SQL

            cmdConsCliente.Connection = cnnBaseDatos;
            cmdConsCliente.CommandType = CommandType.Text;
            cmdConsCliente.CommandText = "exec sp_InfoCliente " + recibeCedula;

            //Abre conexion y ejecuta consulta

            cnnBaseDatos.Open();
            drConsCliente = cmdConsCliente.ExecuteReader();
            dttConsCliente.Load(drConsCliente);
            cnnBaseDatos.Close();

            return dttConsCliente;
        }

        public void mtIngresarInfoMod(long recibeCedula,string recibeNombre,double recibeIngresos, double recibeEgresos, int recibeDeudas,int recibeScore)
        {
            cnnBaseDatos = new SqlConnection(cadenaConexion);
            cmdConsCliente = new SqlCommand();

            //Preparar comando SQL

            cmdConsCliente.Connection = cnnBaseDatos;
            cmdConsCliente.CommandType = CommandType.Text;
            cmdConsCliente.CommandText = "insert into tblInfoCliente values(" + recibeCedula + "," + recibeIngresos + "," + recibeEgresos + "," + recibeDeudas + "," + recibeScore + ")";

            //Abre conexion y ejecuta consulta

            cnnBaseDatos.Open();
            drConsCliente = cmdConsCliente.ExecuteReader();
            cnnBaseDatos.Close();
        }

        public DataTable mtConsultarProductoMod(long recibeCedula)
        {
            cnnBaseDatos = new SqlConnection(cadenaConexion);
            dttConsCliente = new DataTable();
            cmdConsCliente = new SqlCommand();

            //Preparar comando SQL

            cmdConsCliente.Connection = cnnBaseDatos;
            cmdConsCliente.CommandType = CommandType.Text;
            cmdConsCliente.CommandText = "select* from tblProductos where cedula =" + recibeCedula;

            //Abre conexion y ejecuta consulta

            cnnBaseDatos.Open();
            drConsCliente = cmdConsCliente.ExecuteReader();
            dttConsCliente.Load(drConsCliente);
            cnnBaseDatos.Close();

            return dttConsCliente;
        }

        public void mtIngresarProductosMod(string recibeTipoCredito ,string recibeTipoProducto,double recibeDeuda,long recibeCedula)
        {
            cnnBaseDatos = new SqlConnection(cadenaConexion);
            cmdConsCliente = new SqlCommand();

            //Preparar comando SQL

            cmdConsCliente.Connection = cnnBaseDatos;
            cmdConsCliente.CommandType = CommandType.Text;
            cmdConsCliente.CommandText = "insert into tblProductos  values('"+recibeTipoCredito+"','"+recibeTipoProducto+"',"+recibeDeuda+","+recibeCedula+")";

            //Abre conexion y ejecuta consulta

            cnnBaseDatos.Open();
            drConsCliente = cmdConsCliente.ExecuteReader();
            cnnBaseDatos.Close();
        }

        //En Creacion
        public DataTable mtConsultaClientePrestamoMod(long recibeCedula)
        {
            cnnBaseDatos = new SqlConnection(cadenaConexion);
            dttConsCliente = new DataTable();
            cmdConsCliente = new SqlCommand();

            //Preparar comando SQL

            cmdConsCliente.Connection = cnnBaseDatos;
            cmdConsCliente.CommandType = CommandType.Text;
            cmdConsCliente.CommandText = "exec sp_ConsultaPrestamo "+recibeCedula;

            //Abre conexion y ejecuta consulta

            cnnBaseDatos.Open();
            drConsCliente = cmdConsCliente.ExecuteReader();
            dttConsCliente.Load(drConsCliente);
            cnnBaseDatos.Close();

            return dttConsCliente;
        }

        public void mtPrestamoMod(long recibeCedula,double recibeValPrestamo, double recibeNumCuotas, string recibeTipoPrestamo)
        {
            cnnBaseDatos = new SqlConnection(cadenaConexion);
            cmdConsCliente = new SqlCommand();

            //Preparar comando SQL

            cmdConsCliente.Connection = cnnBaseDatos;
            cmdConsCliente.CommandType = CommandType.Text;
            cmdConsCliente.CommandText = "insert into tblPrestamo values(" + recibeCedula + "," + recibeValPrestamo + "," + recibeNumCuotas + ",'" + recibeTipoPrestamo + "')";

            //Abre conexion y ejecuta consulta

            cnnBaseDatos.Open();
            drConsCliente = cmdConsCliente.ExecuteReader();
            cnnBaseDatos.Close();

        }

        public DataTable mtConsultaTotalDeudas(long recibeCedula)
        {
            cnnBaseDatos = new SqlConnection(cadenaConexion);
            dttConsCliente = new DataTable();
            cmdConsCliente = new SqlCommand();

            //Preparar comando SQL

            cmdConsCliente.Connection = cnnBaseDatos;
            cmdConsCliente.CommandType = CommandType.Text;
            cmdConsCliente.CommandText = "select Deuda from tblProductos where cedula = "+recibeCedula;

            //Abre conexion y ejecuta consulta

            cnnBaseDatos.Open();
            drConsCliente = cmdConsCliente.ExecuteReader();
            dttConsCliente.Load(drConsCliente);
            cnnBaseDatos.Close();

            return dttConsCliente;
        }
    }
}
