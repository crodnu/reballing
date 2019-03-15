using System.Drawing;
using System.Windows.Forms;

namespace leervolt
{
    // https://stackoverflow.com/a/778866
    public class ColorProgressBar : ProgressBar
    {
        public ColorProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height - 4;
            e.Graphics.FillRectangle(BarColor, 2, 2, rec.Width, rec.Height);
        }

        public Brush BarColor = Brushes.Red;
    }
}
