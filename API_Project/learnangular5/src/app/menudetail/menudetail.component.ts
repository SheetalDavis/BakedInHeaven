import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { fakeListings } from '../fake-data';
import { Item } from '../types';

@Component({
  selector: 'app-menudetail',
  templateUrl: './menudetail.component.html',
  styleUrls: ['./menudetail.component.css']
})
export class MenudetailComponent implements OnInit {
 
 items!:Item;

  constructor(
    private route: ActivatedRoute,
  ) { }

  ngOnInit(): void {
   
  }

}
