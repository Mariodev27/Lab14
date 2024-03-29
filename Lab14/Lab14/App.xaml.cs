﻿using Lab14.Interfaces;
using Lab14.Views;
using Lab14.DataContext;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Lab14
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            GetContext().Database.EnsureCreated();
            MainPage = new PeopleView();
        }


        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }
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
