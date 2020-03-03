using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.IO;

namespace Controlador
{
    public class clsControlador
    {
        clsVariables objVariables;
        DataTable dttClientes = null;
        DataTable dttTotalDeudas = null;
        clsModelo clsDatos;


        #region Construccion de Variables
        public clsControlador (clsVariables objVar)
        {
            objVariables = objVar;
        }
#endregion

        public void mtVerificarUsuario()
        {
            clsDatos = new clsModelo();
            dttClientes = clsDatos.mtVerificarUsuarioMod(objVariables.Usuario, objVariables.Contraseña);

            objVariables.idUsuario = Convert.ToInt32(dttClientes.Rows[0]["iduser"]);
        }


        public void mtBuscarCliente()
        {
            clsDatos = new clsModelo();
            dttClientes = clsDatos.mtBuscarClienteMod(objVariables.Cedula);

            objVariables.Nombre = dttClientes.Rows[0]["Nombre"].ToString();
            objVariables.Telefono = dttClientes.Rows[0]["Telefono"].ToString();
            objVariables.Direccion = dttClientes.Rows[0]["Direccion"].ToString();

        }

        public void mtBorrarCliente()
        {
            clsDatos = new clsModelo();
            clsDatos.mtBorrarClienteMod(objVariables.Cedula);

        }

        public void mtInsertarCliente()
        {
            clsDatos = new clsModelo();
            clsDatos.mtInsertarClienteMod(objVariables.Cedula,objVariables.Nombre,objVariables.Direccion,objVariables.Telefono);

        }

        public void mtModificarCliente()
        {
            clsDatos = new clsModelo();
            clsDatos.mtModificarClienteMod(objVariables.Cedula, objVariables.Nombre, objVariables.Direccion, objVariables.Telefono);

        }

        public void mtInfoFinanciera()
        {
            dttClientes = new DataTable();
            clsDatos = new clsModelo();
            dttClientes = clsDatos.mtInfoFinancieraMod(objVariables.Cedula);

            objVariables.Nombre = dttClientes.Rows[0]["Nombre"].ToString();
            objVariables.Ingresos = Convert.ToDouble(dttClientes.Rows[0]["Ingresos"]);
            objVariables.Egresos = Convert.ToDouble(dttClientes.Rows[0]["Egresos"]);
            objVariables.Deudas = Convert.ToInt16(dttClientes.Rows[0]["Deudas"]);
            objVariables.Score= Convert.ToInt16(dttClientes.Rows[0]["Score"]);
            



        }

        public void mtIngresarInfo()
        {
            clsDatos = new clsModelo();
            clsDatos.mtIngresarInfoMod(objVariables.Cedula, objVariables.Nombre, objVariables.Ingresos,objVariables.Egresos,objVariables.Deudas,objVariables.Score);

        }

        public void mtConsultarProducto()
        {
            dttClientes = new DataTable();
            clsDatos = new clsModelo();
            dttClientes = clsDatos.mtConsultarProductoMod(objVariables.Cedula);

            objVariables.dttProductos = dttClientes;


            
        }
        public void mtIngresarProductos()
        {
            clsDatos = new clsModelo();
            clsDatos.mtIngresarProductosMod( objVariables.TipoCredito,objVariables.TipoProducto, objVariables.Deuda,objVariables.Cedula);
        }

        public void mtConsultaClientePrestamo()
        {
            clsDatos = new clsModelo();
            dttClientes = clsDatos.mtConsultaClientePrestamoMod(objVariables.Cedula);

            objVariables.Nombre = dttClientes.Rows[0]["Nombre"].ToString();
            objVariables.Ingresos = Convert.ToDouble(dttClientes.Rows[0]["Ingresos"]);
            objVariables.Egresos = Convert.ToDouble(dttClientes.Rows[0]["Egresos"]);
            objVariables.Score = Convert.ToInt16(dttClientes.Rows[0]["Score"]);
            objVariables.NumeroCuenta = Convert.ToInt16(dttClientes.Rows[0]["#Cuenta"]);
            objVariables.TipoProducto = dttClientes.Rows[0]["Tipo_de_Producto"].ToString();
            objVariables.Deuda = Convert.ToDouble(dttClientes.Rows[0]["Deuda"]);

            objVariables.dttProductos = dttClientes;


        }
        
