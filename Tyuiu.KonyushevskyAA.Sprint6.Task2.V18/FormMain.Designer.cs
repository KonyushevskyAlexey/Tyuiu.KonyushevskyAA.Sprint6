
namespace Tyuiu.KonyushevskyAA.Sprint6.Task2.V18
{
    partial class FormMainTask_KAA
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
            this.groupBoxTask_KAA = new System.Windows.Forms.GroupBox();
            this.labelTask_KAA = new System.Windows.Forms.Label();
            this.groupBoxVvod_KAA = new System.Windows.Forms.GroupBox();
            this.labelstop_KAA = new System.Windows.Forms.Label();
            this.labelstart_KAA = new System.Windows.Forms.Label();
            this.textBoxstop_KAA = new System.Windows.Forms.TextBox();
            this.textBoxstart_KAA = new System.Windows.Forms.TextBox();
            this.buttonHelp_KAA = new System.Windows.Forms.Button();
            this.buttonDone_KAA = new System.Windows.Forms.Button();
            this.groupBox_KAA = new System.Windows.Forms.GroupBox();
            this.dataGridView_KAA = new System.Windows.Forms.DataGridView();
            this.labelResult_KAA = new System.Windows.Forms.Label();
            this.chartFuction_KAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxVvod_KAA.SuspendLayout();
            this.groupBox_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFuction_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KAA
            // 
            this.groupBoxTask_KAA.Location = new System.Drawing.Point(33, 25);
            this.groupBoxTask_KAA.Name = "groupBoxTask_KAA";
            this.groupBoxTask_KAA.Size = new System.Drawing.Size(478, 332);
            this.groupBoxTask_KAA.TabIndex = 0;
            this.groupBoxTask_KAA.TabStop = false;
            this.groupBoxTask_KAA.Text = "Условие";
            // 
            // labelTask_KAA
            // 
            this.labelTask_KAA.Location = new System.Drawing.Point(39, 51);
            this.labelTask_KAA.Name = "labelTask_KAA";
            this.labelTask_KAA.Size = new System.Drawing.Size(354, 39);
            this.labelTask_KAA.TabIndex = 0;
            this.labelTask_KAA.Text = "Протабулировать функцию на заданном диапазоне . Результат вывести в DataGridView " +
    "и построить график функции ";
            // 
            // groupBoxVvod_KAA
            // 
            this.groupBoxVvod_KAA.Controls.Add(this.labelstop_KAA);
            this.groupBoxVvod_KAA.Controls.Add(this.labelstart_KAA);
            this.groupBoxVvod_KAA.Controls.Add(this.textBoxstop_KAA);
            this.groupBoxVvod_KAA.Controls.Add(this.textBoxstart_KAA);
            this.groupBoxVvod_KAA.Location = new System.Drawing.Point(33, 363);
            this.groupBoxVvod_KAA.Name = "groupBoxVvod_KAA";
            this.groupBoxVvod_KAA.Size = new System.Drawing.Size(275, 75);
            this.groupBoxVvod_KAA.TabIndex = 1;
            this.groupBoxVvod_KAA.TabStop = false;
            this.groupBoxVvod_KAA.Text = "Ввод данных ";
            // 
            // labelstop_KAA
            // 
            this.labelstop_KAA.AutoSize = true;
            this.labelstop_KAA.Location = new System.Drawing.Point(143, 13);
            this.labelstop_KAA.Name = "labelstop_KAA";
            this.labelstop_KAA.Size = new System.Drawing.Size(72, 13);
            this.labelstop_KAA.TabIndex = 1;
            this.labelstop_KAA.Text = "Конец шага :";
            // 
            // labelstart_KAA
            // 
            this.labelstart_KAA.AutoSize = true;
            this.labelstart_KAA.Location = new System.Drawing.Point(6, 13);
            this.labelstart_KAA.Name = "labelstart_KAA";
            this.labelstart_KAA.Size = new System.Drawing.Size(70, 13);
            this.labelstart_KAA.TabIndex = 1;
            this.labelstart_KAA.Text = "Старт шага :";
            // 
            // textBoxstop_KAA
            // 
            this.textBoxstop_KAA.Location = new System.Drawing.Point(146, 32);
            this.textBoxstop_KAA.Name = "textBoxstop_KAA";
            this.textBoxstop_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxstop_KAA.TabIndex = 0;
            // 
            // textBoxstart_KAA
            // 
            this.textBoxstart_KAA.Location = new System.Drawing.Point(9, 32);
            this.textBoxstart_KAA.Name = "textBoxstart_KAA";
            this.textBoxstart_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxstart_KAA.TabIndex = 0;
            // 
            // buttonHelp_KAA
            // 
            this.buttonHelp_KAA.Location = new System.Drawing.Point(318, 376);
            this.buttonHelp_KAA.Name = "buttonHelp_KAA";
            this.buttonHelp_KAA.Size = new System.Drawing.Size(75, 62);
            this.buttonHelp_KAA.TabIndex = 2;
            this.buttonHelp_KAA.Text = "Справка";
            this.buttonHelp_KAA.UseVisualStyleBackColor = true;
            this.buttonHelp_KAA.Click += new System.EventHandler(this.buttonHelp_KAA_Click);
            // 
            // buttonDone_KAA
            // 
            this.buttonDone_KAA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KAA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDone_KAA.Location = new System.Drawing.Point(400, 376);
            this.buttonDone_KAA.Name = "buttonDone_KAA";
            this.buttonDone_KAA.Size = new System.Drawing.Size(111, 62);
            this.buttonDone_KAA.TabIndex = 3;
            this.buttonDone_KAA.Text = "Выполнить";
            this.buttonDone_KAA.UseVisualStyleBackColor = false;
            this.buttonDone_KAA.Click += new System.EventHandler(this.buttonDone_KAA_Click);
            this.buttonDone_KAA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_KAA_MouseDown);
            this.buttonDone_KAA.MouseEnter += new System.EventHandler(this.buttonDone_KAA_MouseEnter);
            this.buttonDone_KAA.MouseLeave += new System.EventHandler(this.buttonDone_KAA_MouseLeave);
            // 
            // groupBox_KAA
            // 
            this.groupBox_KAA.Controls.Add(this.chartFuction_KAA);
            this.groupBox_KAA.Controls.Add(this.labelResult_KAA);
            this.groupBox_KAA.Controls.Add(this.dataGridView_KAA);
            this.groupBox_KAA.Location = new System.Drawing.Point(541, 25);
            this.groupBox_KAA.Name = "groupBox_KAA";
            this.groupBox_KAA.Size = new System.Drawing.Size(672, 390);
            this.groupBox_KAA.TabIndex = 4;
            this.groupBox_KAA.TabStop = false;
            this.groupBox_KAA.Text = "Вывод данных";
            // 
            // dataGridView_KAA
            // 
            this.dataGridView_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView_KAA.Location = new System.Drawing.Point(6, 37);
            this.dataGridView_KAA.Name = "dataGridView_KAA";
            this.dataGridView_KAA.RowHeadersVisible = false;
            this.dataGridView_KAA.RowHeadersWidth = 62;
            this.dataGridView_KAA.Size = new System.Drawing.Size(103, 347);
            this.dataGridView_KAA.TabIndex = 0;
            this.dataGridView_KAA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KAA_CellContentClick);
            // 
            // labelResult_KAA
            // 
            this.labelResult_KAA.AutoSize = true;
            this.labelResult_KAA.Location = new System.Drawing.Point(7, 18);
            this.labelResult_KAA.Name = "labelResult_KAA";
            this.labelResult_KAA.Size = new System.Drawing.Size(65, 13);
            this.labelResult_KAA.TabIndex = 1;
            this.labelResult_KAA.Text = "Результат :";
            // 
            // chartFuction_KAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFuction_KAA.ChartAreas.Add(chartArea2);
            this.chartFuction_KAA.Location = new System.Drawing.Point(223, 37);
            this.chartFuction_KAA.Name = "chartFuction_KAA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Name = "Series1";
            this.chartFuction_KAA.Series.Add(series2);
            this.chartFuction_KAA.Size = new System.Drawing.Size(412, 300);
            this.chartFuction_KAA.TabIndex = 2;
            this.chartFuction_KAA.Text = "chart1";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(x)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // FormMainTask_KAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 450);
            this.Controls.Add(this.groupBox_KAA);
            this.Controls.Add(this.buttonDone_KAA);
            this.Controls.Add(this.buttonHelp_KAA);
            this.Controls.Add(this.groupBoxVvod_KAA);
            this.Controls.Add(this.labelTask_KAA);
            this.Controls.Add(this.groupBoxTask_KAA);
            this.Name = "FormMainTask_KAA";
            this.Text = "Спринт 6 | Таск 2 | Вариант 18 | Конюшевский А.А";
            this.groupBoxVvod_KAA.ResumeLayout(false);
            this.groupBoxVvod_KAA.PerformLayout();
            this.groupBox_KAA.ResumeLayout(false);
            this.groupBox_KAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFuction_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KAA;
        private System.Windows.Forms.Label labelTask_KAA;
        private System.Windows.Forms.GroupBox groupBoxVvod_KAA;
        private System.Windows.Forms.TextBox textBoxstop_KAA;
        private System.Windows.Forms.TextBox textBoxstart_KAA;
        private System.Windows.Forms.Label labelstop_KAA;
        private System.Windows.Forms.Label labelstart_KAA;
        private System.Windows.Forms.Button buttonHelp_KAA;
        private System.Windows.Forms.Button buttonDone_KAA;
        private System.Windows.Forms.GroupBox groupBox_KAA;
        private System.Windows.Forms.DataGridView dataGridView_KAA;
        private System.Windows.Forms.Label labelResult_KAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFuction_KAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

