
namespace Tyuiu.KonyushevskyAA.Sprint6.Task6.V20
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonOpenFile_KAA = new System.Windows.Forms.Button();
            this.buttonHelp_KAA = new System.Windows.Forms.Button();
            this.buttonDone_KAA = new System.Windows.Forms.Button();
            this.openFileDialogTask_KAA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_KAA = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxTask_KAA = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_KAA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxLoadFromFile_KAA = new System.Windows.Forms.TextBox();
            this.textBoxResult_KAA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_KAA.SuspendLayout();
            this.groupBoxInPut_KAA.SuspendLayout();
            this.groupBoxOutPut_KAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile_KAA
            // 
            this.buttonOpenFile_KAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_KAA.Image")));
            this.buttonOpenFile_KAA.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenFile_KAA.Name = "buttonOpenFile_KAA";
            this.buttonOpenFile_KAA.Size = new System.Drawing.Size(82, 56);
            this.buttonOpenFile_KAA.TabIndex = 0;
            this.toolTip_KAA.SetToolTip(this.buttonOpenFile_KAA, "Открыть файл \r\nВыберите нужный файл для обработки \r\n");
            this.buttonOpenFile_KAA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_KAA.Click += new System.EventHandler(this.buttonOpenFile_KAA_Click);
            // 
            // buttonHelp_KAA
            // 
            this.buttonHelp_KAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_KAA.Image")));
            this.buttonHelp_KAA.Location = new System.Drawing.Point(697, 12);
            this.buttonHelp_KAA.Name = "buttonHelp_KAA";
            this.buttonHelp_KAA.Size = new System.Drawing.Size(91, 57);
            this.buttonHelp_KAA.TabIndex = 1;
            this.toolTip_KAA.SetToolTip(this.buttonHelp_KAA, "Сведение о программе");
            this.buttonHelp_KAA.UseVisualStyleBackColor = true;
            this.buttonHelp_KAA.Click += new System.EventHandler(this.buttonHelp_KAA_Click);
            // 
            // buttonDone_KAA
            // 
            this.buttonDone_KAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_KAA.Image")));
            this.buttonDone_KAA.Location = new System.Drawing.Point(114, 13);
            this.buttonDone_KAA.Name = "buttonDone_KAA";
            this.buttonDone_KAA.Size = new System.Drawing.Size(87, 56);
            this.buttonDone_KAA.TabIndex = 2;
            this.toolTip_KAA.SetToolTip(this.buttonDone_KAA, " Вывести второе слово каждой строки в результирующею строку и вывести ее\r\n");
            this.buttonDone_KAA.UseVisualStyleBackColor = true;
            this.buttonDone_KAA.Click += new System.EventHandler(this.buttonDone_KAA_Click);
            // 
            // openFileDialogTask_KAA
            // 
            this.openFileDialogTask_KAA.FileName = "openFileDialog1";
            // 
            // toolTip_KAA
            // 
            this.toolTip_KAA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_KAA.ToolTipTitle = "Подсказка";
            // 
            // groupBoxTask_KAA
            // 
            this.groupBoxTask_KAA.Controls.Add(this.textBox1);
            this.groupBoxTask_KAA.Location = new System.Drawing.Point(13, 76);
            this.groupBoxTask_KAA.Name = "groupBoxTask_KAA";
            this.groupBoxTask_KAA.Size = new System.Drawing.Size(775, 71);
            this.groupBoxTask_KAA.TabIndex = 3;
            this.groupBoxTask_KAA.TabStop = false;
            this.groupBoxTask_KAA.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(751, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxInPut_KAA
            // 
            this.groupBoxInPut_KAA.Controls.Add(this.textBoxLoadFromFile_KAA);
            this.groupBoxInPut_KAA.Location = new System.Drawing.Point(13, 154);
            this.groupBoxInPut_KAA.Name = "groupBoxInPut_KAA";
            this.groupBoxInPut_KAA.Size = new System.Drawing.Size(350, 284);
            this.groupBoxInPut_KAA.TabIndex = 4;
            this.groupBoxInPut_KAA.TabStop = false;
            this.groupBoxInPut_KAA.Text = "Ввод:";
            // 
            // groupBoxOutPut_KAA
            // 
            this.groupBoxOutPut_KAA.Controls.Add(this.textBoxResult_KAA);
            this.groupBoxOutPut_KAA.Location = new System.Drawing.Point(386, 154);
            this.groupBoxOutPut_KAA.Name = "groupBoxOutPut_KAA";
            this.groupBoxOutPut_KAA.Size = new System.Drawing.Size(402, 284);
            this.groupBoxOutPut_KAA.TabIndex = 5;
            this.groupBoxOutPut_KAA.TabStop = false;
            this.groupBoxOutPut_KAA.Text = "Вывод:";
            // 
            // textBoxLoadFromFile_KAA
            // 
            this.textBoxLoadFromFile_KAA.Location = new System.Drawing.Point(7, 19);
            this.textBoxLoadFromFile_KAA.Multiline = true;
            this.textBoxLoadFromFile_KAA.Name = "textBoxLoadFromFile_KAA";
            this.textBoxLoadFromFile_KAA.Size = new System.Drawing.Size(337, 258);
            this.textBoxLoadFromFile_KAA.TabIndex = 0;
            // 
            // textBoxResult_KAA
            // 
            this.textBoxResult_KAA.Location = new System.Drawing.Point(7, 19);
            this.textBoxResult_KAA.Multiline = true;
            this.textBoxResult_KAA.Name = "textBoxResult_KAA";
            this.textBoxResult_KAA.Size = new System.Drawing.Size(378, 258);
            this.textBoxResult_KAA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOutPut_KAA);
            this.Controls.Add(this.groupBoxInPut_KAA);
            this.Controls.Add(this.groupBoxTask_KAA);
            this.Controls.Add(this.buttonDone_KAA);
            this.Controls.Add(this.buttonHelp_KAA);
            this.Controls.Add(this.buttonOpenFile_KAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 20 | Конюшевский А.А";
            this.groupBoxTask_KAA.ResumeLayout(false);
            this.groupBoxTask_KAA.PerformLayout();
            this.groupBoxInPut_KAA.ResumeLayout(false);
            this.groupBoxInPut_KAA.PerformLayout();
            this.groupBoxOutPut_KAA.ResumeLayout(false);
            this.groupBoxOutPut_KAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_KAA;
        private System.Windows.Forms.ToolTip toolTip_KAA;
        private System.Windows.Forms.Button buttonHelp_KAA;
        private System.Windows.Forms.Button buttonDone_KAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KAA;
        private System.Windows.Forms.GroupBox groupBoxTask_KAA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxInPut_KAA;
        private System.Windows.Forms.TextBox textBoxLoadFromFile_KAA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KAA;
        private System.Windows.Forms.TextBox textBoxResult_KAA;
    }
}

