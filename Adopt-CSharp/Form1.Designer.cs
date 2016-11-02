using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace Adopt_CSharp
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtusu = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcontra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(30, 195);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Usuario";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(30, 241);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(86, 19);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Contraseña";
            // 
            // txtusu
            // 
            this.txtusu.BackColor = System.Drawing.Color.White;
            this.txtusu.Depth = 0;
            this.txtusu.Hint = "";
            this.txtusu.Location = new System.Drawing.Point(156, 191);
            this.txtusu.MaxLength = 32767;
            this.txtusu.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtusu.Name = "txtusu";
            this.txtusu.PasswordChar = '\0';
            this.txtusu.SelectedText = "";
            this.txtusu.SelectionLength = 0;
            this.txtusu.SelectionStart = 0;
            this.txtusu.Size = new System.Drawing.Size(118, 23);
            this.txtusu.TabIndex = 20;
            this.txtusu.TabStop = false;
            this.txtusu.UseSystemPasswordChar = false;
            // 
            // txtcontra
            // 
            this.txtcontra.Depth = 0;
            this.txtcontra.Hint = "";
            this.txtcontra.Location = new System.Drawing.Point(156, 237);
            this.txtcontra.MaxLength = 32767;
            this.txtcontra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.PasswordChar = '*';
            this.txtcontra.SelectedText = "";
            this.txtcontra.SelectionLength = 0;
            this.txtcontra.SelectionStart = 0;
            this.txtcontra.Size = new System.Drawing.Size(118, 23);
            this.txtcontra.TabIndex = 21;
            this.txtcontra.TabStop = false;
            this.txtcontra.UseSystemPasswordChar = false;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(156, 306);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(93, 36);
            this.materialFlatButton2.TabIndex = 22;
            this.materialFlatButton2.Text = "REGISTRAR";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(52, 306);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(86, 36);
            this.materialRaisedButton1.TabIndex = 23;
            this.materialRaisedButton1.Text = "Ingresar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(318, 357);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(318, 357);
            this.MinimumSize = new System.Drawing.Size(318, 357);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialLabel materialLabel1;
        private MaterialLabel materialLabel2;
        private MaterialSingleLineTextField txtusu;
        private MaterialSingleLineTextField txtcontra;
        private MaterialFlatButton materialFlatButton2;
        private MaterialRaisedButton materialRaisedButton1;
        private PictureBox pictureBox1;
    }
}

