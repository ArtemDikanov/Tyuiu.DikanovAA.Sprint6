using Tyuiu.DikanovAA.Sprint6.Task4.V28.Lib;
namespace Tyuiu.DikanovAA.Sprint6.Task4.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonResultTask4_DAA_Click(object sender, EventArgs e)
        {
            try
            {

                int startStep = Convert.ToInt32(textBoxInputStartTask4_DAA.Text);
                int stopStep = Convert.ToInt32(textBoxInputStopTask4_DAA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunctionTask4_DAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunctionTask4_DAA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResultTask4_DAA.Text = "";

                chartFunctionTask4_DAA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunctionTask4_DAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResultTask4_DAA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void buttonHelp2_DAA_Click(object seder, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы РППб-24-1 Диканов Артём Алексеевич", "Сообщение");
        }

        private void buttonSaveTask4_DAA_Click(object seder, EventArgs e)
        {
            try
            {
                string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask4.txt" });
                File.WriteAllText(path, textBoxResultTask4_DAA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " успешно сохранён!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
