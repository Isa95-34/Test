namespace TestForm2
{
    partial class FormEnter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnter));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textLog = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.checkCaphca = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(391, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // textLog
            // 
            this.textLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textLog.BackColor = System.Drawing.Color.Lime;
            this.textLog.Location = new System.Drawing.Point(397, 162);
            this.textLog.Margin = new System.Windows.Forms.Padding(4);
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(172, 26);
            this.textLog.TabIndex = 3;
            // 
            // textPass
            // 
            this.textPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPass.BackColor = System.Drawing.Color.Lime;
            this.textPass.Location = new System.Drawing.Point(397, 240);
            this.textPass.Margin = new System.Windows.Forms.Padding(4);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(172, 26);
            this.textPass.TabIndex = 4;
            // 
            // BtnEnter
            // 
            this.BtnEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnEnter.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEnter.Location = new System.Drawing.Point(422, 392);
            this.BtnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(100, 34);
            this.BtnEnter.TabIndex = 5;
            this.BtnEnter.Text = "Войти";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // checkCaphca
            // 
            this.checkCaphca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkCaphca.AutoSize = true;
            this.checkCaphca.Location = new System.Drawing.Point(369, 322);
            this.checkCaphca.Margin = new System.Windows.Forms.Padding(4);
            this.checkCaphca.Name = "checkCaphca";
            this.checkCaphca.Size = new System.Drawing.Size(216, 23);
            this.checkCaphca.TabIndex = 6;
            this.checkCaphca.Text = "Потвердите что вы не робот";
            this.checkCaphca.UseVisualStyleBackColor = true;
            this.checkCaphca.CheckedChanged += new System.EventHandler(this.checkCaphca_CheckedChanged);
            // 
            // FormEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.checkCaphca);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEnter";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.FormEnter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.CheckBox checkCaphca;
    }
}

