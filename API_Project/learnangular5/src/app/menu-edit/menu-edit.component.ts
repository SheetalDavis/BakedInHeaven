import { Component, OnInit, Input} from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Item } from '../types';
import { fakeMyListings } from '../fake-data';


@Component({
  selector: 'app-menu-edit',
  templateUrl: './menu-edit.component.html',
  styleUrls: ['./menu-edit.component.css']
})
export class MenuEditComponent implements OnInit {

  listing!: Item;
  
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

  constructor(
    private router: Router,
     private route: ActivatedRoute) { }

  ngOnInit(): void {

    
  }
  onSubmit(): void {
    alert('Editing Item');
    this.router.navigateByUrl('/adminmenu');
  }
}
