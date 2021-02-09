import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from '../home/home.component';
import { MenuComponent } from '../menu/menu.component';
import { UserComponent } from '../user/user.component';
import { RegistrationComponent } from '../user/registration/registration.component';
import { LoginComponent } from '../user/login/login.component';
import { MenuEditComponent } from '../menu-edit/menu-edit.component';
import { MenudetailComponent } from '../menudetail/menudetail.component';
import { AdminmenuComponent } from '../adminmenu/adminmenu.component';
import { AddmenuComponent } from '../addmenu/addmenu.component';
import { ItemsComponent } from '../items/items.component';
const routes: Routes = [
  { path: 'home', component: HomeComponent},
  { path: 'listings', component: MenuComponent},
  { path: 'MenuEdit/:id', component: MenuEditComponent},
  { path: 'listings/:id', component: MenudetailComponent},
  { path: 'adminmenu', component: AdminmenuComponent},
  { path: 'addmenu', component: AddmenuComponent},
  {path: 'items', component: ItemsComponent},
  {
    path: 'user', component: UserComponent,
    children: [
      { path: 'registration', component: RegistrationComponent },
      { path: 'login', component: LoginComponent }
    ]
  },
  { path: '', redirectTo: '/home', pathMatch: 'full' }
];


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ],
  
})
export class RoutingModule { }
