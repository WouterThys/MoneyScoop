﻿using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;

namespace MoneyScoop.ViewModel
{
    [POCOViewModel]
    public class CustomerEditViewModel : BaseEditViewModel<Customer>
    {
        public static CustomerEditViewModel Create(Customer original)
        {
            return ViewModelSource.Create(() => new CustomerEditViewModel(original));
        }

        protected CustomerEditViewModel(Customer original) : base(ModuleTypes.CustomerEditModule, original)
        {
            Load();
        }
    }
}
