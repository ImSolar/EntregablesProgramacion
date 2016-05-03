namespace Pong
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
            this.marcadorLabel = new System.Windows.Forms.Label();
            this.raquetaLocalPictureBox = new System.Windows.Forms.PictureBox();
            this.raquetaVisitantePictureBox = new System.Windows.Forms.PictureBox();
            this.pelotaPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.raquetaLocalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raquetaVisitantePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelotaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // marcadorLabel
            // 
            this.marcadorLabel.AutoSize = true;
            this.marcadorLabel.BackColor = System.Drawing.Color.Transparent;
            this.marcadorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcadorLabel.ForeColor = System.Drawing.Color.White;
            this.marcadorLabel.Location = new System.Drawing.Point(285, 70);
            this.marcadorLabel.Name = "marcadorLabel";
            this.marcadorLabel.Size = new System.Drawing.Size(230, 108);
            this.marcadorLabel.TabIndex = 0;
            this.marcadorLabel.Text = "0 : 0";
            // 
            // raquetaLocalPictureBox
            // 
            this.raquetaLocalPictureBox.BackColor = System.Drawing.Color.White;
            this.raquetaLocalPictureBox.Location = new System.Drawing.Point(31, 254);
            this.raquetaLocalPictureBox.Name = "raquetaLocalPictureBox";
            this.raquetaLocalPictureBox.Size = new System.Drawing.Size(19, 65);
            this.raquetaLocalPictureBox.TabIndex = 1;
            this.raquetaLocalPictureBox.TabStop = false;
            // 
            // raquetaVisitantePictureBox
            // 
            this.raquetaVisitantePictureBox.BackColor = System.Drawing.Color.White;
            this.raquetaVisitantePictureBox.Location = new System.Drawing.Point(731, 254);
            this.raquetaVisitantePictureBox.Name = "raquetaVisitantePictureBox";
            this.raquetaVisitantePictureBox.Size = new System.Drawing.Size(19, 65);
            this.raquetaVisitantePictureBox.TabIndex = 2;
            this.raquetaVisitantePictureBox.TabStop = false;
            // 
            // pelotaPictureBox
            // 
            this.pelotaPictureBox.BackColor = System.Drawing.Color.White;
            this.pelotaPictureBox.Location = new System.Drawing.Point(383, 248);
            this.pelotaPictureBox.Name = "pelotaPictureBox";
            this.pelotaPictureBox.Size = new System.Drawing.Size(15, 16);
            this.pelotaPictureBox.TabIndex = 3;
            this.pelotaPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pelotaPictureBox);
            this.Controls.Add(this.raquetaVisitantePictureBox);
            this.Controls.Add(this.raquetaLocalPictureBox);
            this.Controls.Add(this.marcadorLabel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.pintarForm);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.raquetaLocalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raquetaVisitantePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelotaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label marcadorLabel;
        private System.Windows.Forms.PictureBox raquetaLocalPictureBox;
        private System.Windows.Forms.PictureBox raquetaVisitantePictureBox;
        private System.Windows.Forms.PictureBox pelotaPictureBox;
    }
}

