using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Diary
{
    /// <summary>
    /// Interaction logic for FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {

       
        public FirstPage()
        {
            
            InitializeComponent();
            

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
           // Home home = new Home();
           if (CmbDate.SelectedItem.ToString()!="date"&&CmbMonth.SelectedItem.ToString()!="month" && CmbYear.SelectedItem.ToString()!="year")
            {
                string Date = CmbDate.SelectedItem.ToString() + CmbMonth.SelectedItem.ToString() + CmbYear.SelectedItem.ToString();
                string FilePath = @"C:\newproj\\{shamili}.txt";
                string content = Content.Text ;
                File.WriteAllText(FilePath,content);
                MessageBox.Show("File saved Sucessfully");
            }
           else
            {
                MessageBox.Show("Please Select Date");
            }
            }
    }
}
