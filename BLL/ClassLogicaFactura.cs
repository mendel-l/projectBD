using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSet1TableAdapters;
using System.Data;
using DAL.DataSetCategoriaTableAdapters;

namespace BLL
{
    public class ClassLogicaFactura
    {
        private ClientesTableAdapter clientes = null;

        private ClientesTableAdapter CLIENTES
        {
            get
            {
                if (clientes == null)
                    clientes = new ClientesTableAdapter();
                return clientes;
            }
        }
        /*----------------------------------------------------*/
        private FacturasTableAdapter facturas = null;
        private v_ListadoFacturasTableAdapter prestamo = null;

        private FacturasTableAdapter FACTURAS
        {
            get
            {
                if (facturas == null)
                    facturas = new FacturasTableAdapter();
                return facturas;
            }
        }
        private v_ListadoFacturasTableAdapter PRESTAMO
        {
            get { if (prestamo == null) prestamo = new v_ListadoFacturasTableAdapter(); return prestamo; }
        }

        public DataTable ListarPretasmos()
        {
            return PRESTAMO.GetDataListadoFactura();
        }//fin de ListarPretasmos


        public string grabaPrestamoTRANSACCION(DateTime fecha_fin, int estudiante, List<ClassDTOprestamo> listado)
        {
            string respuesta = "";
            DataTable _dt = new DataTable() { Columns = { "libroId" } };
            foreach (ClassDTOprestamo item in listado)
            {
                _dt.Rows.Add(item.libroId);
            }
            PRESTAMO.sp_CreaPrestamo(fecha_fin, estudiante, _dt, ref respuesta);

            return respuesta;
        }//fin grabaPrestamoTRANSACCION



        /*----------------------------------------------------*/
        private PagoTableAdapter pago = null;

        private PagoTableAdapter PAGOS
        {
            get
            {
                if (pago == null)
                    pago = new PagoTableAdapter();
                return pago;
            }
        }
        /*----------------------------------------------------*/
        private VentasTableAdapter ventas = null;

        private VentasTableAdapter VENTAS
        {
            get
            {
                if (ventas == null)
                    ventas = new VentasTableAdapter();
                return ventas;
            }
        }
        /*----------------------------------------------------*/

        public DataTable listarIDCli()
        {
            return CLIENTES.GetDataidClientes();
        }
        public DataTable listaridV()
        {
            return CLIENTES.GetDataidVen();
        }
        public DataTable listaridP()
        {
            return CLIENTES.GetDataidPag();
        }

        public DataTable listAllF()
        {
            return FACTURAS.GetDataAllFact();
        }

        public string nuevaFactura(int nofactura, string fecha, int idCli, int idVenta, int idPag)
        {
            {
                FACTURAS.inserFacturas(nofactura, fecha, idCli, idVenta, idPag);
                return "Se agregó un nueva factura " + nofactura;
            }
        }
        public string editFactura(int nofactura, string fecha, int idCli, int idVenta, int idPag, int idF)
        {
            {
                FACTURAS.UpdateFacturas(nofactura, fecha, idCli, idVenta, idPag, idF);
                return "Se actualizo la factura No. " + nofactura;
            }
        }

        public DataTable obtenerClienteNom(int idCli)
        {
            {
            
                return CLIENTES.getNomCli(idCli);
            }
        }

        public DataTable obtenerTpago(int idPag)
        {
            {

                return PAGOS.GetDataTipoPag(idPag);
            }
        }

        public DataTable obtenerCantidadV(int idPag)
        {
            {

                return VENTAS.GetVentasCantidad(idPag);
            }
        }

        public DataTable obtenerVtotal(int idPag)
        {
            {

                return PAGOS.GetDataVtotal(idPag);
            }
        }

    }
    public class Factura //clase Logica principal
    {
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleFactura> Detalles { get; set; }

        public Factura()
        {
            Detalles = new List<DetalleFactura>();
        }
    }

    public class DetalleFactura
    {
        public string Nombre { get; set; }
        public string Cantidad { get; set; }
        public string Monto { get; set; }
        public string TipoPag { get; set; }

        public DetalleFactura(string nombre, string cantidad,string monto, string tipopag)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Monto = monto;
            TipoPag = tipopag;
        }
    } 



}

