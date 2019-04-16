namespace Lazuta
{
    partial class Login
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.DLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LPassword = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.LLogin = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoginLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.LPassword.SuspendLayout();
            this.LLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(42, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 47);
            this.label2.TabIndex = 15;
            this.label2.Text = "Авторизация";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(110, 8);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // DLogin
            // 
            this.DLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.DLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.DLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DLogin.BorderRadius = 0;
            this.DLogin.ButtonText = "Авторизироваться";
            this.DLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DLogin.DisabledColor = System.Drawing.Color.Maroon;
            this.DLogin.ForeColor = System.Drawing.Color.Transparent;
            this.DLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.DLogin.Iconimage = null;
            this.DLogin.Iconimage_right = null;
            this.DLogin.Iconimage_right_Selected = null;
            this.DLogin.Iconimage_Selected = null;
            this.DLogin.IconMarginLeft = 0;
            this.DLogin.IconMarginRight = 0;
            this.DLogin.IconRightVisible = true;
            this.DLogin.IconRightZoom = 0D;
            this.DLogin.IconVisible = true;
            this.DLogin.IconZoom = 90D;
            this.DLogin.IsTab = false;
            this.DLogin.Location = new System.Drawing.Point(40, 264);
            this.DLogin.Name = "DLogin";
            this.DLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.DLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.DLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.DLogin.selected = false;
            this.DLogin.Size = new System.Drawing.Size(240, 50);
            this.DLogin.TabIndex = 16;
            this.DLogin.TabStop = false;
            this.DLogin.Text = "Авторизироваться";
            this.DLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DLogin.Textcolor = System.Drawing.Color.White;
            this.DLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DLogin.Click += new System.EventHandler(this.DLogin_Click_1);
            // 
            // LPassword
            // 
            this.LPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.LPassword.Controls.Add(this.panel3);
            this.LPassword.Controls.Add(this.LoginPassword);
            this.LPassword.Location = new System.Drawing.Point(40, 205);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(240, 50);
            this.LPassword.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(103)))), ((int)(((byte)(126)))));
            this.panel3.Location = new System.Drawing.Point(20, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 13;
            // 
            // LoginPassword
            // 
            this.LoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.LoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoginPassword.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.LoginPassword.Location = new System.Drawing.Point(20, 10);
            this.LoginPassword.Multiline = true;
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(200, 30);
            this.LoginPassword.TabIndex = 1;
            this.LoginPassword.Text = "Пароль";
            this.LoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginPassword.Click += new System.EventHandler(this.LoginPassword_Click_1);
            // 
            // LLogin
            // 
            this.LLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.LLogin.Controls.Add(this.panel2);
            this.LLogin.Controls.Add(this.LoginLogin);
            this.LLogin.Location = new System.Drawing.Point(41, 149);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(237, 50);
            this.LLogin.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(103)))), ((int)(((byte)(126)))));
            this.panel2.Location = new System.Drawing.Point(20, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 12;
            // 
            // LoginLogin
            // 
            this.LoginLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.LoginLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoginLogin.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.LoginLogin.Location = new System.Drawing.Point(20, 10);
            this.LoginLogin.Multiline = true;
            this.LoginLogin.Name = "LoginLogin";
            this.LoginLogin.Size = new System.Drawing.Size(200, 30);
            this.LoginLogin.TabIndex = 0;
            this.LoginLogin.Text = "Логин";
            this.LoginLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginLogin.Click += new System.EventHandler(this.LoginLogin_Click_1);
            this.LoginLogin.TextChanged += new System.EventHandler(this.LoginLogin_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.DLogin);
            this.Controls.Add(this.LPassword);
            this.Controls.Add(this.LLogin);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(320, 320);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.LPassword.ResumeLayout(false);
            this.LPassword.PerformLayout();
            this.LLogin.ResumeLayout(false);
            this.LLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Bunifu.Framework.UI.BunifuFlatButton DLogin;
        private System.Windows.Forms.Panel LPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.Panel LLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox LoginLogin;
    }
}
