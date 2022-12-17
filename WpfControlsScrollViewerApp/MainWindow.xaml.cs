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

namespace WpfControlsScrollViewerApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            panel.Width = 500;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            scroll.ScrollToTop();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            scroll.LineUp();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            scroll.LineDown();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            scroll.ScrollToBottom();
        }
    }
}
