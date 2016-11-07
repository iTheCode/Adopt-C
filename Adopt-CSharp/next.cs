using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adopt_CSharp
{
    public partial class next : Form
    {
        public next()
        {
            InitializeComponent();
        }
        BaseDeDatos am = new BaseDeDatos();
        private void guardar_Click(object sender, EventArgs e)
        {
            string agregar = " insert into nose(nose) values ('" + txtnombre.Text + "')";
            if (am.executecommand(agregar))
            {
                MessageBox.Show("porfavor envia ");
            }
            else
            {
                MessageBox.Show("mierda");
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
