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
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            DoneEntering = new Button();
            ChangeData = new Button();
            AddData = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            comboBox3 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)OpenMenuIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            LabelStartNewWork.Text = "Для начала работы - введите данные об операциях, мур!";
            LabelStartNewWork.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 111);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
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
            panel1.Controls.Add(DoneEntering);
            panel1.Controls.Add(ChangeData);
            panel1.Controls.Add(AddData);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numericUpDown1);
            panel1.Location = new Point(727, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 598);
            panel1.TabIndex = 18;
            // 
            // DoneEntering
            // 
            DoneEntering.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DoneEntering.Location = new Point(106, 518);
            DoneEntering.Name = "DoneEntering";
            DoneEntering.Size = new Size(144, 65);
            DoneEntering.TabIndex = 13;
            DoneEntering.Text = "Готово";
            DoneEntering.UseVisualStyleBackColor = true;
            // 
            // ChangeData
            // 
            ChangeData.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChangeData.Location = new Point(193, 447);
            ChangeData.Name = "ChangeData";
            ChangeData.Size = new Size(144, 65);
            ChangeData.TabIndex = 12;
            ChangeData.Text = "Изменить";
            ChangeData.UseVisualStyleBackColor = true;
            ChangeData.Click += ChangeData_Click;
            // 
            // AddData
            // 
            AddData.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddData.Location = new Point(17, 447);
            AddData.Name = "AddData";
            AddData.Size = new Size(144, 65);
            AddData.TabIndex = 11;
            AddData.Text = "Добавить";
            AddData.UseVisualStyleBackColor = true;
            AddData.Click += AddData_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker1.Location = new Point(17, 396);
            dateTimePicker1.MaxDate = new DateTime(2026, 5, 12, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(320, 34);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.Value = new DateTime(2026, 5, 12, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(88, 353);
            label5.Name = "label5";
            label5.Size = new Size(201, 34);
            label5.TabIndex = 9;
            label5.Text = "Дата операции";
            label5.Click += label5_Click;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Рубли", "Доллары" });
            comboBox3.Location = new Point(16, 302);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(320, 34);
            comboBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(129, 265);
            label4.Name = "label4";
            label4.Size = new Size(111, 34);
            label4.TabIndex = 7;
            label4.Text = "Валюта";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Продукты", "Кафе", "Транспорт", "Доставка", "Одежда", "Электротехника" });
            comboBox2.Location = new Point(17, 214);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(320, 34);
            comboBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(46, 177);
            label3.Name = "label3";
            label3.Size = new Size(272, 34);
            label3.TabIndex = 5;
            label3.Text = "Категория операции";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Зачисление", "Перевод", "Снятие", "Списание" });
            comboBox1.Location = new Point(17, 126);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(320, 34);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(88, 89);
            label2.Name = "label2";
            label2.Size = new Size(193, 34);
            label2.TabIndex = 3;
            label2.Text = "Тип операции";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(64, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 34);
            label1.TabIndex = 1;
            label1.Text = "Размер операции";
            label1.Click += label1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDown1.Location = new Point(85, 37);
            numericUpDown1.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(196, 34);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 100010, 0, 0, 131072 });
            // 
            // StartNewWork
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(OpenMenuIcon);
            Controls.Add(LabelStartNewWork);
            Controls.Add(pictureBox1);
            Name = "StartNewWork";
            Size = new Size(1075, 712);
            ((System.ComponentModel.ISupportInitialize)OpenMenuIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox OpenMenuIcon;
        private Label LabelStartNewWork;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private ComboBox comboBox3;
        private Label label4;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button ChangeData;
        private Button AddData;
        private Button DoneEntering;
    }
}
