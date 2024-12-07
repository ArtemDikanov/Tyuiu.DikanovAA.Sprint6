namespace Tyuiu.DikanovAA.Sprint6.Task3.V19
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
            groupBoxConditionTask3_DAA = new GroupBox();
            dataGridViewMatrixTask3_DAA = new DataGridView();
            textBoxConditionTask3_DAA = new TextBox();
            groupBoxOutputDataTask3_DAA = new GroupBox();
            dataGridViewMatrixRTask3_DAA = new DataGridView();
            buttoneResultTask3_DAA = new Button();
            buttonHelpTask3_DAA = new Button();
            textBoxOutputDataTask3_DAA = new TextBox();
            groupBoxConditionTask3_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixTask3_DAA).BeginInit();
            groupBoxOutputDataTask3_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixRTask3_DAA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxConditionTask3_DAA
            // 
            groupBoxConditionTask3_DAA.Controls.Add(dataGridViewMatrixTask3_DAA);
            groupBoxConditionTask3_DAA.Controls.Add(textBoxConditionTask3_DAA);
            groupBoxConditionTask3_DAA.Location = new Point(12, 12);
            groupBoxConditionTask3_DAA.Name = "groupBoxConditionTask3_DAA";
            groupBoxConditionTask3_DAA.Size = new Size(552, 424);
            groupBoxConditionTask3_DAA.TabIndex = 0;
            groupBoxConditionTask3_DAA.TabStop = false;
            groupBoxConditionTask3_DAA.Text = "Условие";
            // 
            // dataGridViewMatrixTask3_DAA
            // 
            dataGridViewMatrixTask3_DAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrixTask3_DAA.Location = new Point(254, 47);
            dataGridViewMatrixTask3_DAA.Name = "dataGridViewMatrixTask3_DAA";
            dataGridViewMatrixTask3_DAA.RowHeadersVisible = false;
            dataGridViewMatrixTask3_DAA.Size = new Size(275, 327);
            dataGridViewMatrixTask3_DAA.TabIndex = 1;
            // 
            // textBoxConditionTask3_DAA
            // 
            textBoxConditionTask3_DAA.BackColor = SystemColors.MenuBar;
            textBoxConditionTask3_DAA.BorderStyle = BorderStyle.None;
            textBoxConditionTask3_DAA.Location = new Point(16, 22);
            textBoxConditionTask3_DAA.Multiline = true;
            textBoxConditionTask3_DAA.Name = "textBoxConditionTask3_DAA";
            textBoxConditionTask3_DAA.ReadOnly = true;
            textBoxConditionTask3_DAA.Size = new Size(198, 208);
            textBoxConditionTask3_DAA.TabIndex = 0;
            textBoxConditionTask3_DAA.Text = "Дана матрица 5 на 5:\r\n  4  32 -20 27  21\r\n 17 15  -1  -2  -1\r\n -3 18  12 -10 29\r\n 7 -15   2   -8  12\r\n-10 25  5   27  21.\r\nВыполнить сортировку по возрастанию в пятом столбце.\r\n\r\n\r\n";
            // 
            // groupBoxOutputDataTask3_DAA
            // 
            groupBoxOutputDataTask3_DAA.Controls.Add(dataGridViewMatrixRTask3_DAA);
            groupBoxOutputDataTask3_DAA.Controls.Add(buttoneResultTask3_DAA);
            groupBoxOutputDataTask3_DAA.Controls.Add(buttonHelpTask3_DAA);
            groupBoxOutputDataTask3_DAA.Controls.Add(textBoxOutputDataTask3_DAA);
            groupBoxOutputDataTask3_DAA.Location = new Point(578, 12);
            groupBoxOutputDataTask3_DAA.Name = "groupBoxOutputDataTask3_DAA";
            groupBoxOutputDataTask3_DAA.Size = new Size(285, 424);
            groupBoxOutputDataTask3_DAA.TabIndex = 1;
            groupBoxOutputDataTask3_DAA.TabStop = false;
            groupBoxOutputDataTask3_DAA.Text = "Вывод данных";
            // 
            // dataGridViewMatrixRTask3_DAA
            // 
            dataGridViewMatrixRTask3_DAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrixRTask3_DAA.Location = new Point(6, 47);
            dataGridViewMatrixRTask3_DAA.Name = "dataGridViewMatrixRTask3_DAA";
            dataGridViewMatrixRTask3_DAA.RowHeadersVisible = false;
            dataGridViewMatrixRTask3_DAA.Size = new Size(275, 327);
            dataGridViewMatrixRTask3_DAA.TabIndex = 2;
            // 
            // buttoneResultTask3_DAA
            // 
            buttoneResultTask3_DAA.BackColor = Color.PaleGreen;
            buttoneResultTask3_DAA.Location = new Point(63, 387);
            buttoneResultTask3_DAA.Name = "buttoneResultTask3_DAA";
            buttoneResultTask3_DAA.Size = new Size(84, 31);
            buttoneResultTask3_DAA.TabIndex = 3;
            buttoneResultTask3_DAA.Text = "Выполнить";
            buttoneResultTask3_DAA.UseVisualStyleBackColor = false;
            buttoneResultTask3_DAA.Click += buttoneResultTask3_DAA_CLick;
            // 
            // buttonHelpTask3_DAA
            // 
            buttonHelpTask3_DAA.BackColor = SystemColors.ActiveCaption;
            buttonHelpTask3_DAA.Location = new Point(12, 387);
            buttonHelpTask3_DAA.Name = "buttonHelpTask3_DAA";
            buttonHelpTask3_DAA.Size = new Size(36, 31);
            buttonHelpTask3_DAA.TabIndex = 2;
            buttonHelpTask3_DAA.Text = "?";
            buttonHelpTask3_DAA.UseVisualStyleBackColor = false;
            buttonHelpTask3_DAA.Click += buttonHelpTask3_DAA_Click;
            // 
            // textBoxOutputDataTask3_DAA
            // 
            textBoxOutputDataTask3_DAA.BackColor = SystemColors.MenuBar;
            textBoxOutputDataTask3_DAA.BorderStyle = BorderStyle.None;
            textBoxOutputDataTask3_DAA.Location = new Point(12, 25);
            textBoxOutputDataTask3_DAA.Name = "textBoxOutputDataTask3_DAA";
            textBoxOutputDataTask3_DAA.ReadOnly = true;
            textBoxOutputDataTask3_DAA.Size = new Size(138, 16);
            textBoxOutputDataTask3_DAA.TabIndex = 0;
            textBoxOutputDataTask3_DAA.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 448);
            Controls.Add(groupBoxOutputDataTask3_DAA);
            Controls.Add(groupBoxConditionTask3_DAA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 19 | Диканов А. А.";
            Load += FormMain_Load;
            groupBoxConditionTask3_DAA.ResumeLayout(false);
            groupBoxConditionTask3_DAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixTask3_DAA).EndInit();
            groupBoxOutputDataTask3_DAA.ResumeLayout(false);
            groupBoxOutputDataTask3_DAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixRTask3_DAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxConditionTask3_DAA;
        private TextBox textBoxConditionTask3_DAA;
        private DataGridView dataGridViewMatrixTask3_DAA;
        private GroupBox groupBoxOutputDataTask3_DAA;
        private TextBox textBoxOutputDataTask3_DAA;
        private Button buttonHelpTask3_DAA;
        private Button buttoneResultTask3_DAA;
        private DataGridView dataGridViewMatrixRTask3_DAA;
    }
}
