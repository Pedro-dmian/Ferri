using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Products
    {
        public ConexionBD conexion;
        public Products(ConexionBD con)
        {
            conexion = con;
        }

        public DataTable getProducts()
        {
            return this.conexion.GenericSPSelect("getProducts");
        }

        public DataTable getProductById(int product_id)
        {
            return conexion.GenericSPSelect("getProductID", new SqlParameter[]
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = product_id }
            });
        }

    }
}
