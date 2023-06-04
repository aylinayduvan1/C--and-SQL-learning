namespace WindowsFormsAppSQL
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.label1 = new System.Windows.Forms.Label();
            this.doviz_btn = new System.Windows.Forms.Button();
            this.hava_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.turn_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "isim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // doviz_btn
            // 
            this.doviz_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(34)))), ((int)(((byte)(184)))));
            this.doviz_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doviz_btn.ForeColor = System.Drawing.Color.Transparent;
            this.doviz_btn.Location = new System.Drawing.Point(42, 138);
            this.doviz_btn.Name = "doviz_btn";
            this.doviz_btn.Size = new System.Drawing.Size(143, 79);
            this.doviz_btn.TabIndex = 1;
            this.doviz_btn.Text = "Döviz Hesaplat";
            this.doviz_btn.UseVisualStyleBackColor = false;
            this.doviz_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // hava_btn
            // 
            this.hava_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(34)))), ((int)(((byte)(184)))));
            this.hava_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hava_btn.ForeColor = System.Drawing.Color.Transparent;
            this.hava_btn.Location = new System.Drawing.Point(42, 252);
            this.hava_btn.Name = "hava_btn";
            this.hava_btn.Size = new System.Drawing.Size(143, 82);
            this.hava_btn.TabIndex = 2;
            this.hava_btn.Text = "Hava Durumu ";
            this.hava_btn.UseVisualStyleBackColor = false;
            this.hava_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F);
            this.label2.Location = new System.Drawing.Point(595, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 182);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lütfen yapmak \r\n\r\nistediginiz \r\n\r\nislemi \r\n\r\nseçiniz..";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.button1.Location = new System.Drawing.Point(903, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 35);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // turn_btn
            // 
            this.turn_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(34)))), ((int)(((byte)(184)))));
            this.turn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.turn_btn.ForeColor = System.Drawing.Color.Transparent;
            this.turn_btn.Location = new System.Drawing.Point(42, 370);
            this.turn_btn.Name = "turn_btn";
            this.turn_btn.Size = new System.Drawing.Size(143, 76);
            this.turn_btn.TabIndex = 8;
            this.turn_btn.Text = "Giriş sayfasına dön";
            this.turn_btn.UseVisualStyleBackColor = false;
            this.turn_btn.Click += new System.EventHandler(this.turn_btn_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 518);
            this.Controls.Add(this.turn_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hava_btn);
            this.Controls.Add(this.doviz_btn);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doviz_btn;
        private System.Windows.Forms.Button hava_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button turn_btn;
    }
}