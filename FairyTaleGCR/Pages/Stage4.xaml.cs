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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FairyTaleGCR
{
    /// <summary>
    /// Логика взаимодействия для Stage4.xaml
    /// </summary>
    public partial class Stage4 : Page
    {
        public Stage4()
        {
            InitializeComponent();
        }

        private void btnLAH_Click(object sender, RoutedEventArgs e)
        {
            Transition.MainFrame.Navigate(new Stage5());
        }

        private void btnBX_Click(object sender, RoutedEventArgs e)
        {
            Transition.MainFrame.Navigate(new Stage11());
        }
    }
}
