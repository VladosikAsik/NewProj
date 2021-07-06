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
        private bool check;
        private Point mousePosition;
        private Rectangle clickZone;

        public ZohaButton() : base()
        {
            this.Size = new System.Drawing.Size(200, 100);
            this.BackColor = Color.Purple;
            this.Location = new Point(100, 100);
            base.Paint += ZohaButton_Paint;
            base.MouseClick += ZohaButton_MouseClick;
            clickZone = new Rectangle(50, 35, 100, 30);
        }

        private void ZohaButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.mousePosition = new Point(e.Location.X, e.Location.Y);
            Invalidate();
        }

        private void ZohaButton_Paint(object sender, PaintEventArgs e)
        {
            var g = CreateGraphics();
            var brush = new SolidBrush(Color.Blue);
            g.FillRectangle(Brushes.White, new RectangleF(50, 35, 100, 30));
            check = true;

            if(new Rectangle(mousePosition, new Size(1,1)).IntersectsWith(clickZone))
            {
                check = !check;
            }
            if (check == true)
            {
                g.FillRectangle(Brushes.Green, new RectangleF(50, 35, 100, 30));
                g.FillEllipse(brush, new RectangleF(50, 35, 30, 30));
            }
            else if (check == false)
            {
                g.FillRectangle(Brushes.Red, new RectangleF(50, 35, 100, 30));
                g.FillEllipse(brush, new RectangleF(120, 35, 30, 30));
            }
        }
    }
}
