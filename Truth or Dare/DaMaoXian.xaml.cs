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
    public partial class DaMaoXian : PhoneApplicationPage
    {
        DataBase db;
        bool buttonState = true;
        int count;
        Random r = new Random();
        List<Table2> list;
        public DaMaoXian()
        {
            InitializeComponent();
            this.LayoutRoot.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri("Bg/12.jpg", UriKind.Relative)) };
            db = new DataBase(DataBase.contectString);
            list= db.table2.Where(c=>c.IsUse==true).ToList<Table2>();
            count=list.Count;
            int r1 = r.Next(0, count);
            int r2 = r.Next(0, count);
            int r3 = r.Next(0, count);
            content1.Text=list.ElementAt(r1).Content;
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
                Storyboard1.Completed += new EventHandler(Storyboard1_Completed);
               
            }
           
        }

        void Storyboard1_Completed(object sender, EventArgs e)
        {
            
                
                //Storyboard1.Begin();
        }

        
        //private void pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
          
        //    int bg = r.Next(1, 7);
        //    //var url=string.Format("Bg/{0}.jpg",bg);
        //    //bgControl.ImageUrl = url;
        //    //this.LayoutRoot.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri(url, UriKind.Relative)) };
        //    if (sb_shuffle != null)
        //    {
        //        sb_shuffle.Begin();
        //        pivot.IsHitTestVisible = false;
        //        sb_shuffle.Completed += (e1, e2) =>
        //        {
        //            bgControl.ImageUrl = string.Format("Bg/{0}.jpg", bg);
        //            sb_next.Begin();
        //            sb_next.Completed += (e3, e4) =>
        //            {
        //                pivot.IsHitTestVisible = true;
        //            };

        //        };

        //    }
        //    // var table = from MyTable item in db.Mytable
        //    //            select item;
        //    var table = db.table2;
        //    // table.First();
        //    Table2 data = db.table2.First(c => c.Id == bg);
        //    //title1.Text = data.Title;
        //    //title2.Text = data.Title;
        //    //title3.Text = data.Title;
        //    //content1.Text = data.Content;
        //    //content2.Text = data.Content;
        //    //content3.Text = data.Content;
        //}

        //private void begin_Click(object sender, RoutedEventArgs e)
        //{
        //    buttonState=!buttonState;
        //    if (!buttonState) begin.Content = "停止"; else begin.Content = "开始";
        //   // while (!buttonState)
        //    {
                
                
               
        //        //var url=string.Format("Bg/{0}.jpg",bg);
        //        //bgControl.ImageUrl = url;
        //        //this.LayoutRoot.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri(url, UriKind.Relative)) };
        //        if (sb_shuffle != null&&!buttonState)
        //        {
        //            int bg = r.Next(1, 7);
        //            sb_shuffle.Begin();
        //            pivot.IsHitTestVisible = false;
        //            sb_shuffle.Completed += (e1, e2) =>
        //            {
        //                bgControl.ImageUrl = string.Format("Bg/{0}.jpg", bg);
        //                sb_next.Begin();
        //                sb_next.Completed += (e3, e4) =>
        //                {
        //                    pivot.IsHitTestVisible = true;
        //                    if (!buttonState)
        //                    {
        //                        bg = r.Next(1, 7);
        //                        sb_shuffle.Begin();
        //                    }
        //                };

        //            };
        //        }
        //    }
        //}
    }
}