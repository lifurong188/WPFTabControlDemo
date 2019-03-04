using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TabControlDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<TabItem> tabItems = new ObservableCollection<TabItem>();
        public MainWindow()
        {
            InitializeComponent();
            UserControl1 userControl1 = new UserControl1() { Name="UserControl1"};
            UserControl2 userControl2 = new UserControl2() { Name= "UserControl2"};
            tabItems.Add(new TabItem() { Header="TabItem1",Content= userControl1 });
            tabItems.Add(new TabItem() { Header = "TabItem2", Content = userControl2 });
            tabControl.ItemsSource = tabItems;
        }
    }
}
