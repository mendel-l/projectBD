using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using DAL.DataSetUsuarioTableAdapters;
using System;
using System.Net.Http;

namespace BLL
{
    public class ClassLogicaUsuario
    {

        private UsuarioTableAdapter usuario = null;
        private UsuarioTableAdapter Usuario
        {
            get
            {
                if (usuario == null)
                {
                    usuario = new UsuarioTableAdapter();
                }

                return usuario;
            }
        }

        public string VerifyPassword(string usuario, string password)
        {
            var userData = Usuario.GetDataUser(usuario);

            try
            {
                if (userData.Rows.Count == 1)
                {
                    string savedHash = userData.Rows[0][2].ToString();
                    string sal = userData.Rows[0][5].ToString();
                    string noRepID = userData.Rows[0][4].ToString();
                    string generateHash = BCrypt.Net.BCrypt.HashPassword(password, sal);

                    if (generateHash == savedHash)
                    {

                        return "usuario existente";
                    }
                    else
                    {

                        return "Invalido";
                    }
                }


                return "Invalido";

            }
            catch (Exception error)
            {
                return "Invalido:" + error.ToString();
            }
            return "Invalido";
        }

        public string crearUsuario(string usuario, string password, int idPersona, int idRol)
        {
            var userData = Usuario.GetDataID(idPersona);
            var userData2 = Usuario.GetDataUser(usuario);

            try
            {
                
                    if (userData.Rows.Count > 0)
                    {
                        return "Existe";
                    }
                    else
                    {
                    if (userData2.Rows.Count > 0) {
                        string sal = BCrypt.Net.BCrypt.GenerateSalt();
                        string passwordHash = BCrypt.Net.BCrypt.HashPassword(password, sal);
                        Usuario.InsertQuery1(usuario, passwordHash, idRol, idPersona, sal);
                        return "Usuario Registrado Exitosamente";
                    }
                    else
                    {
                        return "Existe";
                    }

                    }
                


            }
            catch (Exception error)
            {
                return "Invalido:" + error.ToString();
            }

        }




    }

}