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
using Microsoft.Phone.Controls;
using System.Windows.Media.Imaging;

namespace mangoBgAnimation
{
    public partial class ZhenXinHua : PhoneApplicationPage
    {
        bool buttonState=true;
        DataBase db;
        int count;
        Random r = new Random();
        List<Table1> list;
        public ZhenXinHua()
        {
            InitializeComponent();
            this.LayoutRoot.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri("Bg/12.jpg", UriKind.Relative)) };
            db = new DataBase(DataBase.contectString);
            list = db.table1.Where(c => c.IsUse == true).ToList<Table1>();
            count = list.Count;
            int r1 = r.Next(0, count );
            int r2 = r.Next(0, count );
            int r3 = r.Next(0, count );
            content1.Text = list.ElementAt(r1).Content;
            content2.Text = list.ElementAt(r2).Content;
            content3.Text = list.ElementAt(r3).Content;
            
        }
        private void begin_Click(object sender, RoutedEventArgs e)
        {
            buttonState = !buttonState;

            if (buttonState)
            {
                begin.Content = "开始";
                Storyboard1.Stop();
                int r1 = r.Next(0, count );
                int r2 = r.Next(0, count );
                int r3 = r.Next(0, count );
                content1.Text = list.ElementAt(r1).Content;
                content2.Text = list.ElementAt(r2).Content;
                content3.Text = list.ElementAt(r3).Content;
                content2.Visibility = Visibility.Collapsed;
                content3.Visibility = Visibility.Collapsed;
            }
            else
            {
                begin.Content = "停止";
                Storyboard1.RepeatBehavior = RepeatBehavior.Forever;
                content3.Visibility = Visibility.Visible;
                content2.Visibility = Visibility.Visible;
                Storyboard1.Begin();
              

            }
        }


    }
}
