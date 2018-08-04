using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plot
{
    class MainViewModel : INotifyPropertyChanged
    {
        private Command _buttonCommand;

        public Command ButtonCommand => _buttonCommand ?? (_buttonCommand = new Command(ButtonMethod));

        private void ButtonMethod()
        {

        }

        public MainViewModel()
        {

        }


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);

        }
        #endregion
    }
}
