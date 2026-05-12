namespace Smart_Budget
{
    partial class MainMenu
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            IconOfApplication = new PictureBox();
            ImageOfCat = new PictureBox();
            ButtonExit = new Button();
            ButtonSettings = new Button();
            ButtonFirstTime = new Button();
            ButtonContinueWork = new Button();
            ButtonStartNewWork = new Button();
            Label = new Label();
            ((System.ComponentModel.ISupportInitialize)IconOfApplication).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageOfCat).BeginInit();
            SuspendLayout();
            // 
            // IconOfApplication
            // 
            IconOfApplication.Image = (Image)resources.GetObject("IconOfApplication.Image");
            IconOfApplication.ImeMode = ImeMode.NoControl;
            IconOfApplication.Location = new Point(493, 44);
            IconOfApplication.Name = "IconOfApplication";
            IconOfApplication.Size = new Size(77, 74);
            IconOfApplication.TabIndex = 16;
            IconOfApplication.TabStop = false;
            // 
            // ImageOfCat
            // 
            ImageOfCat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ImageOfCat.ErrorImage = null;
            ImageOfCat.Image = (Image)resources.GetObject("ImageOfCat.Image");
            ImageOfCat.ImeMode = ImeMode.NoControl;
            ImageOfCat.InitialImage = null;
            ImageOfCat.Location = new Point(3, -3);
            ImageOfCat.Name = "ImageOfCat";
            ImageOfCat.Size = new Size(570, 715);
            ImageOfCat.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageOfCat.TabIndex = 15;
            ImageOfCat.TabStop = false;
            // 
            // ButtonExit
            // 
            ButtonExit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButtonExit.Font = new Font("Times New Roman", 22.2F);
            ButtonExit.ImeMode = ImeMode.NoControl;
            ButtonExit.Location = new Point(694, 566);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new Size(363, 71);
            ButtonExit.TabIndex = 14;
            ButtonExit.Text = "Выход";
            ButtonExit.TextAlign = ContentAlignment.MiddleRight;
            ButtonExit.UseVisualStyleBackColor = true;
            ButtonExit.Click += ButtonExit_Click;
            // 
            // ButtonSettings
            // 
            ButtonSettings.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButtonSettings.Font = new Font("Times New Roman", 22.2F);
            ButtonSettings.ImeMode = ImeMode.NoControl;
            ButtonSettings.Location = new Point(694, 465);
            ButtonSettings.Name = "ButtonSettings";
            ButtonSettings.Size = new Size(363, 71);
            ButtonSettings.TabIndex = 13;
            ButtonSettings.Text = "Настройки";
            ButtonSettings.TextAlign = ContentAlignment.MiddleRight;
            ButtonSettings.UseVisualStyleBackColor = true;
            ButtonSettings.Click += ButtonSettings_Click;
            // 
            // ButtonFirstTime
            // 
            ButtonFirstTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButtonFirstTime.Font = new Font("Times New Roman", 22.2F);
            ButtonFirstTime.ImeMode = ImeMode.NoControl;
            ButtonFirstTime.Location = new Point(694, 363);
            ButtonFirstTime.Name = "ButtonFirstTime";
            ButtonFirstTime.Size = new Size(363, 71);
            ButtonFirstTime.TabIndex = 12;
            ButtonFirstTime.Text = "О приложении";
            ButtonFirstTime.TextAlign = ContentAlignment.MiddleRight;
            ButtonFirstTime.UseVisualStyleBackColor = true;
            ButtonFirstTime.Click += ButtonFirstTime_Click;
            // 
            // ButtonContinueWork
            // 
            ButtonContinueWork.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButtonContinueWork.Font = new Font("Times New Roman", 22.2F);
            ButtonContinueWork.ImeMode = ImeMode.NoControl;
            ButtonContinueWork.Location = new Point(694, 164);
            ButtonContinueWork.Name = "ButtonContinueWork";
            ButtonContinueWork.Size = new Size(363, 71);
            ButtonContinueWork.TabIndex = 11;
            ButtonContinueWork.Text = "Продолжить работу";
            ButtonContinueWork.TextAlign = ContentAlignment.MiddleRight;
            ButtonContinueWork.UseVisualStyleBackColor = true;
            // 
            // ButtonStartNewWork
            // 
            ButtonStartNewWork.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButtonStartNewWork.Font = new Font("Times New Roman", 22.2F);
            ButtonStartNewWork.ImageAlign = ContentAlignment.MiddleRight;
            ButtonStartNewWork.ImeMode = ImeMode.NoControl;
            ButtonStartNewWork.Location = new Point(694, 263);
            ButtonStartNewWork.Name = "ButtonStartNewWork";
            ButtonStartNewWork.Size = new Size(363, 71);
            ButtonStartNewWork.TabIndex = 10;
            ButtonStartNewWork.Text = "Начать новую работу";
            ButtonStartNewWork.TextAlign = ContentAlignment.MiddleRight;
            ButtonStartNewWork.UseVisualStyleBackColor = true;
            ButtonStartNewWork.Click += ButtonStartNewWork_Click;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Times New Roman", 48F, FontStyle.Bold);
            Label.ImeMode = ImeMode.NoControl;
            Label.Location = new Point(561, 28);
            Label.Name = "Label";
            Label.Size = new Size(514, 90);
            Label.TabIndex = 9;
            Label.Text = "Smart Budget";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(IconOfApplication);
            Controls.Add(ImageOfCat);
            Controls.Add(ButtonExit);
            Controls.Add(ButtonSettings);
            Controls.Add(ButtonFirstTime);
            Controls.Add(ButtonContinueWork);
            Controls.Add(ButtonStartNewWork);
            Controls.Add(Label);
            Name = "MainMenu";
            Size = new Size(1075, 712);
            ((System.ComponentModel.ISupportInitialize)IconOfApplication).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageOfCat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox IconOfApplication;
        private PictureBox ImageOfCat;
        private Button ButtonExit;
        private Button ButtonSettings;
        private Button ButtonFirstTime;
        private Button ButtonContinueWork;
        private Button ButtonStartNewWork;
        private Label Label;
    }
}
