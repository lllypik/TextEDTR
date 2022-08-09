using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TextEDTR
{
    class MyCommands
    {

        public static RoutedCommand FontBold { get; set; }

        public static RoutedCommand FontItalic { get; set; }

        public static RoutedCommand FontUnderline { get; set; }

        public static RoutedCommand FontSize { get; set; }

        public static RoutedCommand FontType { get; set; }

        //public static RoutedCommand FontColorBlack { get; set; }
        public static RoutedUICommand FontColorBlack { get; set; }

        public static RoutedCommand FontColorRed { get; set; }

        static MyCommands()
        {
            InputGestureCollection inputBold = new InputGestureCollection();
            inputBold.Add(new KeyGesture(Key.B, ModifierKeys.Control, "CTRL+B"));
            FontBold = new RoutedCommand("FontBold", typeof(MyCommands), inputBold);

            InputGestureCollection inputItalic = new InputGestureCollection();
            inputItalic.Add(new KeyGesture(Key.I, ModifierKeys.Control, "CTRL+I"));
            FontItalic = new RoutedCommand("FontItalic", typeof(MyCommands), inputItalic);

            InputGestureCollection inputUnderline = new InputGestureCollection();
            inputUnderline.Add(new KeyGesture(Key.U, ModifierKeys.Control, "CTRL+U"));
            FontUnderline = new RoutedCommand("FontItalic", typeof(MyCommands), inputUnderline);

            //FontColorBlack = new RoutedCommand("FontColorBlack", typeof(MyCommands));
            FontColorBlack = new RoutedUICommand("Black","FontColorBlack", typeof(MyCommands));

            FontColorRed = new RoutedCommand("FontColorRed", typeof(MyCommands));

        }
    }
}
