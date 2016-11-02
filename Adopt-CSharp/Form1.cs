using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Adopt_CSharp
{
    public partial class Login : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Login()
        {
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        

        private void txtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            try
            {
                //creando la conexion
                //SqlConnection con = new SqlConnection(@"server=RICARDO-PC\SQLEXPRESS; Initial Catalog = BD_adopt; Integrated Security=True;");
                //abriendo conexion
                //con.Open();
                //SqlCommand comando = new SqlCommand("select nombre, apellido from cliente where nombre = '" + txtUsuario.Text + "'And apellido = '" + txtContraseña.Text + "' ", con);
                //ejecuta una instruccion de sql devolviendo el numero de las filas afectadas
                //comando.ExecuteNonQuery();
                //DataSet ds = new DataSet();
                //SqlDataAdapter da = new SqlDataAdapter(comando);
                ////Llenando el dataAdapter
                //da.Fill(ds, "cliente");
                ////utilizado para representar una fila de la tabla q necesitas en este caso usuario
                //DataRow DR;
                //DR = ds.Tables["cliente"].Rows[0];
                ////evaluando que la contraseña y usuario sean correctos
                //if ((txtUsuario.Text == DR["nombre"].ToString()) || (txtContraseña.Text == DR["apellido"].ToString()))
                //{
                //    //abriendo el formulario principal
                //    Panel p= new Panel();
                //    p.Show();
                //    this.Hide();//esto sirve para ocultar el formulario de login
                //}
            }
            catch
            {
                //en caso que la contraseña sea erronea mostrara un mensaje
                MessageBox.Show("Error! Su contraseña y/o usuario son invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro r = new Registro();
            r.Show();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel p = new Panel();
            p.Show();
        }
    }
}
