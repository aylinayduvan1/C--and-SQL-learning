namespace WindowsFormsAppSQL
{
    partial class Singup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Singup));
            this.button1 = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.singup_btn = new System.Windows.Forms.Button();
            this.nameadd_textBox = new System.Windows.Forms.TextBox();
            this.addpas_textBox = new System.Windows.Forms.TextBox();
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
            this.button1.Location = new System.Drawing.Point(911, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 35);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.login_btn.Location = new System.Drawing.Point(547, 382);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(131, 39);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Girişe dön";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // singup_btn
            // 
            this.singup_btn.BackColor = System.Drawing.Color.PowderBlue;
            this.singup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.singup_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.singup_btn.FlatAppearance.BorderSize = 0;
            this.singup_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.singup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.singup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.singup_btn.ForeColor = System.Drawing.Color.Indigo;
            this.singup_btn.Location = new System.Drawing.Point(710, 382);
            this.singup_btn.Name = "singup_btn";
            this.singup_btn.Size = new System.Drawing.Size(131, 39);
            this.singup_btn.TabIndex = 5;
            this.singup_btn.Text = "Üyeliği tamamla";
            this.singup_btn.UseVisualStyleBackColor = false;
            this.singup_btn.Click += new System.EventHandler(this.singup_btn_Click);
            // 
            // nameadd_textBox
            // 
            this.nameadd_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameadd_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameadd_textBox.Location = new System.Drawing.Point(597, 180);
            this.nameadd_textBox.Name = "nameadd_textBox";
            this.nameadd_textBox.Size = new System.Drawing.Size(224, 19);
            this.nameadd_textBox.TabIndex = 6;
            // 
            // addpas_textBox
            // 
            this.addpas_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addpas_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addpas_textBox.Location = new System.Drawing.Point(597, 289);
            this.addpas_textBox.Name = "addpas_textBox";
            this.addpas_textBox.Size = new System.Drawing.Size(224, 19);
            this.addpas_textBox.TabIndex = 7;
            // 
            // Singup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 521);
            this.Controls.Add(this.addpas_textBox);
            this.Controls.Add(this.nameadd_textBox);
            this.Controls.Add(this.singup_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Singup";
            this.Text = "Singup";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Singup_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Singup_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Singup_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button singup_btn;
        private System.Windows.Forms.TextBox nameadd_textBox;
        private System.Windows.Forms.TextBox addpas_textBox;
    }
}