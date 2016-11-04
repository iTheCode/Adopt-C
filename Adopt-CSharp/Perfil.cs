using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Adopt_CSharp
{
    public partial class Perfil : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Perfil()
        {
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
        }


    private void perfil_mascota_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel p = new Panel();
            p.Show();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    }
}
