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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Drawing.Size sizeWindows;
        DoubleAnimation animation = new DoubleAnimation();
        public MainWindow()
        {
            sizeWindows = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        { 
            signInGrid.Visibility = Visibility.Hidden;
            MainWindowGrid.Visibility = Visibility.Visible;

            animation.To = (sizeWindows.Width - 1200) / 2;
            animation.AutoReverse = false;
            animation.Duration = new Duration(TimeSpan.FromSeconds(3));
            BeginAnimation(LeftProperty, animation);
        }

        private void DoubleAnimation_Completed(object sender, EventArgs e)
        {
        }

        private void WindowApp_Loaded(object sender, RoutedEventArgs e)
        {
            Left = (sizeWindows.Width - signInGrid.Width)/2;
            Top = (sizeWindows.Height - signInGrid.Height)/2;
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
