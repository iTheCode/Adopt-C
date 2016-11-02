using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace Adopt_CSharp
{
    public partial class Registro : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        String genero,fecha;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
            if (rbnfem.Checked)
            {
                genero = "femenino";
            }
            if (rbnmas.Checked)
            {
                genero = "masculino";
            }            
            string agregar = "insert login (usuario, contraseña, nombre, apellido, genero, fecha) values ('" + txtusu.Text + "','" + txtcontra.Text + "','" + txtnombre.Text + "','" +
            txtapellido.Text + "','" + genero + "','" + dateTimePicker1.Text+ "')";

            if(txtcontra.Text==txtccontra.Text & CheckBox1.Checked==true)
            {
                if (bd.executecommand(agregar))
                {
                    MessageBox.Show("Registro agregado correctamente");
                    this.Hide();
                    Login l = new Login();
                    l.Show();

                }
                else
                {
                    MessageBox.Show("Error al agregar");
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden o terminos no aceptados");
                txtcontra.Clear();
                txtccontra.Clear();
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
    }
}
