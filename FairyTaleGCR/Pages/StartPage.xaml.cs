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

namespace FairyTaleGCR
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        string path = @"C:\Users\user\Desktop\game.txt";
        public StartPage()
        {
            InitializeComponent();
        }

        private void btnNG_Click(object sender, RoutedEventArgs e)
        {
            if ((tbEN.Text != "Enter nickname") || (tbEN.Text  !=""))
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine($"{tbEN.Text.Trim()};");

                    sw.Close();

                }

                Transition.MainFrame.Navigate(new Preface());
            }
            else
            {
                Transition.MainFrame.Navigate(new Preface());
            }

        }

        private void tbEN_GotFocus(object sender, RoutedEventArgs e)
        {
            tbEN.Clear();
        }

        private void tbEN_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key < Key.A) || (e.Key > Key.Z))
            {
                e.Handled = true;
            }
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
