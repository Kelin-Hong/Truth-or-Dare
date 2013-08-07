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
using System.Data.Linq.Mapping;
using System.ComponentModel;
namespace mangoBgAnimation
{
    [Table]
    public class Table2:INotifyPropertyChanging,INotifyPropertyChanged
    {
        private int id;
        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
        public int Id
        {
            get { return id; }
            set 
            {
                if (id != value)
                {
                    OnPropertyChanging("Id");
                    id = value;
                    OnPropertyChanged("Id");
                }
            
            }
        }
        private bool isUse;
        [Column]
        public bool IsUse
        {
            get { return isUse; }
            set
            {
                if (isUse != value)
                {
                    OnPropertyChanging("IsUse");
                    isUse = value;
                    OnPropertyChanged("IsUse");
                }
            }
        }
        private string title;
        [Column]
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    OnPropertyChanging("Title");
                    title = value;
                    OnPropertyChanged("Title");
                }
            }
        }
        private string content;
        [Column]
        public string Content
        {
            get { return content; }
            set
            {
                if (content != value)
                {
                    OnPropertyChanging("Content");
                    content = value;
                    OnPropertyChanged("Content");
                }
            }
        }
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanging(string str)
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this,new PropertyChangingEventArgs(str));
            }
        }
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
