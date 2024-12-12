namespace Tyuiu.DikanovAA.Sprint6.Task7.V25
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox1 = new PictureBox();
            labelInfoTask7_DAA = new Label();
            buttonOKTask7_DAA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelInfoTask7_DAA
            // 
            labelInfoTask7_DAA.AutoSize = true;
            labelInfoTask7_DAA.Location = new Point(273, 50);
            labelInfoTask7_DAA.Name = "labelInfoTask7_DAA";
            labelInfoTask7_DAA.Size = new Size(285, 135);
            labelInfoTask7_DAA.TabIndex = 1;
            labelInfoTask7_DAA.Text = "Разработчик: Диканов А.А.\r\nгруппа РППб - 24 - 1\r\n\r\nПрогррамма разработана в рамках изучения С#\r\n\r\nТИУ 2024\r\nВШЦТ 2024\r\n\r\nВнутреннее имя: Tyuiu.DikanovAA.Sprint6.Task7.V25";
            // 
            // buttonOKTask7_DAA
            // 
            buttonOKTask7_DAA.Location = new Point(364, 230);
            buttonOKTask7_DAA.Name = "buttonOKTask7_DAA";
            buttonOKTask7_DAA.Size = new Size(75, 23);
            buttonOKTask7_DAA.TabIndex = 2;
            buttonOKTask7_DAA.Text = "ОК";
            buttonOKTask7_DAA.UseVisualStyleBackColor = true;
            buttonOKTask7_DAA.Click += buttonOKTask7_DAA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 265);
            Controls.Add(buttonOKTask7_DAA);
            Controls.Add(labelInfoTask7_DAA);
            Controls.Add(pictureBox1);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelInfoTask7_DAA;
        private Button buttonOKTask7_DAA;
    }
}