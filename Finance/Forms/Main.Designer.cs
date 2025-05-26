namespace Finance
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxRecent = new System.Windows.Forms.ListBox();
            this.labelLastOperation = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelBalance);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 149);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBoxRecent);
            this.panel2.Controls.Add(this.labelLastOperation);
            this.panel2.Location = new System.Drawing.Point(3, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 110);
            this.panel2.TabIndex = 1;
            // 
            // listBoxRecent
            // 
            this.listBoxRecent.FormattingEnabled = true;
            this.listBoxRecent.Location = new System.Drawing.Point(124, 3);
            this.listBoxRecent.Name = "listBoxRecent";
            this.listBoxRecent.Size = new System.Drawing.Size(212, 95);
            this.listBoxRecent.TabIndex = 1;
            // 
            // labelLastOperation
            // 
            this.labelLastOperation.AutoSize = true;
            this.labelLastOperation.Location = new System.Drawing.Point(10, 0);
            this.labelLastOperation.Name = "labelLastOperation";
            this.labelLastOperation.Size = new System.Drawing.Size(114, 13);
            this.labelLastOperation.TabIndex = 0;
            this.labelLastOperation.Text = "Последняя операция";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(13, 4);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(97, 13);
            this.labelBalance.TabIndex = 0;
            this.labelBalance.Text = "Текущий балланс";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReport);
            this.panel3.Controls.Add(this.btnSettings);
            this.panel3.Controls.Add(this.btnHistory);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(12, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 277);
            this.panel3.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(3, 71);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(333, 32);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Отчёт";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(3, 37);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(333, 32);
            this.btnHistory.TabIndex = 0;
            this.btnHistory.Text = "История";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(333, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить операцию";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(3, 106);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(333, 32);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelLastOperation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxRecent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSettings;
    }
}

