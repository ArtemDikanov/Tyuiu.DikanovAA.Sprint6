using Tyuiu.DikanovAA.Sprint6.Task5.V2.Lib;
namespace Tyuiu.DikanovAA.Sprint6.Task5.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint5\InPutDataFileTask5V2.txt";

        private void buttoneResultTask5_DAA_Click(object sender, EventArgs e)
        {
            dateGridViewResultTask5_DAA.ColumnCount = 2;
            dateGridViewResultTask5_DAA.Columns[0].Width = 20;
            dateGridViewResultTask5_DAA.Columns[1].Width = 50;

            this.chartDiagTask5_DAA.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartDiagTask5_DAA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiagTask5_DAA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dateGridViewResultTask5_DAA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiagTask5_DAA.Series[0].Points.AddXY(i, numsMass[i]);
            }


        }

        private void buttonOpenFileTask5_DAA_Click(object seder, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelpTask5_DAA_Click(object seder, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы РППб-24-1 Диканов Артём Алексеевич", "Сообщение");
        }
    }
}
