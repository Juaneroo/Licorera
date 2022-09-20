using Licorera.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Licorera.CapaNegocio
{
    public class BLLProductos
    {

        private DALProductos objetoCD = new DALProductos();

        public void Create(int codigo, float valor, string producto, string descripcion, int cantidad)
        {

            objetoCD.CreateProduct(codigo, valor, producto, descripcion, cantidad);
        }

        public DataTable View()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ReadAllProducts();
            return tabla;

        }

        public void Delete(int codigo)
        {

            objetoCD.DeleteProduct(codigo);
        }

        public void Update(int codigo, float valor, string producto, string descripcion, int cantidad)
        {

            objetoCD.UpdateProduct(codigo, valor, producto, descripcion, cantidad);
        }


    }
}