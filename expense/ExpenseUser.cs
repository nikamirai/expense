//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace expense
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExpenseUser
    {
        public int IDExpenseUser { get; set; }
        public System.DateTime DatePurchase { get; set; }
        public int IDTypeOfExpense { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
    
        public virtual TypeOfExpense TypeOfExpense { get; set; }
    }
}
