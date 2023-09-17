
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //usa el DATA TABLE
using DAL.DataSetCategoriaTableAdapters;
using System.Reflection;
using System.Text.RegularExpressions;

namespace BLL
{
    public class ClassLogicaCategoria
    {
        private CategoriaTableAdapter categoria = null;

        //PROPIEDADES
        private CategoriaTableAdapter CATEGORIA
        {
            get
            {
                if (categoria == null)
                    categoria = new CategoriaTableAdapter();
                return categoria;
            }
        }

        public DataTable ListarCategoria()
        {
            return CATEGORIA.GetData();
        }


        public string nuevaCategoria( string Marca, string Modelo, string Categoria)
        {
            int existe;
            existe = Convert.ToInt32(CATEGORIA.ScalarQuery(Categoria));
            if (existe > 0)
                return "Error: la categoria" + Categoria + " ya existe!";
            else
            {
                CATEGORIA.InsertQuery(Marca, Modelo,Categoria);
                return "Se agregó a " + Categoria + " como nueva Categoria";
            }
        }
        public string editCATEGORIA(string Marca, string Modelo, string Categoria,int idCatego)
        {


            CATEGORIA.editCategoria(Marca, Modelo, Categoria, idCatego);
            return "Se editó la editorial con registro: " + idCatego;
        }
        public string Eliminar(string Categoria, int idCatego)
        {


            CATEGORIA.DeleteQuery(idCatego);
            return "Se elimino la categoria:  " + Categoria;
        }

    }



    
  
}
