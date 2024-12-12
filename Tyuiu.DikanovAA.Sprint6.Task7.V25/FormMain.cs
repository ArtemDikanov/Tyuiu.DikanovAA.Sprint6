using System.IO;
using System.Windows.Forms;
using Tyuiu.DikanovAA.Sprint6.Task7.V25.Lib;
namespace Tyuiu.DikanovAA.Sprint6.Task7.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_DAA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_DAA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
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

        private void buttonHelpTask7_DAA_Click(object seder, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonResultTask7_DAA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutputMatrixTask7_DAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFileTask7_DAA.Enabled = true;
        }

        private void buttonSaveFileTask7_DAA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_DAA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_DAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_DAA.ShowDialog();

            string path = saveFileDialogMatrix_DAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutputMatrixTask7_DAA.RowCount;
            int columns = dataGridViewOutputMatrixTask7_DAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutputMatrixTask7_DAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutputMatrixTask7_DAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFileTask7_DAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_DAA.ShowDialog();
            openFilePath = openFileDialogTask_DAA.FileName;

            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInputMatrixTask7_DAA.ColumnCount = colums;
            dataGridViewInputMatrixTask7_DAA.RowCount = rows;
            dataGridViewOutputMatrixTask7_DAA.ColumnCount = colums;
            dataGridViewOutputMatrixTask7_DAA.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewInputMatrixTask7_DAA.Columns[i].Width = 25;
                dataGridViewOutputMatrixTask7_DAA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInputMatrixTask7_DAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonResultTask7_DAA.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInputMatrixTask7_DAA.ColumnCount = 50;
            dataGridViewOutputMatrixTask7_DAA.ColumnCount = 50;

            dataGridViewOutputMatrixTask7_DAA.RowCount = 50;
            dataGridViewInputMatrixTask7_DAA.RowCount = 50;

            panelLeftTask7_DAA.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInputMatrixTask7_DAA.Columns[i].Width = 25;
                dataGridViewOutputMatrixTask7_DAA.Columns[i].Width = 25;
            }
        }
        private void buttonOpenFileTask7_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtonTask7_DAA.ToolTipTitle = "Открыть файл";
        }
        private void buttonResultTask7_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtonTask7_DAA.ToolTipTitle = "Выполнить";
        }
        private void buttonSaveFileTask7_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtonTask7_DAA.ToolTipTitle = "Сохранить в файл";
        }
        private void buttonHelpTask7_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtonTask7_DAA.ToolTipTitle = "Справка";
        }



    }
}
