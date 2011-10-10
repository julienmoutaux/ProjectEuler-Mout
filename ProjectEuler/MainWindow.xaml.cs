using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectEuler
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

        private void Exo1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem1.Solve().ToString());
        }

        private void Exo2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem2.Solve().ToString());
        }

        private void Exo4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem4.Solve().ToString());
        }

        private void Exo5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem5.Solve().ToString());
        }

        private void Exo6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem6.Solve().ToString());
        }

        private void Exo7_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem7.Solve().ToString());
        }

        private void Exo8_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem8.Solve().ToString());
        }

        private void Exo10_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem10.Solve().ToString());
        }

        private void Exo9_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem9.Solve().ToString());
        }

        private void Exo12_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem12.Solve().ToString());
        }

        private void Exo14_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem14.Solve().ToString());
        }

        private void Exo11_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem11.Solve().ToString());
        }

        private void Exo15_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem15.Solve().ToString());
        }

        private void Exo13_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem13.Solve().ToString());
        }

        private void Exo16_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem16.Solve().ToString());
        }

        private void Exo20_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem20.Solve().ToString());
        }

        private void Exo18_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem18.Solve().ToString());
        }

        private void Exo19_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem19.Solve().ToString());
        }

        private void Exo17_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem17.Solve().ToString());
        }

        private void Exo67_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem67.Solve().ToString());
        }

        private void Exo21_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem21.Solve().ToString());
        }

        private void Exo22_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Problem22.Solve().ToString());
        }
    }
}
