import { Injectable }    from '@angular/core';
import { Headers, Http } from '@angular/http';
import 'rxjs/add/operator/toPromise';
import {EntityBase} from '../Model/EntityBase';
import {ICartClientService} from './ICartClientService'

@Injectable()
export class CartClientService<T extends EntityBase> implements ICartClientService<T> {

    constructor(private http: Http) {
    }

    GetAll(): Promise<Array<T>> {
        return this.http.get("http://localhost:18511/api/customer")
            .toPromise()
            .then(response => response.json().data)
            .catch(this.handleError);
    }

    Get(id: number): Promise<T> {
        return this.http.get("")
            .toPromise()
            .then(response => response.json().data)
    }

    Add(entity: T) {
        let headers = new Headers({
            'Content-Type': 'application/json'
        });

        return this.http
            .post("Url", JSON.stringify(entity), { headers: headers })
            .toPromise()
            .then(res => res.json().data)
            .catch(this.handleError);
    }

    Update(entity: T) {
        let headers = new Headers();
        headers.append('Content-Type', 'application/json');

        let url = '${this."Url"}/${entity.Id}';

        return this.http
            .put(url, JSON.stringify(entity), { headers: headers })
            .toPromise()
            .then(() => entity)
            .catch(this.handleError);
    }

    Remove(entity: T) {
        let headers = new Headers();
        headers.append('Content-Type', 'application/json');

        let url = `${"Url"}/${entity.Id}`;

        return this.http
            .delete(url, headers)
            .toPromise()
            .catch(this.handleError);
    }

    private handleError(error: any) {
        console.error('An error occurred', error);
        return Promise.reject(error.message || error);
    }
}