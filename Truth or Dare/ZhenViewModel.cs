using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace mangoBgAnimation
{
    public class ZhenViewModel:INotifyPropertyChanged
    {
        private ObservableCollection<Table1> table1List;

        public ObservableCollection<Table1> Table1List
        {
            get { return table1List; }
            set
            {
                if (table1List != value)
                {
                    table1List = value;
                    NotifyPropertyChanged("Table1List");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
