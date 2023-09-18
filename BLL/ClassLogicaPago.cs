using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.DataSetPagoTableAdapters; //usa el DAL
using System.Data; //usa el DATA TABLE

namespace BLL
{
    public class ClassLogicaPago
    {
        //ATRIBUTOS
        private PagoTableAdapter pago = null;

        //PROPIEDADES
        private PagoTableAdapter PAGO
        {
            get
            {
                if (pago == null)
                    pago = new PagoTableAdapter();
                return pago;
            }
        }

        //METODOS
        public DataTable ListarPago()
        {
            return PAGO.GetDataPago(); //from Select * seleccionar la capa
        }

        public string NewPago(string tipoPago)
        {
                PAGO.InsertQueryPago(tipoPago);
                return "Se agregó un nuevo pago";
        }

        public string editPago(string tipoPago, int IDpago)
        {
                PAGO.UpdateQueryPago(tipoPago, IDpago);
                return "Se editó la tabla Persona con registro id: " + IDpago;
        }
    }
}
