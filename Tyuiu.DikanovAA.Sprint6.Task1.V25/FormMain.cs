using Tyuiu.DikanovAA.Sprint6.Task1.V25.Lib;
namespace Tyuiu.DikanovAA.Sprint6.Task1.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonAnswer2_DAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputStart_DAA.Text);
                int stopStep = Convert.ToInt32(textBoxInputStop_DAA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult2_DAA.AppendText("+------------+------------+" + Environment.NewLine);
                textBoxResult2_DAA.AppendText("|     X      |     f(x)   +" + Environment.NewLine);
                textBoxResult2_DAA.AppendText("+------------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("| {0,5:d}      |   {1, 6:f2}    |", startStep, valueArray[i]);
                    textBoxResult2_DAA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult2_DAA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp2_DAA_Click(object seder, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы РППб-24-1 Диканов Артём Алексеевич", "Сообщение");
        }

         
    }
}
