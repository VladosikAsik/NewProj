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
        //private Panel panel;

        public ZohaButton() : base()
        {
            this.Size = new System.Drawing.Size(50, 50);
            this.BackColor = Color.Gray;
            this.Location = new Point(50, 50);
            base.Paint += ZohaButton_Paint;
        }

        private void ZohaButton_Paint(object sender, PaintEventArgs e)
        {
            var g = CreateGraphics();
            g.DrawRectangle(new Pen(Color.Red, 3), new Rectangle(50, 50, 50, 50));
        }
    }
}
