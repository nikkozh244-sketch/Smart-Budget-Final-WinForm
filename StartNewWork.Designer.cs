namespace Smart_Budget
{
    partial class StartNewWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartNewWork));
            OpenMenuIcon = new PictureBox();
            LabelStartNewWork = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            ButtonDoneEntering = new Button();
            ButtonChangeData = new Button();
            ButtonAddData = new Button();
            DatePicker = new DateTimePicker();
            LabelDate = new Label();
            ComboBoxCurrency = new ComboBox();
            LabelCurrency = new Label();
            ComboBoxCaregory = new ComboBox();
            LabelCategory = new Label();
            ComboBoxType = new ComboBox();
            LabelType = new Label();
            LabelAmount = new Label();
            NumericAmount = new NumericUpDown();
            helpProvider1 = new HelpProvider();
            PictureCat = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)OpenMenuIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureCat).BeginInit();
            SuspendLayout();
            // 
            // OpenMenuIcon
            // 
            OpenMenuIcon.Image = (Image)resources.GetObject("OpenMenuIcon.Image");
            OpenMenuIcon.Location = new Point(935, 3);
            OpenMenuIcon.Name = "OpenMenuIcon";
            OpenMenuIcon.Size = new Size(98, 94);
            OpenMenuIcon.TabIndex = 16;
            OpenMenuIcon.TabStop = false;
            OpenMenuIcon.Click += OpenMenuIcon_Click;
            // 
            // LabelStartNewWork
            // 
            LabelStartNewWork.BackColor = SystemColors.Window;
            LabelStartNewWork.BorderStyle = BorderStyle.FixedSingle;
            LabelStartNewWork.FlatStyle = FlatStyle.Flat;
            LabelStartNewWork.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelStartNewWork.ImageAlign = ContentAlignment.MiddleRight;
            LabelStartNewWork.Location = new Point(106, 0);
            LabelStartNewWork.Name = "LabelStartNewWork";
            LabelStartNewWork.Size = new Size(812, 111);
            LabelStartNewWork.TabIndex = 15;
            LabelStartNewWork.Text = "Для начала работы - введите данные об операциях, мур! Откройте F1 после нажатия на любую из кнопок\r\n\r\n";
            LabelStartNewWork.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(709, 566);
            dataGridView1.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(ButtonDoneEntering);
            panel1.Controls.Add(ButtonChangeData);
            panel1.Controls.Add(ButtonAddData);
            panel1.Controls.Add(DatePicker);
            panel1.Controls.Add(LabelDate);
            panel1.Controls.Add(ComboBoxCurrency);
            panel1.Controls.Add(LabelCurrency);
            panel1.Controls.Add(ComboBoxCaregory);
            panel1.Controls.Add(LabelCategory);
            panel1.Controls.Add(ComboBoxType);
            panel1.Controls.Add(LabelType);
            panel1.Controls.Add(LabelAmount);
            panel1.Controls.Add(NumericAmount);
            panel1.Location = new Point(727, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 598);
            panel1.TabIndex = 18;
            // 
            // ButtonDoneEntering
            // 
            ButtonDoneEntering.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonDoneEntering.Location = new Point(17, 518);
            ButtonDoneEntering.Name = "ButtonDoneEntering";
            ButtonDoneEntering.Size = new Size(144, 65);
            ButtonDoneEntering.TabIndex = 13;
            ButtonDoneEntering.Text = "Готово";
            ButtonDoneEntering.UseVisualStyleBackColor = true;
            ButtonDoneEntering.Click += DoneEntering_Click;
            // 
            // ButtonChangeData
            // 
            ButtonChangeData.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonChangeData.Location = new Point(193, 447);
            ButtonChangeData.Name = "ButtonChangeData";
            ButtonChangeData.Size = new Size(144, 65);
            ButtonChangeData.TabIndex = 12;
            ButtonChangeData.Text = "Изменить";
            ButtonChangeData.UseVisualStyleBackColor = true;
            ButtonChangeData.Click += ChangeData_Click;
            // 
            // ButtonAddData
            // 
            ButtonAddData.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonAddData.Location = new Point(17, 447);
            ButtonAddData.Name = "ButtonAddData";
            ButtonAddData.Size = new Size(144, 65);
            ButtonAddData.TabIndex = 11;
            ButtonAddData.Text = "Добавить";
            ButtonAddData.UseVisualStyleBackColor = true;
            ButtonAddData.Click += AddData_Click;
            // 
            // DatePicker
            // 
            DatePicker.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DatePicker.Location = new Point(17, 396);
            DatePicker.MaxDate = new DateTime(2026, 6, 20, 0, 0, 0, 0);
            DatePicker.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(320, 34);
            DatePicker.TabIndex = 10;
            DatePicker.Value = new DateTime(2026, 5, 12, 0, 0, 0, 0);
            // 
            // LabelDate
            // 
            LabelDate.AutoSize = true;
            LabelDate.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelDate.Location = new Point(88, 353);
            LabelDate.Name = "LabelDate";
            LabelDate.Size = new Size(201, 34);
            LabelDate.TabIndex = 9;
            LabelDate.Text = "Дата операции";
            LabelDate.Click += label5_Click;
            // 
            // ComboBoxCurrency
            // 
            ComboBoxCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxCurrency.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ComboBoxCurrency.FormattingEnabled = true;
            ComboBoxCurrency.Items.AddRange(new object[] { "Рубли", "Доллары" });
            ComboBoxCurrency.Location = new Point(16, 302);
            ComboBoxCurrency.Name = "ComboBoxCurrency";
            ComboBoxCurrency.Size = new Size(320, 34);
            ComboBoxCurrency.TabIndex = 8;
            // 
            // LabelCurrency
            // 
            LabelCurrency.AutoSize = true;
            LabelCurrency.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelCurrency.Location = new Point(129, 265);
            LabelCurrency.Name = "LabelCurrency";
            LabelCurrency.Size = new Size(111, 34);
            LabelCurrency.TabIndex = 7;
            LabelCurrency.Text = "Валюта";
            // 
            // ComboBoxCaregory
            // 
            ComboBoxCaregory.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ComboBoxCaregory.FormattingEnabled = true;
            ComboBoxCaregory.Items.AddRange(new object[] { "Продукты", "Кафе", "Транспорт", "Доставка", "Одежда", "Электротехника" });
            ComboBoxCaregory.Location = new Point(17, 214);
            ComboBoxCaregory.Name = "ComboBoxCaregory";
            ComboBoxCaregory.Size = new Size(320, 34);
            ComboBoxCaregory.TabIndex = 6;
            // 
            // LabelCategory
            // 
            LabelCategory.AutoSize = true;
            LabelCategory.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelCategory.Location = new Point(46, 177);
            LabelCategory.Name = "LabelCategory";
            LabelCategory.Size = new Size(272, 34);
            LabelCategory.TabIndex = 5;
            LabelCategory.Text = "Категория операции";
            // 
            // ComboBoxType
            // 
            ComboBoxType.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ComboBoxType.FormattingEnabled = true;
            ComboBoxType.Items.AddRange(new object[] { "Зачисление", "Перевод", "Снятие", "Списание" });
            ComboBoxType.Location = new Point(17, 126);
            ComboBoxType.Name = "ComboBoxType";
            ComboBoxType.Size = new Size(320, 34);
            ComboBoxType.TabIndex = 4;
            // 
            // LabelType
            // 
            LabelType.AutoSize = true;
            LabelType.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelType.Location = new Point(88, 89);
            LabelType.Name = "LabelType";
            LabelType.Size = new Size(193, 34);
            LabelType.TabIndex = 3;
            LabelType.Text = "Тип операции";
            // 
            // LabelAmount
            // 
            LabelAmount.AutoSize = true;
            LabelAmount.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelAmount.Location = new Point(64, 0);
            LabelAmount.Name = "LabelAmount";
            LabelAmount.Size = new Size(232, 34);
            LabelAmount.TabIndex = 1;
            LabelAmount.Text = "Размер операции";
            LabelAmount.Click += label1_Click;
            // 
            // NumericAmount
            // 
            NumericAmount.DecimalPlaces = 2;
            NumericAmount.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumericAmount.Location = new Point(85, 37);
            NumericAmount.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            NumericAmount.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            NumericAmount.Name = "NumericAmount";
            NumericAmount.Size = new Size(196, 34);
            NumericAmount.TabIndex = 0;
            NumericAmount.Value = new decimal(new int[] { 100010, 0, 0, 131072 });
            // 
            // PictureCat
            // 
            PictureCat.BackColor = SystemColors.Window;
            PictureCat.BorderStyle = BorderStyle.FixedSingle;
            PictureCat.Image = (Image)resources.GetObject("PictureCat.Image");
            PictureCat.Location = new Point(0, 0);
            PictureCat.Name = "PictureCat";
            PictureCat.Size = new Size(109, 111);
            PictureCat.TabIndex = 19;
            PictureCat.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(193, 518);
            button1.Name = "button1";
            button1.Size = new Size(144, 65);
            button1.TabIndex = 14;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            // 
            // StartNewWork
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PictureCat);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(OpenMenuIcon);
            Controls.Add(LabelStartNewWork);
            Name = "StartNewWork";
            Size = new Size(1075, 712);
            ((System.ComponentModel.ISupportInitialize)OpenMenuIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureCat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox OpenMenuIcon;
        private Label LabelStartNewWork;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label LabelAmount;
        private NumericUpDown NumericAmount;
        private Label LabelType;
        private ComboBox ComboBoxCurrency;
        private Label LabelCurrency;
        private ComboBox ComboBoxCaregory;
        private Label LabelCategory;
        private ComboBox ComboBoxType;
        private Label LabelDate;
        private DateTimePicker DatePicker;
        private Button ButtonChangeData;
        private Button ButtonAddData;
        private Button ButtonDoneEntering;
        private HelpProvider helpProvider1;
        private PictureBox PictureCat;
        private Button button1;
    }
}
