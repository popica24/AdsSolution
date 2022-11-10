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
            this.AdContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewAdBtn
            // 
            this.NewAdBtn.Location = new System.Drawing.Point(688, 12);
            this.NewAdBtn.Name = "NewAdBtn";
            this.NewAdBtn.Size = new System.Drawing.Size(100, 23);
            this.NewAdBtn.TabIndex = 0;
            this.NewAdBtn.Text = "New Ad";
            this.NewAdBtn.UseVisualStyleBackColor = true;
            this.NewAdBtn.Click += new System.EventHandler(this.NewAdBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.AdContainer);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(670, 426);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // AdContainer
            // 
            this.AdContainer.Location = new System.Drawing.Point(3, 3);
            this.AdContainer.Name = "AdContainer";
            this.AdContainer.Size = new System.Drawing.Size(200, 100);
            this.AdContainer.TabIndex = 0;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.NewAdBtn);
            this.Name = "ParentForm";
            this.Text = "OLX";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewAdBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel AdContainer;
    }
}

