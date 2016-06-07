using System.Collections.ObjectModel;
using Domain.Entity;

namespace Presentation.Wpf.ViewModel
{
    public interface ICustomerViewModel
    {
        ObservableCollection<Customer> Customers { get; set; }
        Customer SelectedCustomer { get; set; }
    }
}