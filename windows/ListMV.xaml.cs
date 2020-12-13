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
    /// Логика взаимодействия для ListMV.xaml
    /// </summary>
    public partial class ListMV : Window
    {
        AXCHEntities db = new AXCHEntities();
        public ListMV()
        {
            InitializeComponent();
            
            
        }

        
        private void EmployeeList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                DeleteEmployee(MVList.CurrentItem as Employee);
            }
        }

        public bool DeleteEmployee(Employee CurrentEmployee)
        {
            var result = MessageBox.Show("Удалить сотрудника?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                DB.db.Employee.Remove(CurrentEmployee);
                DB.Save();
                Load();
                return true;

            }
            return false;
        }
        public void Load()
        {
            MVList.ItemsSource = db.MaterialValuesAccounting.ToList();
        }

        private void AddMV_Click(object sender, RoutedEventArgs e)
        {
            EnterMV emv = new EnterMV();
            emv.Show();
        }
    }
}
