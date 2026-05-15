namespace Smart_Budget
{
    partial class GetAnalys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetAnalys));
            IconOpenMenu = new PictureBox();
            LabelGetAnalys = new Label();
            PictureCat = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)IconOpenMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureCat).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // IconOpenMenu
            // 
            IconOpenMenu.Image = (Image)resources.GetObject("IconOpenMenu.Image");
            IconOpenMenu.Location = new Point(934, 3);
            IconOpenMenu.Name = "IconOpenMenu";
            IconOpenMenu.Size = new Size(98, 94);
            IconOpenMenu.TabIndex = 13;
            IconOpenMenu.TabStop = false;
            // 
            // LabelGetAnalys
            // 
            LabelGetAnalys.BackColor = SystemColors.Window;
            LabelGetAnalys.BorderStyle = BorderStyle.FixedSingle;
            LabelGetAnalys.FlatStyle = FlatStyle.Flat;
            LabelGetAnalys.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelGetAnalys.ImageAlign = ContentAlignment.MiddleRight;
            LabelGetAnalys.Location = new Point(105, 0);
            LabelGetAnalys.Name = "LabelGetAnalys";
            LabelGetAnalys.Size = new Size(812, 111);
            LabelGetAnalys.TabIndex = 12;
            LabelGetAnalys.Text = "Анализ данных завершен! В будущем вы сможете, наведя курсор мышки на функцию, узнать подробнее о ней, мяу!\r\n\r\n";
            LabelGetAnalys.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PictureCat
            // 
            PictureCat.BackColor = SystemColors.Window;
            PictureCat.BorderStyle = BorderStyle.FixedSingle;
            PictureCat.Image = (Image)resources.GetObject("PictureCat.Image");
            PictureCat.Location = new Point(-1, 0);
            PictureCat.Name = "PictureCat";
            PictureCat.Size = new Size(109, 111);
            PictureCat.TabIndex = 11;
            PictureCat.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(button4, 1, 1);
            tableLayoutPanel1.Controls.Add(button5, 0, 2);
            tableLayoutPanel1.Controls.Add(button6, 1, 2);
            tableLayoutPanel1.Location = new Point(689, 532);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel1.Size = new Size(373, 177);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(180, 50);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(189, 3);
            button2.Name = "button2";
            button2.Size = new Size(181, 50);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 59);
            button3.Name = "button3";
            button3.Size = new Size(180, 58);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(189, 59);
            button4.Name = "button4";
            button4.Size = new Size(181, 58);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 123);
            button5.Name = "button5";
            button5.Size = new Size(180, 51);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(189, 123);
            button6.Name = "button6";
            button6.Size = new Size(181, 51);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // GetAnalys
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(IconOpenMenu);
            Controls.Add(LabelGetAnalys);
            Controls.Add(PictureCat);
            Name = "GetAnalys";
            Size = new Size(1062, 712);
            ((System.ComponentModel.ISupportInitialize)IconOpenMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureCat).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox IconOpenMenu;
        private Label LabelGetAnalys;
        private PictureBox PictureCat;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
