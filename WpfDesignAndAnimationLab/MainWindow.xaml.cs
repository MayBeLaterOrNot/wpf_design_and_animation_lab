﻿using System.Windows;
using System.Windows.Controls;
using WpfDesignAndAnimationLab.Infrastructure;

namespace WpfDesignAndAnimationLab
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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var exampleDefinition = DemoItemsControl.SelectedItem as ExampleDefinition;
            if (exampleDefinition == null)
                return;

            var container = new DemoContainer(exampleDefinition);
            DemoContentControl.Content = container;
        }
    }
}
