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

namespace CustomProgressBar
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

        private void loadingBar_MouseMove(object sender, MouseEventArgs e)
        {
            ThicknessAnimation animation = new ThicknessAnimation();
            animation.From = new Thickness(0, 50, -100, 50);
            animation.To = new Thickness(0, 50, 100, 50);
            animation.Duration = TimeSpan.FromSeconds(0.5);
            animation.RepeatBehavior = RepeatBehavior.Forever;
            loadingBar.BeginAnimation(MarginProperty, animation);
        }
    }
}
