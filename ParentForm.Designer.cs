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
            this.AdContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CurentUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewAdBtn
            // 
            this.NewAdBtn.Location = new System.Drawing.Point(236, 19);
            this.NewAdBtn.Name = "NewAdBtn";
            this.NewAdBtn.Size = new System.Drawing.Size(26, 23);
            this.NewAdBtn.TabIndex = 0;
            this.NewAdBtn.Text = "+";
            this.NewAdBtn.UseVisualStyleBackColor = true;
            this.NewAdBtn.Click += new System.EventHandler(this.NewAdBtn_Click);
            // 
            // AdContainer
            // 
            this.AdContainer.Location = new System.Drawing.Point(12, 12);
            this.AdContainer.Name = "AdContainer";
            this.AdContainer.Size = new System.Drawing.Size(670, 426);
            this.AdContainer.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(688, 77);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(268, 361);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // CurentUser
            // 
            this.CurentUser.AutoSize = true;
            this.CurentUser.BackColor = System.Drawing.Color.White;
            this.CurentUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurentUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CurentUser.Location = new System.Drawing.Point(6, 16);
            this.CurentUser.Name = "CurentUser";
            this.CurentUser.Size = new System.Drawing.Size(38, 15);
            this.CurentUser.TabIndex = 3;
            this.CurentUser.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.CurentUser);
            this.groupBox1.Controls.Add(this.NewAdBtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(688, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.AdContainer);
            this.Name = "ParentForm";
            this.Text = "OLX";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewAdBtn;
        private System.Windows.Forms.FlowLayoutPanel AdContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label CurentUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

