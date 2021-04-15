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
    /// Логика взаимодействия для Stage16.xaml
    /// </summary>
    public partial class Stage16 : Page
    {
        public Stage16()
        {
            InitializeComponent();
        }

        private void btnMoney_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данная сюжетная ветка является уникальной и потому платная. " +
                " Для продолжения игры оформите подписку за $9.99 .");

            Transition.MainFrame.Navigate(new Stage15());
        }
    }
}
