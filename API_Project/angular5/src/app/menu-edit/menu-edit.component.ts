import { Component, OnInit, Input} from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Listing } from '../types';
import { fakeMyListings } from '../fake-data';


@Component({
  selector: 'app-menu-edit',
  templateUrl: './menu-edit.component.html',
  styleUrls: ['./menu-edit.component.css']
})
export class MenuEditComponent implements OnInit {

  listing!: Listing;
  
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

    const id = this.route.snapshot.paramMap.get('id');
    this.listing  != fakeMyListings.find(listing => listing.id === id);

    this.name = this.currentName;
    this.description = this.currentDescription;
    this.price = this.currentPrice;
    this.quantity = this.currentquantity;
    this.description = this.currentweight;
    this.price = this.currentnutrition;
    this.currentveg = this.currentveg;
  }
  onSubmit(): void {
    alert('Editing Item');
    this.router.navigateByUrl('/adminmenu');
  }
}
