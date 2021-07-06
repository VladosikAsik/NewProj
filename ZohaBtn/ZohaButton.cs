using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZohaBtn
{
    class ZohaButton : Control
    {
        public ZohaButton() : base()
        {
            this.Size = new System.Drawing.Size(200, 100);
            this.BackColor = Color.Purple;
            this.Location = new Point(100, 100);
            base.Paint += ZohaButton_Paint;
        }

        private void ZohaButton_Paint(object sender, PaintEventArgs e)
        {
            var g = CreateGraphics();
            var brush = new SolidBrush(Color.Blue);
            g.FillRectangle(Brushes.Red, new RectangleF(50, 35, 100, 30));
            g.FillEllipse(brush, new RectangleF(50, 35, 30, 30));
        }
    }
}
