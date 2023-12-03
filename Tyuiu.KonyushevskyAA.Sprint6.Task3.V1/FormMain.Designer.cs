
namespace Tyuiu.KonyushevskyAA.Sprint6.Task3.V1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KAA));
            this.groupBoxOne_KAA = new System.Windows.Forms.GroupBox();
            this.groupBoxTwo_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KAA = new System.Windows.Forms.TextBox();
            this.labelresult_KAA = new System.Windows.Forms.Label();
            this.labelmtrx_KAA = new System.Windows.Forms.Label();
            this.dataGridView_KAA = new System.Windows.Forms.DataGridView();
            this.buttondone_KAA = new System.Windows.Forms.Button();
            this.buttonHelp_KAA = new System.Windows.Forms.Button();
            this.textBoxTask_KAA = new System.Windows.Forms.TextBox();
            this.groupBoxOne_KAA.SuspendLayout();
            this.groupBoxTwo_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOne_KAA
            // 
            this.groupBoxOne_KAA.Controls.Add(this.textBoxTask_KAA);
            this.groupBoxOne_KAA.Controls.Add(this.dataGridView_KAA);
            this.groupBoxOne_KAA.Controls.Add(this.labelmtrx_KAA);
            this.groupBoxOne_KAA.Location = new System.Drawing.Point(27, 27);
            this.groupBoxOne_KAA.Name = "groupBoxOne_KAA";
            this.groupBoxOne_KAA.Size = new System.Drawing.Size(578, 396);
            this.groupBoxOne_KAA.TabIndex = 0;
            this.groupBoxOne_KAA.TabStop = false;
            this.groupBoxOne_KAA.Text = "Условие ";
            // 
            // groupBoxTwo_KAA
            // 
            this.groupBoxTwo_KAA.Controls.Add(this.labelresult_KAA);
            this.groupBoxTwo_KAA.Controls.Add(this.textBoxResult_KAA);
            this.groupBoxTwo_KAA.Location = new System.Drawing.Point(611, 27);
            this.groupBoxTwo_KAA.Name = "groupBoxTwo_KAA";
            this.groupBoxTwo_KAA.Size = new System.Drawing.Size(177, 79);
            this.groupBoxTwo_KAA.TabIndex = 0;
            this.groupBoxTwo_KAA.TabStop = false;
            this.groupBoxTwo_KAA.Text = "Вывод данных:";
            // 
            // textBoxResult_KAA
            // 
            this.textBoxResult_KAA.Location = new System.Drawing.Point(7, 37);
            this.textBoxResult_KAA.Name = "textBoxResult_KAA";
            this.textBoxResult_KAA.ReadOnly = true;
            this.textBoxResult_KAA.Size = new System.Drawing.Size(164, 20);
            this.textBoxResult_KAA.TabIndex = 0;
            // 
            // labelresult_KAA
            // 
            this.labelresult_KAA.AutoSize = true;
            this.labelresult_KAA.Location = new System.Drawing.Point(16, 21);
            this.labelresult_KAA.Name = "labelresult_KAA";
            this.labelresult_KAA.Size = new System.Drawing.Size(65, 13);
            this.labelresult_KAA.TabIndex = 1;
            this.labelresult_KAA.Text = "Результат :";
            // 
            // labelmtrx_KAA
            // 
            this.labelmtrx_KAA.AutoSize = true;
            this.labelmtrx_KAA.Location = new System.Drawing.Point(6, 66);
            this.labelmtrx_KAA.Name = "labelmtrx_KAA";
            this.labelmtrx_KAA.Size = new System.Drawing.Size(0, 13);
            this.labelmtrx_KAA.TabIndex = 1;
            // 
            // dataGridView_KAA
            // 
            this.dataGridView_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KAA.Location = new System.Drawing.Point(277, 40);
            this.dataGridView_KAA.Name = "dataGridView_KAA";
            this.dataGridView_KAA.RowHeadersWidth = 62;
            this.dataGridView_KAA.Size = new System.Drawing.Size(280, 254);
            this.dataGridView_KAA.TabIndex = 3;
            // 
            // buttondone_KAA
            // 
            this.buttondone_KAA.Location = new System.Drawing.Point(683, 400);
            this.buttondone_KAA.Name = "buttondone_KAA";
            this.buttondone_KAA.Size = new System.Drawing.Size(75, 23);
            this.buttondone_KAA.TabIndex = 1;
            this.buttondone_KAA.Text = "Выполнить";
            this.buttondone_KAA.UseVisualStyleBackColor = true;
            this.buttondone_KAA.Click += new System.EventHandler(this.buttondone_KAA_Click);
            // 
            // buttonHelp_KAA
            // 
            this.buttonHelp_KAA.Location = new System.Drawing.Point(630, 400);
            this.buttonHelp_KAA.Name = "buttonHelp_KAA";
            this.buttonHelp_KAA.Size = new System.Drawing.Size(24, 23);
            this.buttonHelp_KAA.TabIndex = 2;
            this.buttonHelp_KAA.Text = "?";
            this.buttonHelp_KAA.UseVisualStyleBackColor = true;
            this.buttonHelp_KAA.Click += new System.EventHandler(this.buttonHelp_KAA_Click);
            // 
            // textBoxTask_KAA
            // 
            this.textBoxTask_KAA.Location = new System.Drawing.Point(9, 36);
            this.textBoxTask_KAA.Multiline = true;
            this.textBoxTask_KAA.Name = "textBoxTask_KAA";
            this.textBoxTask_KAA.ReadOnly = true;
            this.textBoxTask_KAA.Size = new System.Drawing.Size(245, 258);
            this.textBoxTask_KAA.TabIndex = 4;
            this.textBoxTask_KAA.Text = resources.GetString("textBoxTask_KAA.Text");
            // 
            // FormMain_KAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_KAA);
            this.Controls.Add(this.buttondone_KAA);
            this.Controls.Add(this.groupBoxTwo_KAA);
            this.Controls.Add(this.groupBoxOne_KAA);
            this.Name = "FormMain_KAA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 1 | Конюшевский А.А ";
            this.Load += new System.EventHandler(this.FormMain_KAA_Load);
            this.groupBoxOne_KAA.ResumeLayout(false);
            this.groupBoxOne_KAA.PerformLayout();
            this.groupBoxTwo_KAA.ResumeLayout(false);
            this.groupBoxTwo_KAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOne_KAA;
        private System.Windows.Forms.GroupBox groupBoxTwo_KAA;
        private System.Windows.Forms.TextBox textBoxResult_KAA;
        private System.Windows.Forms.Label labelmtrx_KAA;
        private System.Windows.Forms.Label labelresult_KAA;
        private System.Windows.Forms.DataGridView dataGridView_KAA;
        private System.Windows.Forms.Button buttondone_KAA;
        private System.Windows.Forms.Button buttonHelp_KAA;
        private System.Windows.Forms.TextBox textBoxTask_KAA;
    }
}

