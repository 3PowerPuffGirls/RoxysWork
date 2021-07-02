using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetMobileApp.Model
{
    public static class BudgetManager
    {

        public static double UserBudget { get; set; }
        public static List<Expense> Expenses = new List<Expense>();
        public static double Balance
        {
            get
            {
                //calculate balace based on expenses
                double totalExp = 0;
                Expenses.ForEach(exp => totalExp += exp.Amount);
                return UserBudget - totalExp;
            }
        }

        public static void AddExpense(Expense expense)
        {
            DateTime Date = expense.Date.Date;
            Expenses.Add(expense);
        }
    }
}
