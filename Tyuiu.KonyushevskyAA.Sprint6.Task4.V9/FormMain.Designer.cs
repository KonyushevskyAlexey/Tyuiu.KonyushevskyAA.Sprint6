
namespace Tyuiu.KonyushevskyAA.Sprint6.Task4.V9
{
    partial class FormMain_KAA
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
            this.groupBoxTwo_KAA = new System.Windows.Forms.GroupBox();
            this.groupBoxTri_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KAA = new System.Windows.Forms.TextBox();
            this.textBoxResult_KAA = new System.Windows.Forms.TextBox();
            this.textBoxStart_KAA = new System.Windows.Forms.TextBox();
            this.textBoxStop_KAA = new System.Windows.Forms.TextBox();
            this.labelStart_KAA = new System.Windows.Forms.Label();
            this.labelStop_KAA = new System.Windows.Forms.Label();
            this.buttonDone_KAA = new System.Windows.Forms.Button();
            this.buttonSave_KAA = new System.Windows.Forms.Button();
            this.buttonHelp_KAA = new System.Windows.Forms.Button();
            this.chartFunction_KAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxOne_KAA.SuspendLayout();
            this.groupBoxTwo_KAA.SuspendLayout();
            this.groupBoxTri_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOne_KAA
            // 
            this.groupBoxOne_KAA.Controls.Add(this.textBoxTask_KAA);
            this.groupBoxOne_KAA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxOne_KAA.Name = "groupBoxOne_KAA";
            this.groupBoxOne_KAA.Size = new System.Drawing.Size(546, 112);
            this.groupBoxOne_KAA.TabIndex = 0;
            this.groupBoxOne_KAA.TabStop = false;
            this.groupBoxOne_KAA.Text = "Условие :";
            // 
            // groupBoxTwo_KAA
            // 
            this.groupBoxTwo_KAA.Controls.Add(this.labelStop_KAA);
            this.groupBoxTwo_KAA.Controls.Add(this.labelStart_KAA);
            this.groupBoxTwo_KAA.Controls.Add(this.textBoxStop_KAA);
            this.groupBoxTwo_KAA.Controls.Add(this.textBoxStart_KAA);
            this.groupBoxTwo_KAA.Location = new System.Drawing.Point(578, 13);
            this.groupBoxTwo_KAA.Name = "groupBoxTwo_KAA";
            this.groupBoxTwo_KAA.Size = new System.Drawing.Size(269, 112);
            this.groupBoxTwo_KAA.TabIndex = 1;
            this.groupBoxTwo_KAA.TabStop = false;
            this.groupBoxTwo_KAA.Text = "Ввод данных ";
            // 
            // groupBoxTri_KAA
            // 
            this.groupBoxTri_KAA.Controls.Add(this.textBoxResult_KAA);
            this.groupBoxTri_KAA.Location = new System.Drawing.Point(13, 132);
            this.groupBoxTri_KAA.Name = "groupBoxTri_KAA";
            this.groupBoxTri_KAA.Size = new System.Drawing.Size(332, 379);
            this.groupBoxTri_KAA.TabIndex = 2;
            this.groupBoxTri_KAA.TabStop = false;
            this.groupBoxTri_KAA.Text = "Вывод:";
            // 
            // textBoxTask_KAA
            // 
            this.textBoxTask_KAA.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_KAA.Multiline = true;
            this.textBoxTask_KAA.Name = "textBoxTask_KAA";
            this.textBoxTask_KAA.ReadOnly = true;
            this.textBoxTask_KAA.Size = new System.Drawing.Size(533, 77);
            this.textBoxTask_KAA.TabIndex = 0;
            this.textBoxTask_KAA.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5 \r\nРезультат вывести в te" +
    "xtBox . Построить график функции и сохранить в файл \r\nOutPutFileTask.txt по нажа" +
    "тию кнопки ";
            // 
            // textBoxResult_KAA
            // 
            this.textBoxResult_KAA.Location = new System.Drawing.Point(7, 20);
            this.textBoxResult_KAA.Multiline = true;
            this.textBoxResult_KAA.Name = "textBoxResult_KAA";
            this.textBoxResult_KAA.Size = new System.Drawing.Size(319, 353);
            this.textBoxResult_KAA.TabIndex = 0;
            // 
            // textBoxStart_KAA
            // 
            this.textBoxStart_KAA.Location = new System.Drawing.Point(7, 63);
            this.textBoxStart_KAA.Name = "textBoxStart_KAA";
            this.textBoxStart_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_KAA.TabIndex = 0;
            // 
            // textBoxStop_KAA
            // 
            this.textBoxStop_KAA.Location = new System.Drawing.Point(152, 62);
            this.textBoxStop_KAA.Name = "textBoxStop_KAA";
            this.textBoxStop_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_KAA.TabIndex = 1;
            // 
            // labelStart_KAA
            // 
            this.labelStart_KAA.AutoSize = true;
            this.labelStart_KAA.Location = new System.Drawing.Point(6, 38);
            this.labelStart_KAA.Name = "labelStart_KAA";
            this.labelStart_KAA.Size = new System.Drawing.Size(70, 13);
            this.labelStart_KAA.TabIndex = 2;
            this.labelStart_KAA.Text = "Старт шага :";
            // 
            // labelStop_KAA
            // 
            this.labelStop_KAA.AutoSize = true;
            this.labelStop_KAA.Location = new System.Drawing.Point(152, 38);
            this.labelStop_KAA.Name = "labelStop_KAA";
            this.labelStop_KAA.Size = new System.Drawing.Size(72, 13);
            this.labelStop_KAA.TabIndex = 3;
            this.labelStop_KAA.Text = "Конец шага :";
            // 
            // buttonDone_KAA
            // 
            this.buttonDone_KAA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KAA.Location = new System.Drawing.Point(874, 33);
            this.buttonDone_KAA.Name = "buttonDone_KAA";
            this.buttonDone_KAA.Size = new System.Drawing.Size(101, 63);
            this.buttonDone_KAA.TabIndex = 3;
            this.buttonDone_KAA.Text = "Выполнить ";
            this.buttonDone_KAA.UseVisualStyleBackColor = false;
            this.buttonDone_KAA.Click += new System.EventHandler(this.buttonDone_KAA_Click);
            // 
            // buttonSave_KAA
            // 
            this.buttonSave_KAA.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSave_KAA.Location = new System.Drawing.Point(981, 34);
            this.buttonSave_KAA.Name = "buttonSave_KAA";
            this.buttonSave_KAA.Size = new System.Drawing.Size(97, 62);
            this.buttonSave_KAA.TabIndex = 4;
            this.buttonSave_KAA.Text = "Сохранить ";
            this.buttonSave_KAA.UseVisualStyleBackColor = false;
            this.buttonSave_KAA.Click += new System.EventHandler(this.buttonSave_KAA_Click);
            // 
            // buttonHelp_KAA
            // 
            this.buttonHelp_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_KAA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_KAA.Location = new System.Drawing.Point(1084, 34);
            this.buttonHelp_KAA.Name = "buttonHelp_KAA";
            this.buttonHelp_KAA.Size = new System.Drawing.Size(89, 61);
            this.buttonHelp_KAA.TabIndex = 5;
            this.buttonHelp_KAA.Text = "Справка ";
            this.buttonHelp_KAA.UseVisualStyleBackColor = false;
            this.buttonHelp_KAA.Click += new System.EventHandler(this.buttonHelp_KAA_Click);
            // 
            // chartFunction_KAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_KAA.ChartAreas.Add(chartArea2);
            this.chartFunction_KAA.Location = new System.Drawing.Point(375, 132);
            this.chartFunction_KAA.Name = "chartFunction_KAA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Name = "Series1";
            this.chartFunction_KAA.Series.Add(series2);
            this.chartFunction_KAA.Size = new System.Drawing.Size(765, 379);
            this.chartFunction_KAA.TabIndex = 6;
            this.chartFunction_KAA.Text = "chart1";
            // 
            // FormMain_KAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 523);
            this.Controls.Add(this.chartFunction_KAA);
            this.Controls.Add(this.buttonHelp_KAA);
            this.Controls.Add(this.buttonSave_KAA);
            this.Controls.Add(this.buttonDone_KAA);
            this.Controls.Add(this.groupBoxTri_KAA);
            this.Controls.Add(this.groupBoxTwo_KAA);
            this.Controls.Add(this.groupBoxOne_KAA);
            this.Name = "FormMain_KAA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 9 | Конюшевский А.А";
            this.groupBoxOne_KAA.ResumeLayout(false);
            this.groupBoxOne_KAA.PerformLayout();
            this.groupBoxTwo_KAA.ResumeLayout(false);
            this.groupBoxTwo_KAA.PerformLayout();
            this.groupBoxTri_KAA.ResumeLayout(false);
            this.groupBoxTri_KAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOne_KAA;
        private System.Windows.Forms.TextBox textBoxTask_KAA;
        private System.Windows.Forms.GroupBox groupBoxTwo_KAA;
        private System.Windows.Forms.GroupBox groupBoxTri_KAA;
        private System.Windows.Forms.Label labelStop_KAA;
        private System.Windows.Forms.Label labelStart_KAA;
        private System.Windows.Forms.TextBox textBoxStop_KAA;
        private System.Windows.Forms.TextBox textBoxStart_KAA;
        private System.Windows.Forms.TextBox textBoxResult_KAA;
        private System.Windows.Forms.Button buttonDone_KAA;
        private System.Windows.Forms.Button buttonSave_KAA;
        private System.Windows.Forms.Button buttonHelp_KAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KAA;
    }
}

