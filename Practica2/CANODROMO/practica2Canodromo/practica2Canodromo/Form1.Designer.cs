namespace practica2Canodromo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fondo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMayte = new System.Windows.Forms.Label();
            this.lblCarlos = new System.Windows.Forms.Label();
            this.lblAna = new System.Windows.Forms.Label();
            this.btnYA = new System.Windows.Forms.Button();
            this.btnApuesta = new System.Windows.Forms.Button();
            this.nudPerro = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblApostador = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMayte = new System.Windows.Forms.RadioButton();
            this.rbCarlos = new System.Windows.Forms.RadioButton();
            this.rbAna = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.perro1 = new System.Windows.Forms.PictureBox();
            this.perro2 = new System.Windows.Forms.PictureBox();
            this.perro3 = new System.Windows.Forms.PictureBox();
            this.perro4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perro3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perro4)).BeginInit();
            this.SuspendLayout();
            // 
            // fondo
            // 
            this.fondo.Image = ((System.Drawing.Image)(resources.GetObject("fondo.Image")));
            this.fondo.Location = new System.Drawing.Point(12, 12);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(600, 200);
            this.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fondo.TabIndex = 0;
            this.fondo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMayte);
            this.groupBox1.Controls.Add(this.lblCarlos);
            this.groupBox1.Controls.Add(this.lblAna);
            this.groupBox1.Controls.Add(this.btnYA);
            this.groupBox1.Controls.Add(this.btnApuesta);
            this.groupBox1.Controls.Add(this.nudPerro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudCantidad);
            this.groupBox1.Controls.Add(this.lblApostador);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 197);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Casa de Apuestas";
            // 
            // lblMayte
            // 
            this.lblMayte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMayte.Location = new System.Drawing.Point(248, 110);
            this.lblMayte.Name = "lblMayte";
            this.lblMayte.Size = new System.Drawing.Size(345, 20);
            this.lblMayte.TabIndex = 14;
            this.lblMayte.Text = "Apuesta de Mayte";
            // 
            // lblCarlos
            // 
            this.lblCarlos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarlos.Location = new System.Drawing.Point(248, 87);
            this.lblCarlos.Name = "lblCarlos";
            this.lblCarlos.Size = new System.Drawing.Size(345, 20);
            this.lblCarlos.TabIndex = 13;
            this.lblCarlos.Text = "Apuesta de Carlos";
            // 
            // lblAna
            // 
            this.lblAna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAna.Location = new System.Drawing.Point(248, 64);
            this.lblAna.Name = "lblAna";
            this.lblAna.Size = new System.Drawing.Size(345, 20);
            this.lblAna.TabIndex = 12;
            this.lblAna.Text = "Apuesta de Ana";
            // 
            // btnYA
            // 
            this.btnYA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYA.Location = new System.Drawing.Point(505, 162);
            this.btnYA.Name = "btnYA";
            this.btnYA.Size = new System.Drawing.Size(88, 23);
            this.btnYA.TabIndex = 11;
            this.btnYA.Text = "¡YA!";
            this.btnYA.UseVisualStyleBackColor = true;
            this.btnYA.Click += new System.EventHandler(this.btnYA_Click);
            // 
            // btnApuesta
            // 
            this.btnApuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApuesta.Location = new System.Drawing.Point(391, 162);
            this.btnApuesta.Name = "btnApuesta";
            this.btnApuesta.Size = new System.Drawing.Size(108, 23);
            this.btnApuesta.TabIndex = 10;
            this.btnApuesta.Text = "Apuesta";
            this.btnApuesta.UseVisualStyleBackColor = true;
            this.btnApuesta.Click += new System.EventHandler(this.btnApuesta_Click);
            // 
            // nudPerro
            // 
            this.nudPerro.Location = new System.Drawing.Point(315, 165);
            this.nudPerro.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudPerro.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPerro.Name = "nudPerro";
            this.nudPerro.Size = new System.Drawing.Size(40, 20);
            this.nudPerro.TabIndex = 9;
            this.nudPerro.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "euros en el galgo número";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(73, 165);
            this.nudCantidad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(40, 20);
            this.nudCantidad.TabIndex = 7;
            this.nudCantidad.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblApostador
            // 
            this.lblApostador.AutoSize = true;
            this.lblApostador.Location = new System.Drawing.Point(22, 167);
            this.lblApostador.Name = "lblApostador";
            this.lblApostador.Size = new System.Drawing.Size(36, 13);
            this.lblApostador.TabIndex = 6;
            this.lblApostador.Text = "Carlos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMayte);
            this.groupBox2.Controls.Add(this.rbCarlos);
            this.groupBox2.Controls.Add(this.rbAna);
            this.groupBox2.Location = new System.Drawing.Point(19, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 93);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // rbMayte
            // 
            this.rbMayte.AutoSize = true;
            this.rbMayte.Location = new System.Drawing.Point(6, 65);
            this.rbMayte.Name = "rbMayte";
            this.rbMayte.Size = new System.Drawing.Size(130, 17);
            this.rbMayte.TabIndex = 2;
            this.rbMayte.TabStop = true;
            this.rbMayte.Text = "Mayte tiene 100 euros";
            this.rbMayte.UseVisualStyleBackColor = true;
            this.rbMayte.CheckedChanged += new System.EventHandler(this.rbMayte_CheckedChanged);
            // 
            // rbCarlos
            // 
            this.rbCarlos.AutoSize = true;
            this.rbCarlos.Location = new System.Drawing.Point(6, 42);
            this.rbCarlos.Name = "rbCarlos";
            this.rbCarlos.Size = new System.Drawing.Size(130, 17);
            this.rbCarlos.TabIndex = 1;
            this.rbCarlos.TabStop = true;
            this.rbCarlos.Text = "Carlos tiene 100 euros";
            this.rbCarlos.UseVisualStyleBackColor = true;
            this.rbCarlos.CheckedChanged += new System.EventHandler(this.rbCarlos_CheckedChanged);
            // 
            // rbAna
            // 
            this.rbAna.AutoSize = true;
            this.rbAna.Location = new System.Drawing.Point(6, 19);
            this.rbAna.Name = "rbAna";
            this.rbAna.Size = new System.Drawing.Size(120, 17);
            this.rbAna.TabIndex = 0;
            this.rbAna.TabStop = true;
            this.rbAna.Text = "Ana tiene 100 euros";
            this.rbAna.UseVisualStyleBackColor = true;
            this.rbAna.CheckedChanged += new System.EventHandler(this.rbAna_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apuestas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apuesta Mínima: 5 euros";
            // 
            // perro1
            // 
            this.perro1.Image = ((System.Drawing.Image)(resources.GetObject("perro1.Image")));
            this.perro1.Location = new System.Drawing.Point(21, 28);
            this.perro1.Name = "perro1";
            this.perro1.Size = new System.Drawing.Size(75, 20);
            this.perro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.perro1.TabIndex = 2;
            this.perro1.TabStop = false;
            // 
            // perro2
            // 
            this.perro2.Image = ((System.Drawing.Image)(resources.GetObject("perro2.Image")));
            this.perro2.Location = new System.Drawing.Point(21, 83);
            this.perro2.Name = "perro2";
            this.perro2.Size = new System.Drawing.Size(75, 20);
            this.perro2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.perro2.TabIndex = 3;
            this.perro2.TabStop = false;
            // 
            // perro3
            // 
            this.perro3.Image = ((System.Drawing.Image)(resources.GetObject("perro3.Image")));
            this.perro3.Location = new System.Drawing.Point(21, 137);
            this.perro3.Name = "perro3";
            this.perro3.Size = new System.Drawing.Size(75, 20);
            this.perro3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.perro3.TabIndex = 4;
            this.perro3.TabStop = false;
            // 
            // perro4
            // 
            this.perro4.Image = ((System.Drawing.Image)(resources.GetObject("perro4.Image")));
            this.perro4.Location = new System.Drawing.Point(21, 188);
            this.perro4.Name = "perro4";
            this.perro4.Size = new System.Drawing.Size(75, 20);
            this.perro4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.perro4.TabIndex = 5;
            this.perro4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 427);
            this.Controls.Add(this.perro4);
            this.Controls.Add(this.perro3);
            this.Controls.Add(this.perro2);
            this.Controls.Add(this.perro1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Canódromo";
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perro3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perro4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fondo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMayte;
        private System.Windows.Forms.RadioButton rbCarlos;
        private System.Windows.Forms.RadioButton rbAna;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblApostador;
        private System.Windows.Forms.Button btnYA;
        private System.Windows.Forms.Button btnApuesta;
        private System.Windows.Forms.NumericUpDown nudPerro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox perro1;
        private System.Windows.Forms.PictureBox perro2;
        private System.Windows.Forms.PictureBox perro3;
        private System.Windows.Forms.PictureBox perro4;
        private System.Windows.Forms.Label lblMayte;
        private System.Windows.Forms.Label lblCarlos;
        private System.Windows.Forms.Label lblAna;
        private System.Windows.Forms.Timer timer1;
    }
}

