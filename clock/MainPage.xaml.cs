using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace clock
{
    public partial class MainPage : ContentPage
    {
        private static System.Timers.Timer timer = new System.Timers.Timer(500);
        public MainPage()
        {
            InitializeComponent();

            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Start();

        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            //format 08:42:33
            String current_time = e.SignalTime.TimeOfDay.ToString();

            FirstHoursDisplay.ShowNumber(current_time[0]);
            SecondHoursDisplay.ShowNumber(current_time[1]);

            FirstMinDisplay.ShowNumber(current_time[3]);
            SecondMinDisplay.ShowNumber(current_time[4]);

            FirstSecDisplay.ShowNumber(current_time[6]);
            SecondSecDisplay.ShowNumber(current_time[7]);
        }

    }
}
