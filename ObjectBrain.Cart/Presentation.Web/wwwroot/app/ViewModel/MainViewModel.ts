import { Component } from '@angular/core';
import {TopMenuViewModel} from './TopMenuViewModel';
import {LeftMenuViewModel} from './LeftMenuViewModel';
import {CustomerViewModel} from './CustomerViewModel'
import {DashboardViewModel} from './DashboardViewModel'
import { RouteConfig, ROUTER_DIRECTIVES, ROUTER_PROVIDERS } from '@angular/router-deprecated';

@Component({
    selector: 'main-view',
    templateUrl: 'app/view/MainView.html',
    directives:[TopMenuViewModel,LeftMenuViewModel,ROUTER_DIRECTIVES],
    providers:[ROUTER_PROVIDERS]
})
@RouteConfig([
  {
    path: '/dashboard',
    name: 'Dashboard',
    component: DashboardViewModel,
    useAsDefault: true
  },
  {
    path: '/customers',
    name: 'Customers',
    component: CustomerViewModel
  }
])
export class MainViewModel { 
}


/*
Copyright 2016 Google Inc. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at http://angular.io/license
*/