namespace Restaurant
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Entry = new System.Windows.Forms.Button();
            this.EntryReg = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EntryReg);
            this.panel1.Controls.Add(this.Entry);
            this.panel1.Controls.Add(this.PasswordBox);
            this.panel1.Controls.Add(this.LoginBox);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Location = new System.Drawing.Point(211, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 254);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добро пожаловать в наш ресторан";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(30, 21);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(41, 13);
            this.Login.TabIndex = 2;
            this.Login.Text = "Логин:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(30, 80);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(48, 13);
            this.Password.TabIndex = 3;
            this.Password.Text = "Пароль:";
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(33, 38);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(141, 20);
            this.LoginBox.TabIndex = 4;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(33, 96);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(141, 20);
            this.PasswordBox.TabIndex = 5;
            // 
            // Entry
            // 
            this.Entry.Location = new System.Drawing.Point(124, 141);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(166, 23);
            this.Entry.TabIndex = 6;
            this.Entry.Text = "Войти";
            this.Entry.UseVisualStyleBackColor = true;
            // 
            // EntryReg
            // 
            this.EntryReg.Location = new System.Drawing.Point(124, 171);
            this.EntryReg.Name = "EntryReg";
            this.EntryReg.Size = new System.Drawing.Size(166, 23);
            this.EntryReg.TabIndex = 7;
            this.EntryReg.Text = "Зарегистрироваться";
            this.EntryReg.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Entry;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Button EntryReg;
    }
}