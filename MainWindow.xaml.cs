using System;
using System.Collections.Generic;
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
using CefSharp;
using CefSharp.Wpf;

namespace WpfAppChromiumBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ChromiumWebBrowser browser;
        ChromiumWebBrowser browser2;

        public MainWindow()
        {
            InitializeComponent();
            InitializeBrowser();
        }

        public void InitializeBrowser()
        {
            browser = new ChromiumWebBrowser();
            browser.LoadUrl("https://google.com");
            tabItem1.Content = browser;

            browser2 = new ChromiumWebBrowser();
            browser2.LoadUrl("https://youtube.com"); 
            tabItem2.Content = browser2;

        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            browser.LoadUrl(AdressBar.Text);
        }
    }
}
