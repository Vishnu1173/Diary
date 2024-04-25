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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
           
        }

       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string Path = $"C:\\newproj\\{txtname.Text}.txt";

            if (File.Exists(Path))
            {
                string content = File.ReadAllText(Path);
                string[] values = content.Split("|");
                if (values.Length > 1)
                {
                    if (txtname.Text == values[1])
                    {
                        Register register = new Register();
                        register.txtfirst.Text = values[0];

                        register.txtsecondname.Text = values[1];
                        register.BtnRegister.Content = "Update";
                        register.txtfirst.IsEnabled = false;
                        register.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid");
                    }
                }


                else
                {
                    MessageBox.Show("Invalid");
                }

            }
        }
    } }

