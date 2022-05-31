namespace SimpsonsAPP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SimpsonsAPP.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(31, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.Gold;
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUser.Location = new System.Drawing.Point(92, 94);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(165, 19);
            this.textBoxUser.TabIndex = 3;
            this.textBoxUser.Text = "Username";
            this.textBoxUser.Click += new System.EventHandler(this.textBoxUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(31, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(31, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 7;
            // 
            // textBoxPW
            // 
            this.textBoxPW.BackColor = System.Drawing.Color.Gold;
            this.textBoxPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPW.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPW.Location = new System.Drawing.Point(92, 145);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.PasswordChar = '*';
            this.textBoxPW.Size = new System.Drawing.Size(165, 19);
            this.textBoxPW.TabIndex = 6;
            this.textBoxPW.Text = "Password";
            this.textBoxPW.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SimpsonsAPP.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(31, 145);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Gold;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(31, 194);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(236, 31);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Confirm";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.buttonLogin);
            this.panel3.Controls.Add(this.textBoxUser);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.textBoxPW);
            this.panel3.Location = new System.Drawing.Point(82, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 243);
            this.panel3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 416);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
    }
}
