using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System;

namespace Data
{
    public class Products
    {
        public ConexionBD conexion;
        public Products(ConexionBD con)
        {
            conexion = con;
        }

        public DataTable getProducts()
        {
            return this.conexion.GenericSPSelect("GetProducts");
        }
    }
}