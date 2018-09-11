using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using CreativeBeginner.Models;
using SQLite.Net.Interop;
using System.IO;

[assembly: Dependency(typeof(CreativeBeginner.Droid.Config))]

namespace CreativeBeginner.Droid
{
    class Config : IConfig
    {

        private string directorioDB;
        private ISQLitePlatform plataforma;

        public string DirectorioDB
        {
            get
            {
                if (string.IsNullOrEmpty(directorioDB))
                {
                    directorioDB = System.Environment.GetFolderPath(
                        System.Environment.SpecialFolder.Personal);
                }
                return directorioDB;
            }
        }
        public ISQLitePlatform Plataforma
        {
            get
            {
                if (plataforma == null)
                {
                    plataforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                }
                return plataforma;
            }
        }
    }
}