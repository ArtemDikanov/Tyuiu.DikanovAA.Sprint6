namespace Tyuiu.DikanovAA.Sprint6.Task5.V2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTopTask5_DAA = new Panel();
            buttonHelpTask5_DAA = new Button();
            buttonOpenFileTask5_DAA = new Button();
            buttoneResultTask5_DAA = new Button();
            groupBoxConditionTask5_DAA = new GroupBox();
            textBoxConditionTask5_DAA = new TextBox();
            panelLeftTask5_DAA = new Panel();
            groupBoxOutPutDataTask5_DAA = new GroupBox();
            dateGridViewResultTask5_DAA = new DataGridView();
            panelCenterTask5_DAA = new Panel();
            chartDiagTask5_DAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTopTask5_DAA.SuspendLayout();
            groupBoxConditionTask5_DAA.SuspendLayout();
            panelLeftTask5_DAA.SuspendLayout();
            groupBoxOutPutDataTask5_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateGridViewResultTask5_DAA).BeginInit();
            panelCenterTask5_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiagTask5_DAA).BeginInit();
            SuspendLayout();
            // 
            // panelTopTask5_DAA
            // 
            panelTopTask5_DAA.Controls.Add(buttonHelpTask5_DAA);
            panelTopTask5_DAA.Controls.Add(buttonOpenFileTask5_DAA);
            panelTopTask5_DAA.Controls.Add(buttoneResultTask5_DAA);
            panelTopTask5_DAA.Controls.Add(groupBoxConditionTask5_DAA);
            panelTopTask5_DAA.Dock = DockStyle.Top;
            panelTopTask5_DAA.Location = new Point(0, 0);
            panelTopTask5_DAA.Name = "panelTopTask5_DAA";
            panelTopTask5_DAA.Size = new Size(800, 100);
            panelTopTask5_DAA.TabIndex = 0;
            // 
            // buttonHelpTask5_DAA
            // 
            buttonHelpTask5_DAA.BackColor = Color.FromArgb(128, 255, 255);
            buttonHelpTask5_DAA.Location = new Point(686, 21);
            buttonHelpTask5_DAA.Name = "buttonHelpTask5_DAA";
            buttonHelpTask5_DAA.Size = new Size(102, 61);
            buttonHelpTask5_DAA.TabIndex = 3;
            buttonHelpTask5_DAA.Text = "Справка";
            buttonHelpTask5_DAA.UseVisualStyleBackColor = false;
            buttonHelpTask5_DAA.Click += buttonHelpTask5_DAA_Click;
            // 
            // buttonOpenFileTask5_DAA
            // 
            buttonOpenFileTask5_DAA.BackColor = SystemColors.ActiveCaption;
            buttonOpenFileTask5_DAA.Location = new Point(570, 21);
            buttonOpenFileTask5_DAA.Name = "buttonOpenFileTask5_DAA";
            buttonOpenFileTask5_DAA.Size = new Size(101, 61);
            buttonOpenFileTask5_DAA.TabIndex = 2;
            buttonOpenFileTask5_DAA.Text = "Открыть файл";
            buttonOpenFileTask5_DAA.UseVisualStyleBackColor = false;
            buttonOpenFileTask5_DAA.Click += buttonOpenFileTask5_DAA_Click;
            // 
            // buttoneResultTask5_DAA
            // 
            buttoneResultTask5_DAA.BackColor = Color.FromArgb(0, 192, 0);
            buttoneResultTask5_DAA.Location = new Point(455, 21);
            buttoneResultTask5_DAA.Name = "buttoneResultTask5_DAA";
            buttoneResultTask5_DAA.Size = new Size(99, 61);
            buttoneResultTask5_DAA.TabIndex = 1;
            buttoneResultTask5_DAA.Text = "Выполнить";
            buttoneResultTask5_DAA.UseVisualStyleBackColor = false;
            buttoneResultTask5_DAA.Click += buttoneResultTask5_DAA_Click;
            // 
            // groupBoxConditionTask5_DAA
            // 
            groupBoxConditionTask5_DAA.Controls.Add(textBoxConditionTask5_DAA);
            groupBoxConditionTask5_DAA.Location = new Point(3, 4);
            groupBoxConditionTask5_DAA.Name = "groupBoxConditionTask5_DAA";
            groupBoxConditionTask5_DAA.Size = new Size(437, 90);
            groupBoxConditionTask5_DAA.TabIndex = 0;
            groupBoxConditionTask5_DAA.TabStop = false;
            groupBoxConditionTask5_DAA.Text = "Условие";
            // 
            // textBoxConditionTask5_DAA
            // 
            textBoxConditionTask5_DAA.BackColor = SystemColors.MenuBar;
            textBoxConditionTask5_DAA.BorderStyle = BorderStyle.None;
            textBoxConditionTask5_DAA.Location = new Point(7, 17);
            textBoxConditionTask5_DAA.Multiline = true;
            textBoxConditionTask5_DAA.Name = "textBoxConditionTask5_DAA";
            textBoxConditionTask5_DAA.ReadOnly = true;
            textBoxConditionTask5_DAA.Size = new Size(356, 67);
            textBoxConditionTask5_DAA.TabIndex = 0;
            textBoxConditionTask5_DAA.Text = "Прочитать данные из файла InOutFileTask5.txt. Вывести в dataGridView отрицательные значения и построить диаграмму по этим значениям.";
            // 
            // panelLeftTask5_DAA
            // 
            panelLeftTask5_DAA.Controls.Add(groupBoxOutPutDataTask5_DAA);
            panelLeftTask5_DAA.Dock = DockStyle.Left;
            panelLeftTask5_DAA.Location = new Point(0, 100);
            panelLeftTask5_DAA.Name = "panelLeftTask5_DAA";
            panelLeftTask5_DAA.Size = new Size(200, 350);
            panelLeftTask5_DAA.TabIndex = 1;
            // 
            // groupBoxOutPutDataTask5_DAA
            // 
            groupBoxOutPutDataTask5_DAA.Controls.Add(dateGridViewResultTask5_DAA);
            groupBoxOutPutDataTask5_DAA.Location = new Point(5, 6);
            groupBoxOutPutDataTask5_DAA.Name = "groupBoxOutPutDataTask5_DAA";
            groupBoxOutPutDataTask5_DAA.Size = new Size(192, 341);
            groupBoxOutPutDataTask5_DAA.TabIndex = 0;
            groupBoxOutPutDataTask5_DAA.TabStop = false;
            groupBoxOutPutDataTask5_DAA.Text = "Вывод данных";
            // 
            // dateGridViewResultTask5_DAA
            // 
            dateGridViewResultTask5_DAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dateGridViewResultTask5_DAA.Location = new Point(-5, 22);
            dateGridViewResultTask5_DAA.Name = "dateGridViewResultTask5_DAA";
            dateGridViewResultTask5_DAA.Size = new Size(200, 322);
            dateGridViewResultTask5_DAA.TabIndex = 0;
            // 
            // panelCenterTask5_DAA
            // 
            panelCenterTask5_DAA.Controls.Add(chartDiagTask5_DAA);
            panelCenterTask5_DAA.Dock = DockStyle.Fill;
            panelCenterTask5_DAA.Location = new Point(200, 100);
            panelCenterTask5_DAA.Name = "panelCenterTask5_DAA";
            panelCenterTask5_DAA.Size = new Size(600, 350);
            panelCenterTask5_DAA.TabIndex = 2;
            // 
            // chartDiagTask5_DAA
            // 
            chartArea1.Name = "ChartArea1";
            chartDiagTask5_DAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiagTask5_DAA.Legends.Add(legend1);
            chartDiagTask5_DAA.Location = new Point(0, 0);
            chartDiagTask5_DAA.Name = "chartDiagTask5_DAA";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiagTask5_DAA.Series.Add(series1);
            chartDiagTask5_DAA.Size = new Size(600, 350);
            chartDiagTask5_DAA.TabIndex = 0;
            chartDiagTask5_DAA.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelCenterTask5_DAA);
            Controls.Add(panelLeftTask5_DAA);
            Controls.Add(panelTopTask5_DAA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 2 | Диканов А. А.";
            panelTopTask5_DAA.ResumeLayout(false);
            groupBoxConditionTask5_DAA.ResumeLayout(false);
            groupBoxConditionTask5_DAA.PerformLayout();
            panelLeftTask5_DAA.ResumeLayout(false);
            groupBoxOutPutDataTask5_DAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dateGridViewResultTask5_DAA).EndInit();
            panelCenterTask5_DAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiagTask5_DAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopTask5_DAA;
        private GroupBox groupBoxConditionTask5_DAA;
        private Panel panelLeftTask5_DAA;
        private Panel panelCenterTask5_DAA;
        private TextBox textBoxConditionTask5_DAA;
        private GroupBox groupBoxOutPutDataTask5_DAA;
        private DataGridView dateGridViewResultTask5_DAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagTask5_DAA;
        private Button buttonHelpTask5_DAA;
        private Button buttonOpenFileTask5_DAA;
        private Button buttoneResultTask5_DAA;
    }
}
