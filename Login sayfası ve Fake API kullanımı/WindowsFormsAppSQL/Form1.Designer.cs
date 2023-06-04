namespace WindowsFormsAppSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.sing_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(919, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 35);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.name_textBox.Location = new System.Drawing.Point(149, 159);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(224, 19);
            this.name_textBox.TabIndex = 1;
            // 
            // password_textBox
            // 
            this.password_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.password_textBox.Location = new System.Drawing.Point(149, 269);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(224, 19);
            this.password_textBox.TabIndex = 2;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.PowderBlue;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.ForeColor = System.Drawing.Color.Indigo;
            this.login_btn.Location = new System.Drawing.Point(107, 370);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(118, 39);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Giriş yap";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // sing_btn
            // 
            this.sing_btn.BackColor = System.Drawing.Color.PowderBlue;
            this.sing_btn.FlatAppearance.BorderSize = 0;
            this.sing_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sing_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sing_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sing_btn.ForeColor = System.Drawing.Color.Indigo;
            this.sing_btn.Location = new System.Drawing.Point(255, 370);
            this.sing_btn.Name = "sing_btn";
            this.sing_btn.Size = new System.Drawing.Size(118, 39);
            this.sing_btn.TabIndex = 4;
            this.sing_btn.Text = "Üye ol";
            this.sing_btn.UseVisualStyleBackColor = false;
            this.sing_btn.Click += new System.EventHandler(this.sing_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 521);
            this.Controls.Add(this.sing_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button sing_btn;
    }
}

