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
    public partial class DaAdd : PhoneApplicationPage
    {
        public DaAdd()
        {
            InitializeComponent();
            this.LayoutRoot.Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri("Bg/12.jpg", UriKind.Relative)) };
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase(DataBase.contectString);
            Table2 table = new Table2() {Title="大冒险",Content=this.content.Text,IsUse=true};
            db.table2.InsertOnSubmit(table);
            db.SubmitChanges();
            NavigationService.Navigate(new Uri("/DaMaoXianList.xaml", UriKind.Relative));
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Focus();
            this.content.Text = "";
        }
    }
}