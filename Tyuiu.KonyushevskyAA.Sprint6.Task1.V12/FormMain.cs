using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KonyushevskyAA.Sprint6.Task1.V12.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint6.Task1.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
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

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                

                textBoxResultTwo_KAA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResultTwo_KAA.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResultTwo_KAA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1, 6:f2}   |", startStep, valueArray[i]);
                    textBoxResultTwo_KAA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResultTwo_KAA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-2 Конюшевский Алексей Александрович ", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
