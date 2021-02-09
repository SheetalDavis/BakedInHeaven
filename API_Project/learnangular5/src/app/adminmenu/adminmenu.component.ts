import { Component, OnInit } from '@angular/core';
import { ItemsService } from '../items.service';
import { Item } from '../types';

@Component({
  selector: 'app-adminmenu',
  templateUrl: './adminmenu.component.html',
  styleUrls: ['./adminmenu.component.css']
})
export class AdminmenuComponent implements OnInit {
  isLoading: boolean=true;

  items: Item[]=[];

  constructor(
    private itemsService: ItemsService,
  ) { }

  ngOnInit(): void {
    this.itemsService.getItems()
    .subscribe(items => {this.items=items; this.isLoading=false;});
  
  }
  
  OnDeleteClicked(id: number): void{
    this.itemsService.deleteItem(id)
    .subscribe(()=>{
        this.items=this.items.filter(
          item=>item.id !== id
        );
    });

}
}
