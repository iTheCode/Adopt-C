using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopt_CSharp
{
    class usuarios:conexion
    {
        private String usuario;
        private string contraseña;

        public usuarios()
        {
            usuario = string.Empty;
            contraseña = string.Empty;
            this.sql = string.Empty;
        }

        public string Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }

        public string Contraseña
        {
            get { return this.contraseña; }
            set { this.contraseña = value; }
        }

        public bool Buscar()
        {
            bool res = false;
            this.sql = string.Format(@"select id_cliente from nombre where NickName='{0}' and Contraseña='{1}'",this.usuario,this.contraseña);
            this.comansql = new System.Data.SqlClient.SqlCommand(this.sql,this.cnn);
            this.cnn.Open();
            SqlDataReader reg = null;
            reg = this.comansql.ExecuteReader();
            if(reg.Read())
            {
                res = true;
                this.mensaje = "Bienvenido, Perrita!";
            }
            else
            {
                this.mensaje = "Datos incorrectos, no seas pendejo";
            }
            this.cnn.Close();
            return res;
        }
    }
}
