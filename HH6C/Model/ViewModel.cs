using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.Model
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    /// 
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string someText;
        public string SomeText
        {
            get { return someText; }
            set
            {
                someText = value;
                OnPropertyChanged("SomeText");
                OnPropertyChanged(nameof(FancyMessage));
            }
        }

        public string FancyMessage => $"This one is cool: {SomeText}";
    }
}
