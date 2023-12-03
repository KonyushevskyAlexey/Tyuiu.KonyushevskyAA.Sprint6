using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KonyushevskyAA.Sprint6.Task2.V18.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint6.Task2.V18
{
    public partial class FormMainTask_KAA : Form
    {
        public FormMainTask_KAA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_KAA_Click(object sender, EventArgs e)
        {

            try
            { 
            int startStep = Convert.ToInt32(textBoxstart_KAA.Text);
            int stopStep = Convert.ToInt32(textBoxstop_KAA.Text);

            int len = ds.GetMassFunction(startStep, stopStep).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startStep, stopStep);

            this.chartFuction_KAA.Titles.Add("График функции ");

            this.chartFuction_KAA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFuction_KAA.ChartAreas[0].AxisY.Title = "Ось Y";

            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridView_KAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                this.chartFuction_KAA.Series[0].Points.AddXY(startStep, valueArray[i]);
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
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-2 Конюшевский Алексей Александрович ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_KAA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KAA.BackColor = Color.Red;
        }

        private void buttonDone_KAA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KAA.BackColor = Color.Blue;
        }

        private void buttonDone_KAA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_KAA.BackColor = Color.Green;
        }

        private void dataGridView_KAA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
    }
}
