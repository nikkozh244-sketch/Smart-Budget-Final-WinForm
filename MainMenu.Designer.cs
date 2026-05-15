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
            LabelOfApp = new Label();
            HelpButton = new Button();
            helpProvider1 = new HelpProvider();
            ((System.ComponentModel.ISupportInitialize)IconOfApplication).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageOfCat).BeginInit();
            SuspendLayout();
            // 
            // IconOfApplication
            // 
            IconOfApplication.Image = (Image)resources.GetObject("IconOfApplication.Image");
            IconOfApplication.ImeMode = ImeMode.NoControl;
            IconOfApplication.Location = new Point(496, 3);
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
            ButtonExit.Location = new Point(641, 601);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new Size(416, 71);
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
            ButtonSettings.Location = new Point(641, 500);
            ButtonSettings.Name = "ButtonSettings";
            ButtonSettings.Size = new Size(416, 71);
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
            ButtonFirstTime.Location = new Point(641, 398);
            ButtonFirstTime.Name = "ButtonFirstTime";
            ButtonFirstTime.Size = new Size(416, 71);
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
            ButtonContinueWork.Location = new Point(641, 100);
            ButtonContinueWork.Name = "ButtonContinueWork";
            ButtonContinueWork.Size = new Size(416, 71);
            ButtonContinueWork.TabIndex = 11;
            ButtonContinueWork.Text = "Продолжить работу";
            ButtonContinueWork.TextAlign = ContentAlignment.MiddleRight;
            ButtonContinueWork.UseVisualStyleBackColor = true;
            ButtonContinueWork.Click += ButtonContinueWork_Click;
            // 
            // ButtonStartNewWork
            // 
            ButtonStartNewWork.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButtonStartNewWork.BackColor = SystemColors.ButtonHighlight;
            ButtonStartNewWork.FlatAppearance.BorderColor = Color.Black;
            ButtonStartNewWork.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ButtonStartNewWork.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ButtonStartNewWork.Font = new Font("Times New Roman", 22.2F);
            ButtonStartNewWork.ImageAlign = ContentAlignment.MiddleRight;
            ButtonStartNewWork.ImeMode = ImeMode.NoControl;
            ButtonStartNewWork.Location = new Point(641, 199);
            ButtonStartNewWork.Name = "ButtonStartNewWork";
            ButtonStartNewWork.Size = new Size(416, 71);
            ButtonStartNewWork.TabIndex = 10;
            ButtonStartNewWork.Text = "Начать новую работу";
            ButtonStartNewWork.TextAlign = ContentAlignment.MiddleRight;
            ButtonStartNewWork.UseVisualStyleBackColor = false;
            ButtonStartNewWork.Click += ButtonStartNewWork_Click;
            // 
            // LabelOfApp
            // 
            LabelOfApp.AutoSize = true;
            LabelOfApp.Font = new Font("Times New Roman", 48F, FontStyle.Bold);
            LabelOfApp.ImeMode = ImeMode.NoControl;
            LabelOfApp.Location = new Point(561, -8);
            LabelOfApp.Name = "LabelOfApp";
            LabelOfApp.Size = new Size(514, 90);
            LabelOfApp.TabIndex = 9;
            LabelOfApp.Text = "Smart Budget";
            // 
            // HelpButton
            // 
            HelpButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            HelpButton.Font = new Font("Times New Roman", 22.2F);
            HelpButton.ImeMode = ImeMode.NoControl;
            HelpButton.Location = new Point(641, 297);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(416, 71);
            HelpButton.TabIndex = 17;
            HelpButton.Text = "Помощь (Справ. служба)";
            HelpButton.TextAlign = ContentAlignment.MiddleRight;
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(HelpButton);
            Controls.Add(IconOfApplication);
            Controls.Add(ImageOfCat);
            Controls.Add(ButtonExit);
            Controls.Add(ButtonSettings);
            Controls.Add(ButtonFirstTime);
            Controls.Add(ButtonContinueWork);
            Controls.Add(ButtonStartNewWork);
            Controls.Add(LabelOfApp);
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
        private Label LabelOfApp;
        private Button HelpButton;
        private HelpProvider helpProvider1;
    }
}
