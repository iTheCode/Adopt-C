using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Adopt_CSharp
{
    public partial class Panel : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private int id_usuario;

        BaseDeDatos bd = new BaseDeDatos();
        public Panel(int id_usuario)
        {
            this.id_usuario = id_usuario;
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
            Setear(0, 0);
            Setear(0, 1);
            Setear(0, 2);
            Setear(0, 3);
            Setear(0, 4);

            string nombre = bd.selectstring("select nombre from login where id_usuario = '" + id_usuario + "'");
            string apellido = bd.selectstring("select apellido from login where id_usuario = '" + id_usuario + "'");
            string image = bd.selectstring("select img from login where id_usuario = '" + id_usuario + "'");
            pictureBox36.Image = Base64ToImage(image);
            materialLabel16.Text = nombre + " " + apellido;


        }
        private void Ver_Perfil(int num_perfil)
        {
            this.Hide();
            //Editar_Mascota e = new Editar_Mascota(this.id_usuario, num_perfil);
            //e.txtnombre.Text = nombre;
            //e.txtraza.Text = raza;
            //e.txtedad.Text = edad;
            //e.txtcategoria.Text = tipo;
            //e.txtubicacion.Text = ubicacion;
            //e.txthistoria.Text = historia;
            //e.pictureBox4.Image = Base64ToImage(img);
            //e.pictureBox5.Image = Base64ToImage(img);
            //e.Show();
            Perfil_Mascota p = new Perfil_Mascota(this.id_usuario, num_perfil);
            string nombre = bd.selectstring("select nombre from animales where id_animales = " + num_perfil + "");
            string raza = bd.selectstring("select raza from animales where id_animales = " + num_perfil + "");
            string edad = bd.selectstring("select edad from animales where id_animales = " + num_perfil + "");
            string tipo = bd.selectstring("select tipo from animales where id_animales = " + num_perfil + "");
            string ubicacion = bd.selectstring("select ubicacion from animales where id_animales = " + num_perfil + "");
            string historia = bd.selectstring("select informacion from animales where id_animales = " + num_perfil + "");
            string img = bd.selectstring("select img from animales where id_animales = " + num_perfil + "");
            p.Text = "        "+nombre;
            p.lblcategoria.Text = tipo;
            p.lbledad.Text = edad;
            p.lblnombre.Text = nombre;
            p.lblraza.Text = raza;
            p.lblubicacion.Text = ubicacion;
            p.lblhistoria.Text = historia;
            p.pictureBox4.Image = Base64ToImage(img);
            p.pictureBox5.Image = Base64ToImage(img);

            p.Show();
        }
        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        private string[][] Consultar(int pagina, int tipo)
        {

            string[] id = new string[3];
            string[] nombre = new string[3];
            string[] historia = new string[3];
            string[] img = new string[3];
            int inicio = (pagina * 3) + 1;
            if (tipo == 0) {
                int total = Int32.Parse(bd.selectstring("select count(*) from animales")) / 3;
                if (total == pagina && total % 3 != 0)
                {
                    if (total % 3 == 2) { inicio -= 1; } else if (total % 3 == 1) { inicio -=- 2; }
                }
                for (int i = 0; i < 3; i++)
                {
                    id[i] = bd.selectstring("SELECT id_animales FROM ( SELECT *, ROW_NUMBER() OVER (ORDER BY id_animales DESC) as row FROM animales ) as alias WHERE row =  " + (inicio + i ));
                    nombre[i] = bd.selectstring("select nombre from animales where id_animales = '" + id[i] + "'");
                    historia[i] = bd.selectstring("select informacion from animales where id_animales = '" + id[i] + "'");
                    img[i] = bd.selectstring("select img from animales where id_animales = '"+ id[i]+"'");

                }
            }
            else
            {
                int total = Int32.Parse(bd.selectstring("select count(*) from animales where tipo = '" + tipo + "'")) / 3;
                if (total == pagina && total % 3 != 0)
                {
                    if (total % 3 == 2) { inicio -= 1; } else if (total % 3 == 1) { inicio -= 2; }
                }
                for (int i = 0; i < 3; i++)
                {
                    id[i] = bd.selectstring("SELECT id_animales FROM ( SELECT *, ROW_NUMBER() OVER (ORDER BY id_animales DESC) as row FROM animales WHERE tipo = " + tipo + ") as alias WHERE row =  " + (inicio + i));
                    nombre[i] = bd.selectstring("select nombre from animales where id_animales = '" + id[i] + "'");
                    historia[i] = bd.selectstring("select informacion from animales where id_animales = '" + id[i] + "'");
                    img[i] = bd.selectstring("select img from animales where id_animales = '" + id[i] + "'");

                }
            }

            string[][] datos = new string[][] { nombre, historia, id, img };

            return datos;

        }

        private void pictureBox9_Click_2(object sender, EventArgs e)
        {
            //Ocultar Tablero
            pictureBox9.Hide();
            pictureBox3.Show();
            materialTabSelector1.Hide();
            materialTabSelector1.Visible = false;
            materialTabControl1.Visible = false;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            pictureBox35.Visible = false;
            pictureBox36.Visible = false;
            materialLabel16.Visible = false;
            materialFlatButton2.Visible = false;
            materialFlatButton3.Visible = false;
            materialFlatButton4.Visible = false;
            materialDivider1.Visible = false;
            materialFlatButton5.Visible = false;
            materialFlatButton6.Visible = false;
            materialFlatButton7.Visible = false;
            materialDivider2.Visible = false;
            pictureBox34.Visible = false;
            pictureBox37.Visible = false;
            pictureBox1.Visible = true;

            pictureBox9.Show();
            pictureBox3.Hide();
            // Mostrar tablero
            materialTabSelector1.Show();
            materialTabSelector1.Visible = true;
            materialTabControl1.Visible = true;

        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agregar_Mascota add = new Agregar_Mascota(this.id_usuario);
            add.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox35.Visible = true;
            pictureBox36.Visible = true;
            materialLabel16.Visible = true;
            int tipo = Int32.Parse(bd.selectstring("select tipo from login where id_usuario = '" + this.id_usuario + "'"));
            if (tipo != 0)
            {
                materialFlatButton2.Visible = true;
            }
            materialFlatButton3.Visible = true;
            materialFlatButton4.Visible = true;
            materialDivider1.Visible = true;
            materialFlatButton5.Visible = true;
            materialFlatButton6.Visible = true;
            materialFlatButton7.Visible = true;
            materialDivider2.Visible = true;
            pictureBox34.Visible = true;
            pictureBox37.Visible = true;
            pictureBox1.Visible = false;
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {

            pictureBox35.Visible = false;
            pictureBox36.Visible = false;
            materialLabel16.Visible = false;
            materialFlatButton2.Visible = false;
            materialFlatButton3.Visible = false;
            materialFlatButton4.Visible = false;
            materialDivider1.Visible = false;
            materialFlatButton5.Visible = false;
            materialFlatButton6.Visible = false;
            materialFlatButton7.Visible = false;
            materialDivider2.Visible = false;
            pictureBox34.Visible = false;
            pictureBox37.Visible = false;
            pictureBox1.Visible = true;
        }

        private void materialFlatButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
        private void Setear(int pagina, int tipo)
        {
            string[][] datos = Consultar(pagina, tipo);

            switch (tipo)
            {
                case 0:
                    {
                        materialLabel1.Text = datos[0][0];
                        label1.Text = datos[1][0];
                        textBox1.Text = datos[2][0];
                        pictureBox6.Image = Base64ToImage(datos[3][0]);

                        materialLabel2.Text = datos[0][1];
                        label2.Text = datos[1][1];
                        textBox2.Text = datos[2][1];
                        pictureBox7.Image = Base64ToImage(datos[3][1]);

                        materialLabel3.Text = datos[0][2];
                        label3.Text = datos[1][2];
                        textBox3.Text = datos[2][2];
                        pictureBox8.Image = Base64ToImage(datos[3][2]);
                        break;
                    }
                case 1:
                    {
                        materialLabel4.Text = datos[0][0];
                        label4.Text = datos[1][0];
                        textBox4.Text = datos[2][0];
                        pictureBox10.Image = Base64ToImage(datos[3][0]);

                        materialLabel5.Text = datos[0][1];
                        label5.Text = datos[1][1];
                        textBox5.Text = datos[2][1];
                        pictureBox12.Image = Base64ToImage(datos[3][1]);

                        materialLabel6.Text = datos[0][2];
                        label6.Text = datos[1][2];
                        textBox6.Text = datos[2][2];
                        pictureBox13.Image = Base64ToImage(datos[3][2]);
                        break;
                    }
                case 2:
                    {
                        materialLabel7.Text = datos[0][0];
                        label7.Text = datos[1][0];
                        textBox7.Text = datos[2][0];
                        pictureBox16.Image = Base64ToImage(datos[3][0]);

                        materialLabel8.Text = datos[0][1];
                        label8.Text = datos[1][1];
                        textBox8.Text = datos[2][1];
                        pictureBox18.Image = Base64ToImage(datos[3][1]);

                        materialLabel9.Text = datos[0][2];
                        label9.Text = datos[1][2];
                        textBox9.Text = datos[2][2];
                        pictureBox19.Image = Base64ToImage(datos[3][2]);
                        break;
                    }
                case 3:
                    {
                        materialLabel10.Text = datos[0][0];
                        label10.Text = datos[1][0];
                        textBox10.Text = datos[2][0];
                        pictureBox22.Image = Base64ToImage(datos[3][0]);

                        materialLabel11.Text = datos[0][1];
                        label11.Text = datos[1][1];
                        textBox11.Text = datos[2][1];
                        pictureBox24.Image = Base64ToImage(datos[3][1]);

                        materialLabel12.Text = datos[0][2];
                        label12.Text = datos[1][2];
                        textBox12.Text = datos[2][2];
                        pictureBox25.Image = Base64ToImage(datos[3][2]);
                        break;
                    }
                case 4:
                    {
                        materialLabel13.Text = datos[0][0];
                        label13.Text = datos[1][0];
                        textBox13.Text = datos[2][0];
                        pictureBox28.Image = Base64ToImage(datos[3][0]);

                        materialLabel14.Text = datos[0][1];
                        label14.Text = datos[1][1];
                        textBox14.Text = datos[2][1];
                        pictureBox30.Image = Base64ToImage(datos[3][1]);

                        materialLabel15.Text = datos[0][2];
                        label15.Text = datos[1][2];
                        textBox15.Text = datos[2][2];
                        pictureBox31.Image = Base64ToImage(datos[3][2]);
                        break;
                    }

            }
        }
        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            //Consultar Todos - Incrementando
            int pagina = Int32.Parse(materialSingleLineTextField1.Text)+1;
            int total = Int32.Parse(bd.selectstring("select count(*) from animales")) / 3;
            if ( pagina >= total)
            {
                MessageBox.Show("Usted se encuentra en la última página.");
            }else
            {
                Setear(pagina, 0);
                materialSingleLineTextField1.Text = Convert.ToString(pagina);
            }


        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {

            //Consultar Todos - Disminuyendo
            int pagina = Int32.Parse(materialSingleLineTextField1.Text) - 1;
            if (pagina < 0)
            {
                MessageBox.Show("Usted se encuentra en la primera página.");
            }
            else
            {
                Setear(pagina, 0);
                materialSingleLineTextField1.Text = Convert.ToString(pagina);
            }


        }

        private void materialRaisedButton18_Click(object sender, EventArgs e)
        {
            //Consultar Perros - Incrementando
            int pagina = Int32.Parse(textBox16.Text)+1;
            int total = Int32.Parse(bd.selectstring("select count(*) from animales where tipo = '1'")) / 3;
            if (pagina >= total)
            {
                MessageBox.Show("Usted se encuentra en la última página.");
            }
            else
            {
                Setear(pagina, 1);
                textBox16.Text = Convert.ToString(pagina);
            }

        }

        private void materialRaisedButton19_Click(object sender, EventArgs e)
        {
            //Consultar Perros - Disminuyendo
            int pagina = Int32.Parse(textBox16.Text)-1;
            if (pagina < 0)
            {
                MessageBox.Show("Usted se encuentra en la primera página.");
            }
            else
            {
                Setear(pagina, 1);
                textBox16.Text = Convert.ToString(pagina);
            }
        }

        private void materialRaisedButton20_Click(object sender, EventArgs e)
        {
            //Consultar Gatos - Incrementando
            int pagina = Int32.Parse(textBox17.Text)+1;
            int total = Int32.Parse(bd.selectstring("select count(*) from animales where tipo = '2'")) / 3;
            if (pagina >= total)
            {
                MessageBox.Show("Usted se encuentra en la última página.");
            }
            else
            {
                Setear(pagina, 2);
                textBox17.Text = Convert.ToString(pagina);
            }

        }

        private void materialRaisedButton21_Click(object sender, EventArgs e)
        {
            //Consultar Gatos - Disminuyendo
            int pagina = Int32.Parse(textBox17.Text)-1;
            if (pagina < 0)
            {
                MessageBox.Show("Usted se encuentra en la primera página.");
            }
            else
            {
                Setear(pagina, 2);
                textBox17.Text = Convert.ToString(pagina);
            }

        }

        private void materialRaisedButton22_Click(object sender, EventArgs e)
        {
            //Consultar Aves - Incrementando
            int pagina = Int32.Parse(textBox18.Text)+1;
            int total = Int32.Parse(bd.selectstring("select count(*) from animales where tipo = '3'")) / 3;
            if (pagina >= total)
            {
                MessageBox.Show("Usted se encuentra en la última página.");
            }
            else
            {
                Setear(pagina, 3);
                textBox18.Text = Convert.ToString(pagina);
            }

        }

        private void materialRaisedButton23_Click(object sender, EventArgs e)
        {
            //Consultar Aves - Disminuyendo
            int pagina = Int32.Parse(textBox18.Text)-1;
            if (pagina < 0)
            {
                MessageBox.Show("Usted se encuentra en la primera página.");
            }
            else
            {
                Setear(pagina, 3);
                textBox18.Text = Convert.ToString(pagina);
            }

        }

        private void materialRaisedButton24_Click(object sender, EventArgs e)
        {
            //Consultar Otros - Incrementando
            int pagina = Int32.Parse(textBox19.Text)+1;
            int total = Int32.Parse(bd.selectstring("select count(*) from animales where tipo = '4'")) / 3;
            if (pagina >= total)
            {
                MessageBox.Show("Usted se encuentra en la última página.");
            }
            else
            {
                Setear(pagina, 4);
                textBox19.Text = Convert.ToString(pagina);
            }

        }

        private void materialRaisedButton25_Click(object sender, EventArgs e)
        {
            //Consultar Otros - Disminuyendo
            int pagina = Int32.Parse(textBox19.Text)-1;
            if (pagina < 0)
            {
                MessageBox.Show("Usted se encuentra en la primera página.");
            }
            else
            {
                Setear(pagina, 4);
                textBox19.Text = Convert.ToString(pagina);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Ver_Perfil(Int32.Parse(textBox1.Text));
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

            Ver_Perfil(Int32.Parse(textBox2.Text));
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {

            Ver_Perfil(Int32.Parse(textBox3.Text));
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {

            Ver_Perfil(Int32.Parse(textBox4.Text));
        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {

            Ver_Perfil(Int32.Parse(textBox5.Text));
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {

            Ver_Perfil(Int32.Parse(textBox6.Text));
        }

        private void materialRaisedButton9_Click(object sender, EventArgs e)
        {

            Ver_Perfil(Int32.Parse(textBox7.Text));
        }

        private void materialRaisedButton11_Click(object sender, EventArgs e)
        {

            Ver_Perfil(Int32.Parse(textBox8.Text));
        }

        private void materialRaisedButton10_Click(object sender, EventArgs e)
        {

            Ver_Perfil(Int32.Parse(textBox9.Text));
        }

        private void materialRaisedButton12_Click(object sender, EventArgs e)
        {

            Ver_Perfil(Int32.Parse(textBox10.Text));
        }

        private void materialRaisedButton14_Click(object sender, EventArgs e)
        {

            Ver_Perfil(Int32.Parse(textBox11.Text));
        }

        private void materialRaisedButton13_Click(object sender, EventArgs e)
        {

            Ver_Perfil(Int32.Parse(textBox12.Text));
        }

        private void materialRaisedButton15_Click(object sender, EventArgs e)
        {

            Ver_Perfil(Int32.Parse(textBox13.Text));
        }

        private void materialRaisedButton17_Click(object sender, EventArgs e)
        {

            Ver_Perfil(Int32.Parse(textBox14.Text));
        }

        private void materialRaisedButton16_Click(object sender, EventArgs e)
        {

            Ver_Perfil(Int32.Parse(textBox15.Text));
        }
    }
}
