using System;
using System.Collections.ObjectModel;
using Domain.Entity;
using GalaSoft.MvvmLight;
using Presentation.Wpf.Service;

namespace Presentation.Wpf.ViewModel
{
    public class CustomerViewModel : ViewModelBase, ICustomerViewModel
    {
        private readonly ICartClientService<Customer> _customerClientService;
        private ObservableCollection<Customer> _customers;

        public CustomerViewModel(ICartClientService<Customer> customerClientService)
        {
            _customerClientService = customerClientService;

            _customerClientService.GetAll()
                .Subscribe(x => { Customers = new ObservableCollection<Customer>(x); },
                    (exception => { throw exception; }));
        }

        public ObservableCollection<Customer> Customers
        {
            get { return _customers; }
            set { Set(() => Customers, ref _customers, value); }
        }

        public Customer SelectedCustomer { get; set; }
    }
}