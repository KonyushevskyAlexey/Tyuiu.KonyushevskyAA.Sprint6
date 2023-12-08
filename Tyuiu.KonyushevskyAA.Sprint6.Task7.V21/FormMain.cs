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

using Tyuiu.KonyushevskyAA.Sprint6.Task7.V21.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint6.Task7.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_KAA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_KAA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_KAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KAA.ShowDialog();
            openFilePath = openFileDialogTask_KAA.FileName;

            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInput_KAA.ColumnCount = colums;
            dataGridViewInput_KAA.RowCount = rows;
            dataGridViewOutput_KAA.ColumnCount = colums;
            dataGridViewOutput_KAA.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewInput_KAA.Columns[i].Width = 25;
                dataGridViewOutput_KAA.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInput_KAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_KAA.Enabled = true;

        }

        private void buttonhelp_KAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_KAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KAA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_KAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KAA.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_KAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KAA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonhelp_KAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KAA.ToolTipTitle = "Справка";
        }

        private void buttonDone_KAA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutput_KAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_KAA.Enabled = true;
        }

        private void buttonSaveFile_KAA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KAA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_KAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KAA.ShowDialog();

            string path = saveFileDialogMatrix_KAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput_KAA.RowCount;
            int columns = dataGridViewOutput_KAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutput_KAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutput_KAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}
