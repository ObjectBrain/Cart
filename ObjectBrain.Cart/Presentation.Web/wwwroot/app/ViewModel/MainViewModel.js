"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
var TopMenuViewModel_1 = require('./TopMenuViewModel');
var LeftMenuViewModel_1 = require('./LeftMenuViewModel');
var CustomerViewModel_1 = require('./CustomerViewModel');
var DashboardViewModel_1 = require('./DashboardViewModel');
var router_deprecated_1 = require('@angular/router-deprecated');
var MainViewModel = (function () {
    function MainViewModel() {
    }
    MainViewModel = __decorate([
        core_1.Component({
            selector: 'main-view',
            templateUrl: 'app/view/MainView.html',
            directives: [TopMenuViewModel_1.TopMenuViewModel, LeftMenuViewModel_1.LeftMenuViewModel, router_deprecated_1.ROUTER_DIRECTIVES],
            providers: [router_deprecated_1.ROUTER_PROVIDERS]
        }),
        router_deprecated_1.RouteConfig([
            {
                path: '/dashboard',
                name: 'Dashboard',
                component: DashboardViewModel_1.DashboardViewModel,
                useAsDefault: true
            },
            {
                path: '/customers',
                name: 'Customers',
                component: CustomerViewModel_1.CustomerViewModel
            }
        ]), 
        __metadata('design:paramtypes', [])
    ], MainViewModel);
    return MainViewModel;
}());
exports.MainViewModel = MainViewModel;
/*
Copyright 2016 Google Inc. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at http://angular.io/license
*/ 
//# sourceMappingURL=MainViewModel.js.map