        public void mtPrestamo()
        {
            clsDatos = new clsModelo();
            clsDatos.mtPrestamoMod(objVariables.Cedula,objVariables.ValPrestamo, objVariables.NumCuotas, objVariables.TipoPrestamo);

        }

        public void mtEvaluaCredito()
        {
            clsDatos = new clsModelo();

            dttClientes = clsDatos.mtConsultaTotalDeudas(objVariables.Cedula);

            objVariables.SumatoriaDeudas = Convert.ToDouble(dttClientes.Rows[0]["Deuda"]);

            int contador = 0;

            if (objVariables.Score >= 400)
            {
                contador++;
            }
            else
            {
                objVariables.Mensaje1 = "Su Score no es lo suficientemente alto";
            }

            if (objVariables.FlujoCaja > 0)
            {
                contador++;
            }
            else
            {
                objVariables.Mensaje2 = "Su flujo de caja es Negativo";
            }

            if (objVariables.Ingresos * 15 > objVariables.SumatoriaDeudas)
            {
                contador++;
            }
            else
            {
                objVariables.Mensaje3 = "La sumatoria de sus deudas son más de 15 veces su salario ";
            }
            if (objVariables.FlujoCaja > objVariables.Ingresos * 0.20)
            {
                contador++;
            }
            else
            {
                objVariables.Mensaje4 = "La diferencia entre su Salario y Egresos es mayor al 20% de su Salario";
            }

            if (contador == 4)
            {
                objVariables.Estado = "Aprobado";
            }
            else
            {
                objVariables.Estado = "Negado";
            }
        }

