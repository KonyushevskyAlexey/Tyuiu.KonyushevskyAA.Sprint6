
namespace Tyuiu.KonyushevskyAA.Sprint6.Task5.V2
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxOne_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxOne_KAA = new System.Windows.Forms.TextBox();
            this.groupBoxTwo_KAA = new System.Windows.Forms.GroupBox();
            this.buttonDone_KAA = new System.Windows.Forms.Button();
            this.buttonOpenFile_KAA = new System.Windows.Forms.Button();
            this.buttonHelp_KAA = new System.Windows.Forms.Button();
            this.chartDiag_KAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewNums_KAA = new System.Windows.Forms.DataGridView();
            this.groupBoxOne_KAA.SuspendLayout();
            this.groupBoxTwo_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_KAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOne_KAA
            // 
            this.groupBoxOne_KAA.Controls.Add(this.textBoxOne_KAA);
            this.groupBoxOne_KAA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxOne_KAA.Name = "groupBoxOne_KAA";
            this.groupBoxOne_KAA.Size = new System.Drawing.Size(462, 92);
            this.groupBoxOne_KAA.TabIndex = 0;
            this.groupBoxOne_KAA.TabStop = false;
            this.groupBoxOne_KAA.Text = "Условие";
            // 
            // textBoxOne_KAA
            // 
            this.textBoxOne_KAA.Location = new System.Drawing.Point(7, 20);
            this.textBoxOne_KAA.Multiline = true;
            this.textBoxOne_KAA.Name = "textBoxOne_KAA";
            this.textBoxOne_KAA.ReadOnly = true;
            this.textBoxOne_KAA.Size = new System.Drawing.Size(449, 66);
            this.textBoxOne_KAA.TabIndex = 0;
            this.textBoxOne_KAA.Text = "Прочитать данные из файла InPutFileTask5V2.txt. \r\nВывести в dataGridView. Вывести" +
    " все отрицательные числа.\r\nПостроить диаграмму по этим значениям. ";
            // 
            // groupBoxTwo_KAA
            // 
            this.groupBoxTwo_KAA.Controls.Add(this.dataGridViewNums_KAA);
            this.groupBoxTwo_KAA.Location = new System.Drawing.Point(20, 112);
            this.groupBoxTwo_KAA.Name = "groupBoxTwo_KAA";
            this.groupBoxTwo_KAA.Size = new System.Drawing.Size(195, 326);
            this.groupBoxTwo_KAA.TabIndex = 1;
            this.groupBoxTwo_KAA.TabStop = false;
            this.groupBoxTwo_KAA.Text = "Вывод данных :";
            // 
            // buttonDone_KAA
            // 
            this.buttonDone_KAA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KAA.Location = new System.Drawing.Point(493, 33);
            this.buttonDone_KAA.Name = "buttonDone_KAA";
            this.buttonDone_KAA.Size = new System.Drawing.Size(90, 66);
            this.buttonDone_KAA.TabIndex = 2;
            this.buttonDone_KAA.Text = "Выполнить";
            this.buttonDone_KAA.UseVisualStyleBackColor = false;
            this.buttonDone_KAA.Click += new System.EventHandler(this.buttonDone_KAA_Click);
            // 
            // buttonOpenFile_KAA
            // 
            this.buttonOpenFile_KAA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpenFile_KAA.Location = new System.Drawing.Point(598, 39);
            this.buttonOpenFile_KAA.Name = "buttonOpenFile_KAA";
            this.buttonOpenFile_KAA.Size = new System.Drawing.Size(82, 55);
            this.buttonOpenFile_KAA.TabIndex = 3;
            this.buttonOpenFile_KAA.Text = "Открыть файл";
            this.buttonOpenFile_KAA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_KAA.Click += new System.EventHandler(this.buttonOpenFile_KAA_Click);
            // 
            // buttonHelp_KAA
            // 
            this.buttonHelp_KAA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_KAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_KAA.Location = new System.Drawing.Point(697, 39);
            this.buttonHelp_KAA.Name = "buttonHelp_KAA";
            this.buttonHelp_KAA.Size = new System.Drawing.Size(77, 55);
            this.buttonHelp_KAA.TabIndex = 4;
            this.buttonHelp_KAA.Text = "Справка";
            this.buttonHelp_KAA.UseVisualStyleBackColor = false;
            this.buttonHelp_KAA.Click += new System.EventHandler(this.buttonHelp_KAA_Click);
            // 
            // chartDiag_KAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDiag_KAA.ChartAreas.Add(chartArea2);
            this.chartDiag_KAA.Location = new System.Drawing.Point(240, 112);
            this.chartDiag_KAA.Name = "chartDiag_KAA";
            this.chartDiag_KAA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chartDiag_KAA.Series.Add(series2);
            this.chartDiag_KAA.Size = new System.Drawing.Size(534, 326);
            this.chartDiag_KAA.TabIndex = 5;
            this.chartDiag_KAA.Text = "chart1";
            // 
            // dataGridViewNums_KAA
            // 
            this.dataGridViewNums_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_KAA.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewNums_KAA.Name = "dataGridViewNums_KAA";
            this.dataGridViewNums_KAA.RowHeadersWidth = 62;
            this.dataGridViewNums_KAA.Size = new System.Drawing.Size(169, 300);
            this.dataGridViewNums_KAA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartDiag_KAA);
            this.Controls.Add(this.buttonHelp_KAA);
            this.Controls.Add(this.buttonOpenFile_KAA);
            this.Controls.Add(this.buttonDone_KAA);
            this.Controls.Add(this.groupBoxTwo_KAA);
            this.Controls.Add(this.groupBoxOne_KAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 2 | Конюшевский А.А";
            this.groupBoxOne_KAA.ResumeLayout(false);
            this.groupBoxOne_KAA.PerformLayout();
            this.groupBoxTwo_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_KAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOne_KAA;
        private System.Windows.Forms.TextBox textBoxOne_KAA;
        private System.Windows.Forms.GroupBox groupBoxTwo_KAA;
        private System.Windows.Forms.Button buttonDone_KAA;
        private System.Windows.Forms.Button buttonOpenFile_KAA;
        private System.Windows.Forms.Button buttonHelp_KAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_KAA;
        private System.Windows.Forms.DataGridView dataGridViewNums_KAA;
    }
}

