﻿using Database2022.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab14.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeopleView : ContentPage
    {
        public PeopleView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelPeople();
        }
    }
}