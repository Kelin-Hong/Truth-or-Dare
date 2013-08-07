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
using System.Windows.Navigation;

namespace mangoBgAnimation
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        DataBase db;
        public MainPage()
        {
            InitializeComponent();
            this.LayoutRoot.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri("/Background/1.jpg", UriKind.Relative)) };
            db = new DataBase(DataBase.contectString);
            daList.TextNum = db.table2.Count().ToString();
            zhenList.TextNum = db.table1.Count().ToString();
            daMaoXian.TextNum = db.table1.Count(c => c.IsUse == true).ToString();
            zhenXinHua.TextNum = db.table2.Count(c => c.IsUse == true).ToString();
            
        }
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            //this.Storyboard2.Begin();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.Storyboard2.Begin();
            daList.TextNum = db.table2.Count().ToString();
            zhenList.TextNum = db.table1.Count().ToString();
            daMaoXian.TextNum = db.table1.Count(c => c.IsUse == true).ToString();
            zhenXinHua.TextNum = db.table2.Count(c => c.IsUse == true).ToString();
        }
        
        //Random r = new Random();
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
            
        //    int bg = r.Next(1, 7);
        //    //var url=string.Format("Bg/{0}.jpg",bg);
        //    //bgControl.ImageUrl = url;
        //    //this.LayoutRoot.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri(url, UriKind.Relative)) };
        //    if (sb_shuffle != null)
        //    {
        //        sb_shuffle.Begin();
        //        sb_shuffle.Completed += (e1, e2) =>
        //        {
        //           // bgControl.ImageUrl = string.Format("Bg/{0}.jpg", bg);
        //            sb_next.Begin();
        //        };

        //    }
            
        //}

       

        private void zhenXinHua_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DaMaoXian.xaml", UriKind.Relative));
        }

        private void daMaoXian_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ZhenXinHua.xaml", UriKind.Relative));
           // NavigationService.Navigate(new Uri("/PiovtPage.xaml", UriKind.Relative));
        }

        private void daList_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DaMaoXianList.xaml", UriKind.Relative));
        }

        private void zhenList_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ZhenXinHuaList.xaml", UriKind.Relative));
        }

        private void daAdd_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DaAdd.xaml", UriKind.Relative));
        }

        private void zhenAdd_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ZhenAdd.xaml", UriKind.Relative));
        }
    }
}