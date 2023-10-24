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

        private FacturasTableAdapter FACTURAS
        {
            get
            {
                if (facturas == null)
                    facturas = new FacturasTableAdapter();
                return facturas;
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

        public string nuevaFactura(int nofactura, string fecha, int idCli, int idVenta,int idPag)
        {
            {
                FACTURAS.inserFacturas(nofactura, fecha, idCli, idVenta, idPag);
                return "Se agregó un nueva factura "+nofactura;
            }
        }
        public string editFactura(int nofactura, string fecha, int idCli, int idVenta, int idPag,int idF)
        {
            {
                FACTURAS.UpdateFacturas(nofactura, fecha, idCli, idVenta, idPag,idF);
                return "Se actualizo la factura No. " + nofactura;
            }
        }
    }
}
