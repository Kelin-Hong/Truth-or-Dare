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
    public partial class ZhenXinHuaList : PhoneApplicationPage
    {
        DataBase db;
        ZhenViewModel vm = new ZhenViewModel();
        public ZhenXinHuaList()
        {
            InitializeComponent();
            this.LayoutRoot.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri("Bg/12.jpg", UriKind.Relative)) };
            db = new DataBase(DataBase.contectString);
            var table = from Table1 item in db.table1 select item;
            vm.Table1List = new System.Collections.ObjectModel.ObservableCollection<Table1>(table);
            this.DataContext = vm;
        }
        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            //Call base method
            base.OnNavigatedFrom(e);

            //Save changes to the database
            db.SubmitChanges();
        }
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("确定删除吗？", "提示", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                Image image = (Image)sender;
                Table1 item = (Table1)image.DataContext;
                db.table1.DeleteOnSubmit(item);
                db.SubmitChanges();
                var table = from Table1 i in db.table1 select i;
                vm.Table1List = new System.Collections.ObjectModel.ObservableCollection<Table1>(table);
                this.DataContext = vm;
            }

        }

       
        //private void checkBox_Click(object sender, RoutedEventArgs e)
        //{
        //    //CheckBox checkBox = (CheckBox)sender;
        //    //Table1 item = (Table1)checkBox.DataContext;
        //    //item.IsUse = !item.IsUse;
        //    //Table1 table = new Table1() { Title = item.Title, Content = item.Content, IsUse = !item.IsUse };
        //    //db.table1.DeleteOnSubmit(item);
        //    //db.table1.InsertOnSubmit(table);
            
        //}
    }
}