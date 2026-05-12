namespace Smart_Budget
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            pnlMenu = new Panel();
            ButtonReturnToHome = new Button();
            ButtonSettings = new Button();
            ButtonFirstTime = new Button();
            ButtonContinueWork = new Button();
            ButtonStartNewWork = new Button();
            label6 = new Label();
            ButtonResetSettings = new Button();
            ButtonApplySettings = new Button();
            OpenMenuIcon = new PictureBox();
            LabelSettings = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            checkBox3 = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            checkBox2 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            checkBox1 = new CheckBox();
            LabelDarkOnOrOff = new Label();
            LabelDarkTheme = new Label();
            pictureBox2 = new PictureBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            LabelChangeLanguage = new Label();
            pictureBox3 = new PictureBox();
            numericUpDown1 = new NumericUpDown();
            LabelEnterDollar = new Label();
            LabelChangeDollar = new Label();
            DollarIcon = new PictureBox();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OpenMenuIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DollarIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = SystemColors.Control;
            pnlMenu.BorderStyle = BorderStyle.FixedSingle;
            pnlMenu.Controls.Add(ButtonReturnToHome);
            pnlMenu.Controls.Add(ButtonSettings);
            pnlMenu.Controls.Add(ButtonFirstTime);
            pnlMenu.Controls.Add(ButtonContinueWork);
            pnlMenu.Controls.Add(ButtonStartNewWork);
            pnlMenu.Controls.Add(label6);
            pnlMenu.ForeColor = SystemColors.ControlDarkDark;
            pnlMenu.Location = new Point(668, 44);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(401, 583);
            pnlMenu.TabIndex = 0;
            pnlMenu.Visible = false;
            // 
            // ButtonReturnToHome
            // 
            ButtonReturnToHome.Anchor = AnchorStyles.None;
            ButtonReturnToHome.Font = new Font("Times New Roman", 18F);
            ButtonReturnToHome.ForeColor = SystemColors.ActiveCaptionText;
            ButtonReturnToHome.ImeMode = ImeMode.NoControl;
            ButtonReturnToHome.Location = new Point(18, 388);
            ButtonReturnToHome.Name = "ButtonReturnToHome";
            ButtonReturnToHome.Size = new Size(375, 43);
            ButtonReturnToHome.TabIndex = 18;
            ButtonReturnToHome.Text = "Вернуться в главное меню";
            ButtonReturnToHome.UseVisualStyleBackColor = true;
            // 
            // ButtonSettings
            // 
            ButtonSettings.Anchor = AnchorStyles.None;
            ButtonSettings.BackColor = SystemColors.AppWorkspace;
            ButtonSettings.Enabled = false;
            ButtonSettings.Font = new Font("Times New Roman", 18F);
            ButtonSettings.ForeColor = Color.DimGray;
            ButtonSettings.ImeMode = ImeMode.NoControl;
            ButtonSettings.Location = new Point(18, 315);
            ButtonSettings.Name = "ButtonSettings";
            ButtonSettings.Size = new Size(375, 43);
            ButtonSettings.TabIndex = 17;
            ButtonSettings.Text = "Настройки";
            ButtonSettings.UseVisualStyleBackColor = false;
            // 
            // ButtonFirstTime
            // 
            ButtonFirstTime.Anchor = AnchorStyles.None;
            ButtonFirstTime.Font = new Font("Times New Roman", 18F);
            ButtonFirstTime.ForeColor = SystemColors.ActiveCaptionText;
            ButtonFirstTime.ImeMode = ImeMode.NoControl;
            ButtonFirstTime.Location = new Point(18, 233);
            ButtonFirstTime.Name = "ButtonFirstTime";
            ButtonFirstTime.Size = new Size(375, 43);
            ButtonFirstTime.TabIndex = 16;
            ButtonFirstTime.Text = "О приложении";
            ButtonFirstTime.UseVisualStyleBackColor = true;
            // 
            // ButtonContinueWork
            // 
            ButtonContinueWork.Anchor = AnchorStyles.None;
            ButtonContinueWork.Font = new Font("Times New Roman", 18F);
            ButtonContinueWork.ForeColor = SystemColors.ActiveCaptionText;
            ButtonContinueWork.ImeMode = ImeMode.NoControl;
            ButtonContinueWork.Location = new Point(21, 88);
            ButtonContinueWork.Name = "ButtonContinueWork";
            ButtonContinueWork.Size = new Size(375, 43);
            ButtonContinueWork.TabIndex = 15;
            ButtonContinueWork.Text = "Продолжить работу";
            ButtonContinueWork.UseVisualStyleBackColor = true;
            // 
            // ButtonStartNewWork
            // 
            ButtonStartNewWork.Anchor = AnchorStyles.None;
            ButtonStartNewWork.Font = new Font("Times New Roman", 18F);
            ButtonStartNewWork.ForeColor = SystemColors.ActiveCaptionText;
            ButtonStartNewWork.ImageAlign = ContentAlignment.MiddleRight;
            ButtonStartNewWork.ImeMode = ImeMode.NoControl;
            ButtonStartNewWork.Location = new Point(18, 164);
            ButtonStartNewWork.Name = "ButtonStartNewWork";
            ButtonStartNewWork.Size = new Size(375, 43);
            ButtonStartNewWork.TabIndex = 14;
            ButtonStartNewWork.Text = "Начать новую работу";
            ButtonStartNewWork.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(124, 11);
            label6.Name = "label6";
            label6.Size = new Size(119, 42);
            label6.TabIndex = 0;
            label6.Text = "Меню";
            // 
            // ButtonResetSettings
            // 
            ButtonResetSettings.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonResetSettings.Location = new Point(623, 456);
            ButtonResetSettings.Name = "ButtonResetSettings";
            ButtonResetSettings.Size = new Size(350, 91);
            ButtonResetSettings.TabIndex = 10;
            ButtonResetSettings.Text = "Сбросить настройки";
            ButtonResetSettings.UseVisualStyleBackColor = true;
            ButtonResetSettings.Click += ButtonResetSettings_Click;
            // 
            // ButtonApplySettings
            // 
            ButtonApplySettings.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonApplySettings.ForeColor = Color.Black;
            ButtonApplySettings.Location = new Point(106, 456);
            ButtonApplySettings.Name = "ButtonApplySettings";
            ButtonApplySettings.Size = new Size(350, 91);
            ButtonApplySettings.TabIndex = 9;
            ButtonApplySettings.Text = "Применить настройки";
            ButtonApplySettings.UseVisualStyleBackColor = true;
            ButtonApplySettings.Click += ButtonApplySettings_Click;
            // 
            // OpenMenuIcon
            // 
            OpenMenuIcon.Image = (Image)resources.GetObject("OpenMenuIcon.Image");
            OpenMenuIcon.Location = new Point(945, 3);
            OpenMenuIcon.Name = "OpenMenuIcon";
            OpenMenuIcon.Size = new Size(98, 92);
            OpenMenuIcon.TabIndex = 8;
            OpenMenuIcon.TabStop = false;
            OpenMenuIcon.Click += OpenMenuIcon_Click;
            // 
            // LabelSettings
            // 
            LabelSettings.BackColor = SystemColors.Window;
            LabelSettings.BorderStyle = BorderStyle.FixedSingle;
            LabelSettings.FlatStyle = FlatStyle.Flat;
            LabelSettings.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelSettings.ImageAlign = ContentAlignment.MiddleRight;
            LabelSettings.Location = new Point(106, 0);
            LabelSettings.Name = "LabelSettings";
            LabelSettings.Size = new Size(812, 114);
            LabelSettings.TabIndex = 7;
            LabelSettings.Text = "Добро пожаловать в меню настроек, мяу! Здесь вы можете настроить приложение специально под себя";
            LabelSettings.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 114);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(LabelDarkOnOrOff);
            panel1.Controls.Add(LabelDarkTheme);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LabelChangeLanguage);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(LabelEnterDollar);
            panel1.Controls.Add(LabelChangeDollar);
            panel1.Controls.Add(DollarIcon);
            panel1.Controls.Add(ButtonResetSettings);
            panel1.Controls.Add(ButtonApplySettings);
            panel1.Location = new Point(0, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(1075, 582);
            panel1.TabIndex = 11;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox3.Location = new Point(935, 354);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(127, 30);
            checkBox3.TabIndex = 30;
            checkBox3.Text = "Вкл/Выкл";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(623, 353);
            label4.Name = "label4";
            label4.Size = new Size(311, 26);
            label4.TabIndex = 29;
            label4.Text = "Меняет помощника на собаку:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(623, 309);
            label5.Name = "label5";
            label5.Size = new Size(353, 42);
            label5.TabIndex = 28;
            label5.Text = "\"Режим собачника\"";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.free_icon_paw_672675;
            pictureBox5.Location = new Point(547, 309);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 70);
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox2.Location = new Point(899, 214);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(127, 30);
            checkBox2.TabIndex = 26;
            checkBox2.Text = "Вкл/Выкл";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(623, 213);
            label2.Name = "label2";
            label2.Size = new Size(270, 26);
            label2.TabIndex = 25;
            label2.Text = "Отзеркаливает интерфейс:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(623, 169);
            label3.Name = "label3";
            label3.Size = new Size(290, 42);
            label3.TabIndex = 24;
            label3.Text = "\"Режим левши\"";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.free_icon_lefty_mouse_16566__2_;
            pictureBox4.Location = new Point(547, 169);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(70, 70);
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(384, 352);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 30);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Вкл/Выкл";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // LabelDarkOnOrOff
            // 
            LabelDarkOnOrOff.AutoSize = true;
            LabelDarkOnOrOff.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelDarkOnOrOff.Location = new Point(90, 353);
            LabelDarkOnOrOff.Name = "LabelDarkOnOrOff";
            LabelDarkOnOrOff.Size = new Size(287, 26);
            LabelDarkOnOrOff.TabIndex = 21;
            LabelDarkOnOrOff.Text = "Тёмный фон, светлый текст:";
            // 
            // LabelDarkTheme
            // 
            LabelDarkTheme.AutoSize = true;
            LabelDarkTheme.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelDarkTheme.Location = new Point(90, 309);
            LabelDarkTheme.Name = "LabelDarkTheme";
            LabelDarkTheme.Size = new Size(232, 42);
            LabelDarkTheme.TabIndex = 20;
            LabelDarkTheme.Text = "Тёмная тема";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.free_icon_night_mode_12377255__2_;
            pictureBox2.Location = new Point(14, 309);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Русский", "English" });
            comboBox1.Location = new Point(384, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(120, 34);
            comboBox1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(90, 213);
            label1.Name = "label1";
            label1.Size = new Size(288, 26);
            label1.TabIndex = 17;
            label1.Text = "Выберете язык приложения:";
            // 
            // LabelChangeLanguage
            // 
            LabelChangeLanguage.AutoSize = true;
            LabelChangeLanguage.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelChangeLanguage.Location = new Point(90, 169);
            LabelChangeLanguage.Name = "LabelChangeLanguage";
            LabelChangeLanguage.Size = new Size(238, 42);
            LabelChangeLanguage.TabIndex = 16;
            LabelChangeLanguage.Text = "Смена языка";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.free_icon_translating_6490410__2_;
            pictureBox3.Location = new Point(14, 169);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 70);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDown1.Location = new Point(728, 81);
            numericUpDown1.Maximum = new decimal(new int[] { 121, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(58, 34);
            numericUpDown1.TabIndex = 14;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // LabelEnterDollar
            // 
            LabelEnterDollar.AutoSize = true;
            LabelEnterDollar.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelEnterDollar.Location = new Point(399, 83);
            LabelEnterDollar.Name = "LabelEnterDollar";
            LabelEnterDollar.Size = new Size(323, 26);
            LabelEnterDollar.TabIndex = 13;
            LabelEnterDollar.Text = "Введите текущий курс доллара:";
            // 
            // LabelChangeDollar
            // 
            LabelChangeDollar.AutoSize = true;
            LabelChangeDollar.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelChangeDollar.Location = new Point(399, 36);
            LabelChangeDollar.Name = "LabelChangeDollar";
            LabelChangeDollar.Size = new Size(376, 42);
            LabelChangeDollar.TabIndex = 12;
            LabelChangeDollar.Text = "Смена курса доллара";
            // 
            // DollarIcon
            // 
            DollarIcon.Image = Properties.Resources.free_icon_dollar_symbol_126179;
            DollarIcon.Location = new Point(337, 39);
            DollarIcon.Name = "DollarIcon";
            DollarIcon.Size = new Size(70, 70);
            DollarIcon.TabIndex = 11;
            DollarIcon.TabStop = false;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(OpenMenuIcon);
            Controls.Add(LabelSettings);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "Settings";
            Size = new Size(1075, 712);
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OpenMenuIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DollarIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlMenu;
        private Button ButtonResetSettings;
        private Button ButtonApplySettings;
        private PictureBox OpenMenuIcon;
        private Label LabelSettings;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label LabelChangeDollar;
        private PictureBox DollarIcon;
        private Label LabelEnterDollar;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox3;
        private Label LabelChangeLanguage;
        private ComboBox comboBox1;
        private Label label1;
        private CheckBox checkBox1;
        private Label LabelDarkOnOrOff;
        private Label LabelDarkTheme;
        private PictureBox pictureBox2;
        private CheckBox checkBox3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox5;
        private CheckBox checkBox2;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox4;
        private Button ButtonReturnToHome;
        private Button ButtonSettings;
        private Button ButtonFirstTime;
        private Button ButtonContinueWork;
        private Button ButtonStartNewWork;
        private Label label6;
    }
}
