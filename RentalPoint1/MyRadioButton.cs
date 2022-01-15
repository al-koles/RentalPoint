using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalPoint1
{
    class MyRadioButton : RadioButton
    {
        public string Field { get; private set; }
        public MyRadioButton(string field) : base()
        {
            Field = field;
        }
    }
}
