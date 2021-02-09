import { Component, OnInit } from '@angular/core';
import {ItemsService} from '../items.service';
import { Item } from '../types';

@Component({
  selector: 'app-items',
  templateUrl: './items.component.html',
  styleUrls: ['./items.component.css']
})
export class ItemsComponent implements OnInit {
  
  isLoading: boolean=true;

  items: Item[]=[];

  constructor(
    private itemsService: ItemsService,
  ) { }

  ngOnInit(): void {
    this.itemsService.getItems()
    .subscribe(items => {this.items=items; this.isLoading=false;});

    


  }

}