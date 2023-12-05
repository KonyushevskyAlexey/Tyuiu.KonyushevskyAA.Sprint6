using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Tyuiu.KonyushevskyAA.Sprint6.Task5.V2.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint6.Task5.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Task5\InPutFileTask5V2.txt";

        private void buttonDone_KAA_Click(object sender, EventArgs e)
        {
            dataGridViewNums_KAA.ColumnCount = 2;
            dataGridViewNums_KAA.Columns[0].Width = 20;
            dataGridViewNums_KAA.Columns[1].Width = 50;

            this.chartDiag_KAA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_KAA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_KAA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_KAA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_KAA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_KAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_KAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПБ-23-2 Конюшевский Алексей Александрович ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
