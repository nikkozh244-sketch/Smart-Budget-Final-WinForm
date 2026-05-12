using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Budget
{
    public class TransparentPanel : Panel
    {
        private int alpha = 125; // Прозрачность от 0 до 255

        public TransparentPanel()
        {
            // Включаем поддержку прозрачности
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            this.BackColor = Color.FromArgb(alpha, Color.Black); // Темный цвет
        }

        public int Alpha
        {
            get { return alpha; }
            set
            {
                alpha = Math.Max(0, Math.Min(255, value)); // Ограничение от 0 до 255
                this.BackColor = Color.FromArgb(alpha, Color.Black);
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Рисуем полупрозрачный фон
            using (var brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }
    }
}
