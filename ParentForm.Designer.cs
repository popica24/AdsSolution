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
            this.AdPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SocialPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CurrentUser = new System.Windows.Forms.LinkLabel();
            this.CurentUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // AdPanel
            // 
            this.AdPanel.Controls.Add(this.groupBox2);
            this.AdPanel.Location = new System.Drawing.Point(12, 12);
            this.AdPanel.Name = "AdPanel";
            this.AdPanel.Size = new System.Drawing.Size(670, 426);
            this.AdPanel.TabIndex = 1;
            // 
            // SocialPanel
            // 
            this.SocialPanel.Location = new System.Drawing.Point(688, 118);
            this.SocialPanel.Name = "SocialPanel";
            this.SocialPanel.Size = new System.Drawing.Size(268, 320);
            this.SocialPanel.TabIndex = 2;
            // 
            // CurrentUser
            // 
            this.CurrentUser.AutoSize = true;
            this.CurrentUser.Location = new System.Drawing.Point(901, 12);
            this.CurrentUser.Name = "CurrentUser";
            this.CurrentUser.Size = new System.Drawing.Size(0, 13);
            this.CurrentUser.TabIndex = 0;
            // 
            // CurentUser
            // 
            this.CurentUser.AutoSize = true;
            this.CurentUser.Location = new System.Drawing.Point(42, 16);
            this.CurentUser.Name = "CurentUser";
            this.CurentUser.Size = new System.Drawing.Size(35, 13);
            this.CurentUser.TabIndex = 3;
            this.CurentUser.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.CurentUser);
            this.groupBox1.Location = new System.Drawing.Point(688, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 171);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 149);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CurrentUser);
            this.Controls.Add(this.NewAdBtn);
            this.Controls.Add(this.SocialPanel);
            this.Controls.Add(this.AdPanel);
            this.Name = "ParentForm";
            this.Text = "OLX";
            this.AdPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewAdBtn;
        private System.Windows.Forms.FlowLayoutPanel AdPanel;
        private System.Windows.Forms.FlowLayoutPanel SocialPanel;
        private System.Windows.Forms.LinkLabel CurrentUser;
        private System.Windows.Forms.Label CurentUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

