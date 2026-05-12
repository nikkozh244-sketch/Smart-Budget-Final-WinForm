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
            OpenMenuIcon = new PictureBox();
            LabelSettings = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)OpenMenuIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // OpenMenuIcon
            // 
            OpenMenuIcon.Image = (Image)resources.GetObject("OpenMenuIcon.Image");
            OpenMenuIcon.Location = new Point(934, 3);
            OpenMenuIcon.Name = "OpenMenuIcon";
            OpenMenuIcon.Size = new Size(98, 94);
            OpenMenuIcon.TabIndex = 13;
            OpenMenuIcon.TabStop = false;
            // 
            // LabelSettings
            // 
            LabelSettings.BackColor = SystemColors.Window;
            LabelSettings.BorderStyle = BorderStyle.FixedSingle;
            LabelSettings.FlatStyle = FlatStyle.Flat;
            LabelSettings.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelSettings.ImageAlign = ContentAlignment.MiddleRight;
            LabelSettings.Location = new Point(105, 0);
            LabelSettings.Name = "LabelSettings";
            LabelSettings.Size = new Size(812, 111);
            LabelSettings.TabIndex = 12;
            LabelSettings.Text = "Анализ данных завершен! В будущем вы сможете, наведя курсор мышки на функцию, узнать подробнее о ней, мяу!\r\n\r\n";
            LabelSettings.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 111);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // GetAnalys
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OpenMenuIcon);
            Controls.Add(LabelSettings);
            Controls.Add(pictureBox1);
            Name = "GetAnalys";
            Size = new Size(1062, 712);
            ((System.ComponentModel.ISupportInitialize)OpenMenuIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox OpenMenuIcon;
        private Label LabelSettings;
        private PictureBox pictureBox1;
    }
}
