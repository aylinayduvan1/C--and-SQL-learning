namespace WindowsFormsAppSQL
{
    partial class Doviz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doviz));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDolar = new System.Windows.Forms.Label();
            this.lbEuro = new System.Windows.Forms.Label();
            this.lbSterlin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alan_btn = new System.Windows.Forms.Button();
            this.hava_btn = new System.Windows.Forms.Button();
            this.doviz_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F);
            this.label2.Location = new System.Drawing.Point(574, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dolar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F);
            this.label3.Location = new System.Drawing.Point(574, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Euro :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F);
            this.label4.Location = new System.Drawing.Point(574, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sterlin :";
            // 
            // lbDolar
            // 
            this.lbDolar.AutoSize = true;
            this.lbDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDolar.ForeColor = System.Drawing.Color.Brown;
            this.lbDolar.Location = new System.Drawing.Point(666, 261);
            this.lbDolar.Name = "lbDolar";
            this.lbDolar.Size = new System.Drawing.Size(0, 20);
            this.lbDolar.TabIndex = 11;
            // 
            // lbEuro
            // 
            this.lbEuro.AutoSize = true;
            this.lbEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbEuro.ForeColor = System.Drawing.Color.Brown;
            this.lbEuro.Location = new System.Drawing.Point(666, 312);
            this.lbEuro.Name = "lbEuro";
            this.lbEuro.Size = new System.Drawing.Size(0, 20);
            this.lbEuro.TabIndex = 12;
            // 
            // lbSterlin
            // 
            this.lbSterlin.AutoSize = true;
            this.lbSterlin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSterlin.ForeColor = System.Drawing.Color.Brown;
            this.lbSterlin.Location = new System.Drawing.Point(686, 370);
            this.lbSterlin.Name = "lbSterlin";
            this.lbSterlin.Size = new System.Drawing.Size(0, 20);
            this.lbSterlin.TabIndex = 13;
            this.lbSterlin.Click += new System.EventHandler(this.lbSterlin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(571, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alan_btn
            // 
            this.alan_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(34)))), ((int)(((byte)(184)))));
            this.alan_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alan_btn.ForeColor = System.Drawing.Color.Transparent;
            this.alan_btn.Location = new System.Drawing.Point(40, 370);
            this.alan_btn.Name = "alan_btn";
            this.alan_btn.Size = new System.Drawing.Size(143, 77);
            this.alan_btn.TabIndex = 18;
            this.alan_btn.Text = "Giriş sayfasına dön";
            this.alan_btn.UseVisualStyleBackColor = false;
            this.alan_btn.Click += new System.EventHandler(this.alan_btn_Click);
            // 
            // hava_btn
            // 
            this.hava_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(34)))), ((int)(((byte)(184)))));
            this.hava_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hava_btn.ForeColor = System.Drawing.Color.Transparent;
            this.hava_btn.Location = new System.Drawing.Point(40, 251);
            this.hava_btn.Name = "hava_btn";
            this.hava_btn.Size = new System.Drawing.Size(143, 82);
            this.hava_btn.TabIndex = 17;
            this.hava_btn.Text = "Hava Durumu ";
            this.hava_btn.UseVisualStyleBackColor = false;
            this.hava_btn.Click += new System.EventHandler(this.hava_btn_Click);
            // 
            // doviz_btn
            // 
            this.doviz_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(34)))), ((int)(((byte)(184)))));
            this.doviz_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doviz_btn.ForeColor = System.Drawing.Color.Transparent;
            this.doviz_btn.Location = new System.Drawing.Point(40, 137);
            this.doviz_btn.Name = "doviz_btn";
            this.doviz_btn.Size = new System.Drawing.Size(143, 79);
            this.doviz_btn.TabIndex = 16;
            this.doviz_btn.Text = "Döviz Hesaplat";
            this.doviz_btn.UseVisualStyleBackColor = false;
            this.doviz_btn.Click += new System.EventHandler(this.doviz_btn_Click);
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
            this.button1.Location = new System.Drawing.Point(889, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 35);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "1";
            // 
            // Doviz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alan_btn);
            this.Controls.Add(this.hava_btn);
            this.Controls.Add(this.doviz_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbSterlin);
            this.Controls.Add(this.lbEuro);
            this.Controls.Add(this.lbDolar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doviz";
            this.Text = "Doviz";
            this.Load += new System.EventHandler(this.Doviz_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Doviz_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Doviz_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Doviz_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDolar;
        private System.Windows.Forms.Label lbEuro;
        private System.Windows.Forms.Label lbSterlin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button alan_btn;
        private System.Windows.Forms.Button hava_btn;
        private System.Windows.Forms.Button doviz_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}