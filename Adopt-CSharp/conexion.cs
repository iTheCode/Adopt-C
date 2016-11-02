using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adopt_CSharp
{
    class conexion
    {
        public string ccon;
        protected string sql;
        protected int res;
        protected SqlConnection con;
        protected SqlCommand comando;
        protected string mensaje;

        public void Conexion()
        {
            this.ccon = (@"server=RICARDO-PC\SQLEXPRESS; Initial Catalog = BD_adopt; Integrated Security=True;");
            this.con = new SqlConnection(this.ccon);
        }

        public string Mensaje
        {
            get
            {
                return this.mensaje;
            }
        }
    }
}
