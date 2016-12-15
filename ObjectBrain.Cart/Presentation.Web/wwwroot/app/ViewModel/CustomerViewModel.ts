import {Component} from '@angular/core';
import {Customer} from '../Model/Customer'
import {CartClientService} from '../Service/CartClientService'
@Component({
    selector: 'customer-view',
    templateUrl: 'app/view/CustomerView.html',
    providers:[CartClientService]
})
export class CustomerViewModel {

    constructor(private customerService:CartClientService<Customer>) {

    //    this.customerService.GetAll().then(cts=>this.Customers=cts);
    }

    public Customers:Array<Customer>;
}