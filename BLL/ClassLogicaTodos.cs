using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; //usa el DATA TABLE
using DAL.DataSetTablasDTableAdapters; //usa el DAL
using System.Collections;

namespace BLL
{
    public class ClassLogicaTodos
    {
        //ATRIBUTOS
        private pedidosProveedoresTableAdapter pedido = null;
        private ProductosTableAdapter producto = null;
        private VentasTableAdapter venta = null;
        private ClientesTableAdapter cliente = null;
        private EmpleadosTableAdapter empleado = null;

        //PROPIEDADES
        //-----PROVEEDORES-----
        private pedidosProveedoresTableAdapter PEDIDO
        {
            get
            {
                if (pedido == null)
                    pedido = new pedidosProveedoresTableAdapter();
                return pedido;
            }
        }

        //-----PRODUCTO-----
        private ProductosTableAdapter PRODUCTO
        {
            get
            {
                if (producto == null)
                    producto = new ProductosTableAdapter();
                return producto;
            }
        }

        //-----VENTAS-----
        private VentasTableAdapter VENTA
        {
            get
            {
                if (venta == null)
                    venta = new VentasTableAdapter();
                return venta;
            }
        }

        //-----CLIENTES-----
        private ClientesTableAdapter CLIENTE
        {
            get
            {
                if (cliente == null)
                    cliente = new ClientesTableAdapter();
                return cliente;
            }
        }

        //-----EMPLEADOS-----
        private EmpleadosTableAdapter EMPLEADO
        {
            get
            {
                if (empleado == null)
                    empleado = new EmpleadosTableAdapter();
                return empleado;
            }
        }

        //METODOS


        //-----PEDIDO PROVEEDORES-----
        public DataTable ListarTablaPedido()
        {
            return PEDIDO.GetDataPedido(); //from Select * seleccionar la capa
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="noPedido"></param>
        /// <param name="fechaInicio"></param>
        /// <param name="idProveedor"></param>
        /// <returns></returns>
        public string NewPedido(string noPedido, string fechaInicio, int idProveedor)
        {
            {
                PEDIDO.InsertQueryPedido(Convert.ToInt32(noPedido), fechaInicio, idProveedor);
                return "Se agregó un nuevo " + noPedido;
            }
        }

        public string editPedido(string noPedido, string fechaPedido, int IDproveedor, int IDpedido)
        {
            PEDIDO.UpdateQueryPedido(Convert.ToInt32(noPedido), fechaPedido, IDproveedor, IDpedido);
            return "Se editó la el pedido con numero de pedido: " + noPedido + ", y registro: " + IDpedido;
        }

        //-----PRODUCTO-----
        public DataTable ListarTablaProducto()
        {
            return PRODUCTO.GetDataProducto(); //from Select * seleccionar la capa
        }

        public string NewProducto(string Descripcion, double precioVenta, double Descuento, int Stock, string FechaEntrada, string FechaActualizacion, int IDcategoria, int IDpedido)
        {
            {
                PRODUCTO.InsertQueryProducto(Descripcion, precioVenta, Descuento, Stock, FechaEntrada, FechaActualizacion, IDcategoria, IDpedido);
                return "Se agregó un nuevo producto con ID " + IDpedido + "en la categoria " + IDcategoria;
            }
        }

        public string editProducto(string Descripcion, double precioVenta, double Descuento, int Stock, string FechaEntrada, string FechaActualizacion, int IDcategoria, int IDpedido, int IDproducto)
        {
            PRODUCTO.UpdateQueryProducto(Descripcion, precioVenta, Descuento, Stock, FechaEntrada, FechaActualizacion, IDcategoria, IDpedido, IDproducto);
            return "Se editó la editorial con registro: " + IDpedido;
        }

        //-----VENTAS-----
        public DataTable ListarTablaVentas()
        {
            return VENTA.GetDataVenta(); //from Select * seleccionar la capa    
        }

        public string NewVenta(string FechaVenta, int Cantidad, double precioUnitario, int Descuento, double Total, int IDproducto)
        {
            {
                VENTA.InsertQueryVenta(FechaVenta, Cantidad, precioUnitario, Descuento, Total, IDproducto);
                return "Se agregó una nueva venta con total de Q " + Total + "con id " + IDproducto;
            }
        }
        public string editVenta(string FechaVenta, int Cantidad, double precioUnitario, int Descuento, double Total, int IDproducto, int IDventa)
        {
            VENTA.UpdateQueryVenta(FechaVenta, Cantidad, precioUnitario, Descuento, Total, IDproducto, IDventa);
            return "Se editó la editorial con registro: " + IDventa;
        }

        //-----CLIENTES-----
        public DataTable ListarTablaCliente()
        {
            return CLIENTE.GetDataCliente(); //from Select * seleccionar la capa
        }

        public string NewCliente(int IDpersona)
        {
            CLIENTE.InsertQueryCliente(IDpersona);
            return "Se agregó un nuevo cliente con id " + IDpersona;
        }

        public string editCliente(int IDpersona, int IDcliente)
        {
            CLIENTE.UpdateQueryCliente(IDpersona, IDcliente);
            return "Se editó la tabla Persona con registro id: " + IDcliente;
        }

        //-----EMPLEADOS-----
        public DataTable ListarTablaEmpleado()
        {
            return EMPLEADO.GetDataEmpleado(); //from Select * seleccionar la capa
        }

        public string NewEmpleado(string Cargo, string fechaInicio, int IDpersona)
        {
            EMPLEADO.InsertQueryEmpleado(Cargo, fechaInicio, IDpersona);
            return "Se agregó un nuevo enpleado con cargo " + Cargo;
        }
        public string editEmpleado(string Cargo, string fechaInicio, int IDpersona, int IDempleado)
        {
            EMPLEADO.UpdateQueryEmpleado(Cargo, fechaInicio, IDpersona, IDempleado);
            return "Se editó la tabla Persona con registro id: " + IDempleado;
        }
    }
}
