﻿using Practice.Database;
using Practice.ViewModels.PageViewmodels;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Practice.Views.Pages;


public partial class MainPage : Page
{


    public MainPage()
    {
        InitializeComponent();
        UsersCollection.LoadDatabase();

        DataContext = new MainPageViewModel();
    }

   
   
}
