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
    ///</summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int n = 0; //champ de classe
        public MainWindow()
        {
            InitializeComponent();
            lblTime.Content = "25:00";    
        }
        public void StartorStopTimer(object sender, RoutedEventArgs e)
        {
            if (toggle.IsChecked == false)
            {
                toggle.Content = "Start Work";
                timer.Stop();
                return;
            }
            else
            {
                toggle.Content = "Stop Work";
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick -= timer_Tick; // Retire l’association si elle existe déjà
                timer.Tick += timer_Tick; // Ajoute l’association
                timer.Start();
            }
        }

        public void ResetTimer(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            lblTime.Content = "25:00";
            toggle.IsChecked = false;
            toggle.Content = "Start Work";
            n = 0;
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
                    lblTime.Content = "25:00";
                    toggle.IsChecked = false;
                    toggle.Content = "Start Work";
                    StartorStopTimer(toggle, new RoutedEventArgs());
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