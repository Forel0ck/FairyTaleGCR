﻿using System;
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
    /// Логика взаимодействия для Stage10.xaml
    /// </summary>
    public partial class Stage10 : Page
    {
        public Stage10()
        {
            InitializeComponent();
        }

        private void btnBHD_Click(object sender, RoutedEventArgs e)
        {
            Transition.MainFrame.Navigate(new StartPage());
        }
    }
}
