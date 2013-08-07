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
using System.Data.Linq;
namespace mangoBgAnimation
{
    public class DataBase:DataContext
    {
        public static string contectString = "DataSource=isostore:/data.sdf";
        public DataBase(string str):base(str)
        {

        }
        public Table<Table2> table2;
        public Table<Table1> table1;
    }
}
