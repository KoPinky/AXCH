using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AXCH.windows
{
    /// <summary>
    /// Логика взаимодействия для EnterMV.xaml
    /// </summary>
    public partial class EnterMV : Window
    {
        public EnterMV()
        {
            InitializeComponent();
        }

        public void Load()
        {
            NameMVCB.ItemsSource = DB.db.MaterialValues.Select(s => s.Name).ToList();
        }

        private void NameMVCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NameMV.Text = NameMVCB.Text;
            MaterialValues mv = DB.db.MaterialValues.Where(w => w.Name == NameMVCB.Text).FirstOrDefault();

            UnitMV.Text = mv.Unit;
            Categorie.Text = mv.Category;
        }

        public bool SaveInBD()
        {
            try
            {
                if (NameMV.Text != NameMVCB.Text)
                {
                    MaterialValues mv = new MaterialValues
                    {
                        Name = NameMV.Text,
                        Unit = UnitMV.Text,
                        Category = Categorie.Text

                    };
                }

                MaterialValuesAccounting MVA = new MaterialValuesAccounting
                {

                };
                DB.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
