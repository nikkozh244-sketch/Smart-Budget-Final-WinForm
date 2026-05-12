namespace Smart_Budget
{
    partial class FirstTimeInApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstTimeInApplication));
            LabelSettings = new Label();
            pictureBox1 = new PictureBox();
            OpenMenuIcon = new PictureBox();
            PanelMainScroll = new Panel();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OpenMenuIcon).BeginInit();
            PanelMainScroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
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
            LabelSettings.TabIndex = 9;
            LabelSettings.Text = resources.GetString("LabelSettings.Text");
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
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // OpenMenuIcon
            // 
            OpenMenuIcon.Image = (Image)resources.GetObject("OpenMenuIcon.Image");
            OpenMenuIcon.Location = new Point(934, 3);
            OpenMenuIcon.Name = "OpenMenuIcon";
            OpenMenuIcon.Size = new Size(98, 94);
            OpenMenuIcon.TabIndex = 10;
            OpenMenuIcon.TabStop = false;
            OpenMenuIcon.Click += OpenMenuIcon_Click_1;
            // 
            // PanelMainScroll
            // 
            PanelMainScroll.AutoScroll = true;
            PanelMainScroll.BackColor = SystemColors.Control;
            PanelMainScroll.Controls.Add(axWindowsMediaPlayer1);
            PanelMainScroll.Controls.Add(richTextBox1);
            PanelMainScroll.Controls.Add(label1);
            PanelMainScroll.ImeMode = ImeMode.NoControl;
            PanelMainScroll.Location = new Point(0, 117);
            PanelMainScroll.Name = "PanelMainScroll";
            PanelMainScroll.Size = new Size(1062, 712);
            PanelMainScroll.TabIndex = 11;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(249, 0);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(629, 496);
            axWindowsMediaPlayer1.TabIndex = 3;
            axWindowsMediaPlayer1.Enter += axWindowsMediaPlayer1_Enter;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(59, 502);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(973, 821);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
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
            // FirstTimeInApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelMainScroll);
            Controls.Add(OpenMenuIcon);
            Controls.Add(LabelSettings);
            Controls.Add(pictureBox1);
            Name = "FirstTimeInApplication";
            Size = new Size(1062, 712);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)OpenMenuIcon).EndInit();
            PanelMainScroll.ResumeLayout(false);
            PanelMainScroll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LabelSettings;
        private PictureBox pictureBox1;
        private PictureBox OpenMenuIcon;
        private Panel PanelMainScroll;
        private Label label1;
        private RichTextBox richTextBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
