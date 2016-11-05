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
    }
}
