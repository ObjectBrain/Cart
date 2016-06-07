import { Injectable }    from '@angular/core';
import {EntityBase} from '../Model/EntityBase';

@Injectable()
export interface ICartClientService<T extends EntityBase> {

    GetAll(): Promise<Array<T>>;
    Get(id: number): Promise<T>;
    Add(entity: T);
    Update(entity: T);
    Remove(entity: T);
}