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

namespace WPFEvents
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyButton.Click += MyButton_Click;
            MyButton.Click += MyButton_IClick;
            
        }

        private void MyButton_IClick(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            MyLabel.Content = "Hello World again!";
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            MyLabel.Content = "Hello World!";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
