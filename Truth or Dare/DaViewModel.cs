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
    public class DaViewModel:INotifyPropertyChanged,INotifyPropertyChanging
    {
        private ObservableCollection<Table2> table2List;

        public ObservableCollection<Table2> Table2List
        {
            get { return table2List; }
            set
            {
                if (table2List != value)
                {
                    NotifyPropertyChanging("Table2List");
                    table2List = value;
                    NotifyPropertyChanged("Table2List");
                }
            }
        }
        //private bool isUse;
        //public bool IsUse
        //{
        //    get { return isUse; }
        //    set
        //    {
        //        if (isUse != value)
        //        {
        //            NotifyPropertyChanging("IsUse");
        //            isUse = value;
        //            NotifyPropertyChanged("IsUse");
        //        }
        //    }
        //}
        //private string title;

        //public string Title
        //{
        //    get { return title; }
        //    set
        //    {
        //        if (title != value)
        //        {
        //            NotifyPropertyChanging("Title");
        //            title = value;
        //            NotifyPropertyChanged("Title");
        //        }
        //    }
        //}
        //private string content;
        //public string Content
        //{
        //    get { return content; }
        //    set
        //    {
        //        if (content != value)
        //        {
        //            NotifyPropertyChanging("Content");
        //            content = value;
        //            NotifyPropertyChanged("Content");
        //        }
        //    }
        //}
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void NotifyPropertyChanging(string propertyName)
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
            }
        }
        public event PropertyChangingEventHandler PropertyChanging;
    }
}
