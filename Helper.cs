using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AXCH
{
    class Helper
    {
        public static void ErrorMessage(string TextMessagre)
        {
            MessageBox.Show(TextMessagre, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