        public void mtDatosCarta()
        {
            objVariables.ValorTotal = (objVariables.ValPrestamo * objVariables.ValInteres) * objVariables.NumCuotas + objVariables.ValPrestamo;
            objVariables.InteresMes = (objVariables.ValPrestamo * objVariables.ValInteres);
            objVariables.ValorTotalconCadaMes = (objVariables.ValorTotal/objVariables.NumCuotas);
            objVariables.TasaMensual = objVariables.ValInteres * 100;
            objVariables.TasaAnual = objVariables.TasaMensual * 12;


        }
        public void mtGenerarPDF()
        {
            if (objVariables.Estado == "Aprobado")
            {

                // Se crea el documento con el tamaño de página tradicional
                Document doc = new Document(PageSize.LETTER);
                // Indicamos donde vamos a guardar el documento
                PdfWriter writer = PdfWriter.GetInstance(doc,
                                            new FileStream(@"C:\Users\JPablo\Documents\Bancolombia\CartaBancolombia_"+objVariables.Cedula+".pdf", FileMode.Create));

                // Se le coloca el título y el autor
                // **Nota: Esto no será visible en el documento
                doc.AddTitle("Carta Bancaria");
                doc.AddCreator("Bancolombia SA");

                // Abrimos el archivo
                doc.Open();
                // Se crea el tipo de Font que vamos utilizar
                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                // Se escribe el encabezamiento en el documento
                Image logo = Image.GetInstance("C:\\Users\\JPablo\\Documents\\Bancolombia\\Bancologo.png");
                doc.Add(logo);
                doc.Add(new Paragraph("\rMedellín, " + DateTime.Now + "\r\r\r\r Sr(a)." + objVariables.Nombre + " \r" + objVariables.Cedula + " \r" + objVariables.Direccion));
                doc.Add(new Paragraph("\rQueremos informarle que su solicitud de crédito fue APROBADA por nuestros analistas financieros."));
                doc.Add(new Paragraph("A continuación, describimos el resumen de su solicitud:"));
                doc.Add(new Paragraph("\r    • El valor del crédito aprobado es de $" + objVariables.ValPrestamo));
                doc.Add(new Paragraph("    • El valor total a pagar con intereses es de $" + objVariables.ValorTotal));
                doc.Add(new Paragraph("    • La deuda será diferida a " + objVariables.NumCuotas + " meses"));
                doc.Add(new Paragraph("    • El valor a pagar cada mes será de $" + Math.Round(objVariables.ValorTotalconCadaMes)));
                doc.Add(new Paragraph("    • Los intereses causados cada mes serán $" + objVariables.InteresMes));
                doc.Add(new Paragraph("    • La tasa de interés a pagar cada mes es de " + objVariables.TasaMensual + "% NMV"));
                doc.Add(new Paragraph("    • La tasa de interés a pagar cada año es de " + objVariables.TasaAnual + "% NMV"));
                doc.Add(new Paragraph("\r Estamos agradecidos por depositar su confianza en nosotros, recuerde, en Bancolombia, le estamos poniendo el alma."));
                doc.Add(new Paragraph("\r "));
                doc.Add(new Paragraph("Att"));
                Image firma = Image.GetInstance("C:\\Users\\JPablo\\Documents\\Bancolombia\\Firma.png");
                doc.Add(firma);
                doc.Add(Chunk.NEWLINE);



                doc.Close();
                writer.Close();
            }
            else
            {
                // Se crea el documento con el tamaño de página tradicional
                Document doc = new Document(PageSize.LETTER);
                // Indicamos donde vamos a guardar el documento
                PdfWriter writer = PdfWriter.GetInstance(doc,
                                            new FileStream(@"D:\Documentos\Visual Studio\Bancolombia\Cartas\CartaBancolombia_" + objVariables.Cedula+".pdf", FileMode.Create));

                // Se le coloca el título y el autor
                // **Nota: Esto no será visible en el documento
                doc.AddTitle("Carta Bancaria");
                doc.AddCreator("Bancolombia SA");

                // Abrimos el archivo
                doc.Open();
                // Se crea el tipo de Font que vamos utilizar
                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                // Se escribe el encabezamiento en el documento
                //cambia dependiendo de la ubicacion del archivo
                Image logo = Image.GetInstance("D:\\Documentos\\Visual Studio\\Bancolombia\\Recursos\\Bancologo.png");
                doc.Add(logo);
                doc.Add(new Paragraph("\rMedellín, " + DateTime.Now + "\r\r\r\r Sr(a)." + objVariables.Nombre + " \r" + objVariables.Cedula + " \r" + objVariables.Direccion));
                doc.Add(new Paragraph("\rQueremos informarle que su solicitud de crédito fue RECHAZADA por nuestros analistas financieros."));
                doc.Add(new Paragraph("A continuación, describimos los motivos del rechazo:"));
                doc.Add(new Paragraph("\r    • " + objVariables.Mensaje4));
                doc.Add(new Paragraph("    • " + objVariables.Mensaje1));
                doc.Add(new Paragraph("    • " + objVariables.Mensaje2));
                doc.Add(new Paragraph("    • " + objVariables.Mensaje3));
                doc.Add(new Paragraph("\r Estamos agradecidos por depositar su confianza en nosotros, recuerde, en Bancolombia, le estamos poniendo el alma."));
                doc.Add(new Paragraph("\r "));
                doc.Add(new Paragraph("Att"));
                //cambia dependiendo de la ubicacion del archivo
                Image firma = Image.GetInstance("D:\\Documentos\\Visual Studio\\Bancolombia\\Recursos\\Firma.png");
                doc.Add(firma);
                doc.Add(Chunk.NEWLINE);




                doc.Close();
                writer.Close();
            }
 
        }

        public double mtFlujocaja()
        {
            return objVariables.Ingresos - objVariables.Egresos;
        }
    }
}
