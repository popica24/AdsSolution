namespace AdsSolution
{
    partial class ParentForm
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
            this.NewAdBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CurrentUser = new System.Windows.Forms.LinkLabel();
            this.PassEmailAndName = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // NewAdBtn
            // 
            this.NewAdBtn.Location = new System.Drawing.Point(262, 454);
            this.NewAdBtn.Name = "NewAdBtn";
            this.NewAdBtn.Size = new System.Drawing.Size(100, 23);
            this.NewAdBtn.TabIndex = 0;
            this.NewAdBtn.Text = "New Ad";
            this.NewAdBtn.UseVisualStyleBackColor = true;
            this.NewAdBtn.Click += new System.EventHandler(this.NewAdBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(670, 426);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(688, 77);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(268, 361);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // CurrentUser
            // 
            this.CurrentUser.AutoSize = true;
            this.CurrentUser.Location = new System.Drawing.Point(901, 12);
            this.CurrentUser.Name = "CurrentUser";
            this.CurrentUser.Size = new System.Drawing.Size(0, 13);
            this.CurrentUser.TabIndex = 0;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 489);
            this.Controls.Add(this.CurrentUser);
            this.Controls.Add(this.NewAdBtn);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ParentForm";
            this.Text = "OLX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewAdBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.LinkLabel CurrentUser;
        private System.ComponentModel.BackgroundWorker PassEmailAndName;
    }
}

