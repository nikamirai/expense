﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ExpenseEntities : DbContext
    {
        private static ExpenseEntities _context;
        public ExpenseEntities()
            : base("name=ExpenseEntities")
        {
        }
    
        public static ExpenseEntities GetContext()
        {
            if(_context == null)
                _context = new ExpenseEntities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ExpenseUser> ExpenseUser { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeOfExpense> TypeOfExpense { get; set; }
        public virtual DbSet<UserSystem> UserSystem { get; set; }
    }
}
