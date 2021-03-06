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

namespace WpfApp6.View
{
    /// <summary>
    /// Interakční logika pro ThirdView.xaml
    /// </summary>
    public partial class ThirdView : UserControl
    {
        private ViewModel VM => this.DataContext as ViewModel;

        public ThirdView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VM.SomeText = "Third view text";
        }

    }
}
