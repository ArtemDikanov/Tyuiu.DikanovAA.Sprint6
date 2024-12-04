namespace Tyuiu.DikanovAA.Sprint6.Task0.V27
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
            groupBoxCondition_DAA = new GroupBox();
            textBoxConditionText_DAA = new TextBox();
            pictureBoxFormula_DAA = new PictureBox();
            groupBoxInputDate_DAA = new GroupBox();
            groupBoxValue_DAA = new GroupBox();
            textBoxValue_DAA = new TextBox();
            groupBoxOutputDate_DAA = new GroupBox();
            groupBoxResult_DAA = new GroupBox();
            textBoxResult_DAA = new TextBox();
            buttonAnswer_DAA = new Button();
            buttonHelp_DAA = new Button();
            groupBoxCondition_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_DAA).BeginInit();
            groupBoxInputDate_DAA.SuspendLayout();
            groupBoxValue_DAA.SuspendLayout();
            groupBoxOutputDate_DAA.SuspendLayout();
            groupBoxResult_DAA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_DAA
            // 
            groupBoxCondition_DAA.Controls.Add(textBoxConditionText_DAA);
            groupBoxCondition_DAA.Location = new Point(31, 46);
            groupBoxCondition_DAA.Name = "groupBoxCondition_DAA";
            groupBoxCondition_DAA.Size = new Size(411, 171);
            groupBoxCondition_DAA.TabIndex = 0;
            groupBoxCondition_DAA.TabStop = false;
            groupBoxCondition_DAA.Text = "Условие";
            // 
            // textBoxConditionText_DAA
            // 
            textBoxConditionText_DAA.BackColor = SystemColors.Control;
            textBoxConditionText_DAA.ForeColor = SystemColors.WindowText;
            textBoxConditionText_DAA.Location = new Point(0, 22);
            textBoxConditionText_DAA.Multiline = true;
            textBoxConditionText_DAA.Name = "textBoxConditionText_DAA";
            textBoxConditionText_DAA.ReadOnly = true;
            textBoxConditionText_DAA.Size = new Size(411, 149);
            textBoxConditionText_DAA.TabIndex = 0;
            textBoxConditionText_DAA.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_DAA
            // 
            pictureBoxFormula_DAA.Image = (Image)resources.GetObject("pictureBoxFormula_DAA.Image");
            pictureBoxFormula_DAA.Location = new Point(491, 55);
            pictureBoxFormula_DAA.Name = "pictureBoxFormula_DAA";
            pictureBoxFormula_DAA.Size = new Size(224, 49);
            pictureBoxFormula_DAA.TabIndex = 1;
            pictureBoxFormula_DAA.TabStop = false;
            // 
            // groupBoxInputDate_DAA
            // 
            groupBoxInputDate_DAA.Controls.Add(groupBoxValue_DAA);
            groupBoxInputDate_DAA.Location = new Point(31, 232);
            groupBoxInputDate_DAA.Name = "groupBoxInputDate_DAA";
            groupBoxInputDate_DAA.Size = new Size(446, 123);
            groupBoxInputDate_DAA.TabIndex = 2;
            groupBoxInputDate_DAA.TabStop = false;
            groupBoxInputDate_DAA.Text = "Ввод данных";
            // 
            // groupBoxValue_DAA
            // 
            groupBoxValue_DAA.Controls.Add(textBoxValue_DAA);
            groupBoxValue_DAA.Location = new Point(19, 22);
            groupBoxValue_DAA.Name = "groupBoxValue_DAA";
            groupBoxValue_DAA.Size = new Size(101, 95);
            groupBoxValue_DAA.TabIndex = 0;
            groupBoxValue_DAA.TabStop = false;
            groupBoxValue_DAA.Text = "Переменная Х";
            // 
            // textBoxValue_DAA
            // 
            textBoxValue_DAA.Location = new Point(1, 22);
            textBoxValue_DAA.Name = "textBoxValue_DAA";
            textBoxValue_DAA.Size = new Size(100, 23);
            textBoxValue_DAA.TabIndex = 0;
            textBoxValue_DAA.KeyPress += textBoxValue_DAA_KeyPress;
            // 
            // groupBoxOutputDate_DAA
            // 
            groupBoxOutputDate_DAA.Controls.Add(groupBoxResult_DAA);
            groupBoxOutputDate_DAA.Location = new Point(491, 232);
            groupBoxOutputDate_DAA.Name = "groupBoxOutputDate_DAA";
            groupBoxOutputDate_DAA.Size = new Size(254, 123);
            groupBoxOutputDate_DAA.TabIndex = 3;
            groupBoxOutputDate_DAA.TabStop = false;
            groupBoxOutputDate_DAA.Text = "Вывод данных";
            // 
            // groupBoxResult_DAA
            // 
            groupBoxResult_DAA.Controls.Add(textBoxResult_DAA);
            groupBoxResult_DAA.Location = new Point(41, 17);
            groupBoxResult_DAA.Name = "groupBoxResult_DAA";
            groupBoxResult_DAA.Size = new Size(128, 100);
            groupBoxResult_DAA.TabIndex = 4;
            groupBoxResult_DAA.TabStop = false;
            groupBoxResult_DAA.Text = "Результат";
            // 
            // textBoxResult_DAA
            // 
            textBoxResult_DAA.BackColor = SystemColors.ButtonHighlight;
            textBoxResult_DAA.BorderStyle = BorderStyle.None;
            textBoxResult_DAA.Location = new Point(0, 22);
            textBoxResult_DAA.Name = "textBoxResult_DAA";
            textBoxResult_DAA.ReadOnly = true;
            textBoxResult_DAA.Size = new Size(128, 16);
            textBoxResult_DAA.TabIndex = 0;
            // 
            // buttonAnswer_DAA
            // 
            buttonAnswer_DAA.Location = new Point(597, 402);
            buttonAnswer_DAA.Name = "buttonAnswer_DAA";
            buttonAnswer_DAA.Size = new Size(148, 40);
            buttonAnswer_DAA.TabIndex = 4;
            buttonAnswer_DAA.Text = "Выполнить";
            buttonAnswer_DAA.UseVisualStyleBackColor = true;//
            buttonAnswer_DAA.Click += buttonAnswer_DAA_Click;
            // 
            // buttonHelp_DAA
            // 
            buttonHelp_DAA.FlatStyle = FlatStyle.Flat;
            buttonHelp_DAA.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp_DAA.Location = new Point(532, 402);
            buttonHelp_DAA.Name = "buttonHelp_DAA";
            buttonHelp_DAA.Size = new Size(38, 40);
            buttonHelp_DAA.TabIndex = 5;
            buttonHelp_DAA.Text = "?";
            buttonHelp_DAA.UseVisualStyleBackColor = true;
            buttonHelp_DAA.Click += buttonHelp_DAA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 464);
            Controls.Add(buttonHelp_DAA);
            Controls.Add(buttonAnswer_DAA);
            Controls.Add(groupBoxOutputDate_DAA);
            Controls.Add(groupBoxInputDate_DAA);
            Controls.Add(pictureBoxFormula_DAA);
            Controls.Add(groupBoxCondition_DAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 27 | Диканов А. А.";
            groupBoxCondition_DAA.ResumeLayout(false);
            groupBoxCondition_DAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_DAA).EndInit();
            groupBoxInputDate_DAA.ResumeLayout(false);
            groupBoxValue_DAA.ResumeLayout(false);
            groupBoxValue_DAA.PerformLayout();
            groupBoxOutputDate_DAA.ResumeLayout(false);
            groupBoxResult_DAA.ResumeLayout(false);
            groupBoxResult_DAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_DAA;
        private TextBox textBoxConditionText_DAA;
        private PictureBox pictureBoxFormula_DAA;
        private GroupBox groupBoxInputDate_DAA;
        private GroupBox groupBoxValue_DAA;
        private TextBox textBoxValue_DAA;
        private GroupBox groupBoxOutputDate_DAA;
        private GroupBox groupBoxResult_DAA;
        private TextBox textBoxResult_DAA;
        private Button buttonAnswer_DAA;
        private Button buttonHelp_DAA;
    }
}
