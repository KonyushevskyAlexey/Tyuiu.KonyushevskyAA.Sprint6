﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Tyuiu.KonyushevskyAA.Sprint6.Task6.V20.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint6.Task6.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_KAA_Click(object sender, EventArgs e)
        {
            textBoxResult_KAA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonOpenFile_KAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KAA.ShowDialog();
            openFilePath = openFileDialogTask_KAA.FileName;
            textBoxLoadFromFile_KAA.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_KAA.Text = groupBoxOutPut_KAA.Text + " " + openFileDialogTask_KAA.FileName; ;
            buttonDone_KAA.Enabled = true;
        }

        private void buttonHelp_KAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
