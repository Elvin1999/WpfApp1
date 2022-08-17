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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer=new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            //timer.Interval = TimeSpan.FromMilliseconds(2);
            //timer.Tick += Timer_Tick;
            //timer.Start();





            //Stack Panel
            //WrapPanel
            //DockPanel
            //Canvas
            //Uniform Grid
            //Grid

        }
        public int X { get; set; } = 0;
        private void Timer_Tick(object? sender, EventArgs e)
        {
            //lbl.Margin = new Thickness(X, 0, 0, 0);
            //X += 1;
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //if(lbl.Visibility == Visibility.Hidden)
            //{
            //    lbl.Visibility = Visibility.Visible;
            //}
        }
    }
}
