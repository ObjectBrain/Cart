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
var http_1 = require('@angular/http');
require('rxjs/add/operator/toPromise');
var CartClientService = (function () {
    function CartClientService(http) {
        this.http = http;
    }
    CartClientService.prototype.GetAll = function () {
        return this.http.get("http://localhost:18511/api/customer")
            .toPromise()
            .then(function (response) { return response.json().data; })
            .catch(this.handleError);
    };
    CartClientService.prototype.Get = function (id) {
        return this.http.get("")
            .toPromise()
            .then(function (response) { return response.json().data; });
    };
    CartClientService.prototype.Add = function (entity) {
        var headers = new http_1.Headers({
            'Content-Type': 'application/json'
        });
        return this.http
            .post("Url", JSON.stringify(entity), { headers: headers })
            .toPromise()
            .then(function (res) { return res.json().data; })
            .catch(this.handleError);
    };
    CartClientService.prototype.Update = function (entity) {
        var headers = new http_1.Headers();
        headers.append('Content-Type', 'application/json');
        var url = '${this."Url"}/${entity.Id}';
        return this.http
            .put(url, JSON.stringify(entity), { headers: headers })
            .toPromise()
            .then(function () { return entity; })
            .catch(this.handleError);
    };
    CartClientService.prototype.Remove = function (entity) {
        var headers = new http_1.Headers();
        headers.append('Content-Type', 'application/json');
        var url = "Url" + "/" + entity.Id;
        return this.http
            .delete(url, headers)
            .toPromise()
            .catch(this.handleError);
    };
    CartClientService.prototype.handleError = function (error) {
        console.error('An error occurred', error);
        return Promise.reject(error.message || error);
    };
    CartClientService = __decorate([
        core_1.Injectable(), 
        __metadata('design:paramtypes', [http_1.Http])
    ], CartClientService);
    return CartClientService;
}());
exports.CartClientService = CartClientService;
//# sourceMappingURL=CartClientService.js.map