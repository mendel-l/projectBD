using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.DataSetRolTableAdapters; //usa el DAL
using System.Data; //usa el DATA TABLE

namespace BLL
{
    public class ClassLogicaRol
    {
        //ATRIBUTOS
        private RolTableAdapter rol = null;

        //PROPIEDADES
        private RolTableAdapter ROL
        {
            get
            {
                if (rol == null)
                    rol = new RolTableAdapter();
                return rol;
            }
        }

        //METODOS
        public DataTable ListarRol()
        {
            return ROL.GetDataRol(); //from Select * seleccionar la capa
        }

        public string NewRol(string nombreRol)
        {
            ROL.InsertQueryRol(nombreRol);
            return "Se agregó un nuevo " + nombreRol;
        }

        public string editRol(string nombreRol, int IDrol)
        {
            ROL.UpdateQueryRol(nombreRol, IDrol);
            return "Se editó la tabla Persona con registro id: " + IDrol;
        }
    }
}
