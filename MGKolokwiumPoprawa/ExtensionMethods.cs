using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MGKolokwiumPoprawa { 


    class ExtensionMethods
    {
        public object FontStyle { get; private set; }
        public object Brushes { get; private set; }
        public object Font { get; private set; }
        public object SystemPens { get; private set; }

        private void CreatePointsAndSizes(PaintEventArgs e)
        {

            // Point punktStartowy = new Point(subtractButton.Size);
            // Point punktKoncowy = punktStartowy + new Size(140, 150);

        
          //  e.Graphics.DrawLine(SystemPens.Highlight, punktStartowy, punktKoncowy);

           
          // Size buttonSize = (Size)punktStartowy;
            //if (buttonSize == subtractButton.Size)

            {
             //   e.Graphics.DrawString("The sizes are equal.",
                //    new Font(this.Font, FontStyle.Italic),
                //    Brushes.Indigo, 10.0F, 65.0F);
            }
        }

        private class PaintEventArgs
        {
            
        }
    }
}
