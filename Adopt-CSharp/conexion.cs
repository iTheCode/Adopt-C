using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopt_CSharp
{
    class conexion
    {
        public string cadenaconexion;
        protected string sql;
        protected int res;
        protected SqlConnection cnn;
        protected SqlCommand comansql;
        protected string mensaje;

        public conexion()
        {
            this.cadenaconexion = (@"Data Dource=RICARDO-PC\SQLEXPRESS; Initial catalog=BD_adopt; integrated security=true");
            this.cnn = new SqlConnection(this.cadenaconexion);
        } 
        public string Mensaje
        {
            get {
                return this.mensaje;
            }
        }

    }
}
