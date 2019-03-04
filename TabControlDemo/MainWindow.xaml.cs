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
            Button button1 = new Button() { Name="Button1",Tag="NotLoaded" };
            Button button2 = new Button() { Name="Button2",Tag="NotLoaded" };
            button1.Loaded += Button1_Loaded;
            button2.Loaded += Button2_Loaded;
            button1.Click += Button_Click;
            button2.Click += Button_Click;
            tabItems.Add(new TabItem() { Header="TabItem1",Content= button1});
            tabItems.Add(new TabItem() { Header = "TabItem2", Content = button2 });
            tabControl.ItemsSource = tabItems;
        }

        private void Button2_Loaded(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Tag.ToString() == "NotLoaded")
            {
                btn.Content = "button2";
                btn.Tag = "Loaded";
                Console.WriteLine("Button2 is Loaded.");
           }
            
        }

        private void Button1_Loaded(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Tag.ToString() == "NotLoaded")
            {
                btn.Content = "button1";
                btn.Tag = "Loaded";
                Console.WriteLine("Button1 is Loaded.");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = (sender as Button).Content.ToString().ToUpper();
        }
    }
}
