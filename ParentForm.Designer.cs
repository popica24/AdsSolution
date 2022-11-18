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
            this.AdPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SocialPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.NewAdBtn = new System.Windows.Forms.Button();
            this.CurentUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdPanel
            // 
            this.AdPanel.AutoScroll = true;
            this.AdPanel.Location = new System.Drawing.Point(12, 12);
            this.AdPanel.Name = "AdPanel";
            this.AdPanel.Size = new System.Drawing.Size(673, 426);
            this.AdPanel.TabIndex = 1;
            // 
            // SocialPanel
            // 
            this.SocialPanel.Location = new System.Drawing.Point(704, 118);
            this.SocialPanel.Name = "SocialPanel";
            this.SocialPanel.Size = new System.Drawing.Size(268, 320);
            this.SocialPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(200, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewAdBtn
            // 
            this.NewAdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewAdBtn.Location = new System.Drawing.Point(242, 14);
            this.NewAdBtn.Name = "NewAdBtn";
            this.NewAdBtn.Size = new System.Drawing.Size(23, 23);
            this.NewAdBtn.TabIndex = 0;
            this.NewAdBtn.Text = "+";
            this.NewAdBtn.UseVisualStyleBackColor = true;
            this.NewAdBtn.Click += new System.EventHandler(this.NewAdBtn_Click);
            // 
            // CurentUser
            // 
            this.CurentUser.AutoSize = true;
            this.CurentUser.Location = new System.Drawing.Point(19, 14);
            this.CurentUser.Name = "CurentUser";
            this.CurentUser.Size = new System.Drawing.Size(35, 13);
            this.CurentUser.TabIndex = 3;
            this.CurentUser.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewAdBtn);
            this.panel1.Controls.Add(this.CurentUser);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(704, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 100);
            this.panel1.TabIndex = 3;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SocialPanel);
            this.Controls.Add(this.AdPanel);
            this.Name = "ParentForm";
            this.Text = "OLX";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel AdPanel;
        private System.Windows.Forms.FlowLayoutPanel SocialPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NewAdBtn;
        private System.Windows.Forms.Label CurentUser;
        private System.Windows.Forms.Panel panel1;
    }
}

