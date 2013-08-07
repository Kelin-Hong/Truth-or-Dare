using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Media.Imaging;

namespace mangoBgAnimation
{
    public partial class BgControl : UserControl
    {
        public DependencyProperty ImageUrlProperty = DependencyProperty.Register("ImageUrl", typeof(string), typeof(BgControl), 
            new PropertyMetadata(new PropertyChangedCallback((e1,e2) =>
            {
                var control = e1 as BgControl;
                if (control != null && e2.NewValue!=null)
                {
                    //control.LayoutRoot.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri(e2.NewValue.ToString(), UriKind.Relative)) };
                }
            })));
        public DependencyProperty TextNumProperty = DependencyProperty.Register("TextNum", typeof(string), typeof(BgControl),
            new PropertyMetadata(new PropertyChangedCallback((e1, e2) =>
                { 
                    var control= e1 as BgControl;
                    if(control!=null&& e2.NewValue!=null)
                    {
                       
                    }
                })));
        public DependencyProperty TextNameProperty = DependencyProperty.Register("TextName", typeof(string), typeof(BgControl),
           new PropertyMetadata(new PropertyChangedCallback((e1, e2) =>
           {
               var control = e1 as BgControl;
               if (control != null && e2.NewValue != null)
               {

               }
           })));
        //public DependencyProperty ImageUrlProperty = DependencyProperty.Register("Fill", typeof(string), typeof(BgControl),
        //   new PropertyMetadata(new PropertyChangedCallback((e1, e2) =>
        //   {
        //       var control = e1 as BgControl;
        //       if (control != null && e2.NewValue != null)
        //       {
        //           control.LayoutRoot.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri(e2.NewValue.ToString(), UriKind.Relative)) };
        //       }
        //   })));
        public string ImageUrl
        {
            get
            {
                return (string)base.GetValue(ImageUrlProperty);
            }
            set
            {
                base.SetValue(ImageUrlProperty, value);
            }
       }
        public string TextNum
        {
            get
            {
                return(string) GetValue(TextNumProperty);
            }
            set
            {
                SetValue(TextNumProperty, value);
            }
        }
        public string TextName
        {
            get
            {
                return (string)GetValue(TextNameProperty);
            }
            set
            {
                SetValue(TextNameProperty, value);
            }
        }
        //public string Fill
        //{
        //    get
        //    {
        //        return (string)base.GetValue();
        //    }
        //    set
        //    {
        //        base.SetValue(ImageUrlProperty, value);
        //    }
        //}

        public BgControl()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(BgControl_Loaded);
        }

        void BgControl_Loaded(object sender, RoutedEventArgs e)
        {
          this.LayoutRoot.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri(ImageUrl, UriKind.Relative)) };
          // this.image.Source = new BitmapImage(new Uri(ImageUrl, UriKind.Relative));
            this.textNum.Text = "              "+TextNum;
            this.textName.Text ="  "+ TextName;
        }
    }
}
