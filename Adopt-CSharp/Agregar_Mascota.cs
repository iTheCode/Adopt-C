using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using System.Data.SqlClient;
namespace Adopt_CSharp
{
    public partial class Agregar_Mascota : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private int id_usuario;

        public Agregar_Mascota(int id_usuario)
        {
            this.id_usuario = id_usuario;
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
        }
        BaseDeDatos am = new BaseDeDatos();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel p = new Panel(this.id_usuario);
            p.Show();
        }

        private void materialSingleLineTextField4_Click(object sender, EventArgs e)
        {

        }
        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            //Convertir Imagen a Base 64
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
     

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //Acá insertas al sql todo
            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("Debe completar el nombre");
                return;
            }
            if (string.IsNullOrEmpty(txtraza.Text))
            {
                MessageBox.Show("Debe completar el raza");
                return;
            }
            if (string.IsNullOrEmpty(txtedad.Text))
            {
                MessageBox.Show("Debe completar la edad");
                return;
            }
            if (string.IsNullOrEmpty(txtcategoria.Text))
            {
                MessageBox.Show("Debe completar la categoria");
                return;
            }
            if (string.IsNullOrEmpty(txthistoria.Text))
            {
                MessageBox.Show("Debe completar la historia");
                return;
            }
            if (string.IsNullOrEmpty(txtubicacion.Text))
            {
                MessageBox.Show("Debe completar la ubicacion");
                return;
            }
            else
            {
                string agregar = " insert into ani(nombre,raza,edad,categoria,historia,ubicacion) values ('" + txtnombre.Text + "','" + txtraza.Text + "'," + txtedad.Text + ",'" + txtcategoria.Text + "','" + txthistoria.Text + "','" + txtubicacion.Text + "')";
                if (am.executecommand(agregar))
                {
                    MessageBox.Show("mascota agregada");
                    Perfil_Mascota p = new Perfil_Mascota(1, 1);
                    p.lblnombre.Text = txtnombre.Text;
                    p.lblraza.Text = txtraza.Text;
                    p.lbledad.Text = txtedad.Text;
                    p.lblcategoria.Text = txtcategoria.Text;
                    p.lblubicacion.Text = txtubicacion.Text;
                    p.Show();
                }
                else
                {
                    MessageBox.Show("mierda");
                }
                this.Hide();
            }
            //Perfil_Mascota pe = new Perfil_Mascota(1,1);
            //txtnombre.Text=

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog2.FileName;
                    pictureBox4.Image = Image.FromFile(imagen);
                    pictureBox5.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            next ab = new next();
            ab.Show();
        }
    }
}
