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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Diary
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        
        public Register()
        {
            InitializeComponent();
            
        }


        //string Path = $"C:\\newproj\\{txtfirst.Text}.txt";

        //if (File.Exists(Path))
        //{
        //    string content = File.ReadAllText(Path);
        //    string[] values = content.Split("|");
        //    if(values.Length >1)
        //    {
        //        if(txtfirst.Text== values[1])
        //        {
        //            MainWindow mainWindow = new MainWindow();
        //            mainWindow.txtname.Text = values[0];

        //            mainWindow.txtpassword.Text = values[1];
        //            mainWindow.btnsign.Content = "Update";
        //            mainWindow.txtname.IsEnabled = false;
        //            mainWindow.Show();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Invalid");
        //        }
        //    }

        //}
        //else
        //{
        //    MessageBox.Show("Invalid");
        //}
        // Home home = new Home();
        //home.lblname.Content = "Welcome" + txtfirst.Text;
        //home.Show();



        private void BtnRegister_Click_1(object sender, RoutedEventArgs e)
        {
            if (BtnRegister.Content == "Update")
            {
                string path = $"C:\\newproj\\{txtfirst.Text}.txt";
                string Content = $"{txtfirst.Text}|{txtsecondname.Text}";
                if (File.Exists(path))
                {


                    File.WriteAllText(path, Content);

                    MessageBox.Show("update Sucess");

                }

            }

            string Path = $"C:\\newproj\\{txtfirst.Text}.txt";
            string content = $"{txtfirst.Text}|{txtsecondname.Text}";
            if (File.Exists(Path))
            {


                File.WriteAllText(Path, content);

                MessageBox.Show("Register Sucess");
            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
        }
    }
}
