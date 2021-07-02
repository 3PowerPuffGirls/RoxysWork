using BudgetMobileApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BudgetMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddAnExpense : ContentPage
    {
        public Expense expense { get; set; }
        CategoryItems Category = new CategoryItems();
        public AddAnExpense()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            //get the binding context 
            expense = (Expense)BindingContext;
            // this is bound to the user
        }

        private async void ExpenseDoneBtn_Clicked(object sender, EventArgs e)
        {
            var expense = (Expense)BindingContext;
            BudgetManager.AddExpense(expense);
            await Navigation.PushModalAsync(new MainPage());
        }

        private async void ExpenseCancelBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void CategoryPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var category = CategoryPicker.Items[CategoryPicker.SelectedIndex];
            BudgetManager.AddExpense(category);
        }
    }
}