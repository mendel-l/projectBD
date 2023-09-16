using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.DataSetPersonaTableAdapters; //usa el DAL
using System.Data; //usa el DATA TABLE

namespace BLL
{
    public class ClassLogicaPersona
    {
        //ATRIBUTOS
        private PersonaTableAdapter persona = null;

        //PROPIEDADES
        private PersonaTableAdapter PERSONA
        {
            get
            {
                if (persona == null)
                    persona = new PersonaTableAdapter();
                return persona;
            }
        }

        //METODOS
        public DataTable ListarPersonas()
        {
            return PERSONA.GetDataPersona(); //from Select * seleccionar la capa
        }

        /// <summary>
        /// Metodo que graba nueva persona, antes valida que no exista
        /// </summary>
        /// <param name="Nombre"> refiere al nombre de la persona </param>
        /// <param name="Apellido"> refiere al apaellido de la persona </param>
        /// <param name="Direccion"> refiere a la direccion de la persona </param>
        /// <param name="numeroCelular"> refire al telefono de la persona </param>
        /// <param name="correoElectronico"> refire al correo de la persona </param>
        /// <returns></returns>
        public string NuevaPersona(string Nombre, string Apellido, string Direccion, int numeroCelular, string correoElectronico)
        {
            int existe;
            existe = Convert.ToInt32(PERSONA.ScalarQueryExisteNombrePersona(Nombre));
            if (existe > 0)
                return "Error: la persona " + Nombre + " ya existe previamente";
            else
            {
                PERSONA.InsertQueryPersona(Nombre, Apellido, Direccion, numeroCelular, correoElectronico);
                return "Se agregó a " + Nombre + "como nueva persona";
            }
        }

        public string editarPersona(string Nombre, string Apellido, string Direccion, int numeroCelular, string correoElectronico, int IDpersona)
        {
            int existe;
            existe = Convert.ToInt32(PERSONA.ScalarQueryExisteNombrePersona(Nombre));
            if (existe > 1)
                return "Error: la editorial " + Nombre + " ya existe previamente";
            else
            {
                PERSONA.UpdateQueryPersona(Nombre, Apellido, Direccion, Convert.ToInt32(numeroCelular), correoElectronico, IDpersona);
                return "Se editó la editorial con registro: " + Nombre;
            }
        }
    }
}
