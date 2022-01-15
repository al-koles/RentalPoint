using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalPoint1
{
    class MyLabel : Label
    {
        public MyLabel(int y, string text) : base()
        {
            AutoSize = true;
            Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Location = new System.Drawing.Point(20, y);
            Size = new System.Drawing.Size(180, 20);
            Text = text;
        }
    }
}
