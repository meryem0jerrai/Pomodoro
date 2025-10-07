using System;
using System.Collections.Concurrent;
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
using System.Xml.Linq;
using System.Windows.Threading;
using System.Diagnostics.Eventing.Reader;


namespace Pomodoro
{
    ///<summary>
    ///Interaction logic for MainWindow.xaml
    ///</summry>
    public partial class MainWindow : Window
    {
        int n = 0; //champ de classe
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            lblTime.Content = "25:00";
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object? sender, EventArgs e)
        {
            string[] parts = lblTime.Content.ToString().Split(':');
            int minutes = int.Parse(parts[0]);
            int seconds = int.Parse(parts[1]);

            if (minutes == 0 && seconds == 0)
            {
                if (n==0)
                {
                    lblTime.Content = "00:00";
                    MessageBox.Show("Time's up! Take a break.");
                    n++;
                    // Fin de la période de travail
                }
                return;
                
                  
            }

            if (seconds==0)
            {
                if (minutes > 0)
                    {
                    minutes--;
                    seconds = 59;
                }
            }
            else 
                {
                seconds--;
            }
            lblTime.Content = $"{minutes:D2}:{seconds:D2}";

        }

        
    }

}