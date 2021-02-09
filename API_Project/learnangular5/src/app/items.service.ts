import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import {Item} from './types';

@Injectable({
  providedIn: 'root'
})
export class ItemsService {

  constructor(
    private http: HttpClient,
  ) { }

  getItems(): Observable<Item[]> {
     return this.http.get<Item[]>('/api/items');
  }

  deleteItem(id: number):Observable<any>{
    return this.http.delete(`/api/items/${id}`);
  }
  
}
