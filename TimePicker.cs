using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MovieHelper
{
    public partial class TimePicker : UserControl, INotifyPropertyChanged
    {
        private int _time;
        
        [DefaultValue(595000)]
        public int Time
        {
            get { return _time; }
        }

        public TimePicker()
        {
            InitializeComponent();
            CalculateTime();
        }
        
        private void CalculateTime()
        {
            _time = (int)((nudHour.Value * 3600) + (nudMinute.Value * 60) + nudSecond.Value) * 1000;
            if (_time == 0)
                _time = 1;
            OnPropertyChanged("Time");
        }

        public string ShowTimeAsString()
        {
            return string.Format("{0}:{1}:{2}", 
                                    nudHour.Value, 
                                    nudMinute.Value, 
                                    nudSecond.Value);
        }


        private void nudSecond_ValueChanged(object sender, EventArgs e)
        {
            if (nudSecond.Value == 60)
            {
                nudMinute.Value += 1;
                nudSecond.Value = 0;
            }
            if (nudSecond.Value == -1)
            {
                if (nudMinute.Value > 0)
                {
                    nudMinute.Value -= 1;
                    nudSecond.Value = 59;
                }
                else
                    nudSecond.Value = 0;
            }
            CalculateTime();
        }

        private void nudMinute_ValueChanged(object sender, EventArgs e)
        {
            if (nudMinute.Value == 60)
            {
                nudHour.Value += 1;
                nudMinute.Value = 0;
            }
            else if (nudMinute.Value == -1)
            {
                if (nudHour.Value > 0)
                {
                    nudHour.Value -= 1;
                    nudMinute.Value = 59;
                }
                else
                    nudMinute.Value = 0;
            }
            
            CalculateTime();
        }

        #region INotifyPropertyChanged Members 

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private void TimePicker_Load(object sender, EventArgs e)
        {
            CalculateTime();
        }

        private void nudHour_ValueChanged(object sender, EventArgs e)
        {
            CalculateTime();
        }
    }
}
