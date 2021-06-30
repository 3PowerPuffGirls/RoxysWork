﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BudgetMobileApp.Model;


namespace BudgetMobileApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BudgetBtn.IsVisible = false;
        }

        private async void ExpenseBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddAnExpense());
        }


        private void BudgetBtn_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new Budget());
        }

        private void BudgetEnterBtn_Clicked(object sender, EventArgs e)
        {
            BudgetBtn.IsVisible = true;
            MonthlyGoalStack.IsVisible = false;
        }
    }
}