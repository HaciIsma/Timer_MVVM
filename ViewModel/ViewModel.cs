using System.Windows.Threading;
using PropertyChanged;
using System;

namespace Timer_MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class ViewModel
    {
        public string Time { get; set; }

        public ViewModel()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Time = DateTime.Now.ToLongTimeString();
        }
    }
}
