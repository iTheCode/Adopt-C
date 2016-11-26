using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace Adopt_CSharp
{
    public partial class Registro : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        String genero;
        public Registro()
        {
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
            
        }

        BaseDeDatos bd = new BaseDeDatos();
        private string imagen;
        private string image64;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
        private void Registro_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //fecha = Convert.ToDateTime(dateTimePicker1.Text);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imagen = openFileDialog1.FileName;
                    pictureBox5.Image = Image.FromFile(imagen);

                    ImageFormat thisFormat = pictureBox5.Image.RawFormat;

                    image64 = ImageToBase64(pictureBox5.Image, thisFormat);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }

        }
        private void materialSingleLineTextField6_Click(object sender, EventArgs e)
        {

        }

        private void materialContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void materialCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if(txtapellido.MaxLength>50 || txtnombre.MaxLength>50)
            {
                MessageBox.Show("Cantidad de Caracteres excedida!");
                txtcontra.Clear();
                txtccontra.Clear();
                txtapellido.Clear();
                txtnombre.Clear();
                txtusu.Clear();
            }
            else
            {
                string usuario = bd.selectstring("select  usuario from login where usuario = '" + txtusu.Text + "'");
                if (usuario==txtusu.Text)
                {
                    MessageBox.Show("Este Usuario ya ha sido registrado, porfavor elija otro nombre de usuario.");
                }
                else { 
                    if (rbnfem.Checked)
                    {
                        genero = "femenino";
                    }
                    if (rbnmas.Checked)
                    {
                        genero = "masculino";
                    }
                    if(image64 == null)
                    {
                        MessageBox.Show("Porfavor debe usar una imagen como muestra de su perfil, selecciona una imagen.");
                    }
                    encriptar en = new encriptar();
                    DateTime d=Convert.ToDateTime(dateTimePicker1.Text);
                    string agregar = "insert login (usuario, contraseña, nombre, apellido, genero, fech, img) values ('" + txtusu.Text + "','" + en.encripta(txtcontra.Text) + "','" + txtnombre.Text + "','" +
                    txtapellido.Text + "','" + genero + "','" + d + "','" + image64 + "')";

                    if (txtcontra.Text == txtccontra.Text & CheckBox1.Checked == true)
                    {
                        if (bd.executecommand(agregar))
                        {
                            MessageBox.Show("Usted ha sido registrado correctamente, está apto para Adoptar.");
                            this.Hide();
                            Login l = new Login();
                            l.Show();

                        }
                        else
                        {
                            MessageBox.Show("Error al agregar, porfavor reporte su error para solucionarlo.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden o los términos no han sido aceptados.");
                        txtcontra.Clear();
                        txtccontra.Clear();
                    }
                }
            }
        }

        private void rbnfem_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void rbnmas_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Al aceptar nuestros Términos y Condiciones usted acepta ser una persona responsable y está en disposición legal de aceptar una futura adopción de una mascota, en caso de ser procesado usted afirma su responsabilidad previa coordinación con ambas partes.");
        }

    }
}
