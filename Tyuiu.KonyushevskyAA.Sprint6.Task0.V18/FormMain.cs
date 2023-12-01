using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KonyushevskyAA.Sprint6.Task0.V18.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint6.Task0.V18
{
    public partial class FormMain_KAA : Form
    {
        public FormMain_KAA()
        {
            InitializeComponent();
        }

        private void buttonNamedOne_KAA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResultOne_KAA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_KAA.Text)));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void textBoxVarX_KAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonhelp_KAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-23-2 Конюшевский Алексей Александрович ", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonhelp_KAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-23-2 Конюшевский Алексей Александрович ", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
