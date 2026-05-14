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
            ((System.ComponentModel.ISupportInitialize)IconOpenMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureCat).BeginInit();
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
            // GetAnalys
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(IconOpenMenu);
            Controls.Add(LabelGetAnalys);
            Controls.Add(PictureCat);
            Name = "GetAnalys";
            Size = new Size(1062, 712);
            ((System.ComponentModel.ISupportInitialize)IconOpenMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureCat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox IconOpenMenu;
        private Label LabelGetAnalys;
        private PictureBox PictureCat;
    }
}
