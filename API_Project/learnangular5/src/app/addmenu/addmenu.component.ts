import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-addmenu',
  templateUrl: './addmenu.component.html',
  styleUrls: ['./addmenu.component.css']
})
export class AddmenuComponent implements OnInit {

  name: string = '';
  description: string = '';
  price: string = '';
  quantity: string = '';
  weight: string = '';
  nutrition: string = '';

  constructor(
    private router: Router,
  ) { }

  ngOnInit(): void {
  }

  onSubmit(): void {
    alert('Creating a new listing...');
    this.router.navigateByUrl('/adminmenu');
  }
}
