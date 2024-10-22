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

namespace MVVM.Practice
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            lvEntries.Items.Add("a1");
            lvEntries.Items.Add("a2");
            lvEntries.Items.Add("a3");
            lvEntries.Items.Add("a4");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(txtEntry.Text.ToString());
            txtEntry.Clear();
        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            //int selectedIndex = lvEntries.SelectedIndex;
            object item = lvEntries.SelectedItem;
            var result = MessageBox.Show($"Are sure you want to delete {(string)item}", "Sure", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                lvEntries.Items.Remove(item);
            }
            txtEntry.Clear();
        }

        private void Button_Question(object sender, RoutedEventArgs e)
        { 
        }
    }
}
