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
    /// ↩ ↪ ⟳ ⌂
    public partial class MainWindow : Window
    {
        ChromiumWebBrowser browser1;
        ChromiumWebBrowser browser2;
        ChromiumWebBrowser browser3;

        public MainWindow()
        {
            InitializeComponent();
            InitializeBrowser();
        }

        public void InitializeBrowser()
        {
            browser1 = new ChromiumWebBrowser();
            browser1.LoadUrl(AdressBar.Text);
            tabItem1.Content = browser1;

            browser3 = new ChromiumWebBrowser();
            browser3.LoadUrl("https://google.com");
            tabItem3.Content = browser3;

            browser2 = new ChromiumWebBrowser();
            browser2.LoadUrl("https://youtube.com"); 
            tabItem2.Content = browser2;

           
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            browser1.LoadUrl(AdressBar.Text);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (browser1.CanGoBack)
            {
                browser1.Back();
            }

        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            if (browser1.CanGoForward)
            {
                browser1.Forward();
            }
        }

        private void ReloadButton_Click(object sender, RoutedEventArgs e)
        {
            browser1.Reload();
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            Info infowindow = new Info();
            infowindow.Show();
        }
    }
}
