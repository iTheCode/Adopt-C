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

namespace Adopt_CSharp
{
    public partial class Perfil_Mascota : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private int id_usuario, id_animal;
        public Perfil_Mascota(int id_usuario, int id_animal)
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
        private void Perfil_Mascota_Load(object sender, EventArgs e)
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel p = new Panel(this.id_usuario);
            p.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void lblnombre_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Editar_Mascota ed = new Editar_Mascota(this.id_usuario, this.id_animal);
            string nombre = bd.selectstring("select nombre from animales where id_animales = " + this.id_animal + "");
            string raza = bd.selectstring("select raza from animales where id_animales = " + this.id_animal + "");
            string edad = bd.selectstring("select edad from animales where id_animales = " + this.id_animal + "");
            string tipo = bd.selectstring("select tipo from animales where id_animales = " + this.id_animal + "");
            string ubicacion = bd.selectstring("select ubicacion from animales where id_animales = " + this.id_animal + "");
            string historia = bd.selectstring("select informacion from animales where id_animales = " + this.id_animal + "");
            string img = bd.selectstring("select img from animales where id_animales = " + this.id_animal + "");
            ed.Text = "        " + nombre;
            ed.txtnombre.Text = nombre;
            ed.txtraza.Text = raza;
            ed.txtedad.Text = edad;
            ed.txtcategoria.Text = tipo;
            ed.txtubicacion.Text = ubicacion;
            ed.txthistoria.Text = historia;
            ed.pictureBox4.Image = Base64ToImage(img);
            ed.pictureBox5.Image = Base64ToImage(img);
            ed.Show();
        }
    }
}
