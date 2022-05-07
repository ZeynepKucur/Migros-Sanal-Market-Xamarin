using Migros_Sanal_Market.Services;
using Migros_Sanal_Market.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.IO;
using Xamarin.Essentials;

namespace Migros_Sanal_Market
{
    public partial class App : Application
    {
        public static string FilePath;
         public App()
         {
             InitializeComponent();

             DependencyService.Register<AddKategoriService>();

             MainPage = new AppShell();
         }
       /* public App(string filePath)
        {
            InitializeComponent();

            DependencyService.Register<AddKategoriService>();
            
            MainPage = new AppShell();

            FilePath = filePath;
        }
       */
        protected override void OnStart()
         {
         }

         protected override void OnSleep()
         {
         }

         protected override void OnResume()
         {
         }
       
            
     }
}


