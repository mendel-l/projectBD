using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetPagoTableAdapters;
using System.Data;
using DAL.DataSetCategoriaTableAdapters;

namespace BLL
{
    public class ClassLogicaPago
    {

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

        public DataTable ListarPago()
        {
            return PAGO.GetData();
        }


    }
}
