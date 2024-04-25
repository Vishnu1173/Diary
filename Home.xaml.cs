using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace Diary
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        FirstPage firstPage;
        ReadPage readPage;
        public Home()
        {
            InitializeComponent();
            firstPage = new FirstPage();
             readPage = new ReadPage();
            Framemain.Content = firstPage;
        }

       

       

        private void Btnwrite_Click_1(object sender, RoutedEventArgs e)
        {
            Framemain.Content = firstPage;
        }

        private void Btnread_Click_1(object sender, RoutedEventArgs e)
        {
            Framemain.Content = readPage;
        }

       
    }
}
