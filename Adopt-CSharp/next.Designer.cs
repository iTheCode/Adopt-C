namespace Adopt_CSharp
{
    partial class next
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
            this.guardar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtnose = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(50, 228);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(78, 30);
            this.guardar.TabIndex = 0;
            this.guardar.Text = "button1";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(37, 63);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(219, 20);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // txtnose
            // 
            this.txtnose.Location = new System.Drawing.Point(37, 126);
            this.txtnose.Name = "txtnose";
            this.txtnose.Size = new System.Drawing.Size(100, 20);
            this.txtnose.TabIndex = 2;
            // 
            // next
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 386);
            this.Controls.Add(this.txtnose);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.guardar);
            this.Name = "next";
            this.Text = "next";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtnose;
    }
}