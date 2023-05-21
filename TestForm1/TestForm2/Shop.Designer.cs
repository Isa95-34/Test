namespace TestForm2
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.lalabelFullName = new System.Windows.Forms.Label();
            this.lalabelRole = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lalabelFullName1 = new System.Windows.Forms.Label();
            this.lalabelRole1 = new System.Windows.Forms.Label();
            this.GridViewDataBaze = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDataBaze)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.DeleteProductButton);
            this.panel2.Controls.Add(this.AddProductButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 586);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1397, 59);
            this.panel2.TabIndex = 2;
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteProductButton.BackColor = System.Drawing.Color.Gainsboro;
            this.DeleteProductButton.Location = new System.Drawing.Point(113, 4);
            this.DeleteProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(88, 30);
            this.DeleteProductButton.TabIndex = 1;
            this.DeleteProductButton.Text = "Удалить";
            this.DeleteProductButton.UseVisualStyleBackColor = false;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddProductButton.Location = new System.Drawing.Point(0, 4);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(88, 30);
            this.AddProductButton.TabIndex = 0;
            this.AddProductButton.Text = "Добавить";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // lalabelFullName
            // 
            this.lalabelFullName.Location = new System.Drawing.Point(0, 0);
            this.lalabelFullName.Name = "lalabelFullName";
            this.lalabelFullName.Size = new System.Drawing.Size(100, 23);
            this.lalabelFullName.TabIndex = 0;
            // 
            // lalabelRole
            // 
            this.lalabelRole.Location = new System.Drawing.Point(0, 0);
            this.lalabelRole.Name = "lalabelRole";
            this.lalabelRole.Size = new System.Drawing.Size(100, 23);
            this.lalabelRole.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1397, 102);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(617, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lalabelFullName1
            // 
            this.lalabelFullName1.AutoSize = true;
            this.lalabelFullName1.Location = new System.Drawing.Point(1448, 12);
            this.lalabelFullName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lalabelFullName1.Name = "lalabelFullName1";
            this.lalabelFullName1.Size = new System.Drawing.Size(41, 17);
            this.lalabelFullName1.TabIndex = 5;
            this.lalabelFullName1.Text = "label2";
            // 
            // lalabelRole1
            // 
            this.lalabelRole1.AutoSize = true;
            this.lalabelRole1.Location = new System.Drawing.Point(1448, 68);
            this.lalabelRole1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lalabelRole1.Name = "lalabelRole1";
            this.lalabelRole1.Size = new System.Drawing.Size(41, 17);
            this.lalabelRole1.TabIndex = 6;
            this.lalabelRole1.Text = "label3";
            // 
            // GridViewDataBaze
            // 
            this.GridViewDataBaze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewDataBaze.GridColor = System.Drawing.Color.IndianRed;
            this.GridViewDataBaze.Location = new System.Drawing.Point(0, 102);
            this.GridViewDataBaze.Margin = new System.Windows.Forms.Padding(4);
            this.GridViewDataBaze.Name = "GridViewDataBaze";
            this.GridViewDataBaze.Size = new System.Drawing.Size(1397, 484);
            this.GridViewDataBaze.TabIndex = 0;
            this.GridViewDataBaze.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDataBaze_CellContentClick);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1397, 645);
            this.Controls.Add(this.GridViewDataBaze);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Shop";
            this.Text = "Магазин";
            this.Load += new System.EventHandler(this.Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDataBaze)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lalabelFullName;
        private System.Windows.Forms.Label lalabelRole;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lalabelFullName1;
        private System.Windows.Forms.Label lalabelRole1;
        private System.Windows.Forms.DataGridView GridViewDataBaze;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}