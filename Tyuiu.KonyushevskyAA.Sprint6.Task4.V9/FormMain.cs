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

using Tyuiu.KonyushevskyAA.Sprint6.Task4.V9.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint6.Task4.V9
{
    public partial class FormMain_KAA : Form
    {
        public FormMain_KAA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_KAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KAA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_KAA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_KAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KAA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_KAA.Text = "";

                chartFunction_KAA.Series[0].Points.Clear();

                for (int i = 0; i < len - 1; i++)
                {
                    this.chartFunction_KAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_KAA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }

            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_KAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПБ-23-2 Конюшевский Алексей Александрович ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_KAA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V9.txt";
                File.WriteAllText(path, textBoxResult_KAA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
