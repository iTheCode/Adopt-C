using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.IO;

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

        BaseDeDatos bd = new BaseDeDatos();

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
           
        }
        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro r = new Registro();
            r.Show();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string usuario = bd.selectstring("select  usuario from login where usuario = '" + txtusu.Text + "'");
            string contraseña = bd.selectstring("select contraseña from login where contraseña = '" + txtcontra.Text + "'");
            int id_usuario = Int32.Parse(bd.selectstring("select id_usuario from login where usuario = '" + txtusu.Text + "'"));
            if (usuario == txtusu.Text && contraseña == txtcontra.Text)
            {
                string nombre = bd.selectstring("select nombre from login where usuario = '" + txtusu.Text + "'");
                string apellido = bd.selectstring("select apellido from login where usuario = '" + txtusu.Text + "'");
                string image = bd.selectstring("select img from login where usuario = '" + txtusu.Text + "'");
                Panel p = new Panel(id_usuario);
                p.pictureBox36.Image = Base64ToImage(image);
                p.materialLabel16.Text = nombre + " " + apellido;
                p.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El Usuario o Contraseña ingresados son incorrectos.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
