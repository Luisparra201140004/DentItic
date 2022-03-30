namespace ConsultorioDental
{
    partial class administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(administrador));
            this.leibel1 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.butt1 = new System.Windows.Forms.Button();
            this.pctreBoxcerrar = new System.Windows.Forms.PictureBox();
            this.pictureBminimizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctreBoxcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBminimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // leibel1
            // 
            this.leibel1.AutoSize = true;
            this.leibel1.BackColor = System.Drawing.Color.White;
            this.leibel1.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leibel1.ForeColor = System.Drawing.Color.DarkBlue;
            this.leibel1.Location = new System.Drawing.Point(100, 54);
            this.leibel1.Name = "leibel1";
            this.leibel1.Size = new System.Drawing.Size(172, 30);
            this.leibel1.TabIndex = 1;
            this.leibel1.Text = "Introduce tu ID";
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(122, 97);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(129, 20);
            this.txtBox1.TabIndex = 2;
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            this.txtBox1.Enter += new System.EventHandler(this.txtBox1_Enter);
            this.txtBox1.Leave += new System.EventHandler(this.txtBox1_Leave);
            // 
            // butt1
            // 
            this.butt1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt1.ForeColor = System.Drawing.Color.Black;
            this.butt1.Location = new System.Drawing.Point(122, 135);
            this.butt1.Name = "butt1";
            this.butt1.Size = new System.Drawing.Size(127, 37);
            this.butt1.TabIndex = 3;
            this.butt1.Text = "Aceptar";
            this.butt1.UseVisualStyleBackColor = true;
            // 
            // pctreBoxcerrar
            // 
            this.pctreBoxcerrar.Image = ((System.Drawing.Image)(resources.GetObject("pctreBoxcerrar.Image")));
            this.pctreBoxcerrar.Location = new System.Drawing.Point(340, 5);
            this.pctreBoxcerrar.Name = "pctreBoxcerrar";
            this.pctreBoxcerrar.Size = new System.Drawing.Size(23, 22);
            this.pctreBoxcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctreBoxcerrar.TabIndex = 4;
            this.pctreBoxcerrar.TabStop = false;
            this.pctreBoxcerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBminimizar
            // 
            this.pictureBminimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBminimizar.Image")));
            this.pictureBminimizar.Location = new System.Drawing.Point(311, 5);
            this.pictureBminimizar.Name = "pictureBminimizar";
            this.pictureBminimizar.Size = new System.Drawing.Size(23, 22);
            this.pictureBminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBminimizar.TabIndex = 5;
            this.pictureBminimizar.TabStop = false;
            this.pictureBminimizar.Click += new System.EventHandler(this.pictureBminimizar_Click);
            // 
            // administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(375, 184);
            this.Controls.Add(this.pictureBminimizar);
            this.Controls.Add(this.pctreBoxcerrar);
            this.Controls.Add(this.butt1);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.leibel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "administrador";
            this.Text = "administrador";
            ((System.ComponentModel.ISupportInitialize)(this.pctreBoxcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBminimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leibel1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button butt1;
        private System.Windows.Forms.PictureBox pctreBoxcerrar;
        private System.Windows.Forms.PictureBox pictureBminimizar;
    }
}