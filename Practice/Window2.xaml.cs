using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            DataContext = this;
            //Intialise entries before InitializeComponent() becuase if set is called
            //and entries is intialised afterwater then we cana null 
            //check exception between will only know data before initializeocomponent.
            entries = new ObservableCollection<string>();
            entries.Add("Test");
            this.TextWindow = "Hola";
            InitializeComponent();
        }


        private string _textWindow;
        
        public string TextWindow
        {
            get { return _textWindow; }
            set { _textWindow = value; }
        }

        private ObservableCollection<string> entries;


        public ObservableCollection<string> Entries
        {
            get { return entries; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            entries.Add(txtEntry.Text);
            
        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            string selectedItem = (string)lvEntries.SelectedItem;
            entries.Remove(selectedItem);
        }

        private void Button_Question(object sender, RoutedEventArgs e)
        {
        }
    }
}
