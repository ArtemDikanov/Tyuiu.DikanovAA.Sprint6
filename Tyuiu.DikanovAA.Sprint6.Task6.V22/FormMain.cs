using Tyuiu.DikanovAA.Sprint6.Task6.V22.Lib;
namespace Tyuiu.DikanovAA.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonResultTask6_DAA_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxResultTask6_DAA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelpTask6_DAA_Click(object seder, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFileTask6_DAA_Click(object seder, EventArgs e)
        {
            openFileDialogTaskTask6_DAA.ShowDialog();
            openFilePath = openFileDialogTaskTask6_DAA.FileName;
            textBoxLoadFromFileTask6_DAA.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutDataTask6_DAA.Text = groupBoxOutPutDataTask6_DAA.Text + " " + openFileDialogTaskTask6_DAA.FileName;
            buttonResultTask6_DAA.Enabled = true;
        }
    }
}
