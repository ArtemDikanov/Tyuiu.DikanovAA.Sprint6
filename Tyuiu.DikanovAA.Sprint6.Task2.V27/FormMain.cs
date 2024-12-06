using Tyuiu.DikanovAA.Sprint6.Task2.V27.Lib;
namespace Tyuiu.DikanovAA.Sprint6.Task2.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonResultTask2_DAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStepTask2_DAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStepTask2_DAA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunctionTask2_DAA.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunctionTask2_DAA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunctionTask2_DAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunctionTask2_DAA.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void chartFunctionTask2_DAA_CLick(object sender, EventArgs e)
        {
            //
        }

        private void buttonResultTask2_DAA_MouseEnter(object sender, EventArgs e)
        {
            buttonResultTask2_DAA.BackColor = Color.Red;
        }

        private void buttonResultTask2_DAA_MouseLeave(object sender, EventArgs e)
        {
            buttonResultTask2_DAA.BackColor = Color.Green;
        }

        private void buttonResultTask2_DAA_MouseDown(object sender, EventArgs e)
        {
            buttonResultTask2_DAA.BackColor = Color.Blue;
        }

        private void buttonHelpTask2_DAA_Click(object seder, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы РППб-24-1 Диканов Артём Алексеевич", "Сообщение");
        }

        
    }
}
