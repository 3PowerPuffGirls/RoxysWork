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
        public AddAnExpense()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private async void ExpenseDoneBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}