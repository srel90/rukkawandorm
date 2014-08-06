using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rukkawandorm.Class
{
    class module
    {
        public static int employeeID { get; set; }
        public static void ClearControl(Control control)
        {
          TextBox tb = control as TextBox;
          if (tb != null)
          {
            tb.Text = String.Empty;
          }
          if (control.HasChildren)
          {
            foreach(Control child in control.Controls)
            {
                ClearControl(child);
            }
          }
        }
    }
}
