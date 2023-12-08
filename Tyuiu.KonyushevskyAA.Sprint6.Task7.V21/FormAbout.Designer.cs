
namespace Tyuiu.KonyushevskyAA.Sprint6.Task7.V21
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_KAA = new System.Windows.Forms.PictureBox();
            this.labelInfo_KAA = new System.Windows.Forms.Label();
            this.buttonOk_KAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_KAA
            // 
            this.pictureBoxAvatar_KAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_KAA.Image")));
            this.pictureBoxAvatar_KAA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_KAA.Name = "pictureBoxAvatar_KAA";
            this.pictureBoxAvatar_KAA.Size = new System.Drawing.Size(171, 234);
            this.pictureBoxAvatar_KAA.TabIndex = 1;
            this.pictureBoxAvatar_KAA.TabStop = false;
            // 
            // labelInfo_KAA
            // 
            this.labelInfo_KAA.Location = new System.Drawing.Point(209, 12);
            this.labelInfo_KAA.Name = "labelInfo_KAA";
            this.labelInfo_KAA.Size = new System.Drawing.Size(351, 145);
            this.labelInfo_KAA.TabIndex = 2;
            this.labelInfo_KAA.Text = resources.GetString("labelInfo_KAA.Text");
            // 
            // buttonOk_KAA
            // 
            this.buttonOk_KAA.Location = new System.Drawing.Point(458, 207);
            this.buttonOk_KAA.Name = "buttonOk_KAA";
            this.buttonOk_KAA.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_KAA.TabIndex = 3;
            this.buttonOk_KAA.Text = "Ok";
            this.buttonOk_KAA.UseVisualStyleBackColor = true;
            this.buttonOk_KAA.Click += new System.EventHandler(this.buttonOk_KAA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 258);
            this.Controls.Add(this.buttonOk_KAA);
            this.Controls.Add(this.labelInfo_KAA);
            this.Controls.Add(this.pictureBoxAvatar_KAA);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_KAA;
        private System.Windows.Forms.Label labelInfo_KAA;
        private System.Windows.Forms.Button buttonOk_KAA;
    }
}