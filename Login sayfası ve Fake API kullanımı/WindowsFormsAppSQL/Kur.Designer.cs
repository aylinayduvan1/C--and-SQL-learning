namespace WindowsFormsAppSQL
{
    partial class Kur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kur));
            this.label4 = new System.Windows.Forms.Label();
            this.turn_btn = new System.Windows.Forms.Button();
            this.hava_btn = new System.Windows.Forms.Button();
            this.doviz_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbSterlin = new System.Windows.Forms.Label();
            this.lbEuro = new System.Windows.Forms.Label();
            this.lbDolar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 37);
            this.label4.TabIndex = 26;
            this.label4.Text = "1";
            // 
            // turn_btn
            // 
            this.turn_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(34)))), ((int)(((byte)(184)))));
            this.turn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.turn_btn.ForeColor = System.Drawing.Color.Transparent;
            this.turn_btn.Location = new System.Drawing.Point(49, 372);
            this.turn_btn.Name = "turn_btn";
            this.turn_btn.Size = new System.Drawing.Size(143, 76);
            this.turn_btn.TabIndex = 29;
            this.turn_btn.Text = "Giriş sayfasına dön";
            this.turn_btn.UseVisualStyleBackColor = false;
            this.turn_btn.Click += new System.EventHandler(this.turn_btn_Click);
            // 
            // hava_btn
            // 
            this.hava_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(34)))), ((int)(((byte)(184)))));
            this.hava_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hava_btn.ForeColor = System.Drawing.Color.Transparent;
            this.hava_btn.Location = new System.Drawing.Point(49, 254);
            this.hava_btn.Name = "hava_btn";
            this.hava_btn.Size = new System.Drawing.Size(143, 82);
            this.hava_btn.TabIndex = 28;
            this.hava_btn.Text = "Hava Durumu ";
            this.hava_btn.UseVisualStyleBackColor = false;
            this.hava_btn.Click += new System.EventHandler(this.hava_btn_Click);
            // 
            // doviz_btn
            // 
            this.doviz_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(34)))), ((int)(((byte)(184)))));
            this.doviz_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doviz_btn.ForeColor = System.Drawing.Color.Transparent;
            this.doviz_btn.Location = new System.Drawing.Point(49, 140);
            this.doviz_btn.Name = "doviz_btn";
            this.doviz_btn.Size = new System.Drawing.Size(143, 79);
            this.doviz_btn.TabIndex = 27;
            this.doviz_btn.Text = "Döviz Hesaplat";
            this.doviz_btn.UseVisualStyleBackColor = false;
            this.doviz_btn.Click += new System.EventHandler(this.doviz_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(572, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // lbSterlin
            // 
            this.lbSterlin.AutoSize = true;
            this.lbSterlin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSterlin.ForeColor = System.Drawing.Color.Brown;
            this.lbSterlin.Location = new System.Drawing.Point(687, 365);
            this.lbSterlin.Name = "lbSterlin";
            this.lbSterlin.Size = new System.Drawing.Size(0, 20);
            this.lbSterlin.TabIndex = 35;
            // 
            // lbEuro
            // 
            this.lbEuro.AutoSize = true;
            this.lbEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbEuro.ForeColor = System.Drawing.Color.Brown;
            this.lbEuro.Location = new System.Drawing.Point(667, 307);
            this.lbEuro.Name = "lbEuro";
            this.lbEuro.Size = new System.Drawing.Size(0, 20);
            this.lbEuro.TabIndex = 34;
            // 
            // lbDolar
            // 
            this.lbDolar.AutoSize = true;
            this.lbDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDolar.ForeColor = System.Drawing.Color.Brown;
            this.lbDolar.Location = new System.Drawing.Point(667, 256);
            this.lbDolar.Name = "lbDolar";
            this.lbDolar.Size = new System.Drawing.Size(0, 20);
            this.lbDolar.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F);
            this.label1.Location = new System.Drawing.Point(575, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Sterlin :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F);
            this.label3.Location = new System.Drawing.Point(575, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 31;
            this.label3.Text = "Euro :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F);
            this.label2.Location = new System.Drawing.Point(575, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "Dolar :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(892, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 35);
            this.button1.TabIndex = 37;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Kur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbSterlin);
            this.Controls.Add(this.lbEuro);
            this.Controls.Add(this.lbDolar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.turn_btn);
            this.Controls.Add(this.hava_btn);
            this.Controls.Add(this.doviz_btn);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kur";
            this.Text = "Kur";
            this.Load += new System.EventHandler(this.Kur_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Kur_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Kur_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Kur_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button turn_btn;
        private System.Windows.Forms.Button hava_btn;
        private System.Windows.Forms.Button doviz_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbSterlin;
        private System.Windows.Forms.Label lbEuro;
        private System.Windows.Forms.Label lbDolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}