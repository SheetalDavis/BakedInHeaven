import { Component, OnInit, Input, Output, EventEmitter} from '@angular/core';
import { Router } from '@angular/router';
import { Listing } from '../types';
@Component({
  selector: 'app-item-data-form',
  templateUrl: './item-data-form.component.html',
  styleUrls: ['./item-data-form.component.css']
})
export class ItemDataFormComponent implements OnInit {
  @Input() buttonText: any;
  @Input() currentName ='';
  @Input() currentDescription ='';
  @Input() currentPrice ='';
  @Input() currentquantity ='';
  @Input() currentweight='';
  @Input() currentnutrition ='';
  @Input() currentveg=''; 

  name: string = '';
  description: string = '';
  price: string = '';
  quantity: string = '';
  weight: string = '';
  nutrition: string = '';
 veg: string = '';
  
  @Output() onSubmit = new EventEmitter<Listing>();
  

  constructor(
    private router: Router,
  ) { }

  ngOnInit(): void {
  
  }
}


