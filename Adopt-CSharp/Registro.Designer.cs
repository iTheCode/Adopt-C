namespace Adopt_CSharp
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtnombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtapellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtusu = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcontra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtccontra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.rbnmas = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbnfem = new MaterialSkin.Controls.MaterialRadioButton();
            this.CheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 351);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 308);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "Apellidos";
            // 
            // txtnombre
            // 
            this.txtnombre.Depth = 0;
            this.txtnombre.Hint = "";
            this.txtnombre.Location = new System.Drawing.Point(169, 260);
            this.txtnombre.MaxLength = 32767;
            this.txtnombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PasswordChar = '\0';
            this.txtnombre.SelectedText = "";
            this.txtnombre.SelectionLength = 0;
            this.txtnombre.SelectionStart = 0;
            this.txtnombre.Size = new System.Drawing.Size(173, 23);
            this.txtnombre.TabIndex = 22;
            this.txtnombre.TabStop = false;
            this.txtnombre.UseSystemPasswordChar = false;
            // 
            // txtapellido
            // 
            this.txtapellido.Depth = 0;
            this.txtapellido.Hint = "";
            this.txtapellido.Location = new System.Drawing.Point(169, 304);
            this.txtapellido.MaxLength = 32767;
            this.txtapellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.PasswordChar = '\0';
            this.txtapellido.SelectedText = "";
            this.txtapellido.SelectionLength = 0;
            this.txtapellido.SelectionStart = 0;
            this.txtapellido.Size = new System.Drawing.Size(173, 23);
            this.txtapellido.TabIndex = 23;
            this.txtapellido.TabStop = false;
            this.txtapellido.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(41, 634);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(99, 36);
            this.materialRaisedButton1.TabIndex = 32;
            this.materialRaisedButton1.Text = "confirmar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(223, 634);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(91, 36);
            this.materialFlatButton1.TabIndex = 33;
            this.materialFlatButton1.Text = "cancelar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // txtusu
            // 
            this.txtusu.Depth = 0;
            this.txtusu.Hint = "";
            this.txtusu.Location = new System.Drawing.Point(169, 421);
            this.txtusu.MaxLength = 32767;
            this.txtusu.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtusu.Name = "txtusu";
            this.txtusu.PasswordChar = '\0';
            this.txtusu.SelectedText = "";
            this.txtusu.SelectionLength = 0;
            this.txtusu.SelectionStart = 0;
            this.txtusu.Size = new System.Drawing.Size(173, 23);
            this.txtusu.TabIndex = 34;
            this.txtusu.TabStop = false;
            this.txtusu.UseSystemPasswordChar = false;
            // 
            // txtcontra
            // 
            this.txtcontra.Depth = 0;
            this.txtcontra.Hint = "";
            this.txtcontra.Location = new System.Drawing.Point(169, 461);
            this.txtcontra.MaxLength = 32767;
            this.txtcontra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.PasswordChar = '*';
            this.txtcontra.SelectedText = "";
            this.txtcontra.SelectionLength = 0;
            this.txtcontra.SelectionStart = 0;
            this.txtcontra.Size = new System.Drawing.Size(173, 23);
            this.txtcontra.TabIndex = 35;
            this.txtcontra.TabStop = false;
            this.txtcontra.UseSystemPasswordChar = false;
            // 
            // txtccontra
            // 
            this.txtccontra.Depth = 0;
            this.txtccontra.Hint = "";
            this.txtccontra.Location = new System.Drawing.Point(169, 500);
            this.txtccontra.MaxLength = 32767;
            this.txtccontra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtccontra.Name = "txtccontra";
            this.txtccontra.PasswordChar = '*';
            this.txtccontra.SelectedText = "";
            this.txtccontra.SelectionLength = 0;
            this.txtccontra.SelectionStart = 0;
            this.txtccontra.Size = new System.Drawing.Size(173, 23);
            this.txtccontra.TabIndex = 36;
            this.txtccontra.TabStop = false;
            this.txtccontra.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 264);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 37;
            this.materialLabel2.Text = "Nombres";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 351);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(151, 19);
            this.materialLabel3.TabIndex = 38;
            this.materialLabel3.Text = "Fecha de Nacimiento";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 387);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(57, 19);
            this.materialLabel4.TabIndex = 39;
            this.materialLabel4.Text = "Genero";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 425);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(61, 19);
            this.materialLabel5.TabIndex = 40;
            this.materialLabel5.Text = "Usuario";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(12, 504);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(157, 19);
            this.materialLabel6.TabIndex = 41;
            this.materialLabel6.Text = "Confirmar Contraseña";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(12, 465);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(86, 19);
            this.materialLabel7.TabIndex = 42;
            this.materialLabel7.Text = "Contraseña";
            // 
            // rbnmas
            // 
            this.rbnmas.AutoSize = true;
            this.rbnmas.Checked = true;
            this.rbnmas.Depth = 0;
            this.rbnmas.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbnmas.Location = new System.Drawing.Point(162, 387);
            this.rbnmas.Margin = new System.Windows.Forms.Padding(0);
            this.rbnmas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbnmas.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbnmas.Name = "rbnmas";
            this.rbnmas.Ripple = true;
            this.rbnmas.Size = new System.Drawing.Size(93, 30);
            this.rbnmas.TabIndex = 44;
            this.rbnmas.TabStop = true;
            this.rbnmas.Text = "Masculino";
            this.rbnmas.UseVisualStyleBackColor = true;
            this.rbnmas.CheckedChanged += new System.EventHandler(this.rbnmas_CheckedChanged);
            // 
            // rbnfem
            // 
            this.rbnfem.AutoSize = true;
            this.rbnfem.Depth = 0;
            this.rbnfem.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbnfem.Location = new System.Drawing.Point(262, 387);
            this.rbnfem.Margin = new System.Windows.Forms.Padding(0);
            this.rbnfem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbnfem.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbnfem.Name = "rbnfem";
            this.rbnfem.Ripple = true;
            this.rbnfem.Size = new System.Drawing.Size(90, 30);
            this.rbnfem.TabIndex = 45;
            this.rbnfem.Text = "Femenino";
            this.rbnfem.UseVisualStyleBackColor = true;
            this.rbnfem.CheckedChanged += new System.EventHandler(this.rbnfem_CheckedChanged);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Checked = true;
            this.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox1.Depth = 0;
            this.CheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckBox1.Location = new System.Drawing.Point(53, 567);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Ripple = true;
            this.CheckBox1.Size = new System.Drawing.Size(251, 30);
            this.CheckBox1.TabIndex = 46;
            this.CheckBox1.Text = "Acepta los Términos y Condiciones.";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(361, 682);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.rbnfem);
            this.Controls.Add(this.rbnmas);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtccontra);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(361, 682);
            this.MinimumSize = new System.Drawing.Size(361, 682);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtnombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtapellido;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtusu;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcontra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtccontra;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialRadioButton rbnmas;
        private MaterialSkin.Controls.MaterialRadioButton rbnfem;
        private MaterialSkin.Controls.MaterialCheckBox CheckBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}