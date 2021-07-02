using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BudgetMobileApp.Model
{
    public class Expense
    {
        
        public string Name { get; set; }
        public Double Amount { get; set; }
        public DateTime Date { get; set; }
        public Category Category { get; set; }
    }


    public enum Category
    {
        Essentials,
        Entertainment,
        Retail,
        Bills
    }

    public class CategoryItems
    {
        public Category Name { get; set; }
        public string ImageFile { get; set; }

    }

    
}
