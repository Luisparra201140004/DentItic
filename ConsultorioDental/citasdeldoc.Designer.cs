namespace ConsultorioDental
{
    partial class citasdeldoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(citasdeldoc));
            this.lbl1cd = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRATAMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SESION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn1CdDcerrar = new System.Windows.Forms.Button();
            this.panel1CP = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1CP.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1cd
            // 
            this.lbl1cd.AutoSize = true;
            this.lbl1cd.BackColor = System.Drawing.Color.Transparent;
            this.lbl1cd.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1cd.Location = new System.Drawing.Point(189, 47);
            this.lbl1cd.Name = "lbl1cd";
            this.lbl1cd.Size = new System.Drawing.Size(228, 25);
            this.lbl1cd.TabIndex = 0;
            this.lbl1cd.Text = "CITAS PROXIMAS";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.PACIENTE,
            this.TRATAMIENTO,
            this.HORA,
            this.SESION});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(42, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // PACIENTE
            // 
            this.PACIENTE.HeaderText = "PACIENTE";
            this.PACIENTE.Name = "PACIENTE";
            // 
            // TRATAMIENTO
            // 
            this.TRATAMIENTO.HeaderText = "TRATAMIENTO";
            this.TRATAMIENTO.Name = "TRATAMIENTO";
            // 
            // HORA
            // 
            this.HORA.HeaderText = "HORA";
            this.HORA.Name = "HORA";
            // 
            // SESION
            // 
            this.SESION.HeaderText = "SESION";
            this.SESION.Name = "SESION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(593, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(559, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btn1CdDcerrar
            // 
            this.btn1CdDcerrar.BackColor = System.Drawing.Color.White;
            this.btn1CdDcerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn1CdDcerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1CdDcerrar.Location = new System.Drawing.Point(475, 390);
            this.btn1CdDcerrar.Name = "btn1CdDcerrar";
            this.btn1CdDcerrar.Size = new System.Drawing.Size(75, 23);
            this.btn1CdDcerrar.TabIndex = 4;
            this.btn1CdDcerrar.Text = "Cerrar";
            this.btn1CdDcerrar.UseVisualStyleBackColor = false;
            // 
            // panel1CP
            // 
            this.panel1CP.BackColor = System.Drawing.Color.Transparent;
            this.panel1CP.Controls.Add(this.pictureBox2);
            this.panel1CP.Controls.Add(this.pictureBox1);
            this.panel1CP.Location = new System.Drawing.Point(0, -1);
            this.panel1CP.Name = "panel1CP";
            this.panel1CP.Size = new System.Drawing.Size(633, 30);
            this.panel1CP.TabIndex = 5;
            this.panel1CP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1CP_MouseDown);
            // 
            // citasdeldoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.panel1CP);
            this.Controls.Add(this.btn1CdDcerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl1cd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "citasdeldoc";
            this.Text = "citasdeldoc";
            this.Load += new System.EventHandler(this.citasdeldoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1CP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1cd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRATAMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SESION;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn1CdDcerrar;
        private System.Windows.Forms.Panel panel1CP;
    }
}