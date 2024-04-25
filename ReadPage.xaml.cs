using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Diary
{
    /// <summary>
    /// Interaction logic for ReadPage.xaml
    /// </summary>
    public partial class ReadPage : Page
    {
        
        public ReadPage()
        {
            InitializeComponent();
           


            ComboBoxItem date = (ComboBoxItem)CmbDate.SelectedItem;
            ComboBoxItem month = (ComboBoxItem)CmbMonth.SelectedItem;
            ComboBoxItem year = (ComboBoxItem)CmbYear.SelectedItem;


        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (CmbDate.SelectedItem.ToString() != "date" && CmbMonth.SelectedItem.ToString() != "month" && CmbYear.SelectedItem.ToString() != "year")
            {
                string Date = CmbDate.SelectedItem.ToString() + CmbMonth.SelectedItem.ToString() + CmbYear.SelectedItem.ToString();
                if (File.Exists(@"C:\newproj\\{shamili}.txt"));
                {
                    string filecontent = File.ReadAllText(@"C:\newproj\\{shamili}.txt");
                    Content = filecontent.ToString();
                }
            }
        }
    }
}
