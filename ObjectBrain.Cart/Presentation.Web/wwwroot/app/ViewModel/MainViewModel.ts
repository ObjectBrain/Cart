import { Component } from '@angular/core';
import {CustomerViewModel} from './CustomerViewModel';

@Component({
    selector: 'main-view',
    templateUrl: 'app/view/MainView.html',
    directives:[CustomerViewModel]
})

export class MainViewModel { 
}


/*
Copyright 2016 Google Inc. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at http://angular.io/license
*/