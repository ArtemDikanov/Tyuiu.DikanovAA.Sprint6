using System.Drawing.Drawing2D;
using Tyuiu.DikanovAA.Sprint6.Task3.V19.Lib;
namespace Tyuiu.DikanovAA.Sprint6.Task3.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 4, 32, -20, 27 , 21},
                                      { 17, 15, -1, -2 , -1},
                                      { -3, 18, 12, -10 , 29},
                                      { 7, -15, 2, -8 , 12},
                                      { -10, 25, 5, 27 , 21} };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrixTask3_DAA.ColumnCount = columns;
            dataGridViewMatrixTask3_DAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixTask3_DAA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixTask3_DAA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttoneResultTask3_DAA_CLick(object seder, EventArgs e)
        {
            int[,] resArray = ds.Calculate(mtrx);
            int rowss = resArray.GetUpperBound(0) + 1;
            int columnss = resArray.Length / rowss;

            dataGridViewMatrixRTask3_DAA.ColumnCount = columnss;
            dataGridViewMatrixRTask3_DAA.RowCount = rowss;

            for (int i = 0; i < columnss; i++)
            {
                dataGridViewMatrixRTask3_DAA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rowss; i++)
            {
                for (int j = 0; j < columnss; j++)
                {
                    dataGridViewMatrixRTask3_DAA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonHelpTask3_DAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы РППб-24-1 Диканов Артём Алексеевич", "Сообщение");
        }

       
    }
}
//int[,] resArray = ds.Calculate(matrix);
//int rowss = resArray.GetUpperBound(0) + 1;
//int columnss = resArray.Length / rowss;
//for (int i = 0; i < rowss; i++)
//{
    //for (int j = 0; j < columnss; j++)
    //{
        //Console.Write($"{resArray[i, j]} \t");
    //}
    //Console.WriteLine();
//}