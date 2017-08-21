using StudentAppFirebase.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace StudentAppFirebase
{
    public partial class App : Application
    {

        public static bool IsUserLoggedIn { get; set; }
        
        public App()
        {
            InitializeComponent();

            // MainPage = new StudentAppFirebase.MainPage  //MainPage = new StudentApp.Views.ManuPage();
            var mainPage = new TabbedPage();
            var ManuPage = new NavigationPage(new ManuPage()) { Title = "Student" };
            var ManuPage2 = new NavigationPage(new StudentDeailPage()) { Title = "Student2" };


            Device.OnPlatform(iOS: () =>
            {
                ManuPage.Icon = "tab_feed.png";
                ManuPage2.Icon = "tab_feed.png";

            });
            mainPage.Children.Add(ManuPage);
            mainPage.Children.Add(ManuPage);

            //   MainPage = new HomePage();
            MainPage = ManuPage;
        

          
        }

        protected override void OnStart()
        {
            // Handle when your app starts

              if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new LoginPage());

            }
            else
            {
                // MainPage = new NavigationPage(new LoginNavigation.MainPage());
                MainPage = new StudentAppFirebase.MainPage();
            }

          
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
