using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; //usa el DATA TABLE
using DAL.DataSetProveedorTableAdapters;//usa el DAL

namespace BLL
{
    public class ClassLogicaProveedor
    {
        //ATRIBUTOS
        private ProveedoresTableAdapter proveedor = null;

        //PROPIEDADES
        private ProveedoresTableAdapter PROVEEDOR
        {
            get
            {
                if (proveedor == null)
                    proveedor = new ProveedoresTableAdapter();
                return proveedor;
            }
        }

        //METODOS
        public DataTable ListarProveedores()
        {
            return PROVEEDOR.GetDataProveedor(); //from Select * seleccionar la capa
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Direccion"></param>
        /// <param name="numeroCelular"></param>
        /// <param name="correoElectronico"></param>
        /// <returns></returns>
        public string NewProveedor(string Nombre, string Direccion, int numeroCelular, string correoElectronico)
        {
            int existe;
            existe = Convert.ToInt32(PROVEEDOR.ScalarQueryExisteNombreProveedor(Nombre));
            if (existe > 0)
                return "Error: la persona " + Nombre + " ya existe previamente";
            else
            {
                PROVEEDOR.InsertQueryProveedor(Nombre, Direccion, numeroCelular, correoElectronico);
                return "Se agregó a " + Nombre + " como nuevo proveedor";
            }
        }

        
        public string editProveedor(string Nombre, string Direccion, int numeroCelular, string correoElectronico, int IDproveedor)
        {

            int existe;
            existe = Convert.ToInt32(PROVEEDOR.ScalarQueryExisteNombreProveedor(Nombre));
            if (existe > 1)
                return "Error: la editorial " + Nombre + " ya existe previamente";
            else
            {
                PROVEEDOR.UpdateQueryProveedor(Nombre, Direccion, Convert.ToInt32(numeroCelular), correoElectronico, IDproveedor);
                return "Se editó la editorial con registro: " + IDproveedor;
            }
        }
        
    }
}
