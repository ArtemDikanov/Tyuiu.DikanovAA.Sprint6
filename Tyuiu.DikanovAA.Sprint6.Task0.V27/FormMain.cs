using Tyuiu.DikanovAA.Sprint6.Task0.V27.Lib;
namespace Tyuiu.DikanovAA.Sprint6.Task0.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }

        private void buttonAnswer_DAA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_DAA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxValue_DAA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxValue_DAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_DAA_Click(object seder, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы РППб-24-1 Диканов Артём Алексеевич", "Сообщение");
        }

        
    }
}//
