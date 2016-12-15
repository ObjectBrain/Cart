import {Component} from '@angular/core'
import {CustomerViewModel} from './CustomerViewModel'
import {DashboardViewModel} from './DashboardViewModel'
import {ROUTER_DIRECTIVES} from '@angular/router-deprecated';

@Component({
    selector:'leftmenu-view',
    templateUrl:'app/view/LeftMenuView.html',
    directives:[ROUTER_DIRECTIVES]
})
export class LeftMenuViewModel {
    constructor() {
        
    }
}