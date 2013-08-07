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
    public partial class BackGroundControl : UserControl
    {
        public DependencyProperty ImageUrlProperty = DependencyProperty.Register("ImageUrl", typeof(string), typeof(BackGroundControl),
            new PropertyMetadata(new PropertyChangedCallback((e1, e2) =>
            {
                var control = e1 as BackGroundControl;
                if (control != null && e2.NewValue != null)
                {
                    control.LayoutRoot.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri(e2.NewValue.ToString(), UriKind.Relative)) };
                }
            })));
        public string ImageUrl
        {
            get
            {
                return (string)GetValue(ImageUrlProperty);
            }
            set
            {
                SetValue(ImageUrlProperty, value);
            }
        }
        public BackGroundControl()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(BackGroundControl_Loaded);
        }

        void BackGroundControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.LayoutRoot.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri(ImageUrl, UriKind.Relative)) };
        }
    }
}
