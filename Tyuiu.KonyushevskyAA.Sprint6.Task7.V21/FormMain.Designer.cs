
namespace Tyuiu.KonyushevskyAA.Sprint6.Task7.V21
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
            this.panelTap_KAA = new System.Windows.Forms.Panel();
            this.panelcenter_KAA = new System.Windows.Forms.Panel();
            this.panelleft_KAA = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.buttonOpenFile_KAA = new System.Windows.Forms.Button();
            this.buttonDone_KAA = new System.Windows.Forms.Button();
            this.buttonSaveFile_KAA = new System.Windows.Forms.Button();
            this.buttonhelp_KAA = new System.Windows.Forms.Button();
            this.openFileDialogTask_KAA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_KAA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_KAA = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxOne_KAA = new System.Windows.Forms.GroupBox();
            this.groupBoxTwo_KAA = new System.Windows.Forms.GroupBox();
            this.groupBoxThri_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KAA = new System.Windows.Forms.TextBox();
            this.dataGridViewInput_KAA = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutput_KAA = new System.Windows.Forms.DataGridView();
            this.panelTap_KAA.SuspendLayout();
            this.panelcenter_KAA.SuspendLayout();
            this.panelleft_KAA.SuspendLayout();
            this.panel.SuspendLayout();
            this.groupBoxOne_KAA.SuspendLayout();
            this.groupBoxTwo_KAA.SuspendLayout();
            this.groupBoxThri_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_KAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTap_KAA
            // 
            this.panelTap_KAA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTap_KAA.Controls.Add(this.buttonhelp_KAA);
            this.panelTap_KAA.Controls.Add(this.buttonSaveFile_KAA);
            this.panelTap_KAA.Controls.Add(this.buttonDone_KAA);
            this.panelTap_KAA.Controls.Add(this.buttonOpenFile_KAA);
            this.panelTap_KAA.Location = new System.Drawing.Point(1, 1);
            this.panelTap_KAA.Name = "panelTap_KAA";
            this.panelTap_KAA.Size = new System.Drawing.Size(795, 92);
            this.panelTap_KAA.TabIndex = 0;
            // 
            // panelcenter_KAA
            // 
            this.panelcenter_KAA.Controls.Add(this.groupBoxOne_KAA);
            this.panelcenter_KAA.Location = new System.Drawing.Point(1, 94);
            this.panelcenter_KAA.Name = "panelcenter_KAA";
            this.panelcenter_KAA.Size = new System.Drawing.Size(795, 94);
            this.panelcenter_KAA.TabIndex = 1;
            // 
            // panelleft_KAA
            // 
            this.panelleft_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelleft_KAA.Controls.Add(this.groupBoxTwo_KAA);
            this.panelleft_KAA.Location = new System.Drawing.Point(1, 195);
            this.panelleft_KAA.Name = "panelleft_KAA";
            this.panelleft_KAA.Size = new System.Drawing.Size(392, 243);
            this.panelleft_KAA.TabIndex = 2;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.groupBoxThri_KAA);
            this.panel.Controls.Add(this.splitter1);
            this.panel.Location = new System.Drawing.Point(399, 195);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(392, 243);
            this.panel.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 243);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // buttonOpenFile_KAA
            // 
            this.buttonOpenFile_KAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_KAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_KAA.Image")));
            this.buttonOpenFile_KAA.Location = new System.Drawing.Point(4, 4);
            this.buttonOpenFile_KAA.Name = "buttonOpenFile_KAA";
            this.buttonOpenFile_KAA.Size = new System.Drawing.Size(109, 83);
            this.buttonOpenFile_KAA.TabIndex = 0;
            this.toolTipButton_KAA.SetToolTip(this.buttonOpenFile_KAA, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpenFile_KAA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_KAA.Click += new System.EventHandler(this.buttonOpenFile_KAA_Click);
            this.buttonOpenFile_KAA.MouseEnter += new System.EventHandler(this.buttonOpenFile_KAA_MouseEnter);
            // 
            // buttonDone_KAA
            // 
            this.buttonDone_KAA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDone_KAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_KAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_KAA.Image")));
            this.buttonDone_KAA.Location = new System.Drawing.Point(129, 4);
            this.buttonDone_KAA.Name = "buttonDone_KAA";
            this.buttonDone_KAA.Size = new System.Drawing.Size(109, 83);
            this.buttonDone_KAA.TabIndex = 1;
            this.toolTipButton_KAA.SetToolTip(this.buttonDone_KAA, "Выполнить обработку данных ");
            this.buttonDone_KAA.UseVisualStyleBackColor = true;
            this.buttonDone_KAA.Click += new System.EventHandler(this.buttonDone_KAA_Click);
            this.buttonDone_KAA.MouseEnter += new System.EventHandler(this.buttonDone_KAA_MouseEnter);
            // 
            // buttonSaveFile_KAA
            // 
            this.buttonSaveFile_KAA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSaveFile_KAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_KAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_KAA.Image")));
            this.buttonSaveFile_KAA.Location = new System.Drawing.Point(259, 4);
            this.buttonSaveFile_KAA.Name = "buttonSaveFile_KAA";
            this.buttonSaveFile_KAA.Size = new System.Drawing.Size(118, 83);
            this.buttonSaveFile_KAA.TabIndex = 2;
            this.toolTipButton_KAA.SetToolTip(this.buttonSaveFile_KAA, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSaveFile_KAA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_KAA.Click += new System.EventHandler(this.buttonSaveFile_KAA_Click);
            this.buttonSaveFile_KAA.MouseEnter += new System.EventHandler(this.buttonSaveFile_KAA_MouseEnter);
            // 
            // buttonhelp_KAA
            // 
            this.buttonhelp_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonhelp_KAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhelp_KAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonhelp_KAA.Image")));
            this.buttonhelp_KAA.Location = new System.Drawing.Point(673, 4);
            this.buttonhelp_KAA.Name = "buttonhelp_KAA";
            this.buttonhelp_KAA.Size = new System.Drawing.Size(114, 88);
            this.buttonhelp_KAA.TabIndex = 3;
            this.toolTipButton_KAA.SetToolTip(this.buttonhelp_KAA, "Сведение о программе ");
            this.buttonhelp_KAA.UseVisualStyleBackColor = true;
            this.buttonhelp_KAA.Click += new System.EventHandler(this.buttonhelp_KAA_Click);
            this.buttonhelp_KAA.MouseEnter += new System.EventHandler(this.buttonhelp_KAA_MouseEnter);
            // 
            // openFileDialogTask_KAA
            // 
            this.openFileDialogTask_KAA.FileName = "openFileDialog1";
            // 
            // toolTipButton_KAA
            // 
            this.toolTipButton_KAA.IsBalloon = true;
            this.toolTipButton_KAA.ToolTipTitle = "Подсказка";
            // 
            // groupBoxOne_KAA
            // 
            this.groupBoxOne_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOne_KAA.Controls.Add(this.textBoxTask_KAA);
            this.groupBoxOne_KAA.Location = new System.Drawing.Point(4, 6);
            this.groupBoxOne_KAA.Name = "groupBoxOne_KAA";
            this.groupBoxOne_KAA.Size = new System.Drawing.Size(783, 85);
            this.groupBoxOne_KAA.TabIndex = 0;
            this.groupBoxOne_KAA.TabStop = false;
            this.groupBoxOne_KAA.Text = "Условие:";
            // 
            // groupBoxTwo_KAA
            // 
            this.groupBoxTwo_KAA.Controls.Add(this.dataGridViewInput_KAA);
            this.groupBoxTwo_KAA.Location = new System.Drawing.Point(12, 4);
            this.groupBoxTwo_KAA.Name = "groupBoxTwo_KAA";
            this.groupBoxTwo_KAA.Size = new System.Drawing.Size(377, 227);
            this.groupBoxTwo_KAA.TabIndex = 0;
            this.groupBoxTwo_KAA.TabStop = false;
            this.groupBoxTwo_KAA.Text = "Ввод:";
            // 
            // groupBoxThri_KAA
            // 
            this.groupBoxThri_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxThri_KAA.Controls.Add(this.dataGridViewOutput_KAA);
            this.groupBoxThri_KAA.Location = new System.Drawing.Point(17, 4);
            this.groupBoxThri_KAA.Name = "groupBoxThri_KAA";
            this.groupBoxThri_KAA.Size = new System.Drawing.Size(380, 227);
            this.groupBoxThri_KAA.TabIndex = 1;
            this.groupBoxThri_KAA.TabStop = false;
            this.groupBoxThri_KAA.Text = "Вывод:";
            // 
            // textBoxTask_KAA
            // 
            this.textBoxTask_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask_KAA.Location = new System.Drawing.Point(8, 20);
            this.textBoxTask_KAA.Multiline = true;
            this.textBoxTask_KAA.Name = "textBoxTask_KAA";
            this.textBoxTask_KAA.ReadOnly = true;
            this.textBoxTask_KAA.Size = new System.Drawing.Size(769, 65);
            this.textBoxTask_KAA.TabIndex = 0;
            this.textBoxTask_KAA.Text = resources.GetString("textBoxTask_KAA.Text");
            // 
            // dataGridViewInput_KAA
            // 
            this.dataGridViewInput_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInput_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_KAA.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewInput_KAA.Name = "dataGridViewInput_KAA";
            this.dataGridViewInput_KAA.RowHeadersWidth = 62;
            this.dataGridViewInput_KAA.Size = new System.Drawing.Size(358, 207);
            this.dataGridViewInput_KAA.TabIndex = 0;
            // 
            // dataGridViewOutput_KAA
            // 
            this.dataGridViewOutput_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_KAA.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewOutput_KAA.Name = "dataGridViewOutput_KAA";
            this.dataGridViewOutput_KAA.RowHeadersWidth = 62;
            this.dataGridViewOutput_KAA.Size = new System.Drawing.Size(359, 201);
            this.dataGridViewOutput_KAA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelleft_KAA);
            this.Controls.Add(this.panelcenter_KAA);
            this.Controls.Add(this.panelTap_KAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 21 | Конюшевский А.А ";
            this.panelTap_KAA.ResumeLayout(false);
            this.panelcenter_KAA.ResumeLayout(false);
            this.panelleft_KAA.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.groupBoxOne_KAA.ResumeLayout(false);
            this.groupBoxOne_KAA.PerformLayout();
            this.groupBoxTwo_KAA.ResumeLayout(false);
            this.groupBoxThri_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_KAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTap_KAA;
        private System.Windows.Forms.Button buttonhelp_KAA;
        private System.Windows.Forms.Button buttonSaveFile_KAA;
        private System.Windows.Forms.Button buttonDone_KAA;
        private System.Windows.Forms.Button buttonOpenFile_KAA;
        private System.Windows.Forms.Panel panelcenter_KAA;
        private System.Windows.Forms.Panel panelleft_KAA;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KAA;
        private System.Windows.Forms.ToolTip toolTipButton_KAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_KAA;
        private System.Windows.Forms.GroupBox groupBoxOne_KAA;
        private System.Windows.Forms.TextBox textBoxTask_KAA;
        private System.Windows.Forms.GroupBox groupBoxTwo_KAA;
        private System.Windows.Forms.GroupBox groupBoxThri_KAA;
        private System.Windows.Forms.DataGridView dataGridViewInput_KAA;
        private System.Windows.Forms.DataGridView dataGridViewOutput_KAA;
    }
}

