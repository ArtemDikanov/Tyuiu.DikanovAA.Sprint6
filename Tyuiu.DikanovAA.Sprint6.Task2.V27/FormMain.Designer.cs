namespace Tyuiu.DikanovAA.Sprint6.Task2.V27
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxConditionTask2_DAA = new GroupBox();
            textBoxCondion2Task2_DAA = new TextBox();
            pictureBox1 = new PictureBox();
            textBoxCondition1Task2_DAA = new TextBox();
            groupBoxInputDataTask2_DAA = new GroupBox();
            textBoxStopStepTask2_DAA = new TextBox();
            textBoxStartStepTask2_DAA = new TextBox();
            textBoxInputDataStopTask2_DAA = new TextBox();
            textBoxInputDataStartTask2_DAA = new TextBox();
            buttonHelpTask2_DAA = new Button();
            buttonResultTask2_DAA = new Button();
            dataGridViewFunctionTask2_DAA = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            textBoxOutputDataTask2_DAA = new TextBox();
            textBoxResultTask2_DAA = new TextBox();
            chartFunctionTask2_DAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxConditionTask2_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxInputDataTask2_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunctionTask2_DAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunctionTask2_DAA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxConditionTask2_DAA
            // 
            groupBoxConditionTask2_DAA.Controls.Add(textBoxCondion2Task2_DAA);
            groupBoxConditionTask2_DAA.Controls.Add(pictureBox1);
            groupBoxConditionTask2_DAA.Controls.Add(textBoxCondition1Task2_DAA);
            groupBoxConditionTask2_DAA.Location = new Point(12, 22);
            groupBoxConditionTask2_DAA.Name = "groupBoxConditionTask2_DAA";
            groupBoxConditionTask2_DAA.Size = new Size(486, 284);
            groupBoxConditionTask2_DAA.TabIndex = 0;
            groupBoxConditionTask2_DAA.TabStop = false;
            groupBoxConditionTask2_DAA.Text = "Условие";
            // 
            // textBoxCondion2Task2_DAA
            // 
            textBoxCondion2Task2_DAA.BackColor = SystemColors.MenuBar;
            textBoxCondion2Task2_DAA.BorderStyle = BorderStyle.None;
            textBoxCondion2Task2_DAA.Location = new Point(6, 64);
            textBoxCondion2Task2_DAA.Multiline = true;
            textBoxCondion2Task2_DAA.Name = "textBoxCondion2Task2_DAA";
            textBoxCondion2Task2_DAA.ReadOnly = true;
            textBoxCondion2Task2_DAA.Size = new Size(460, 39);
            textBoxCondion2Task2_DAA.TabIndex = 2;
            textBoxCondion2Task2_DAA.Text = "на заданном диапозоне. Результат вывести в DataGridView и построить график функции.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(167, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 36);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBoxCondition1Task2_DAA
            // 
            textBoxCondition1Task2_DAA.BackColor = SystemColors.MenuBar;
            textBoxCondition1Task2_DAA.BorderStyle = BorderStyle.None;
            textBoxCondition1Task2_DAA.Location = new Point(6, 33);
            textBoxCondition1Task2_DAA.Name = "textBoxCondition1Task2_DAA";
            textBoxCondition1Task2_DAA.ReadOnly = true;
            textBoxCondition1Task2_DAA.Size = new Size(167, 16);
            textBoxCondition1Task2_DAA.TabIndex = 0;
            textBoxCondition1Task2_DAA.Text = "Протабулировать функцию";
            // 
            // groupBoxInputDataTask2_DAA
            // 
            groupBoxInputDataTask2_DAA.Controls.Add(textBoxStopStepTask2_DAA);
            groupBoxInputDataTask2_DAA.Controls.Add(textBoxStartStepTask2_DAA);
            groupBoxInputDataTask2_DAA.Controls.Add(textBoxInputDataStopTask2_DAA);
            groupBoxInputDataTask2_DAA.Controls.Add(textBoxInputDataStartTask2_DAA);
            groupBoxInputDataTask2_DAA.Location = new Point(12, 312);
            groupBoxInputDataTask2_DAA.Name = "groupBoxInputDataTask2_DAA";
            groupBoxInputDataTask2_DAA.Size = new Size(266, 126);
            groupBoxInputDataTask2_DAA.TabIndex = 1;
            groupBoxInputDataTask2_DAA.TabStop = false;
            groupBoxInputDataTask2_DAA.Text = "Ввод данных";
            // 
            // textBoxStopStepTask2_DAA
            // 
            textBoxStopStepTask2_DAA.Location = new Point(137, 76);
            textBoxStopStepTask2_DAA.Name = "textBoxStopStepTask2_DAA";
            textBoxStopStepTask2_DAA.Size = new Size(100, 23);
            textBoxStopStepTask2_DAA.TabIndex = 3;
            // 
            // textBoxStartStepTask2_DAA
            // 
            textBoxStartStepTask2_DAA.Location = new Point(6, 76);
            textBoxStartStepTask2_DAA.Name = "textBoxStartStepTask2_DAA";
            textBoxStartStepTask2_DAA.Size = new Size(100, 23);
            textBoxStartStepTask2_DAA.TabIndex = 2;
            // 
            // textBoxInputDataStopTask2_DAA
            // 
            textBoxInputDataStopTask2_DAA.BackColor = SystemColors.MenuBar;
            textBoxInputDataStopTask2_DAA.BorderStyle = BorderStyle.None;
            textBoxInputDataStopTask2_DAA.Location = new Point(137, 43);
            textBoxInputDataStopTask2_DAA.Name = "textBoxInputDataStopTask2_DAA";
            textBoxInputDataStopTask2_DAA.ReadOnly = true;
            textBoxInputDataStopTask2_DAA.Size = new Size(100, 16);
            textBoxInputDataStopTask2_DAA.TabIndex = 1;
            textBoxInputDataStopTask2_DAA.Text = "Конец шага:";
            // 
            // textBoxInputDataStartTask2_DAA
            // 
            textBoxInputDataStartTask2_DAA.BackColor = SystemColors.MenuBar;
            textBoxInputDataStartTask2_DAA.BorderStyle = BorderStyle.None;
            textBoxInputDataStartTask2_DAA.Location = new Point(6, 43);
            textBoxInputDataStartTask2_DAA.Name = "textBoxInputDataStartTask2_DAA";
            textBoxInputDataStartTask2_DAA.ReadOnly = true;
            textBoxInputDataStartTask2_DAA.Size = new Size(100, 16);
            textBoxInputDataStartTask2_DAA.TabIndex = 0;
            textBoxInputDataStartTask2_DAA.Text = "Старт шага:";
            // 
            // buttonHelpTask2_DAA
            // 
            buttonHelpTask2_DAA.BackColor = Color.DarkTurquoise;
            buttonHelpTask2_DAA.Location = new Point(284, 343);
            buttonHelpTask2_DAA.Name = "buttonHelpTask2_DAA";
            buttonHelpTask2_DAA.Size = new Size(101, 68);
            buttonHelpTask2_DAA.TabIndex = 2;
            buttonHelpTask2_DAA.Text = "Справка";
            buttonHelpTask2_DAA.UseVisualStyleBackColor = false;
            buttonHelpTask2_DAA.Click += buttonHelpTask2_DAA_Click;
            // 
            // buttonResultTask2_DAA
            // 
            buttonResultTask2_DAA.BackColor = Color.Green;
            buttonResultTask2_DAA.Location = new Point(391, 343);
            buttonResultTask2_DAA.Name = "buttonResultTask2_DAA";
            buttonResultTask2_DAA.Size = new Size(107, 68);
            buttonResultTask2_DAA.TabIndex = 3;
            buttonResultTask2_DAA.Text = "Выполнить";
            buttonResultTask2_DAA.UseVisualStyleBackColor = false;
            buttonResultTask2_DAA.Click += buttonResultTask2_DAA_Click;
            buttonResultTask2_DAA.MouseDown += buttonResultTask2_DAA_MouseDown;
            buttonResultTask2_DAA.MouseEnter += buttonResultTask2_DAA_MouseEnter;
            buttonResultTask2_DAA.MouseLeave += buttonResultTask2_DAA_MouseLeave;
            // 
            // dataGridViewFunctionTask2_DAA
            // 
            dataGridViewFunctionTask2_DAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunctionTask2_DAA.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewFunctionTask2_DAA.Location = new Point(504, 55);
            dataGridViewFunctionTask2_DAA.Name = "dataGridViewFunctionTask2_DAA";
            dataGridViewFunctionTask2_DAA.RowHeadersVisible = false;
            dataGridViewFunctionTask2_DAA.Size = new Size(102, 356);
            dataGridViewFunctionTask2_DAA.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // textBoxOutputDataTask2_DAA
            // 
            textBoxOutputDataTask2_DAA.BackColor = SystemColors.MenuBar;
            textBoxOutputDataTask2_DAA.BorderStyle = BorderStyle.None;
            textBoxOutputDataTask2_DAA.Location = new Point(530, 12);
            textBoxOutputDataTask2_DAA.Name = "textBoxOutputDataTask2_DAA";
            textBoxOutputDataTask2_DAA.Size = new Size(100, 16);
            textBoxOutputDataTask2_DAA.TabIndex = 5;
            textBoxOutputDataTask2_DAA.Text = "Вывод данных";
            // 
            // textBoxResultTask2_DAA
            // 
            textBoxResultTask2_DAA.BackColor = SystemColors.MenuBar;
            textBoxResultTask2_DAA.BorderStyle = BorderStyle.None;
            textBoxResultTask2_DAA.Location = new Point(530, 34);
            textBoxResultTask2_DAA.Name = "textBoxResultTask2_DAA";
            textBoxResultTask2_DAA.Size = new Size(157, 16);
            textBoxResultTask2_DAA.TabIndex = 6;
            textBoxResultTask2_DAA.Text = "Результат:";
            // 
            // chartFunctionTask2_DAA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunctionTask2_DAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunctionTask2_DAA.Legends.Add(legend1);
            chartFunctionTask2_DAA.Location = new Point(637, 86);
            chartFunctionTask2_DAA.Name = "chartFunctionTask2_DAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunctionTask2_DAA.Series.Add(series1);
            chartFunctionTask2_DAA.Size = new Size(406, 314);
            chartFunctionTask2_DAA.TabIndex = 7;
            chartFunctionTask2_DAA.Text = "chart1";
            chartFunctionTask2_DAA.Click += chartFunctionTask2_DAA_CLick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 450);
            Controls.Add(chartFunctionTask2_DAA);
            Controls.Add(textBoxResultTask2_DAA);
            Controls.Add(textBoxOutputDataTask2_DAA);
            Controls.Add(dataGridViewFunctionTask2_DAA);
            Controls.Add(buttonResultTask2_DAA);
            Controls.Add(buttonHelpTask2_DAA);
            Controls.Add(groupBoxInputDataTask2_DAA);
            Controls.Add(groupBoxConditionTask2_DAA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 27 | Диканов А. А.";
            groupBoxConditionTask2_DAA.ResumeLayout(false);
            groupBoxConditionTask2_DAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxInputDataTask2_DAA.ResumeLayout(false);
            groupBoxInputDataTask2_DAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunctionTask2_DAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunctionTask2_DAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxConditionTask2_DAA;
        private TextBox textBoxCondition1Task2_DAA;
        private TextBox textBoxCondion2Task2_DAA;
        private PictureBox pictureBox1;
        private GroupBox groupBoxInputDataTask2_DAA;
        private TextBox textBoxInputDataStopTask2_DAA;
        private TextBox textBoxInputDataStartTask2_DAA;
        private TextBox textBoxStopStepTask2_DAA;
        private TextBox textBoxStartStepTask2_DAA;
        private Button buttonHelpTask2_DAA;
        private Button buttonResultTask2_DAA;
        private DataGridView dataGridViewFunctionTask2_DAA;
        private TextBox textBoxOutputDataTask2_DAA;
        private TextBox textBoxResultTask2_DAA;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctionTask2_DAA;
    }
}
