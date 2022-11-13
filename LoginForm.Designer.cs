namespace AdsSolution
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
            this.label1 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.EmailStatus = new System.Windows.Forms.Label();
            this.PasswordStatus = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(31, 81);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(282, 20);
            this.EmailBox.TabIndex = 3;
            this.EmailBox.Text = "Email";
            this.EmailBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(31, 125);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(282, 20);
            this.PasswordBox.TabIndex = 4;
            this.PasswordBox.Text = "Password";
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Not a member?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(183, 298);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign Up";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // EmailStatus
            // 
            this.EmailStatus.AutoSize = true;
            this.EmailStatus.Location = new System.Drawing.Point(28, 104);
            this.EmailStatus.Name = "EmailStatus";
            this.EmailStatus.Size = new System.Drawing.Size(0, 13);
            this.EmailStatus.TabIndex = 7;
            // 
            // PasswordStatus
            // 
            this.PasswordStatus.AutoSize = true;
            this.PasswordStatus.Location = new System.Drawing.Point(28, 148);
            this.PasswordStatus.Name = "PasswordStatus";
            this.PasswordStatus.Size = new System.Drawing.Size(0, 13);
            this.PasswordStatus.TabIndex = 8;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(73, 195);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(201, 28);
            this.Login.TabIndex = 9;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // ForgotPassword
            // 
            this.ForgotPassword.AutoSize = true;
            this.ForgotPassword.Location = new System.Drawing.Point(28, 164);
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(92, 13);
            this.ForgotPassword.TabIndex = 10;
            this.ForgotPassword.TabStop = true;
            this.ForgotPassword.Text = "Forgot Password?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 334);
            this.Controls.Add(this.ForgotPassword);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.PasswordStatus);
            this.Controls.Add(this.EmailStatus);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login | OLX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label EmailStatus;
        private System.Windows.Forms.Label PasswordStatus;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.LinkLabel ForgotPassword;
    }
}