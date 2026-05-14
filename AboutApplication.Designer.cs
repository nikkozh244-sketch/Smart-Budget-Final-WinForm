namespace Smart_Budget
{
    partial class AboutApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutApplication));
            LabelAboutApp = new Label();
            PictureCat = new PictureBox();
            IconOpenMenu = new PictureBox();
            PanelMainScroll = new Panel();
            VideoTeaching = new AxWMPLib.AxWindowsMediaPlayer();
            TextTeaching = new RichTextBox();
            label1 = new Label();
            helpProvider1 = new HelpProvider();
            ((System.ComponentModel.ISupportInitialize)PictureCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconOpenMenu).BeginInit();
            PanelMainScroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VideoTeaching).BeginInit();
            SuspendLayout();
            // 
            // LabelAboutApp
            // 
            LabelAboutApp.BackColor = SystemColors.Window;
            LabelAboutApp.BorderStyle = BorderStyle.FixedSingle;
            LabelAboutApp.FlatStyle = FlatStyle.Flat;
            LabelAboutApp.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelAboutApp.ImageAlign = ContentAlignment.MiddleRight;
            LabelAboutApp.Location = new Point(105, 0);
            LabelAboutApp.Name = "LabelAboutApp";
            LabelAboutApp.Size = new Size(812, 111);
            LabelAboutApp.TabIndex = 9;
            LabelAboutApp.Text = resources.GetString("LabelAboutApp.Text");
            LabelAboutApp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PictureCat
            // 
            PictureCat.BackColor = SystemColors.Window;
            PictureCat.BorderStyle = BorderStyle.FixedSingle;
            PictureCat.Image = (Image)resources.GetObject("PictureCat.Image");
            PictureCat.Location = new Point(-1, 0);
            PictureCat.Name = "PictureCat";
            PictureCat.Size = new Size(109, 111);
            PictureCat.TabIndex = 8;
            PictureCat.TabStop = false;
            // 
            // IconOpenMenu
            // 
            IconOpenMenu.Image = (Image)resources.GetObject("IconOpenMenu.Image");
            IconOpenMenu.Location = new Point(934, 3);
            IconOpenMenu.Name = "IconOpenMenu";
            IconOpenMenu.Size = new Size(98, 94);
            IconOpenMenu.TabIndex = 10;
            IconOpenMenu.TabStop = false;
            IconOpenMenu.Click += OpenMenuIcon_Click_1;
            // 
            // PanelMainScroll
            // 
            PanelMainScroll.AutoScroll = true;
            PanelMainScroll.BackColor = SystemColors.Control;
            PanelMainScroll.Controls.Add(VideoTeaching);
            PanelMainScroll.Controls.Add(TextTeaching);
            PanelMainScroll.Controls.Add(label1);
            PanelMainScroll.ImeMode = ImeMode.NoControl;
            PanelMainScroll.Location = new Point(0, 117);
            PanelMainScroll.Name = "PanelMainScroll";
            PanelMainScroll.Size = new Size(1062, 712);
            PanelMainScroll.TabIndex = 11;
            // 
            // VideoTeaching
            // 
            VideoTeaching.Enabled = true;
            VideoTeaching.Location = new Point(249, 0);
            VideoTeaching.Name = "VideoTeaching";
            VideoTeaching.OcxState = (AxHost.State)resources.GetObject("VideoTeaching.OcxState");
            VideoTeaching.Size = new Size(629, 496);
            VideoTeaching.TabIndex = 3;
            VideoTeaching.Enter += axWindowsMediaPlayer1_Enter;
            // 
            // TextTeaching
            // 
            TextTeaching.BackColor = SystemColors.Control;
            TextTeaching.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextTeaching.Location = new Point(59, 502);
            TextTeaching.Name = "TextTeaching";
            TextTeaching.ScrollBars = RichTextBoxScrollBars.Vertical;
            TextTeaching.Size = new Size(973, 821);
            TextTeaching.TabIndex = 2;
            TextTeaching.Text = resources.GetString("TextTeaching.Text");
            TextTeaching.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(487, 502);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AboutApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelMainScroll);
            Controls.Add(IconOpenMenu);
            Controls.Add(LabelAboutApp);
            Controls.Add(PictureCat);
            Name = "AboutApplication";
            Size = new Size(1062, 712);
            ((System.ComponentModel.ISupportInitialize)PictureCat).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconOpenMenu).EndInit();
            PanelMainScroll.ResumeLayout(false);
            PanelMainScroll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VideoTeaching).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LabelAboutApp;
        private PictureBox PictureCat;
        private PictureBox IconOpenMenu;
        private Panel PanelMainScroll;
        private Label label1;
        private RichTextBox TextTeaching;
        private AxWMPLib.AxWindowsMediaPlayer VideoTeaching;
        private HelpProvider helpProvider1;
    }
}
