using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.Additional_buttons
{
    static class PrintTable
    {
        public static Bitmap GetBmpForPrint(DataGridView dataGridView, Rectangle bounds)
        {
            Bitmap bmp = new Bitmap(dataGridView.Width + 10, dataGridView.Height + 10);
            dataGridView.DrawToBitmap(bmp, bounds);
            return bmp;
        }
    }
}
