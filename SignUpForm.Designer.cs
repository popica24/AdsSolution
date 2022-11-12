namespace AdsSolution
{
    partial class SignUpForm
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
            this.PasswordStatus = new System.Windows.Forms.Label();
            this.EmailStatus = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.PhoneStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswordStatus
            // 
            this.PasswordStatus.AutoSize = true;
            this.PasswordStatus.Location = new System.Drawing.Point(351, 185);
            this.PasswordStatus.Margin = new System.Windows.Forms.Padding(6);
            this.PasswordStatus.Name = "PasswordStatus";
            this.PasswordStatus.Size = new System.Drawing.Size(0, 13);
            this.PasswordStatus.TabIndex = 12;
            // 
            // EmailStatus
            // 
            this.EmailStatus.AutoSize = true;
            this.EmailStatus.Location = new System.Drawing.Point(351, 145);
            this.EmailStatus.Margin = new System.Windows.Forms.Padding(6);
            this.EmailStatus.Name = "EmailStatus";
            this.EmailStatus.Size = new System.Drawing.Size(0, 13);
            this.EmailStatus.TabIndex = 11;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(60, 180);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(6);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(282, 22);
            this.PasswordBox.TabIndex = 10;
            this.PasswordBox.Text = "Password";
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(57, 140);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(6);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(282, 22);
            this.EmailBox.TabIndex = 9;
            this.EmailBox.Text = "Email";
            this.EmailBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(57, 101);
            this.NameBox.Margin = new System.Windows.Forms.Padding(6);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(282, 22);
            this.NameBox.TabIndex = 13;
            this.NameBox.Text = "Name";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneBox.Location = new System.Drawing.Point(60, 220);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(6);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(282, 22);
            this.PhoneBox.TabIndex = 14;
            this.PhoneBox.Text = "Phone ";
            this.PhoneBox.TextChanged += new System.EventHandler(this.PhoneBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Sign up";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PhoneStatus
            // 
            this.PhoneStatus.AutoSize = true;
            this.PhoneStatus.Location = new System.Drawing.Point(351, 229);
            this.PhoneStatus.Name = "PhoneStatus";
            this.PhoneStatus.Size = new System.Drawing.Size(0, 13);
            this.PhoneStatus.TabIndex = 16;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.PhoneStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PasswordStatus);
            this.Controls.Add(this.EmailStatus);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label1);
            this.Name = "SignUpForm";
            this.Text = "Sign Up | OLX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PasswordStatus;
        private System.Windows.Forms.Label EmailStatus;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PhoneStatus;
    }
}