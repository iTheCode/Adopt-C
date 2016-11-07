using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Adopt_CSharp
{
    public partial class Editar_Mascota : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private int id_usuario, id_animal;
        private string imagen, image64;
        public Editar_Mascota(int id_usuario, int id_animal)
        {
            this.id_usuario = id_usuario;
            this.id_animal = id_animal;
            InitializeComponent();            
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);

        }
        BaseDeDatos bd = new BaseDeDatos();

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
        public string ImageToBase64(Image image, ImageFormat format)
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
        private void Editar_Mascota_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel p = new Panel(this.id_usuario);
            p.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    imagen = openFileDialog2.FileName;
                    pictureBox4.Image = Image.FromFile(imagen);
                    pictureBox5.Image = Image.FromFile(imagen);

                    ImageFormat thisFormat = pictureBox4.Image.RawFormat;

                    image64 = ImageToBase64(pictureBox4.Image, thisFormat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string modificar = "update animales set nombre ='" + txtnombre.Text + "',raza='" + txtraza.Text + "',edad=" + txtedad.Text + ",tipo='" + txtcategoria.Text + "',informacion='" + txthistoria.Text + "',ubicacion='" + txtubicacion.Text + "' where id = " + id_animal + "";
            string modificar_image = "update img set img ='" + image64 + "' where id_animales = '" + id_animal + "'";
            if (bd.executecommand(modificar) && bd.executecommand(modificar_image))
            {
                MessageBox.Show("modificado");
                Perfil_Mascota p = new Perfil_Mascota(this.id_usuario,this.id_animal);
                p.lblnombre.Text = txtnombre.Text;
                p.lblraza.Text = txtraza.Text;
                p.lbledad.Text = txtedad.Text;
                p.lblcategoria.Text = txtcategoria.Text;
                p.lblubicacion.Text = txtubicacion.Text;
                p.pictureBox4.Image = Image.FromFile(imagen);
                p.pictureBox5.Image = Image.FromFile(imagen);
            
                p.Show();               
                this.Hide();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

    }
}
