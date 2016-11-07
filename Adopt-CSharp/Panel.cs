using System;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Adopt_CSharp
{
    public partial class Panel : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private int id_usuario;

        public Panel(int id_usuario)
        {
            this.id_usuario = id_usuario;
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);

        }
        private void Ver_Perfil(int num_perfil)
        {
            this.Hide();
            Perfil_Mascota perfil = new Perfil_Mascota(this.id_usuario, num_perfil);
            perfil.Show();

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
            Agregar_Mascota add = new Agregar_Mascota(1);
            add.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox35.Visible = true;
            pictureBox36.Visible = true;
            materialLabel16.Visible = true;
            materialFlatButton2.Visible = true;
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
    }
}
