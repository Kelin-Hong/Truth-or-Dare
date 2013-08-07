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
    public partial class DaMaoXianList : PhoneApplicationPage
    {
        DataBase db;
        DaViewModel vm = new DaViewModel();
        public DaMaoXianList()
        {
            InitializeComponent();
            this.LayoutRoot.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri("Bg/12.jpg", UriKind.Relative)) };
            db = new DataBase(DataBase.contectString);
            var table = from Table2 item in db.table2 select item;
            vm.Table2List = new System.Collections.ObjectModel.ObservableCollection<Table2>(table);
            this.DataContext = vm;
        }

        private void delete_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result= MessageBox.Show("确定删除吗？", "提示", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                Image image = (Image)sender;
                Table2 item = (Table2)image.DataContext;
                db.table2.DeleteOnSubmit(item);
                db.SubmitChanges();
                var table = from Table2 i in db.table2 select i;
                vm.Table2List = new System.Collections.ObjectModel.ObservableCollection<Table2>(table);
                this.DataContext = vm;
                
            }
        }
        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            //Call base method
            base.OnNavigatedFrom(e);

            //Save changes to the database
           
            db.SubmitChanges();
        }
       

        //private void isUse_Click(object sender, RoutedEventArgs e)
        //{
        //    //CheckBox checkBox = (CheckBox)sender;
        //    //Table2 item = (Table2)checkBox.DataContext;
        //    //Table2 table = new Table2() {Id=item.Id, Title = item.Title, Content = item.Content, IsUse = !item.IsUse };
        //    //vm.Table2List.Remove(item);
        //    //vm.Table2List.Add(table);

        //   //Table2 item = (Table2)checkBox.DataContext;
            
        //    //item.IsUse = !item.IsUse;
        //    //Table2 table = new Table2() { Title = item.Title, Content = item.Content, IsUse = !item.IsUse };
        //    //db.table2.DeleteOnSubmit(item);
        //    //db.table2.InsertOnSubmit(table);
        //    // db.SubmitChanges();
        //}

       

     
        
    }
}