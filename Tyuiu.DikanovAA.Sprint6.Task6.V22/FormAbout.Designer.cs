namespace Tyuiu.DikanovAA.Sprint6.Task6.V22
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
            pictureBoxMyPhotoTask6_DAA = new PictureBox();
            labelInfoTask6_DAA = new Label();
            buttonOKTask6_DAA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMyPhotoTask6_DAA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMyPhotoTask6_DAA
            // 
            pictureBoxMyPhotoTask6_DAA.Image = (Image)resources.GetObject("pictureBoxMyPhotoTask6_DAA.Image");
            pictureBoxMyPhotoTask6_DAA.Location = new Point(12, 21);
            pictureBoxMyPhotoTask6_DAA.Name = "pictureBoxMyPhotoTask6_DAA";
            pictureBoxMyPhotoTask6_DAA.Size = new Size(215, 153);
            pictureBoxMyPhotoTask6_DAA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMyPhotoTask6_DAA.TabIndex = 0;
            pictureBoxMyPhotoTask6_DAA.TabStop = false;
            // 
            // labelInfoTask6_DAA
            // 
            labelInfoTask6_DAA.AutoSize = true;
            labelInfoTask6_DAA.Location = new Point(233, 30);
            labelInfoTask6_DAA.Name = "labelInfoTask6_DAA";
            labelInfoTask6_DAA.Size = new Size(303, 135);
            labelInfoTask6_DAA.TabIndex = 1;
            labelInfoTask6_DAA.Text = resources.GetString("labelInfoTask6_DAA.Text");
            // 
            // buttonOKTask6_DAA
            // 
            buttonOKTask6_DAA.BackColor = SystemColors.AppWorkspace;
            buttonOKTask6_DAA.Location = new Point(343, 187);
            buttonOKTask6_DAA.Name = "buttonOKTask6_DAA";
            buttonOKTask6_DAA.Size = new Size(58, 30);
            buttonOKTask6_DAA.TabIndex = 2;
            buttonOKTask6_DAA.Text = "Ок";
            buttonOKTask6_DAA.UseVisualStyleBackColor = false;
            buttonOKTask6_DAA.Click += buttonOKTask6_DAA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 229);
            Controls.Add(buttonOKTask6_DAA);
            Controls.Add(labelInfoTask6_DAA);
            Controls.Add(pictureBoxMyPhotoTask6_DAA);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMyPhotoTask6_DAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxMyPhotoTask6_DAA;
        private Label labelInfoTask6_DAA;
        private Button buttonOKTask6_DAA;
    }
}