namespace TestForm2
{
    partial class Caphca
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
            this.BtnEnt = new System.Windows.Forms.Button();
            this.BtnObnov = new System.Windows.Forms.Button();
            this.BoxCaphca = new System.Windows.Forms.PictureBox();
            this.textEnt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BoxCaphca)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEnt
            // 
            this.BtnEnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEnt.Location = new System.Drawing.Point(12, 152);
            this.BtnEnt.Name = "BtnEnt";
            this.BtnEnt.Size = new System.Drawing.Size(75, 23);
            this.BtnEnt.TabIndex = 0;
            this.BtnEnt.Text = "Подтвердить";
            this.BtnEnt.UseVisualStyleBackColor = true;
            this.BtnEnt.Click += new System.EventHandler(this.BtnEnt_Click);
            // 
            // BtnObnov
            // 
            this.BtnObnov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnObnov.ForeColor = System.Drawing.Color.Black;
            this.BtnObnov.Location = new System.Drawing.Point(260, 154);
            this.BtnObnov.Name = "BtnObnov";
            this.BtnObnov.Size = new System.Drawing.Size(75, 23);
            this.BtnObnov.TabIndex = 1;
            this.BtnObnov.Text = "Обновить";
            this.BtnObnov.UseVisualStyleBackColor = true;
            this.BtnObnov.Click += new System.EventHandler(this.BtnObnov_Click);
            // 
            // BoxCaphca
            // 
            this.BoxCaphca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxCaphca.Location = new System.Drawing.Point(90, 37);
            this.BoxCaphca.Name = "BoxCaphca";
            this.BoxCaphca.Size = new System.Drawing.Size(164, 111);
            this.BoxCaphca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BoxCaphca.TabIndex = 2;
            this.BoxCaphca.TabStop = false;
            this.BoxCaphca.Click += new System.EventHandler(this.BoxCaphca_Click);
            // 
            // textEnt
            // 
            this.textEnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEnt.Location = new System.Drawing.Point(93, 154);
            this.textEnt.Name = "textEnt";
            this.textEnt.Size = new System.Drawing.Size(161, 20);
            this.textEnt.TabIndex = 3;
            // 
            // Caphca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 240);
            this.Controls.Add(this.textEnt);
            this.Controls.Add(this.BoxCaphca);
            this.Controls.Add(this.BtnObnov);
            this.Controls.Add(this.BtnEnt);
            this.Name = "Caphca";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Caphca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoxCaphca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEnt;
        private System.Windows.Forms.Button BtnObnov;
        private System.Windows.Forms.PictureBox BoxCaphca;
        private System.Windows.Forms.TextBox textEnt;
    }
}