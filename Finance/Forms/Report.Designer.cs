namespace Finance.Forms
{
    partial class Report
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelExpenditure = new System.Windows.Forms.Label();
            this.labelIncome = new System.Windows.Forms.Label();
            this.viewReport = new System.Windows.Forms.Button();
            this.dateEndPeriod = new System.Windows.Forms.DateTimePicker();
            this.endPeriod = new System.Windows.Forms.Label();
            this.beginningPeriod = new System.Windows.Forms.Label();
            this.dateBeginningPeriod = new System.Windows.Forms.DateTimePicker();
            this.chartGroup = new System.Windows.Forms.GroupBox();
            this.panelChart = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.chartGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelBalance);
            this.panel1.Controls.Add(this.labelExpenditure);
            this.panel1.Controls.Add(this.labelIncome);
            this.panel1.Controls.Add(this.viewReport);
            this.panel1.Controls.Add(this.dateEndPeriod);
            this.panel1.Controls.Add(this.endPeriod);
            this.panel1.Controls.Add(this.beginningPeriod);
            this.panel1.Controls.Add(this.dateBeginningPeriod);
            this.panel1.Location = new System.Drawing.Point(12, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 159);
            this.panel1.TabIndex = 0;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(3, 100);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(44, 13);
            this.labelBalance.TabIndex = 6;
            this.labelBalance.Text = "Баланс";
            // 
            // labelExpenditure
            // 
            this.labelExpenditure.AutoSize = true;
            this.labelExpenditure.Location = new System.Drawing.Point(3, 80);
            this.labelExpenditure.Name = "labelExpenditure";
            this.labelExpenditure.Size = new System.Drawing.Size(43, 13);
            this.labelExpenditure.TabIndex = 5;
            this.labelExpenditure.Text = "Расход";
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Location = new System.Drawing.Point(3, 63);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(39, 13);
            this.labelIncome.TabIndex = 4;
            this.labelIncome.Text = "Доход";
            // 
            // viewReport
            // 
            this.viewReport.Location = new System.Drawing.Point(6, 125);
            this.viewReport.Name = "viewReport";
            this.viewReport.Size = new System.Drawing.Size(200, 26);
            this.viewReport.TabIndex = 3;
            this.viewReport.Text = "Построить отчёт";
            this.viewReport.UseVisualStyleBackColor = true;
            this.viewReport.Click += new System.EventHandler(this.viewReport_Click);
            // 
            // dateEndPeriod
            // 
            this.dateEndPeriod.Location = new System.Drawing.Point(4, 32);
            this.dateEndPeriod.Name = "dateEndPeriod";
            this.dateEndPeriod.Size = new System.Drawing.Size(200, 20);
            this.dateEndPeriod.TabIndex = 2;
            // 
            // endPeriod
            // 
            this.endPeriod.AutoSize = true;
            this.endPeriod.Location = new System.Drawing.Point(211, 38);
            this.endPeriod.Name = "endPeriod";
            this.endPeriod.Size = new System.Drawing.Size(83, 13);
            this.endPeriod.TabIndex = 1;
            this.endPeriod.Text = "Конец периода";
            // 
            // beginningPeriod
            // 
            this.beginningPeriod.AutoSize = true;
            this.beginningPeriod.Location = new System.Drawing.Point(211, 11);
            this.beginningPeriod.Name = "beginningPeriod";
            this.beginningPeriod.Size = new System.Drawing.Size(89, 13);
            this.beginningPeriod.TabIndex = 1;
            this.beginningPeriod.Text = "Начало периода";
            // 
            // dateBeginningPeriod
            // 
            this.dateBeginningPeriod.Location = new System.Drawing.Point(4, 5);
            this.dateBeginningPeriod.Name = "dateBeginningPeriod";
            this.dateBeginningPeriod.Size = new System.Drawing.Size(200, 20);
            this.dateBeginningPeriod.TabIndex = 0;
            // 
            // chartGroup
            // 
            this.chartGroup.Controls.Add(this.panelChart);
            this.chartGroup.Location = new System.Drawing.Point(12, 13);
            this.chartGroup.Name = "chartGroup";
            this.chartGroup.Size = new System.Drawing.Size(593, 265);
            this.chartGroup.TabIndex = 1;
            this.chartGroup.TabStop = false;
            this.chartGroup.Text = "Гистограмма";
            // 
            // panelChart
            // 
            this.panelChart.Location = new System.Drawing.Point(5, 15);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(582, 244);
            this.panelChart.TabIndex = 0;
            this.panelChart.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChart_Paint);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.chartGroup);
            this.Controls.Add(this.panel1);
            this.Name = "Report";
            this.Text = "Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateBeginningPeriod;
        private System.Windows.Forms.Label beginningPeriod;
        private System.Windows.Forms.DateTimePicker dateEndPeriod;
        private System.Windows.Forms.Label endPeriod;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Button viewReport;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelExpenditure;
        private System.Windows.Forms.GroupBox chartGroup;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelChart;
    }
}