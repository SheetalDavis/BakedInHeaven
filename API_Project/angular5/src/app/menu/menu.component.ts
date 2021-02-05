import { Component, OnInit } from '@angular/core';
import { fakeListings } from '../fake-data';
import { ListingsService } from '../listings.service';
import { Listing } from '../types';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {
  listings: Listing[] = [];
  constructor(private listingsService: ListingsService) { }

  ngOnInit(): void {
    this.listingsService.getListings()
    .subscribe(listings=>this.listings=listings);
  }

}
