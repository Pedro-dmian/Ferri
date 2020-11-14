using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CuestionarioConectarConCliente
    {
        public ConexionBD conexion;

        public CuestionarioConectarConCliente(ConexionBD con)
        {
            this.conexion = con;
        }

        public int GuardarCuestionarioConectarConCliente(
            int IDHistoricoVisita,
            string NuevoDato)
        {
            return this.conexion.GenericIntScalarQuery("GuardarCuestionarioConectarConCliente", new SqlParameter[]
                {
                    new SqlParameter("@IDHistoricoVisita", SqlDbType.Int) { Value = IDHistoricoVisita },
                    new SqlParameter("@NuevoDato", SqlDbType.VarChar) { Value = NuevoDato }
                });
        }

    }
}
