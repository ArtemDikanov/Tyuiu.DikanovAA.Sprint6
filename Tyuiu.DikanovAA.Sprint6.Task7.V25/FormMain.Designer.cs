namespace Tyuiu.DikanovAA.Sprint6.Task7.V25
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTopTask7_DAA = new Panel();
            buttonResultTask7_DAA = new Button();
            buttonSaveFileTask7_DAA = new Button();
            buttonHelpTask7_DAA = new Button();
            buttonOpenFileTask7_DAA = new Button();
            panelTop2Task7_DAA = new Panel();
            groupBoxConditionTask7_DAA = new GroupBox();
            textBoxConditionTask7_DAA = new TextBox();
            panelLeftTask7_DAA = new Panel();
            groupBoxInputTask7_DAA = new GroupBox();
            dataGridViewInputMatrixTask7_DAA = new DataGridView();
            splitterBetwenTask7_DAA = new Splitter();
            panelRightTask7_DAA = new Panel();
            groupBoxOutputTask7_DAA = new GroupBox();
            dataGridViewOutputMatrixTask7_DAA = new DataGridView();
            openFileDialogTask_DAA = new OpenFileDialog();
            saveFileDialogMatrix_DAA = new SaveFileDialog();
            toolTipButtonTask7_DAA = new ToolTip(components);
            panelTopTask7_DAA.SuspendLayout();
            panelTop2Task7_DAA.SuspendLayout();
            groupBoxConditionTask7_DAA.SuspendLayout();
            panelLeftTask7_DAA.SuspendLayout();
            groupBoxInputTask7_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInputMatrixTask7_DAA).BeginInit();
            panelRightTask7_DAA.SuspendLayout();
            groupBoxOutputTask7_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutputMatrixTask7_DAA).BeginInit();
            SuspendLayout();
            // 
            // panelTopTask7_DAA
            // 
            panelTopTask7_DAA.Controls.Add(buttonResultTask7_DAA);
            panelTopTask7_DAA.Controls.Add(buttonSaveFileTask7_DAA);
            panelTopTask7_DAA.Controls.Add(buttonHelpTask7_DAA);
            panelTopTask7_DAA.Controls.Add(buttonOpenFileTask7_DAA);
            panelTopTask7_DAA.Dock = DockStyle.Top;
            panelTopTask7_DAA.Location = new Point(0, 0);
            panelTopTask7_DAA.Name = "panelTopTask7_DAA";
            panelTopTask7_DAA.Size = new Size(824, 67);
            panelTopTask7_DAA.TabIndex = 0;
            // 
            // buttonResultTask7_DAA
            // 
            buttonResultTask7_DAA.BackColor = Color.Blue;
            buttonResultTask7_DAA.ForeColor = Color.White;
            buttonResultTask7_DAA.Location = new Point(105, 12);
            buttonResultTask7_DAA.Name = "buttonResultTask7_DAA";
            buttonResultTask7_DAA.Size = new Size(77, 41);
            buttonResultTask7_DAA.TabIndex = 3;
            buttonResultTask7_DAA.Text = "Выполнить";
            toolTipButtonTask7_DAA.SetToolTip(buttonResultTask7_DAA, "Выполнить программу, увидеть результат");
            buttonResultTask7_DAA.UseVisualStyleBackColor = false;
            buttonResultTask7_DAA.Click += buttonResultTask7_DAA_Click;
            buttonResultTask7_DAA.MouseEnter += buttonResultTask7_DAA_MouseEnter;
            // 
            // buttonSaveFileTask7_DAA
            // 
            buttonSaveFileTask7_DAA.BackColor = Color.Lime;
            buttonSaveFileTask7_DAA.Location = new Point(209, 12);
            buttonSaveFileTask7_DAA.Name = "buttonSaveFileTask7_DAA";
            buttonSaveFileTask7_DAA.Size = new Size(79, 41);
            buttonSaveFileTask7_DAA.TabIndex = 2;
            buttonSaveFileTask7_DAA.Text = "Сохранить";
            toolTipButtonTask7_DAA.SetToolTip(buttonSaveFileTask7_DAA, "Сохранить результат работы программы в файл");
            buttonSaveFileTask7_DAA.UseVisualStyleBackColor = false;
            buttonSaveFileTask7_DAA.Click += buttonSaveFileTask7_DAA_Click;
            buttonSaveFileTask7_DAA.MouseEnter += buttonSaveFileTask7_DAA_MouseEnter;
            // 
            // buttonHelpTask7_DAA
            // 
            buttonHelpTask7_DAA.BackColor = Color.Cyan;
            buttonHelpTask7_DAA.Location = new Point(738, 12);
            buttonHelpTask7_DAA.Name = "buttonHelpTask7_DAA";
            buttonHelpTask7_DAA.Size = new Size(74, 41);
            buttonHelpTask7_DAA.TabIndex = 1;
            buttonHelpTask7_DAA.Text = "Справка";
            toolTipButtonTask7_DAA.SetToolTip(buttonHelpTask7_DAA, "Информация о создателе приложения");
            buttonHelpTask7_DAA.UseVisualStyleBackColor = false;
            buttonHelpTask7_DAA.Click += buttonHelpTask7_DAA_Click;
            buttonHelpTask7_DAA.MouseEnter += buttonHelpTask7_DAA_MouseEnter;
            // 
            // buttonOpenFileTask7_DAA
            // 
            buttonOpenFileTask7_DAA.BackColor = Color.White;
            buttonOpenFileTask7_DAA.Location = new Point(12, 12);
            buttonOpenFileTask7_DAA.Name = "buttonOpenFileTask7_DAA";
            buttonOpenFileTask7_DAA.Size = new Size(69, 41);
            buttonOpenFileTask7_DAA.TabIndex = 0;
            buttonOpenFileTask7_DAA.Text = "Открыть";
            toolTipButtonTask7_DAA.SetToolTip(buttonOpenFileTask7_DAA, "Открыть файл");
            buttonOpenFileTask7_DAA.UseVisualStyleBackColor = false;
            buttonOpenFileTask7_DAA.Click += buttonOpenFileTask7_DAA_Click;
            buttonOpenFileTask7_DAA.MouseEnter += buttonOpenFileTask7_DAA_MouseEnter;
            // 
            // panelTop2Task7_DAA
            // 
            panelTop2Task7_DAA.Controls.Add(groupBoxConditionTask7_DAA);
            panelTop2Task7_DAA.Dock = DockStyle.Top;
            panelTop2Task7_DAA.Location = new Point(0, 67);
            panelTop2Task7_DAA.Name = "panelTop2Task7_DAA";
            panelTop2Task7_DAA.Size = new Size(824, 72);
            panelTop2Task7_DAA.TabIndex = 1;
            // 
            // groupBoxConditionTask7_DAA
            // 
            groupBoxConditionTask7_DAA.Controls.Add(textBoxConditionTask7_DAA);
            groupBoxConditionTask7_DAA.Dock = DockStyle.Fill;
            groupBoxConditionTask7_DAA.Location = new Point(0, 0);
            groupBoxConditionTask7_DAA.Name = "groupBoxConditionTask7_DAA";
            groupBoxConditionTask7_DAA.Size = new Size(824, 72);
            groupBoxConditionTask7_DAA.TabIndex = 0;
            groupBoxConditionTask7_DAA.TabStop = false;
            groupBoxConditionTask7_DAA.Text = "Условие";
            // 
            // textBoxConditionTask7_DAA
            // 
            textBoxConditionTask7_DAA.BackColor = SystemColors.MenuBar;
            textBoxConditionTask7_DAA.BorderStyle = BorderStyle.None;
            textBoxConditionTask7_DAA.Location = new Point(19, 18);
            textBoxConditionTask7_DAA.Multiline = true;
            textBoxConditionTask7_DAA.Name = "textBoxConditionTask7_DAA";
            textBoxConditionTask7_DAA.Size = new Size(793, 48);
            textBoxConditionTask7_DAA.TabIndex = 0;
            textBoxConditionTask7_DAA.Text = resources.GetString("textBoxConditionTask7_DAA.Text");
            // 
            // panelLeftTask7_DAA
            // 
            panelLeftTask7_DAA.Controls.Add(groupBoxInputTask7_DAA);
            panelLeftTask7_DAA.Dock = DockStyle.Left;
            panelLeftTask7_DAA.Location = new Point(0, 139);
            panelLeftTask7_DAA.Name = "panelLeftTask7_DAA";
            panelLeftTask7_DAA.Size = new Size(392, 312);
            panelLeftTask7_DAA.TabIndex = 2;
            // 
            // groupBoxInputTask7_DAA
            // 
            groupBoxInputTask7_DAA.Controls.Add(dataGridViewInputMatrixTask7_DAA);
            groupBoxInputTask7_DAA.Dock = DockStyle.Fill;
            groupBoxInputTask7_DAA.Location = new Point(0, 0);
            groupBoxInputTask7_DAA.Name = "groupBoxInputTask7_DAA";
            groupBoxInputTask7_DAA.Size = new Size(392, 312);
            groupBoxInputTask7_DAA.TabIndex = 0;
            groupBoxInputTask7_DAA.TabStop = false;
            groupBoxInputTask7_DAA.Text = "Ввод";
            // 
            // dataGridViewInputMatrixTask7_DAA
            // 
            dataGridViewInputMatrixTask7_DAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInputMatrixTask7_DAA.Location = new Point(19, 22);
            dataGridViewInputMatrixTask7_DAA.Name = "dataGridViewInputMatrixTask7_DAA";
            dataGridViewInputMatrixTask7_DAA.Size = new Size(367, 278);
            dataGridViewInputMatrixTask7_DAA.TabIndex = 0;
            // 
            // splitterBetwenTask7_DAA
            // 
            splitterBetwenTask7_DAA.Location = new Point(392, 139);
            splitterBetwenTask7_DAA.Name = "splitterBetwenTask7_DAA";
            splitterBetwenTask7_DAA.Size = new Size(3, 312);
            splitterBetwenTask7_DAA.TabIndex = 3;
            splitterBetwenTask7_DAA.TabStop = false;
            // 
            // panelRightTask7_DAA
            // 
            panelRightTask7_DAA.Controls.Add(groupBoxOutputTask7_DAA);
            panelRightTask7_DAA.Dock = DockStyle.Right;
            panelRightTask7_DAA.Location = new Point(392, 139);
            panelRightTask7_DAA.Name = "panelRightTask7_DAA";
            panelRightTask7_DAA.Size = new Size(432, 312);
            panelRightTask7_DAA.TabIndex = 4;
            // 
            // groupBoxOutputTask7_DAA
            // 
            groupBoxOutputTask7_DAA.Controls.Add(dataGridViewOutputMatrixTask7_DAA);
            groupBoxOutputTask7_DAA.Dock = DockStyle.Fill;
            groupBoxOutputTask7_DAA.Location = new Point(0, 0);
            groupBoxOutputTask7_DAA.Name = "groupBoxOutputTask7_DAA";
            groupBoxOutputTask7_DAA.Padding = new Padding(5);
            groupBoxOutputTask7_DAA.Size = new Size(432, 312);
            groupBoxOutputTask7_DAA.TabIndex = 0;
            groupBoxOutputTask7_DAA.TabStop = false;
            groupBoxOutputTask7_DAA.Text = "Вывод";
            // 
            // dataGridViewOutputMatrixTask7_DAA
            // 
            dataGridViewOutputMatrixTask7_DAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutputMatrixTask7_DAA.Location = new Point(9, 22);
            dataGridViewOutputMatrixTask7_DAA.Name = "dataGridViewOutputMatrixTask7_DAA";
            dataGridViewOutputMatrixTask7_DAA.Size = new Size(411, 278);
            dataGridViewOutputMatrixTask7_DAA.TabIndex = 1;
            // 
            // openFileDialogTask_DAA
            // 
            openFileDialogTask_DAA.FileName = "openFileDialog1";
            // 
            // toolTipButtonTask7_DAA
            // 
            toolTipButtonTask7_DAA.IsBalloon = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 451);
            Controls.Add(panelRightTask7_DAA);
            Controls.Add(splitterBetwenTask7_DAA);
            Controls.Add(panelLeftTask7_DAA);
            Controls.Add(panelTop2Task7_DAA);
            Controls.Add(panelTopTask7_DAA);
            MinimumSize = new Size(840, 490);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 25 | Диканов А. А.";
            Load += FormMain_Load;
            panelTopTask7_DAA.ResumeLayout(false);
            panelTop2Task7_DAA.ResumeLayout(false);
            groupBoxConditionTask7_DAA.ResumeLayout(false);
            groupBoxConditionTask7_DAA.PerformLayout();
            panelLeftTask7_DAA.ResumeLayout(false);
            groupBoxInputTask7_DAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInputMatrixTask7_DAA).EndInit();
            panelRightTask7_DAA.ResumeLayout(false);
            groupBoxOutputTask7_DAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutputMatrixTask7_DAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopTask7_DAA;
        private Panel panelTop2Task7_DAA;
        private Panel panelLeftTask7_DAA;
        private Splitter splitterBetwenTask7_DAA;
        private Panel panelRightTask7_DAA;
        private GroupBox groupBoxConditionTask7_DAA;
        private TextBox textBoxConditionTask7_DAA;
        private GroupBox groupBoxInputTask7_DAA;
        private GroupBox groupBoxOutputTask7_DAA;
        private Button buttonResultTask7_DAA;
        private Button buttonSaveFileTask7_DAA;
        private Button buttonHelpTask7_DAA;
        private Button buttonOpenFileTask7_DAA;
        private DataGridView dataGridViewInputMatrixTask7_DAA;
        private DataGridView dataGridViewOutputMatrixTask7_DAA;
        private OpenFileDialog openFileDialogTask_DAA;
        private SaveFileDialog saveFileDialogMatrix_DAA;
        private ToolTip toolTipButtonTask7_DAA;
    }
}
