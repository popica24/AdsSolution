namespace AdsSolution
{
    partial class NewAdForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAdForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DescBox = new System.Windows.Forms.RichTextBox();
            this.PhoneCheckbox = new System.Windows.Forms.CheckBox();
            this.EmailCheckbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddPhoto = new System.Windows.Forms.PictureBox();
            this.ChosePhoto = new System.Windows.Forms.OpenFileDialog();
            this.ImageContainer = new System.Windows.Forms.ImageList(this.components);
            this.ImageBox = new System.Windows.Forms.GroupBox();
            this.ImageGrid = new System.Windows.Forms.TableLayoutPanel();
            this.Post = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhoto)).BeginInit();
            this.ImageBox.SuspendLayout();
            this.ImageGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EmailCheckbox);
            this.groupBox1.Controls.Add(this.PhoneCheckbox);
            this.groupBox1.Controls.Add(this.DescBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TitleBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(9, 57);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(193, 26);
            this.TitleBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // DescBox
            // 
            this.DescBox.BackColor = System.Drawing.SystemColors.Window;
            this.DescBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescBox.Location = new System.Drawing.Point(9, 131);
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(193, 60);
            this.DescBox.TabIndex = 5;
            this.DescBox.Text = "";
            // 
            // PhoneCheckbox
            // 
            this.PhoneCheckbox.AutoSize = true;
            this.PhoneCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneCheckbox.Location = new System.Drawing.Point(526, 160);
            this.PhoneCheckbox.Name = "PhoneCheckbox";
            this.PhoneCheckbox.Size = new System.Drawing.Size(62, 19);
            this.PhoneCheckbox.TabIndex = 1;
            this.PhoneCheckbox.Text = "Phone";
            this.PhoneCheckbox.UseVisualStyleBackColor = true;
            // 
            // EmailCheckbox
            // 
            this.EmailCheckbox.AutoSize = true;
            this.EmailCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailCheckbox.Location = new System.Drawing.Point(526, 185);
            this.EmailCheckbox.Name = "EmailCheckbox";
            this.EmailCheckbox.Size = new System.Drawing.Size(58, 19);
            this.EmailCheckbox.TabIndex = 6;
            this.EmailCheckbox.Text = "Email";
            this.EmailCheckbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contact :";
            // 
            // AddPhoto
            // 
            this.AddPhoto.BackColor = System.Drawing.Color.Transparent;
            this.AddPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPhoto.Image = ((System.Drawing.Image)(resources.GetObject("AddPhoto.Image")));
            this.AddPhoto.Location = new System.Drawing.Point(3, 3);
            this.AddPhoto.Name = "AddPhoto";
            this.AddPhoto.Size = new System.Drawing.Size(187, 144);
            this.AddPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddPhoto.TabIndex = 0;
            this.AddPhoto.TabStop = false;
            this.AddPhoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ChosePhoto
            // 
            this.ChosePhoto.FileName = "openFileDialog1";
            // 
            // ImageContainer
            // 
            this.ImageContainer.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImageContainer.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageContainer.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ImageBox
            // 
            this.ImageBox.Controls.Add(this.ImageGrid);
            this.ImageBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ImageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageBox.Location = new System.Drawing.Point(9, 266);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(776, 335);
            this.ImageBox.TabIndex = 1;
            this.ImageBox.TabStop = false;
            this.ImageBox.Text = "Images";
            // 
            // ImageGrid
            // 
            this.ImageGrid.ColumnCount = 4;
            this.ImageGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ImageGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ImageGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ImageGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ImageGrid.Controls.Add(this.AddPhoto, 0, 0);
            this.ImageGrid.Location = new System.Drawing.Point(4, 25);
            this.ImageGrid.Name = "ImageGrid";
            this.ImageGrid.RowCount = 2;
            this.ImageGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImageGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImageGrid.Size = new System.Drawing.Size(772, 304);
            this.ImageGrid.TabIndex = 1;
            // 
            // Post
            // 
            this.Post.Location = new System.Drawing.Point(343, 614);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(75, 23);
            this.Post.TabIndex = 2;
            this.Post.Text = "Post Ad";
            this.Post.UseVisualStyleBackColor = true;
            this.Post.Click += new System.EventHandler(this.Post_Click);
            // 
            // NewAdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 649);
            this.Controls.Add(this.Post);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewAdForm";
            this.Text = "NewAdChild";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhoto)).EndInit();
            this.ImageBox.ResumeLayout(false);
            this.ImageGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox DescBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox EmailCheckbox;
        private System.Windows.Forms.CheckBox PhoneCheckbox;
        private System.Windows.Forms.PictureBox AddPhoto;
        private System.Windows.Forms.OpenFileDialog ChosePhoto;
        private System.Windows.Forms.ImageList ImageContainer;
        private System.Windows.Forms.GroupBox ImageBox;
        private System.Windows.Forms.TableLayoutPanel ImageGrid;
        private System.Windows.Forms.Button Post;
    }
}